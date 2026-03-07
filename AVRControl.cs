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

using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;


namespace AVRControl
{
    public partial class AVRControl : Form
    {
        private string roamingPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AVRControl", "AVRControl.exe");
        private bool isRunningFromRoaming = false;
        private string currentConfigPath;

        private readonly string config = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\AVRControl.cfg";
        private bool _muted = false;
        private int CurVol = 10;
        private bool IsAVROn = false;
        private bool isScrolling = false;
        private System.Windows.Forms.Timer timerProgress;
        private int _localCurPos = 0;
        private int _maxDuration = 0;
        private DateTime _lastUserInteraction = DateTime.MinValue;
        private DateTime _lastVolumeSend = DateTime.MinValue;
        private bool IsHeosPlayPause = false;
        private bool _isShuffleOn = false;

        private AsyncTelnetClient _telnet;

        private AsyncTelnetClient _heosTelnet;
        private string _activePid = "";

        public AVRControl()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            Text = $"AVRControl v{Application.ProductVersion}";

            this.notifyIcon1.Icon = Icon;
            this.notifyIcon1.Text = Text;

            _telnet = new AsyncTelnetClient();
            _telnet.DataReceived += OnDataReceived;
            _telnet.StatusChanged += OnStatusReceived;

            _heosTelnet = new AsyncTelnetClient();
            _heosTelnet.DataReceived += OnHeosDataReceived;


            timerProgress = new System.Windows.Forms.Timer();
            timerProgress.Interval = 100;
            timerProgress.Tick += timerProgress_Tick;
        }

