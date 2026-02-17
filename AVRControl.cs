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
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVRControl
{
    public partial class AVRControl : Form
    {
        private readonly string config = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\AVRControl.cfg";
        private bool _muted = false;
        private int CurVol = 10;
        private bool IsAVROn = false;
        private bool isScrolling = false;
        private System.Windows.Forms.Timer timerProgress;
        private int _localCurPos = 0;
        private int _maxDuration = 0;
        private DateTime _lastUserInteraction = DateTime.MinValue;
       // private bool _isMusicPlaying = false;
        private DateTime _lastVolumeSend = DateTime.MinValue;
        private bool IsHeosPlayPause = false;
        private bool _isShuffleOn = false;

       // private AVRDevices.IAVRDevice _AVR;
        private AsyncTelnetClient _telnet;

        private AsyncTelnetClient _heosTelnet;
        private string _activePid = "";

        public AVRControl()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            //notifyIcon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

           // string version = Assembly.GetExecutingAssembly().GetName().Version.ToString(3).Replace(".0", "");
            Text = "AVRControl v1.0";

            _telnet = new AsyncTelnetClient();
            _telnet.DataReceived += OnDataReceived;
            _telnet.StatusChanged += OnStatusReceived;

            _heosTelnet = new AsyncTelnetClient();
            _heosTelnet.DataReceived += OnHeosDataReceived;


            timerProgress = new System.Windows.Forms.Timer();
            timerProgress.Interval = 100;
            timerProgress.Tick += timerProgress_Tick;

        }

        // Timer Functions for Progressbar
        ////////////////////////////////////////////////////////////////////////////////////////////////////////   
        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (_maxDuration > 0)
            {
                _localCurPos += timerProgress.Interval; // 100ms oder 1000ms

                if (_localCurPos <= _maxDuration)
                {
                    pbProgress.Value = Math.Min(_localCurPos, _maxDuration);
                    lblTime.Text = $"{FormatTime(_localCurPos)} / {FormatTime(_maxDuration)}";
                }
            }
        }

        private void StopHeosTimeline()
        {
           // _isMusicPlaying = false;
            _maxDuration = 0;
            _localCurPos = 0;

            this.Invoke((MethodInvoker)delegate {
                timerProgress.Stop();
                pbProgress.Value = 0;
                lblTime.Text = "00:00 / 00:00";
            });
        }

        private void ResetTimelineImmediate()
        {
            _localCurPos = 0;
            _lastUserInteraction = DateTime.Now;

            this.Invoke((MethodInvoker)delegate {
                pbProgress.Value = 0;
                lblTime.Text = "00:00 / 00:00";
            });
        }
        // Timer Functions for Progressbar END ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Helper Functions
        ////////////////////////////////////////////////////////////////////////////////////////////////////////   
        private string ExtractJsonValue(string data, string key)
        {
            if (string.IsNullOrEmpty(data) || string.IsNullOrEmpty(key)) return "";

            int start = -1;
            int end = -1;

            string patternJson = "\"" + key + "\"";
            int keyIdx = data.IndexOf(patternJson);
            if (keyIdx != -1)
            {
                int colonIdx = data.IndexOf(":", keyIdx + patternJson.Length);
                if (colonIdx != -1)
                {
                    start = colonIdx + 1;
                    while (start < data.Length && (data[start] == ' ' || data[start] == '\"')) start++;

                    end = data.IndexOfAny(new char[] { '\"', ',', '}', '&' }, start);
                }
            }

            if (start == -1)
            {
                string patternMsg = key + "=";
                int msgIdx = data.IndexOf(patternMsg);
                if (msgIdx != -1)
                {
                    start = msgIdx + patternMsg.Length;
                    end = data.IndexOfAny(new char[] { '&', '\"', '}', ' ' }, start);
                }
            }

            if (start != -1)
            {
                if (end == -1) end = data.Length;
                string result = data.Substring(start, end - start).Trim();
                return result.Replace("\"", "");
            }

            return "";
        }

        private string FormatTime(int ms)
        {
            TimeSpan t = TimeSpan.FromMilliseconds(ms);
            return string.Format("{0:D2}:{1:D2}", t.Minutes + (t.Hours * 60), t.Seconds);
        }
        // Helper Functions END ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////



        // HEOS Part
        ////////////////////////////////////////////////////////////////////////////////////////////////////////   

        // HEOS Helper
        /////////////////////
        private async Task LoadAlbumArtAsync(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                pbAlbumArt.Image = null; // or default image
                return;
            }

            try
            {
                using (var client = new System.Net.WebClient())
                {
                    byte[] imageBytes = await client.DownloadDataTaskAsync(url);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        this.Invoke((MethodInvoker)delegate {
                            pbAlbumArt.Image = Image.FromStream(ms);
                            pbAlbumArt.SizeMode = PictureBoxSizeMode.Zoom; // Bild proportional anpassen
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler beim Laden des Covers: " + ex.Message);
            }
        }
        private void ParseAndDisplayTrackInfo(string json)
        {
            try
            {
                string song = ExtractJsonValue(json, "song");
                string artist = ExtractJsonValue(json, "artist");
                string album = ExtractJsonValue(json, "album");
                string sidStr = ExtractJsonValue(json, "sid");
                string state = ExtractJsonValue(json, "state").Trim().ToLower(); // Wichtig für Initial-Start

                string curPosStr = ExtractJsonValue(json, "cur_pos");
                string durationStr = ExtractJsonValue(json, "duration");

                int sid = 0;
                int.TryParse(sidStr, out sid);

                if (!timerProgress.Enabled && state != "pause")
                {
                   // _isMusicPlaying = true;
                    timerProgress.Start();
                }

                string imageUrl = ExtractJsonValue(json, "image_url");

                _ = LoadAlbumArtAsync(imageUrl);

                // Spotify Fix
                string serviceName = "HEOS";
                if (sid == 4 && (json.ToLower().Contains("spotify") || album.ToLower().Contains("spotify")))
                {
                    serviceName = "Spotify Connect";
                }
                else
                {
                    serviceName = sid switch
                    {
                        1 => "Pandora",
                        3 => "TuneIn Radio",
                        4 => "Napster / Media Server",
                        5 => "Deezer",
                        9 => "SoundCloud",
                        10 => "Spotify (App)",
                        13 => "Amazon Music",
                        18 => "TIDAL",
                        1024 => "Musikserver / DLNA",
                        1027 => "AUX Eingang",
                        _ => $"Dienst {sid}"
                    };
                }

                this.Invoke((MethodInvoker)delegate {

                    this.AVRSource.Text = serviceName;
                    this.HeosTrackInfoArtist.Text = artist;
                    this.HeosTrackInfoAlbum.Text = album;
                    this.HeosTrackInfoSong.Text = song;
                    this.lbConnectStatus.Text = "Connected! (HEOS Mode)";

                    int.TryParse(curPosStr, out int curPos);
                    int.TryParse(durationStr, out int duration);

                    if (duration > 0)
                    {
                        if (_maxDuration != duration)
                        {
                            _maxDuration = duration;
                            pbProgress.Maximum = _maxDuration;
                            _localCurPos = curPos; // Erster Sync
                        }

                        if (Math.Abs(_localCurPos - curPos) > 2000)
                        {
                            _localCurPos = curPos;
                        }

                        if (state == "play")
                        {
                            if (!timerProgress.Enabled) timerProgress.Start();
                        }
                        else
                        {
                            timerProgress.Stop();
                        }
                    }
                    //Console.WriteLine($"Anzeige aktualisiert: [{serviceName}] {state} - {artist} - {song}");
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler beim Parsen der Metadaten: " + ex.Message);
            }
        }
        
        private async Task UpdateHeosDetails()
        {
            if (string.IsNullOrEmpty(_activePid))
            {
               // Console.WriteLine("PID ist LEER!");
                await _heosTelnet.SendAsync("heos://player/get_players");
                return;
            }

            string command = $"heos://player/get_now_playing_media?pid={_activePid}";
            await _heosTelnet.SendAsync(command);
        }
        // HEOS Helper END ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        // HEOS LOOP
        private void OnHeosDataReceived(string data)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(OnHeosDataReceived), data);
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
                        
            // Console.WriteLine($"HEOSDATA:{data}"); // Log für alle HEOS-Daten, um die Entwicklung zu erleichtern

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

                   // this.BeginInvoke((MethodInvoker)delegate {
                        if (pbProgress.Maximum != _maxDuration)
                            pbProgress.Maximum = _maxDuration;
                   // });
                }
                return;
            }
            
            if (data.Contains("event/player_now_playing_changed"))
            {
                _localCurPos = 0;
                pbProgress.Value = 0;
               // Console.WriteLine("Event erkannt: Songwechsel!");
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

           /* if (data.Contains("now_playing") || data.Contains("cur_pos"))
            {
                if (!this.IsDisposed && this.IsHandleCreated)
                {
                   // this.BeginInvoke((MethodInvoker)delegate {
                        if (!timerProgress.Enabled)
                        {
                            //_isMusicPlaying = true;
                            timerProgress.Start();
                           // Console.WriteLine(">>> TIMER PHYSISCH GESTARTET <<<");
                        }
                   // });
                }
            }*/

if (data.Contains("shuffle"))
            {
                string shuffleVal = ExtractJsonValue(data, "shuffle");

               // this.Invoke((MethodInvoker)delegate {
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
                //});
            }

            if (data.Contains("event/player_state_changed") || data.Contains("player/get_play_state"))
            {
                string state = ExtractJsonValue(data, "state").Trim().ToLower();
               // this.Invoke((MethodInvoker)delegate {
                    if (state == "play")
                    {
                    //_isMusicPlaying = true;
                    timerProgress.Start();
                        this.btnHeosPlayPause.BackgroundImage = global::AVRControl.Properties.Resources.PauseIcon;
                    }
                    else
                    {
                       // _isMusicPlaying = false;
                        timerProgress.Stop();
                        this.btnHeosPlayPause.BackgroundImage = global::AVRControl.Properties.Resources.PlayIcon;
                    }
               // });
            }

        }
        // HEOS END ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////


        // AVR Telnet Part
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        
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

            if (data.StartsWith("ZMON"))
            {                
                IsAVROn = true;
                _telnet.DoStatusUpdates = true;
                await _telnet.SendAsync("MV?");
                await _telnet.SendAsync("SYSDA?");
                await _telnet.SendAsync("MS?");

                this.AVRSource.Text = _telnet.ReadXMLDeviceInfo();

                this.SliderVolume.Value = CurVol;
                this.ShowVolume.Text = "Vol: " + CurVol.ToString();                

                AVRControlsToggle(true);
            }
            else if (data.StartsWith("ZMOFF"))
            {
                IsAVROn = false;

                AVRControlsToggle(false);
                HeosControlsToggle(false);

                _telnet.DoStatusUpdates = false;
            }

            if (IsAVROn == true)
            {
                if (data.StartsWith("SI"))
                {
                    string xmlSource = _telnet.ReadXMLDeviceInfo();
                    
                    if (xmlSource == "HEOS")
                    {
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
                                HeosControlsToggle(true);
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

                        if (_heosTelnet.IsConnected())
                            _heosTelnet.Stop();

                        this.lbConnectStatus.Text = "Connected!";

                        HeosControlsToggle(false);

                        StopHeosTimeline();
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
        }
        // AVR Telnet END ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////


        // Form Init Part
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AVRControl_Load(object sender, EventArgs e)
        {
            LoadDevice();
        }
        private void LoadDevice()
        {
            HeosControlsToggle(false);

            try
            {
                tbIP.Text = File.ReadAllText(config);

                if (_telnet.IsHostOnline(tbIP.Text))
                {
                    this.lbConnectStatus.Text = "IP online...";
                    if (_telnet.IsPortOpen(tbIP.Text, 23))
                    {
                        this.lbConnectStatus.Text = "Port 23 open..";

                        _ = _telnet.StartAsync(tbIP.Text, 23);
                        this.lbConnectStatus.Text = "Connected!";
                        this.PowerToggle.Enabled = true;
                        AVRControlsToggle(true);
                    }
                    else
                    {
                        this.lbConnectStatus.Text = "IP online but Port 23 closed...";
                        return;
                    }
                }
                else
                {
                    this.lbConnectStatus.Text = "IP offline or wrong...";
                    return;
                }
            }
            catch { }

            if (tbIP.Text != "")
            {
                

                this.lbConnectStatus.Text = "Connecting ...";
            }
            else
            {
                this.lbConnectStatus.Text = "Please set IP below !";
                this.PowerToggle.Enabled = false;

                AVRControlsToggle(false);
            }            
        }
        // Form Init Part END ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
                
        // Form Controls Toggle
        ////////////////////////////////////////////////////////////////////////////////////////////////////////   
        private void AVRControlsToggle(bool enabled)
        {
            this.btnVolUp.Enabled = enabled;
            this.btnVolDown.Enabled = enabled;
            this.btnToggleMute.Enabled = enabled;
            this.SliderVolume.Enabled = enabled;
            

            if (!enabled)
            {
                this.SliderVolume.Value = 10;
                this.ShowVolume.Text = "OFF";
                this.PowerToggle.BackColor = Color.Gray;
                this.PowerToggle.Text = "OFF";
                this.AVRSource.Text = "";
                this.AVRSourceAudio.Text = "";
                this.AVRSoundMode.Text = "";
            }
            else
            {
                this.PowerToggle.BackColor = Color.Green;
                this.PowerToggle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;

                this.PowerToggle.Text = "ON";
            }
        }
        private void HeosControlsToggle(bool enabled)
        {

            this.btnHeosPlayPause.Enabled = enabled;
            this.btnHeosPlayBack.Enabled = enabled;
            this.btnHeosPlaySkip.Enabled = enabled;
            this.btnHeosPlayShuffle.Enabled = enabled;
            this.btnHeosPlayRepeatAll.Enabled = enabled;
            this.btnHeosPlayRepeatOne.Enabled = enabled;

            if (!enabled)
            {
                this.pbAlbumArt.Hide();

                this.HeosTrackInfoArtist.Text = "";
                this.HeosTrackInfoAlbum.Text = "";
                this.HeosTrackInfoSong.Text = "";

                this.lbAlbumCover.Text = "";

                this.lbHeosAlbum.Text = "";
                this.lbHeosArtist.Text = "";
                this.lbHeosSong.Text = "";

                this.lbHeosAVRName.Text = "";
                this.lbHeosAVRVersion.Text = "";
                this.lbHeosAVRID.Text = "";
                this.lbHeosAVRNetType.Text = "";

                this.lbHeosAVRName_Data.Text = "";
                this.lbHeosAVRVersion_Data.Text = "";
                this.lbHeosAVRID_Data.Text = "";
                this.lbHeosAVRNetType_Data.Text = "";
            }
            else
            {
                this.pbAlbumArt.Show();

                this.lbAlbumCover.Text = "Album Cover";

                this.lbHeosAlbum.Text = "Album";
                this.lbHeosArtist.Text = "Artist";
                this.lbHeosSong.Text = "Song";

                this.lbHeosAVRName.Text = "Client:";
                this.lbHeosAVRVersion.Text = "Version:";
                this.lbHeosAVRID.Text = "Player ID:";
                this.lbHeosAVRNetType.Text = "NetType:";
            }
        }
        // Form Controls Toggle END ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Control Events Part
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(config, tbIP.Text);
                LoadDevice();
            }
            catch
            {
                MessageBox.Show("Try running as Administrator and saving your config again.", "Error saving config");
            }
        }
        private async void BtnVolUp_Click(object sender, EventArgs e)
        {
            await _telnet.SendAsync("MV"+ (CurVol+1));
            _muted = false;
        }
        private void BtnVolUp_MouseDown(object sender, EventArgs e)
        {
            this.btnVolUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnVolUp.BackColor = System.Drawing.Color.DarkGray;
        }
        private void BtnVolUp_MouseUp(object sender, EventArgs e)
        {
            this.btnVolUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnVolUp.BackColor = System.Drawing.Color.Transparent;
        }
        private void BtnVolUp_MouseHover(object sender, EventArgs e)
        {            
            this.btnVolUp.BackColor = System.Drawing.Color.DarkGray;
        }

        private async void BtnVolDown_Click(object sender, EventArgs e)
        {
            await _telnet.SendAsync("MV"+(CurVol-1));
            _muted = false;
        }
        private void BtnVolDown_MouseDown(object sender, EventArgs e)
        {
            this.btnVolDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnVolDown.BackColor = System.Drawing.Color.DarkGray;
        }
        private void BtnVolDown_MouseUp(object sender, EventArgs e)
        {
            this.btnVolDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnVolDown.BackColor = System.Drawing.Color.Transparent;
        }
        private void BtnVolDown_MouseHover(object sender, EventArgs e)
        {
            this.btnVolDown.BackColor = System.Drawing.Color.DarkGray;
        }
        private async void SliderVolume_Scroll(object sender, EventArgs e)
        {
            isScrolling = true;
            if ((DateTime.Now - _lastVolumeSend).TotalMilliseconds > 50)
            {
                int val = SliderVolume.Value;
                this.ShowVolume.Text = "Vol: " + val.ToString();
                await _telnet.SendAsync("MV" + val.ToString("D2"));

                _lastVolumeSend = DateTime.Now;
            }
        }
        private void SliderVolume_MouseUp(object sender, EventArgs e)
        {
            isScrolling = false;
            _ = _telnet.SendAsync("MV?");
        }       
        private async void PowerToggle_Click(object sender, EventArgs e)
        {
            IsAVROn = !IsAVROn;

            if (IsAVROn)
            {
                await _telnet.SendAsync("ZMON");
            }
            else
                await _telnet.SendAsync("ZMOFF");
        }
        private async void BtnToggleMute_Click(object sender, EventArgs e)
        {
            this.btnToggleMute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            _muted = !_muted;

            if (_muted)
            {
                await _telnet.SendAsync("MUON");
            }
            else
                await _telnet.SendAsync("MUOFF");
        }
        private void BtnToggleMute_MouseHover(object sender, EventArgs e)
        {
            this.btnToggleMute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            if (!_muted)
            {
                this.btnToggleMute.BackColor = System.Drawing.Color.DarkGray;
            }
        }
        private void BtnToggleMute_MouseLeave(object sender, EventArgs e)
        {
            this.btnToggleMute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            if (!_muted)
            {
                this.btnToggleMute.BackColor = System.Drawing.Color.Transparent;
            }
        }
        private void BtnToggleMute_MouseDown(object sender, EventArgs e)
        {
            this.btnToggleMute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnToggleMute.BackColor = System.Drawing.Color.DarkGray;
        }
        private async void btnHeosPlayPause_Click(object sender, EventArgs e)
        {
            if (_heosTelnet != null && _heosTelnet.IsConnected() && !string.IsNullOrEmpty(_activePid))
            {
                string cmd = "";
                if (!IsHeosPlayPause)
                {                    
                    IsHeosPlayPause = true;
                    cmd = $"heos://player/set_play_state?pid={_activePid}&state=pause";
                }
                else
                {
                    IsHeosPlayPause = false;
                    cmd = $"heos://player/set_play_state?pid={_activePid}&state=play";
                }
                    await _heosTelnet.SendAsync(cmd);
            }
            else
            {
                MessageBox.Show("HEOS-Verbindung nicht aktiv oder Player-ID fehlt.");
            }
        }
        private void btnHeosPlayPause_MouseDown(object sender, EventArgs e)
        {
            this.btnHeosPlayPause.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnHeosPlayPause.BackColor = System.Drawing.Color.DarkGray;
        }
        private void btnHeosPlayPause_MouseUp(object sender, EventArgs e)
        {
            this.btnHeosPlayPause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayPause.BackColor = System.Drawing.Color.Transparent;
        }
        private void btnHeosPlayPause_MouseHover(object sender, EventArgs e)
        {
            this.btnHeosPlayPause.BackColor = System.Drawing.Color.DarkGray;
        }
        private async void btnHeosPlaySkip_Click(object sender, EventArgs e)
        {
            if (_heosTelnet != null && _heosTelnet.IsConnected() && !string.IsNullOrEmpty(_activePid))
            {
                string cmd = $"heos://player/play_next?pid={_activePid}";
                await _heosTelnet.SendAsync(cmd);

                ResetTimelineImmediate();
            }
            else
            {
                MessageBox.Show("HEOS-Verbindung nicht aktiv oder Player-ID fehlt.");
            }
        }
        private void btnHeosPlaySkip_MouseDown(object sender, EventArgs e)
        {
            this.btnHeosPlaySkip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnHeosPlaySkip.BackColor = System.Drawing.Color.DarkGray;
        }
        private void btnHeosPlaySkip_MouseUp(object sender, EventArgs e)
        {
            this.btnHeosPlaySkip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlaySkip.BackColor = System.Drawing.Color.Transparent;
        }
        private void btnHeosPlaySkip_MouseHover(object sender, EventArgs e)
        {
            this.btnHeosPlaySkip.BackColor = System.Drawing.Color.DarkGray;
        }
        private async void btnHeosPlayBack_Click(object sender, EventArgs e)
        {
            if (_heosTelnet != null && _heosTelnet.IsConnected() && !string.IsNullOrEmpty(_activePid))
            {
                string cmd = $"heos://player/play_previous?pid={_activePid}";
                await _heosTelnet.SendAsync(cmd);

                ResetTimelineImmediate();
            }
            else
            {
                MessageBox.Show("HEOS-Verbindung nicht aktiv oder Player-ID fehlt.");
            }
        }
        private void btnHeosPlayBack_MouseDown(object sender, EventArgs e)
        {
            this.btnHeosPlayBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnHeosPlayBack.BackColor = System.Drawing.Color.DarkGray;
        }
        private void btnHeosPlayBack_MouseUp(object sender, EventArgs e)
        {
            this.btnHeosPlayBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayBack.BackColor = System.Drawing.Color.Transparent;
        }
        private void btnHeosPlayBack_MouseHover(object sender, EventArgs e)
        {
            this.btnHeosPlayBack.BackColor = System.Drawing.Color.DarkGray;
        }
        private async void btnHeosPlayShuffle_Click(object sender, EventArgs e)
        {
            if (_heosTelnet.IsConnected() && !string.IsNullOrEmpty(_activePid))
            {
                string newState = _isShuffleOn ? "off" : "on";
                await _heosTelnet.SendAsync($"heos://player/set_play_mode?pid={_activePid}&shuffle={newState}");
            }
        }
        private void btnHeosPlayShuffle_MouseDown(object sender, EventArgs e)
        {
            this.btnHeosPlayShuffle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnHeosPlayShuffle.BackColor = System.Drawing.Color.DarkGray;
        }
        private void btnHeosPlayShuffle_MouseUp(object sender, EventArgs e)
        {
            this.btnHeosPlayShuffle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayShuffle.BackColor = System.Drawing.Color.Transparent;
        }
        private void btnHeosPlayShuffle_MouseHover(object sender, EventArgs e)
        {
            this.btnHeosPlayShuffle.BackColor = System.Drawing.Color.DarkGray;
        }
        private async void btnHeosPlayRepeatAll_Click(object sender, EventArgs e)
        {
            if (_heosTelnet != null && _heosTelnet.IsConnected() && !string.IsNullOrEmpty(_activePid))
            {
                string cmd = $"heos://player/play_previous?pid={_activePid}&repeat=on_all";
                await _heosTelnet.SendAsync(cmd);
            }
            else
            {
                MessageBox.Show("HEOS-Verbindung nicht aktiv oder Player-ID fehlt.");
            }
        }
        private void btnHeosPlayRepeatAll_MouseDown(object sender, EventArgs e)
        {
            this.btnHeosPlayRepeatAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnHeosPlayRepeatAll.BackColor = System.Drawing.Color.DarkGray;
        }
        private void btnHeosPlayRepeatAll_MouseUp(object sender, EventArgs e)
        {
            this.btnHeosPlayRepeatAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayRepeatAll.BackColor = System.Drawing.Color.Transparent;
        }
        private void btnHeosPlayRepeatAll_MouseHover(object sender, EventArgs e)
        {
            this.btnHeosPlayRepeatAll.BackColor = System.Drawing.Color.DarkGray;
        }
        private async void btnHeosPlayRepeatOne_Click(object sender, EventArgs e)
        {
            if (_heosTelnet != null && _heosTelnet.IsConnected() && !string.IsNullOrEmpty(_activePid))
            {
                string cmd = $"heos://player/play_previous?pid={_activePid}&repeat=on_one";
                await _heosTelnet.SendAsync(cmd);
            }
            else
            {
                MessageBox.Show("HEOS-Verbindung nicht aktiv oder Player-ID fehlt.");
            }
        }
        private void btnHeosPlayRepeatOne_MouseDown(object sender, EventArgs e)
        {
            this.btnHeosPlayRepeatOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnHeosPlayRepeatOne.BackColor = System.Drawing.Color.DarkGray;
        }
        private void btnHeosPlayRepeatOne_MouseUp(object sender, EventArgs e)
        {
            this.btnHeosPlayRepeatOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayRepeatOne.BackColor = System.Drawing.Color.Transparent;
        }
        private void btnHeosPlayRepeatOne_MouseHover(object sender, EventArgs e)
        {
            this.btnHeosPlayRepeatOne.BackColor = System.Drawing.Color.DarkGray;
        }
        // Control Events END ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Form Events Part
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AVRControl_Shown(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _telnet.Stop();
            _heosTelnet.Stop();
            this.Dispose(true);
        }
        // Form Events END ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
