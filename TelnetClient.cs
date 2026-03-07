/*
 * Copyright (C) 2026 SAMDestroy

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

public class AsyncTelnetClient
{
    private TcpClient _client;
    private NetworkStream _stream;
    private bool _shouldReconnect = false;
    private bool Initialized = false;
    private CancellationTokenSource _cts;

    private string _IP;

    public bool DoStatusUpdates { get; set; }

    public event Action<string> DataReceived;
    public event Action<string> ErrorOccurred;
    public event Action<string> StatusChanged;


    // XML Reader Part
    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    public async Task<string> ReadXMLDeviceInfoAsync()
    {
        string urlLite = $"http://{_IP}:8080/goform/formMainZone_MainZoneXmlStatusLite.xml";
        string urlCommand = $"http://{_IP}:8080/goform/AppCommand.xml";

        try
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(2);

                var responseLite = await client.GetAsync(urlLite);
                if (!responseLite.IsSuccessStatusCode) return "Booting...";

                string liteXmlString = await responseLite.Content.ReadAsStringAsync();
                var xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(liteXmlString);

                var rawvalue = xmlDoc.DocumentElement.SelectSingleNode("//InputFuncSelect")?.InnerText;
                if (string.IsNullOrEmpty(rawvalue)) return "No Info";

                if (rawvalue == "TV") return "TV Audio";
                if (rawvalue == "NET") return "HEOS";

                // 2. Friendly Name via AppCommand
                string xmlPayload = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<tx>\n<cmd id=\"1\">GetRenameSource</cmd>\n</tx>";
                var content = new StringContent(xmlPayload, Encoding.UTF8, "text/xml");

                var responseCommand = await client.PostAsync(urlCommand, content);
                if (!responseCommand.IsSuccessStatusCode) return rawvalue;

                string commandResponse = await responseCommand.Content.ReadAsStringAsync();
                XDocument doc = XDocument.Parse(commandResponse);

                var friendlyName = doc.Descendants("list")
                    .Where(x => x.Element("name")?.Value == rawvalue)
                    .Select(x => x.Element("rename")?.Value)
                    .FirstOrDefault();

                return friendlyName ?? rawvalue;
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"XML-Abruf verweigert (AVR bootet noch?): {ex.Message}");
            return "Connecting...";
        }
    }
    // XML Reader END ////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////


    // Connector Part
    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    public bool IsHostOnline(string ipAddress)
    {
        try
        {
            using (Ping ping = new Ping())
            {
                // Ping mit 2 Sekunden Timeout
                PingReply reply = ping.Send(ipAddress, 2000);
                return (reply.Status == IPStatus.Success);
            }
        }
        catch
        {
            return false;
        }
    }
    public bool IsPortOpen(string host, int port, int timeoutMilliseconds = 2000)
    {
        using (TcpClient tcpClient = new TcpClient())
        {
            try
            {
                var result = tcpClient.BeginConnect(host, port, null, null);
                var success = result.AsyncWaitHandle.WaitOne(timeoutMilliseconds);

                if (!success) return false;

                tcpClient.EndConnect(result);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    public async Task StartAsync(string hostname, int port)
    {
        _shouldReconnect = true;
        _cts = new CancellationTokenSource();

        _IP = hostname;

        while (_shouldReconnect && _cts != null && !_cts.Token.IsCancellationRequested)
        {
            try
            {
                StatusChanged?.Invoke("Connecting...");
                _client = new TcpClient();

                // Keep-Alive
                _client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);

                // 5 sec delay with 1 sec retry
                uint dummy = 0;
                byte[] inOptionValues = new byte[System.Runtime.InteropServices.Marshal.SizeOf(dummy) * 3];
                BitConverter.GetBytes((uint)1).CopyTo(inOptionValues, 0);      // Activate
                BitConverter.GetBytes((uint)5000).CopyTo(inOptionValues, 4);   // ms
                BitConverter.GetBytes((uint)1000).CopyTo(inOptionValues, 8);   // Intervall

                _client.Client.IOControl(IOControlCode.KeepAliveValues, inOptionValues, null);
                using (_cts.Token.Register(() => _client.Close()))
                {
                    await _client.ConnectAsync(hostname, port);
                }

                _stream = _client.GetStream();

                // Keep-Alive failed?
                _stream.ReadTimeout = 10000; // 10 Sec

                var heartbeatTask = SendHeartbeatAsync(_cts.Token);
                var initialCmdTask = InitialCmd(_cts.Token);

                await initialCmdTask;

                await ReadLoopAsync(_cts.Token);

                await heartbeatTask;
            }
            catch (Exception ex)
            {
                ErrorOccurred?.Invoke($"Disconnected: {ex.Message}");
                StatusChanged?.Invoke("Waiting for Reconnect (5sec)...");
                Initialized = false;
                if (_shouldReconnect && _cts != null && !_cts.Token.IsCancellationRequested)
                {
                    try { await Task.Delay(5000, _cts.Token); } catch { break; }
                }
                else break;
            }
            finally
            {
                _stream?.Close();
                _client?.Close();
            }
        }
        _cts?.Dispose();
        _cts = null;
    }
    public bool IsConnected()
    {
        try
        {
            if (_client?.Client == null || !_client.Client.Connected)
                return false;

            if (_client.Client.Poll(0, SelectMode.SelectRead))
            {
                byte[] buff = new byte[1];
                // Wenn 0 Bytes gelesen werden, ist die Verbindung definitiv zu
                return _client.Client.Receive(buff, SocketFlags.Peek) != 0;
            }

            return true;
        }
        catch { return false; }
    }    
    public async Task SendHeartbeatAsync(CancellationToken token)
    {
        try
        {
            while (!token.IsCancellationRequested && _client.Connected)
            {
                int currentPort = ((IPEndPoint)_client.Client.RemoteEndPoint).Port;

                if (_stream != null && _stream.CanWrite)
                {
                    if (currentPort == 1255)
                    {
                        await SendAsync("heos://system/heart_beat");
                    }
                    else if (currentPort == 23 && DoStatusUpdates)
                    {
                        string combinedCmd = "MS?\r" + "SI?\r";
                        await SendAsync(combinedCmd);
                    }
                }
                await Task.Delay(currentPort == 1255 ? 10000 : 5000, token); // HEOS reicht alle 10-30 Sek.
            }
        }
        catch { /* Cleanup */ }
    }
    public async Task InitialCmd(CancellationToken token)
    {
        int currentPort = ((IPEndPoint)_client.Client.RemoteEndPoint).Port;

        if (currentPort == 1255)
        {
            // For HEOS
            await SendAsync("heos://system/register_for_change_events?enable=on");
            await SendAsync("heos://player/get_players"); // Get PID (maybe not working because of missing PID but np)
            await SendAsync("heos://player/get_now_playing_media");

            Console.WriteLine("HEOS Initialisierung gesendet.");
        }
        else if (currentPort == 23)
        {
            if (_stream != null && _stream.CanWrite && !Initialized)
            {
                Initialized = true;

                string combinedCmd = "ZM?\r";
                byte[] heartbeatMsg = Encoding.UTF8.GetBytes(combinedCmd);

                await _stream.WriteAsync(heartbeatMsg, 0, heartbeatMsg.Length, token);
                await _stream.FlushAsync(token);
            }
        }
    }
    private async Task<string> ReadDenonLineAsync(NetworkStream stream)
    {
        var buffer = new List<byte>();
        byte[] singleByte = new byte[1];

        int currentPort = ((IPEndPoint)_client.Client.RemoteEndPoint).Port;

        while (true)
        {
            int read = await stream.ReadAsync(singleByte, 0, 1);
            if (read == 0) return null;

            byte b = singleByte[0];

            // PORT 23 cr
            if (currentPort == 23 && b == 13)
                break;

            // PORT 1255 cr
            if (currentPort == 1255 && b == 10)
                break;

            // Ignore \r wait for \n
            if (currentPort == 1255 && b == 13)
                continue;

            buffer.Add(b);
        }

        // HEOS (UTF8) or Denon (ASCII)
        return currentPort == 1255
            ? Encoding.UTF8.GetString(buffer.ToArray())
            : Encoding.ASCII.GetString(buffer.ToArray());
    }
    private async Task ReadLoopAsync(CancellationToken token)
    {
        StatusChanged?.Invoke("Connected!");

        while (!token.IsCancellationRequested)
        {
            if (!IsConnected())
            {
                throw new Exception("Network connection lost (IsConnected check failed).");
            }

            try
            {
                string line = await ReadDenonLineAsync(_stream);
                if (line == null)
                {
                   throw new Exception("Server closed connection.");
                }
                DataReceived?.Invoke(line);
            }
            catch (Exception ex)
            {
                throw new Exception($"Read error: {ex.Message}", ex);
            }
        }
    }
    public async Task SendAsync(string cmd)
    {
        if (_stream != null && _stream.CanWrite)
        {
            int currentPort = ((IPEndPoint)_client.Client.RemoteEndPoint).Port;
            // HEOS = \r\n, AVR = \r
            string suffix = (currentPort == 1255) ? "\r\n" : "\r";

            if (!cmd.EndsWith(suffix)) cmd += suffix;

            byte[] Msg = Encoding.UTF8.GetBytes(cmd);
            await _stream.WriteAsync(Msg, 0, Msg.Length);
            await _stream.FlushAsync();
        }
    }
    private void Cleanup()
    {
        try
        {
            _cts?.Cancel();

            _stream?.Close();
            _stream?.Dispose();
            _stream = null;

            _client?.Close();
            _client?.Dispose();
            _client = null;

            _cts?.Dispose();
            _cts = null;

            Initialized = false;
        }
        catch
        {
            // Ignore
        }
    }
    public void Stop()
    {
        StatusChanged?.Invoke("Connection canceled.");
        _shouldReconnect = false;
        _cts?.Cancel();
        Cleanup();
    }
}
