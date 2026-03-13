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
using System.Drawing;
using System.Windows.Forms;

namespace AVRControl
{
    public partial class AVRControl : Form
    {
        // AVR Telnet Status Loop
        private void OnStatusReceived(string data)
        {
            if (this.IsDisposed || lbConnectStatus == null || lbConnectStatus.IsDisposed)
                return;

            if (this.InvokeRequired)
            {
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action<string>(OnStatusReceived), data);
                }
                return;
            }

            // Showing on Status Label
            this.lbConnectStatus.Text = data;
        }

        // AVR Telnet Data Loop
        private async void OnDataReceived(string data)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(OnDataReceived), data);
                return;
            }

            // Console.WriteLine($"NORMALDATA: {data}");

            if (data.StartsWith("MVMAX")) // We dont need it
            {
                return;
            }

            if (data.StartsWith("ZMOFF"))
            {
                IsAVROn = false;

                AVRControlsToggle(false);
                HeosControlsToggle(false);

                StopHeosTimeline();

                _telnet.DoStatusUpdates = false;

                this.lbConnectStatus.Text = "Connected!";

                return;
            }

            if (data.StartsWith("ZMON"))
            {
                IsAVROn = true;
                _telnet.DoStatusUpdates = true;
                await _telnet.SendAsync("MV?");
                await _telnet.SendAsync("SYSDA?");
                await _telnet.SendAsync("MS?");

                //this.AVRSource.Text = await _telnet.ReadXMLDeviceInfoAsync();

                this.SliderVolume.Value = CurVol;
                this.ShowVolume.Text = "Vol: " + CurVol.ToString();

                AVRControlsToggle(true);
            }

            if (IsAVROn == false)
            {
                return;
            }

            if (data.StartsWith("SI"))
            {
                string xmlSource = await _telnet.ReadXMLDeviceInfoAsync();

                if (xmlSource == "HEOS")
                {
                    HeosControlsToggle(true);

                    if (this.AVRSource.Text == "NET" || this.AVRSource.Text == "No Info" || string.IsNullOrEmpty(this.AVRSource.Text))
                    {
                        this.AVRSource.Text = "HEOS";
                    }

                    if (!_heosTelnet.IsConnected())
                    {
                        if (_heosTelnet.IsPortOpen(tbIP.Text, 1255))
                        {
                            _ = _heosTelnet.StartAsync(tbIP.Text, 1255);
                            this.lbConnectStatus.Text = "Connected! (HEOS Mode)";
                        }
                        else
                        {
                            this.lbConnectStatus.Text = "HEOS Port closed...";
                            return;
                        }
                    }
                }
                else
                {
                    this.AVRSource.Text = xmlSource;
                    this.lbConnectStatus.Text = "Connected!";

                    HeosControlsToggle(false);
                    StopHeosTimeline();

                    if (_heosTelnet != null && _heosTelnet.IsConnected())
                    {
                        _heosTelnet.Stop();
                    }
                }
            }
            else if (data.StartsWith("SYSDA"))
            {
                this.AVRSourceAudio.Text = data.Substring(6, data.Length - 6);
            }
            else if (data.StartsWith("MS"))
            {
                this.AVRSoundMode.Text = data.Substring(2, data.Length - 2);
            }
            else if (data.Contains("MUON"))
            {
                _muted = true;
                this.ShowVolume.Text = "Muted";
                this.btnToggleMute.BackColor = System.Drawing.Color.DarkRed;
                this.btnToggleMute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else if (data.StartsWith("MUOFF"))
            {
                _muted = false;
                this.ShowVolume.Text = "Vol: " + CurVol.ToString();
                this.btnToggleMute.BackColor = System.Drawing.Color.Transparent;
                this.btnToggleMute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            else if (data.StartsWith("MV") && isScrolling == false)
            {
                _muted = false;
                CurVol = Int32.Parse(data.Substring(2, 2));

                this.ShowVolume.Text = "Vol: " + CurVol.ToString();
                this.SliderVolume.Value = CurVol;
                this.btnToggleMute.BackColor = System.Drawing.Color.Transparent;
                this.btnToggleMute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            
        }

        // HEOS LOOP
        private void OnHeosDataReceived(string data)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(OnHeosDataReceived), data);
                return;
            }

            if (!IsAVROn)
            {
                return;
            }

            // Getting Initial Infos
            if (data.Contains("player/get_players"))
            {
                string neuePid = ExtractJsonValue(data, "pid");
                string AVRName = ExtractJsonValue(data, "name");
                string AVRVersion = ExtractJsonValue(data, "version");
                string AVRNetwork = ExtractJsonValue(data, "network");

                if (!string.IsNullOrEmpty(neuePid))
                {
                    this.lbHeosAVRID_Data.Text = neuePid;
                    this.lbHeosAVRName_Data.Text = AVRName;
                    this.lbHeosAVRVersion_Data.Text = AVRVersion;
                    this.lbHeosAVRNetType_Data.Text = char.ToUpper(AVRNetwork[0]) + AVRNetwork.Substring(1);

                    _activePid = neuePid;
                    //Console.WriteLine("PID dauerhaft gespeichert: " + _activePid);

                    _ = _heosTelnet.SendAsync($"heos://player/set_progress_events?pid={_activePid}&enable=on");

                    _ = UpdateHeosDetails(); // Initial Info
                }
            }

            // Console.WriteLine($"HEOSDATA:{data}");

            if (data.Contains("event/player_now_playing_progress"))
            {
                if (int.TryParse(ExtractJsonValue(data, "cur_pos"), out int curPos) &&
                    int.TryParse(ExtractJsonValue(data, "duration"), out int duration))
                {
                    _maxDuration = duration;

                    // Sync nur, wenn wir nicht im 3-Sekunden-Skip-Schutz sind
                    if ((DateTime.Now - _lastUserInteraction).TotalSeconds >= 3.0)
                    {
                        if (Math.Abs(_localCurPos - curPos) > 2000) _localCurPos = curPos;
                    }

                    if (pbProgress.Maximum != _maxDuration)
                        pbProgress.Maximum = _maxDuration;
                }
                return;
            }

            if (data.Contains("event/player_now_playing_changed"))
            {
                _localCurPos = 0;
                pbProgress.Value = 0;
                _ = UpdateHeosDetails();
            }

            if (data.Contains("player/get_now_playing_media"))
            {
                if (data.Contains("success"))
                {
                    ParseAndDisplayTrackInfo(data);
                }
                else
                {
                    Console.WriteLine("HEOS meldete Fail - ignoriere Anzeige-Update.");
                }
            }

            if (data.Contains("shuffle"))
            {
                string shuffleVal = ExtractJsonValue(data, "shuffle");

                if (shuffleVal == "on")
                {
                    _isShuffleOn = true;
                    btnHeosPlayShuffle.BackColor = Color.DeepSkyBlue; // Aktive Farbe
                    btnHeosPlayShuffle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                }
                else
                {
                    _isShuffleOn = false;
                    btnHeosPlayShuffle.BackColor = Color.Transparent; // Inaktive Farbe
                    btnHeosPlayShuffle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
            }

            if (data.Contains("event/player_state_changed") || data.Contains("player/get_play_state"))
            {
                string state = ExtractJsonValue(data, "state").Trim().ToLower();

                if (state == "play")
                {
                    timerProgress.Start();
                    this.btnHeosPlayPause.BackgroundImage = global::AVRControl.Properties.Resources.PauseIcon;
                }
                else
                {
                    timerProgress.Stop();
                    this.btnHeosPlayPause.BackgroundImage = global::AVRControl.Properties.Resources.PlayIcon;
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////




    }
}
