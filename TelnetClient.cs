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
    public bool Initialized { get; private set; } = false;

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
        _IP = hostname;

        while (_shouldReconnect)
        {
            _cts = new CancellationTokenSource();
            _client = new TcpClient();

            try
            {
                StatusChanged?.Invoke("Connecting...");

                // Keep-Alive
                _client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
                uint dummy = 0;
                byte[] inOptionValues = new byte[System.Runtime.InteropServices.Marshal.SizeOf(dummy) * 3];
                BitConverter.GetBytes((uint)1).CopyTo(inOptionValues, 0);
                BitConverter.GetBytes((uint)5000).CopyTo(inOptionValues, 4);
                BitConverter.GetBytes((uint)1000).CopyTo(inOptionValues, 8);
                _client.Client.IOControl(IOControlCode.KeepAliveValues, inOptionValues, null);

                using (_cts.Token.Register(() => _client?.Close()))
                {
                    await _client.ConnectAsync(hostname, port);
                }

                _stream = _client.GetStream();
                _stream.ReadTimeout = 10000;

                using (var linkCts = CancellationTokenSource.CreateLinkedTokenSource(_cts.Token))
                {
                    var heartbeatTask = SendHeartbeatAsync(linkCts.Token);
                    var readLoopTask = ReadLoopAsync(linkCts.Token);

                    await InitialCmd(linkCts.Token);

                    await Task.WhenAny(readLoopTask, heartbeatTask);

                    Initialized = false;

                    linkCts.Cancel();
                    try
                    {
                        await Task.WhenAll(readLoopTask, heartbeatTask);
                    }
                    catch {
                            //Expected Cancel
                          }
                }

                throw new Exception("Connection closed by watchdog");
            }
            catch (Exception ex)
            {
                if (!_shouldReconnect || _cts == null || _cts.Token.IsCancellationRequested) break;

                ErrorOccurred?.Invoke($"Disconnected: {ex.Message}");
                StatusChanged?.Invoke($"{ex.Message} - Reconnect in 5s...");
                Initialized = false;

                try { await Task.Delay(5000, _cts.Token); } catch { break; }
            }
            finally
            {
                try { _stream?.Close(); } catch { }
                try { _client?.Close(); } catch { }

                _cts?.Dispose();
                _cts = null;
            }
        }
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
            while (!token.IsCancellationRequested && _client != null && _client.Connected)
            {
                if (_stream != null && _stream.CanWrite)
                {
                    int currentPort = ((IPEndPoint)_client.Client.RemoteEndPoint).Port;

                    if (currentPort == 1255)
                    {
                        // HEOS Heartbeat
                        await SendAsync("heos://system/heart_beat", token);
                    }
                    else if (currentPort == 23 && DoStatusUpdates)
                    {
                        string combinedCmd = "SI?\rMS?\r";
                        await SendAsync(combinedCmd, token);
                    }
                }

                int delayMs = 5000;
                try
                {
                    int port = ((IPEndPoint)_client.Client.RemoteEndPoint).Port;
                    if (port == 1255) delayMs = 10000;
                }
                catch { }

                await Task.Delay(delayMs, token);
            }
        }
        catch (OperationCanceledException)
        {
            // Expected Cancel
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Heartbeat Error: {ex.Message}");
        }
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
                byte[] InitialMsg = Encoding.UTF8.GetBytes(combinedCmd);

                await _stream.WriteAsync(InitialMsg, 0, InitialMsg.Length, token);

                await _stream.FlushAsync(token);
            }
        }
    }
    public async Task ReadLoopAsync(CancellationToken token)
    {
        byte[] buffer = new byte[2048];
        try
        {
            while (!token.IsCancellationRequested && _stream != null && _stream.CanRead)
            {
                int bytesRead = await _stream.ReadAsync(buffer, 0, buffer.Length, token);

                if (bytesRead == 0)
                {
                    break;
                }

                string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                string[] messages = receivedData.Split(new[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var msg in messages)
                {
                    DataReceived?.Invoke(msg);
                }
            }
        }
        catch (OperationCanceledException)
        {
            // Expected Cancel
        }
        catch (Exception ex)
        {
            // Real Exception
            System.Diagnostics.Debug.WriteLine($"ReadLoop Error: {ex.Message}");
        }
    }

    public async Task SendAsync(string cmd, CancellationToken token = default)
    {
        if (_client != null && _client.Connected && _stream != null && _stream.CanWrite)
        {
            try
            {
                int currentPort = ((IPEndPoint)_client.Client.RemoteEndPoint).Port;
                string suffix = (currentPort == 1255) ? "\r\n" : "\r";

                if (!cmd.EndsWith(suffix)) cmd += suffix;

                byte[] Msg = Encoding.UTF8.GetBytes(cmd);

                await _stream.WriteAsync(Msg, 0, Msg.Length, token);
                await _stream.FlushAsync(token);
            }
            catch (OperationCanceledException)
            {
                // Expected Cancel
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Send Error: {ex.Message}");
            }
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
