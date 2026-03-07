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

            this.btnVolUp.Enabled = enabled;
            this.btnVolDown.Enabled = enabled;
            this.btnToggleMute.Enabled = enabled;
            this.SliderVolume.Enabled = enabled;
            this.PowerToggle.Checked = enabled;
            this.PowerToggle.Enabled = true;

            if (!enabled)
            {
                this.AVRSource.Text = "STANDBY";
                this.AVRSourceAudio.Text = "";
                this.AVRSoundMode.Text = "";
                this.ShowVolume.Text = "OFF";
                this.SliderVolume.Value = 10;

                this.PowerToggle.BackColor = Color.Gray;
                this.PowerToggle.FlatAppearance.CheckedBackColor = Color.Gray;
                this.PowerToggle.Text = "OFF";

                this.ActiveControl = null;

                timerProgress.Stop();
            }
            else
            {
                this.PowerToggle.BackColor = Color.Green;
                this.PowerToggle.FlatAppearance.CheckedBackColor = Color.Green;
                this.PowerToggle.Text = "ON";
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

                this.lbHeosAlbum.Text = "Album:";
                this.lbHeosArtist.Text = "Artist:";
                this.lbHeosSong.Text = "Song:";

                this.lbHeosAVRName.Text = "Client:";
                this.lbHeosAVRVersion.Text = "Version:";
                this.lbHeosAVRID.Text = "Player ID:";
                this.lbHeosAVRNetType.Text = "NetType:";
            }
        }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}