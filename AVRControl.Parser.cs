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
using System.Linq;
using System.Windows.Forms;

namespace AVRControl
{
    public partial class AVRControl : Form
    {
        // AVR Telnet Status Loop
        private void OnStatusReceived(string data)
        {
            if (this.IsDisposed || lbConnectStatus == null)
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

            if (data.ToLower().Contains("watchdog"))
            {
                StopHeosTimeline();
                AVRControlsToggle(false);
                HeosControlsToggle(false);

                _activePid = string.Empty;
                IsAVROn = false;

                this.Invalidate();
                this.Update();
            }
        }
        // AVR Telnet Data Loop
        private async void OnDataReceived(string data)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(OnDataReceived), data);
                return;
            }

           //  Console.WriteLine($"NORMALDATA: {data}");

            if (data.StartsWith("MVMAX")) // We dont need it
            {
                return;
            }

            if (data.StartsWith("ZMOFF"))
            {
                IsAVROn = false;

                StopHeosTimeline();

                AVRControlsToggle(false);
                HeosControlsToggle(false);

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

                AVRControlsToggle(true);
            }           

            if (IsAVROn)
            {
                if (data.StartsWith("SI"))
                {
                    string xmlSource = "";

                    if (data == "SINET" || data == "SIHEOS")
                    {
                        xmlSource = "HEOS";
                    }
                    else if (data == "SITV")
                    {
                        xmlSource = "TV Audio";
                    }
                    else
                    {
                        xmlSource = await _telnet.ReadXMLDeviceInfoAsync();
                    }

                    if (xmlSource == "HEOS")
                    {
                        HeosControlsToggle(true);

                        if (this.AVRSource.Text == "ON" || this.AVRSource.Text == "STANDBY" ||
                            this.AVRSource.Text == "HEOS" || string.IsNullOrEmpty(this.AVRSource.Text))
                        {
                            this.AVRSource.Text = "HEOS";
                        }

                        if (!string.IsNullOrEmpty(_lastHeosService))
                        {
                            this.AVRSource.Text = _lastHeosService;
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
                        _lastHeosService = "";

                        this.AVRSource.Text = xmlSource;
                        this.lbConnectStatus.Text = "Connected!";

                        StopHeosTimeline();
                        HeosControlsToggle(false);

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
                    this.btnToggleMute.BackColor = System.Drawing.Color.DarkGray;
                    this.btnToggleMute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
                else if (data.StartsWith("MV") && isScrolling == false)
                {
                    _muted = false;
                    CurVol = Int32.Parse(data.Substring(2, 2));

                    this.ShowVolume.Text = "Vol: " + CurVol.ToString();
                    this.SliderVolume.Value = CurVol;
                    this.btnToggleMute.BackColor = System.Drawing.Color.DarkGray;
                    this.btnToggleMute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }

                else if (data.Contains("CV") && !isScrolling && !_masterMoving)
                {
                    string[] lines = data.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string line in lines)
                    {
                        string cleanLine = line.Trim();
                        if (cleanLine.Length < 4 || cleanLine == "CVEND") continue;

                        var match = System.Text.RegularExpressions.Regex.Match(cleanLine, @"\d+$");
                        if (match.Success)
                        {
                            int val = int.Parse(match.Value);

                            if (val > 100) val = val / 10;

                            this.Invoke((MethodInvoker)delegate
                            {
                                UpdateSpeakerSlider(cleanLine, val);
                            });
                        }
                    }
                }
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

            // Console.WriteLine($"HEOSDATA:{data}");

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
                    _ = _heosTelnet.SendAsync($"heos://player/get_player_now_playing_progress?pid={_activePid}");

                    _ = UpdateHeosDetails(); // Second Info
                }
            }

            if (data.Contains("player/get_now_playing_media"))
            {
                if (data.Contains("\"result\": \"success\""))
                {
                    ParseAndDisplayTrackInfo(data);
                }
                else
                {
                    //Console.WriteLine("HEOS meldete Fail - ignoriere Anzeige-Update.");
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

            if (data.Contains("event/player_now_playing_progress"))
            {
                if (int.TryParse(ExtractJsonValue(data, "cur_pos"), out int curPos) &&
                    int.TryParse(ExtractJsonValue(data, "duration"), out int duration))
                {
                    if (_songChangePending || (curPos < 1000 && _localCurPos > 5000))
                    {
                        _localCurPos = 0;
                        _songChangePending = false;
                    }

                    if (curPos == 0 && _localCurPos > 2000 && !_songChangePending) return;

                    _maxDuration = duration;

                    if ((DateTime.Now - _lastUserInteraction).TotalSeconds >= 3.0)
                    {
                        _localCurPos = curPos;
                    }

                    double percent = (double)_localCurPos / _maxDuration;
                    pnlProgressBar.Width = (int)(pnlProgressBack.ClientRectangle.Width * Math.Min(percent, 1.0));

                    lblTime.Text = $"{FormatTime(_localCurPos)} / {FormatTime(_maxDuration)}";
                }
                return;
            }

            if (data.Contains("event/player_now_playing_changed"))
            {
                _songChangePending = true;
                _localCurPos = 0;
                _maxDuration = 0;
                pnlProgressBar.Width = 0;
                lblTime.Text = "00:00 / 00:00";

                _ = UpdateHeosDetails();
                return;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
