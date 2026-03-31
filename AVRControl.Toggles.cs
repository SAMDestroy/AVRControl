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
        private void AVRControlsToggle(bool enabled)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<bool>(AVRControlsToggle), enabled);
                return;
            }

            IsAVROn = enabled;

            this.btnVolUp.Enabled = enabled;
            this.btnVolDown.Enabled = enabled;
            this.btnToggleMute.Enabled = enabled;
            this.SliderVolume.Enabled = enabled;
            this.PowerToggle.Checked = enabled;
            this.PowerToggle.Enabled = true;
            this.lblTabMain.Enabled = enabled;
            this.lblTabSpeaker.Enabled = enabled;

            if (!enabled)
            {
                if (tabControl1.SelectedIndex != 0)
                {
                    tabControl1.SelectedIndex = 0;

                    lblTabMain.BackColor = Color.SteelBlue; // Aktiv
                    lblTabSpeaker.BackColor = Color.Gray;   // Inaktiv
                }

                this.AVRSource.Text = "STANDBY";
                this.AVRSourceAudio.Text = "";
                this.AVRSoundMode.Text = "";
                this.ShowVolume.Text = "OFF";
                this.SliderVolume.Value = 10;

                this.PowerToggle.BackColor = Color.Gray;
                this.PowerToggle.FlatAppearance.CheckedBackColor = Color.Gray;
                this.PowerToggle.Text = "OFF";

                this.btnVolDown.BackColor = System.Drawing.Color.Transparent;
                this.btnVolUp.BackColor = System.Drawing.Color.Transparent;
                this.btnToggleMute.BackColor = System.Drawing.Color.Transparent;

                this.ActiveControl = null;

                timerProgress.Stop();
            }
            else
            {
                this.PowerToggle.BackColor = Color.Green;
                this.PowerToggle.FlatAppearance.CheckedBackColor = Color.Green;
                this.PowerToggle.Text = "ON";
                this.AVRSource.Text = "ON";

                this.btnVolDown.BackColor = System.Drawing.Color.DarkGray;
                this.btnVolUp.BackColor = System.Drawing.Color.DarkGray;
                this.btnToggleMute.BackColor = System.Drawing.Color.DarkGray;
            }
        }
        private void HeosControlsToggle(bool enabled)
        {

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<bool>(HeosControlsToggle), enabled);
                return;
            }

            this.btnHeosPlayPause.Enabled = enabled;
            this.btnHeosPlayBack.Enabled = enabled;
            this.btnHeosPlaySkip.Enabled = enabled;
            this.btnHeosPlayShuffle.Enabled = enabled;
            this.btnHeosPlayRepeatAll.Enabled = enabled;
            this.btnHeosPlayRepeatOne.Enabled = enabled;

            this.pnlProgressBack.Visible = enabled;

            if (!enabled || !IsAVROn)
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

                this.btnHeosPlayPause.BackColor = System.Drawing.Color.Transparent;
                this.btnHeosPlayBack.BackColor = System.Drawing.Color.Transparent;
                this.btnHeosPlaySkip.BackColor = System.Drawing.Color.Transparent;
                this.btnHeosPlayShuffle.BackColor = System.Drawing.Color.Transparent;
                this.btnHeosPlayRepeatAll.BackColor = System.Drawing.Color.Transparent;
                this.btnHeosPlayRepeatOne.BackColor = System.Drawing.Color.Transparent;
            }
            else
            {
                this.pbAlbumArt.Show();

                this.lbAlbumCover.Text = "Album Cover";

                this.lbHeosAlbum.Text = "Album:";
                this.lbHeosArtist.Text = "Artist:";
                this.lbHeosSong.Text = "Song:";

                this.lbHeosAVRName.Text = "Client:";
                this.lbHeosAVRVersion.Text = "Version:";
                this.lbHeosAVRID.Text = "Player ID:";
                this.lbHeosAVRNetType.Text = "NetType:";

                this.btnHeosPlayPause.BackColor = System.Drawing.Color.DarkGray;
                this.btnHeosPlayBack.BackColor = System.Drawing.Color.DarkGray;
                this.btnHeosPlaySkip.BackColor = System.Drawing.Color.DarkGray;
                this.btnHeosPlayShuffle.BackColor = System.Drawing.Color.DarkGray;
                this.btnHeosPlayRepeatAll.BackColor = System.Drawing.Color.DarkGray;
                this.btnHeosPlayRepeatOne.BackColor = System.Drawing.Color.DarkGray;
            }
        }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}