        // Form Init Part
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AVRControl_Load(object sender, EventArgs e)
        {
            RefreshInstallState();
            LoadDevice();

            if (cbSysTray.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
            else
            {
                this.Opacity = 100;
                this.ShowInTaskbar = true;
            }
        }
        private void LoadDevice()
        {
            HeosControlsToggle(false);

            try
            {
                string savedIP = ConfigManager.GetValue(currentConfigPath, "IP");
                string savedTray = ConfigManager.GetValue(currentConfigPath, "Systray");

                if (savedIP != null)
                {
                    tbIP.Text = savedIP;
                }

                if (savedTray != null && bool.TryParse(savedTray, out bool useTray))
                {
                    cbSysTray.Checked = useTray;
                    this.notifyIcon1.Visible = useTray;
                }

                if (string.IsNullOrWhiteSpace(tbIP.Text))
                {
                    this.lbConnectStatus.Text = "Please set IP below !";

                    return;
                }

                this.lbConnectStatus.Text = "Connecting ...";

                if (_telnet.IsHostOnline(tbIP.Text))
                {
                    if (_telnet.IsPortOpen(tbIP.Text, 23))
                    {
                        this.lbConnectStatus.Text = "Port 23 open..";

                        _ = _telnet.StartAsync(tbIP.Text, 23);

                        this.lbConnectStatus.Text = "Connected!";

                    }
                    else
                    {
                        this.lbConnectStatus.Text = "IP online but Port 23 closed...";

                    }
                }
                else
                {
                    this.lbConnectStatus.Text = "IP offline or wrong...";

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Fehler in LoadDevice: " + ex.Message);
            }
        }
        // Form Init Part END ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////

      
        // Control Events Part
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIP.Text))
            {
                MessageBox.Show("Please enter a valid IP address before saving.",
                                "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbIP.Focus();
                return;
            }

            try
            {
                ConfigManager.SaveValue(currentConfigPath, "IP", tbIP.Text);
                ConfigManager.SaveValue(currentConfigPath, "Systray", cbSysTray.Checked.ToString());

                LoadDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while writing IP to config file: " + ex.Message, "Error");
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
            if (!IsAVROn)
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
                MessageBox.Show("HEOS-Connection not active or missing Player-ID.");
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
                MessageBox.Show("HEOS-Connection not active or missing Player-ID.");
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
                MessageBox.Show("HEOS-Connection not active or missing Player-ID.");
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
                MessageBox.Show("HEOS-Connection not active or missing Player-ID.");
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
        private void btnInstall_Click(object sender, EventArgs e)
        {
            string targetDir = Path.GetDirectoryName(roamingPath);
            string registryPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

            try
            {
                if (btnInstall.Text == "GitUpdate")
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "https://github.com/SAMDestroy/AVRControl/releases/latest",
                        UseShellExecute = true
                    });
                    return;
                }

                if (btnInstall.Text == "Install" || btnInstall.Text == "Update")
                {
                    if (btnInstall.Text == "Install" && string.IsNullOrWhiteSpace(tbIP.Text))
                    {
                        MessageBox.Show("Please enter IP before installing.",
                                        "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbIP.Focus();
                        return;
                    }

                    if (!Directory.Exists(targetDir))
                        Directory.CreateDirectory(targetDir);

                    System.IO.File.Copy(Application.ExecutablePath, roamingPath, true);

                    string targetCfg = Path.Combine(targetDir, "AVRControl.cfg");
                    if (!System.IO.File.Exists(targetCfg))
                    {
                        currentConfigPath = targetCfg;

                        ConfigManager.SaveValue(currentConfigPath, "IP", tbIP.Text);
                        ConfigManager.SaveValue(currentConfigPath, "Systray", cbSysTray.Checked.ToString());
                    }

                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath, true))
                    {
                        if (key != null) key.SetValue("AVRControl", $"\"{roamingPath}\"");
                    }

                    string msg = (btnInstall.Text == "Update") ? "Update successfully!" : "Installation successfully!";
                    MessageBox.Show(msg + "\nAVRControl is now restarting from the roaming folder.", "AVRControl");

                    System.Diagnostics.Process.Start(roamingPath);
                    Environment.Exit(0);
                }
                else if (btnInstall.Text == "Uninstall")
                {
                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath, true))
                    {
                        if (key != null) key.DeleteValue("AVRControl", false);
                    }

                    if (!isRunningFromRoaming && System.IO.File.Exists(roamingPath))
                    {
                        try { System.IO.File.Delete(roamingPath); } catch { }
                    }

                    MessageBox.Show("Autostart removed. Closing AVRControl...", "Deinstallation");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while installing: " + ex.Message, "Error");
            }
        }
        // Control Events END ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Form Events Part
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AVRControl_Resize(object sender, EventArgs e)
        {
            if (cbSysTray.Checked && this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cbSysTray.Checked && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                return;
            }

            _telnet.Stop();
            _heosTelnet.Stop();

            if (notifyIcon1 != null) notifyIcon1.Dispose();
        }
        private void quitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cbSysTray.Checked = false;
            Application.Exit();
        }
        private void notifyIcon1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Visible && this.WindowState != FormWindowState.Minimized)
                {
                    this.Hide();
                    this.ShowInTaskbar = false;
                }
                else
                {
                    this.SuspendLayout();

                    this.Show();
                    this.ShowInTaskbar = true;
                    this.WindowState = FormWindowState.Normal;

                    this.Activate();
                    this.ResumeLayout(false);
                }
            }
        }
        private void cbSysTray_CheckedChanged(object sender, EventArgs e)
        {
            if (notifyIcon1 != null)
            {
                notifyIcon1.Visible = cbSysTray.Checked;
            }

            if (!cbSysTray.Focused)
                return;

            try
            {
                ConfigManager.SaveValue(currentConfigPath, "Systray", cbSysTray.Checked.ToString());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Fehler beim Speichern des Systray-Status: " + ex.Message);
            }
        }

        private void gitHubPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/SAMDestroy/AVRControl",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open browser: " + ex.Message);
            }
        }
        private void toolStripMenuItemShowHide_Click(object sender, EventArgs e)
        {
            if (this.Visible && this.WindowState != FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
            }
            else
            {
                this.SuspendLayout();

                this.Show();
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;

                this.Activate();
                this.ResumeLayout(false);
            }

        }
        // Form Events END ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
