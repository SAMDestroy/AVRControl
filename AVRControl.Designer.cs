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
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace AVRControl
{
    partial class AVRControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeosTrackInfoAlbum = new System.Windows.Forms.Label();
            this.SliderVolume = new System.Windows.Forms.TrackBar();
            this.ShowVolume = new System.Windows.Forms.Label();
            this.HorizontalLine = new System.Windows.Forms.Label();
            this.CopyrightNote = new System.Windows.Forms.Label();
            this.InfoNote = new System.Windows.Forms.Label();
            this.LabelPowerToggle = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbVol10 = new System.Windows.Forms.Label();
            this.lbVol20 = new System.Windows.Forms.Label();
            this.lbVol30 = new System.Windows.Forms.Label();
            this.lbVol40 = new System.Windows.Forms.Label();
            this.lbVol50 = new System.Windows.Forms.Label();
            this.lbVol60 = new System.Windows.Forms.Label();
            this.lbVol70 = new System.Windows.Forms.Label();
            this.lbVol80 = new System.Windows.Forms.Label();
            this.lbVol90 = new System.Windows.Forms.Label();
            this.lbVol100 = new System.Windows.Forms.Label();
            this.lbAVRSource = new System.Windows.Forms.Label();
            this.AVRSource = new System.Windows.Forms.Label();
            this.lbAVRSourceAudio = new System.Windows.Forms.Label();
            this.AVRSourceAudio = new System.Windows.Forms.Label();
            this.lbAVRSoundMode = new System.Windows.Forms.Label();
            this.AVRSoundMode = new System.Windows.Forms.Label();
            this.PowerToggle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDown = new System.Windows.Forms.Label();
            this.lbMute = new System.Windows.Forms.Label();
            this.lbUp = new System.Windows.Forms.Label();
            this.lbConnectStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HeosTrackInfoSong = new System.Windows.Forms.Label();
            this.HeosTrackInfoArtist = new System.Windows.Forms.Label();
            this.lbHeosArtist = new System.Windows.Forms.Label();
            this.lbHeosAlbum = new System.Windows.Forms.Label();
            this.lbHeosSong = new System.Windows.Forms.Label();
            this.lbHeosPlayPause = new System.Windows.Forms.Label();
            this.lbHeosPlayBack = new System.Windows.Forms.Label();
            this.lbHeosPlaySkip = new System.Windows.Forms.Label();
            this.lbHeosPlayShuffle = new System.Windows.Forms.Label();
            this.btnHeosPlayRepeatAll = new System.Windows.Forms.PictureBox();
            this.btnHeosPlayShuffle = new System.Windows.Forms.PictureBox();
            this.btnHeosPlayBack = new System.Windows.Forms.PictureBox();
            this.btnHeosPlaySkip = new System.Windows.Forms.PictureBox();
            this.btnHeosPlayPause = new System.Windows.Forms.PictureBox();
            this.btnToggleMute = new System.Windows.Forms.PictureBox();
            this.btnVolDown = new System.Windows.Forms.PictureBox();
            this.btnVolUp = new System.Windows.Forms.PictureBox();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.lbHeosPlayRepeatAll = new System.Windows.Forms.Label();
            this.btnHeosPlayRepeatOne = new System.Windows.Forms.PictureBox();
            this.lbHeosPlayRepeatOne = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pbAlbumArt = new System.Windows.Forms.PictureBox();
            this.lbAlbumCover = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lbHeosAVRName = new System.Windows.Forms.Label();
            this.lbHeosAVRVersion = new System.Windows.Forms.Label();
            this.lbHeosAVRID = new System.Windows.Forms.Label();
            this.lbHeosAVRNetType = new System.Windows.Forms.Label();
            this.lbHeosAVRName_Data = new System.Windows.Forms.Label();
            this.lbHeosAVRVersion_Data = new System.Windows.Forms.Label();
            this.lbHeosAVRID_Data = new System.Windows.Forms.Label();
            this.lbHeosAVRNetType_Data = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SliderVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayRepeatAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlaySkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayRepeatOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumArt)).BeginInit();
            this.SuspendLayout();
            // 
            // HeosTrackInfoAlbum
            // 
            this.HeosTrackInfoAlbum.AutoSize = true;
            this.HeosTrackInfoAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeosTrackInfoAlbum.ForeColor = System.Drawing.Color.Khaki;
            this.HeosTrackInfoAlbum.Location = new System.Drawing.Point(485, 350);
            this.HeosTrackInfoAlbum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HeosTrackInfoAlbum.Name = "HeosTrackInfoAlbum";
            this.HeosTrackInfoAlbum.Size = new System.Drawing.Size(59, 24);
            this.HeosTrackInfoAlbum.TabIndex = 30;
            this.HeosTrackInfoAlbum.Text = "TEST";
            // 
            // SliderVolume
            // 
            this.SliderVolume.AutoSize = false;
            this.SliderVolume.Enabled = false;
            this.SliderVolume.Location = new System.Drawing.Point(23, 199);
            this.SliderVolume.Margin = new System.Windows.Forms.Padding(24, 23, 24, 0);
            this.SliderVolume.Maximum = 100;
            this.SliderVolume.MaximumSize = new System.Drawing.Size(880, 96);
            this.SliderVolume.Minimum = 10;
            this.SliderVolume.Name = "SliderVolume";
            this.SliderVolume.Size = new System.Drawing.Size(880, 58);
            this.SliderVolume.SmallChange = 2;
            this.SliderVolume.TabIndex = 7;
            this.SliderVolume.Text = "SliderVolume";
            this.SliderVolume.TickFrequency = 5;
            this.SliderVolume.Value = 10;
            this.SliderVolume.Scroll += new System.EventHandler(this.SliderVolume_Scroll);
            this.SliderVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SliderVolume_MouseUp);
            // 
            // ShowVolume
            // 
            this.ShowVolume.ForeColor = System.Drawing.Color.White;
            this.ShowVolume.Location = new System.Drawing.Point(899, 206);
            this.ShowVolume.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ShowVolume.Name = "ShowVolume";
            this.ShowVolume.Size = new System.Drawing.Size(80, 27);
            this.ShowVolume.TabIndex = 8;
            this.ShowVolume.Text = "Vol: 10";
            // 
            // HorizontalLine
            // 
            this.HorizontalLine.BackColor = System.Drawing.Color.DarkSlateGray;
            this.HorizontalLine.Location = new System.Drawing.Point(2, 98);
            this.HorizontalLine.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HorizontalLine.Name = "HorizontalLine";
            this.HorizontalLine.Size = new System.Drawing.Size(1000, 1);
            this.HorizontalLine.TabIndex = 9;
            // 
            // CopyrightNote
            // 
            this.CopyrightNote.AutoSize = true;
            this.CopyrightNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic);
            this.CopyrightNote.ForeColor = System.Drawing.Color.White;
            this.CopyrightNote.Location = new System.Drawing.Point(820, 733);
            this.CopyrightNote.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CopyrightNote.Name = "CopyrightNote";
            this.CopyrightNote.Size = new System.Drawing.Size(161, 25);
            this.CopyrightNote.TabIndex = 10;
            this.CopyrightNote.Text = "by SAMDestroy";
            // 
            // InfoNote
            // 
            this.InfoNote.AutoSize = true;
            this.InfoNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoNote.ForeColor = System.Drawing.Color.White;
            this.InfoNote.Location = new System.Drawing.Point(780, 10);
            this.InfoNote.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.InfoNote.Name = "InfoNote";
            this.InfoNote.Size = new System.Drawing.Size(196, 50);
            this.InfoNote.TabIndex = 11;
            this.InfoNote.Text = "Denon / Marantz\nAVR Telnet Control";
            // 
            // LabelPowerToggle
            // 
            this.LabelPowerToggle.AutoSize = true;
            this.LabelPowerToggle.ForeColor = System.Drawing.Color.White;
            this.LabelPowerToggle.Location = new System.Drawing.Point(562, 10);
            this.LabelPowerToggle.Name = "LabelPowerToggle";
            this.LabelPowerToggle.Size = new System.Drawing.Size(125, 25);
            this.LabelPowerToggle.TabIndex = 13;
            this.LabelPowerToggle.Text = "Main Power";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.ForeColor = System.Drawing.Color.White;
            this.lblIP.Location = new System.Drawing.Point(24, 48);
            this.lblIP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(37, 25);
            this.lblIP.TabIndex = 3;
            this.lblIP.Text = "IP:";
            // 
            // tbIP
            // 
            this.tbIP.BackColor = System.Drawing.Color.DarkGray;
            this.tbIP.Location = new System.Drawing.Point(80, 43);
            this.tbIP.Margin = new System.Windows.Forms.Padding(6);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(209, 31);
            this.tbIP.TabIndex = 2;
            this.tbIP.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.Location = new System.Drawing.Point(320, 39);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 44);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lbVol10
            // 
            this.lbVol10.AutoSize = true;
            this.lbVol10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbVol10.Location = new System.Drawing.Point(33, 255);
            this.lbVol10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol10.Name = "lbVol10";
            this.lbVol10.Size = new System.Drawing.Size(30, 24);
            this.lbVol10.TabIndex = 15;
            this.lbVol10.Text = "10";
            // 
            // lbVol20
            // 
            this.lbVol20.AutoSize = true;
            this.lbVol20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol20.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbVol20.Location = new System.Drawing.Point(125, 255);
            this.lbVol20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol20.Name = "lbVol20";
            this.lbVol20.Size = new System.Drawing.Size(30, 24);
            this.lbVol20.TabIndex = 16;
            this.lbVol20.Text = "20";
            // 
            // lbVol30
            // 
            this.lbVol30.AutoSize = true;
            this.lbVol30.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol30.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbVol30.Location = new System.Drawing.Point(217, 255);
            this.lbVol30.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol30.Name = "lbVol30";
            this.lbVol30.Size = new System.Drawing.Size(30, 24);
            this.lbVol30.TabIndex = 17;
            this.lbVol30.Text = "30";
            // 
            // lbVol40
            // 
            this.lbVol40.AutoSize = true;
            this.lbVol40.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol40.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbVol40.Location = new System.Drawing.Point(309, 255);
            this.lbVol40.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol40.Name = "lbVol40";
            this.lbVol40.Size = new System.Drawing.Size(30, 24);
            this.lbVol40.TabIndex = 18;
            this.lbVol40.Text = "40";
            // 
            // lbVol50
            // 
            this.lbVol50.AutoSize = true;
            this.lbVol50.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol50.ForeColor = System.Drawing.Color.Beige;
            this.lbVol50.Location = new System.Drawing.Point(401, 255);
            this.lbVol50.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol50.Name = "lbVol50";
            this.lbVol50.Size = new System.Drawing.Size(32, 24);
            this.lbVol50.TabIndex = 19;
            this.lbVol50.Text = "50";
            // 
            // lbVol60
            // 
            this.lbVol60.AutoSize = true;
            this.lbVol60.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol60.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lbVol60.Location = new System.Drawing.Point(491, 255);
            this.lbVol60.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol60.Name = "lbVol60";
            this.lbVol60.Size = new System.Drawing.Size(30, 24);
            this.lbVol60.TabIndex = 20;
            this.lbVol60.Text = "60";
            // 
            // lbVol70
            // 
            this.lbVol70.AutoSize = true;
            this.lbVol70.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol70.ForeColor = System.Drawing.Color.Khaki;
            this.lbVol70.Location = new System.Drawing.Point(584, 255);
            this.lbVol70.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol70.Name = "lbVol70";
            this.lbVol70.Size = new System.Drawing.Size(30, 24);
            this.lbVol70.TabIndex = 21;
            this.lbVol70.Text = "70";
            // 
            // lbVol80
            // 
            this.lbVol80.AutoSize = true;
            this.lbVol80.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol80.ForeColor = System.Drawing.Color.Peru;
            this.lbVol80.Location = new System.Drawing.Point(676, 255);
            this.lbVol80.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol80.Name = "lbVol80";
            this.lbVol80.Size = new System.Drawing.Size(30, 24);
            this.lbVol80.TabIndex = 22;
            this.lbVol80.Text = "80";
            // 
            // lbVol90
            // 
            this.lbVol90.AutoSize = true;
            this.lbVol90.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol90.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbVol90.Location = new System.Drawing.Point(768, 255);
            this.lbVol90.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol90.Name = "lbVol90";
            this.lbVol90.Size = new System.Drawing.Size(30, 24);
            this.lbVol90.TabIndex = 23;
            this.lbVol90.Text = "90";
            // 
            // lbVol100
            // 
            this.lbVol100.AutoSize = true;
            this.lbVol100.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol100.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbVol100.Location = new System.Drawing.Point(852, 255);
            this.lbVol100.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol100.Name = "lbVol100";
            this.lbVol100.Size = new System.Drawing.Size(40, 24);
            this.lbVol100.TabIndex = 24;
            this.lbVol100.Text = "100";
            // 
            // lbAVRSource
            // 
            this.lbAVRSource.AutoSize = true;
            this.lbAVRSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAVRSource.ForeColor = System.Drawing.Color.White;
            this.lbAVRSource.Location = new System.Drawing.Point(18, 318);
            this.lbAVRSource.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAVRSource.Name = "lbAVRSource";
            this.lbAVRSource.Size = new System.Drawing.Size(178, 26);
            this.lbAVRSource.TabIndex = 25;
            this.lbAVRSource.Text = "Selected Source:";
            // 
            // AVRSource
            // 
            this.AVRSource.AutoSize = true;
            this.AVRSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVRSource.ForeColor = System.Drawing.Color.DarkOrange;
            this.AVRSource.Location = new System.Drawing.Point(198, 318);
            this.AVRSource.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AVRSource.Name = "AVRSource";
            this.AVRSource.Size = new System.Drawing.Size(63, 24);
            this.AVRSource.TabIndex = 26;
            this.AVRSource.Text = "TEST";
            // 
            // lbAVRSourceAudio
            // 
            this.lbAVRSourceAudio.AutoSize = true;
            this.lbAVRSourceAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAVRSourceAudio.ForeColor = System.Drawing.Color.White;
            this.lbAVRSourceAudio.Location = new System.Drawing.Point(20, 348);
            this.lbAVRSourceAudio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAVRSourceAudio.Name = "lbAVRSourceAudio";
            this.lbAVRSourceAudio.Size = new System.Drawing.Size(143, 26);
            this.lbAVRSourceAudio.TabIndex = 27;
            this.lbAVRSourceAudio.Text = "SourceAudio:";
            // 
            // AVRSourceAudio
            // 
            this.AVRSourceAudio.AutoSize = true;
            this.AVRSourceAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVRSourceAudio.ForeColor = System.Drawing.Color.Khaki;
            this.AVRSourceAudio.Location = new System.Drawing.Point(200, 348);
            this.AVRSourceAudio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AVRSourceAudio.Name = "AVRSourceAudio";
            this.AVRSourceAudio.Size = new System.Drawing.Size(59, 24);
            this.AVRSourceAudio.TabIndex = 28;
            this.AVRSourceAudio.Text = "TEST";
            // 
            // lbAVRSoundMode
            // 
            this.lbAVRSoundMode.AutoSize = true;
            this.lbAVRSoundMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAVRSoundMode.ForeColor = System.Drawing.Color.White;
            this.lbAVRSoundMode.Location = new System.Drawing.Point(20, 378);
            this.lbAVRSoundMode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAVRSoundMode.Name = "lbAVRSoundMode";
            this.lbAVRSoundMode.Size = new System.Drawing.Size(135, 26);
            this.lbAVRSoundMode.TabIndex = 29;
            this.lbAVRSoundMode.Text = "SoundMode:";
            // 
            // AVRSoundMode
            // 
            this.AVRSoundMode.AutoSize = true;
            this.AVRSoundMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVRSoundMode.ForeColor = System.Drawing.Color.Khaki;
            this.AVRSoundMode.Location = new System.Drawing.Point(200, 381);
            this.AVRSoundMode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AVRSoundMode.Name = "AVRSoundMode";
            this.AVRSoundMode.Size = new System.Drawing.Size(59, 24);
            this.AVRSoundMode.TabIndex = 30;
            this.AVRSoundMode.Text = "TEST";
            // 
            // PowerToggle
            // 
            this.PowerToggle.Appearance = System.Windows.Forms.Appearance.Button;
            this.PowerToggle.BackColor = System.Drawing.Color.SlateGray;
            this.PowerToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.PowerToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerToggle.ForeColor = System.Drawing.Color.White;
            this.PowerToggle.Location = new System.Drawing.Point(565, 41);
            this.PowerToggle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.PowerToggle.Name = "PowerToggle";
            this.PowerToggle.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PowerToggle.Size = new System.Drawing.Size(120, 35);
            this.PowerToggle.TabIndex = 12;
            this.PowerToggle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PowerToggle.UseVisualStyleBackColor = false;
            this.PowerToggle.Click += new System.EventHandler(this.PowerToggle_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(-6, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 1);
            this.label1.TabIndex = 0;
            // 
            // lbDown
            // 
            this.lbDown.AutoSize = true;
            this.lbDown.ForeColor = System.Drawing.Color.White;
            this.lbDown.Location = new System.Drawing.Point(17, 172);
            this.lbDown.Name = "lbDown";
            this.lbDown.Size = new System.Drawing.Size(66, 25);
            this.lbDown.TabIndex = 31;
            this.lbDown.Text = "Down";
            // 
            // lbMute
            // 
            this.lbMute.AutoSize = true;
            this.lbMute.ForeColor = System.Drawing.Color.White;
            this.lbMute.Location = new System.Drawing.Point(439, 172);
            this.lbMute.Name = "lbMute";
            this.lbMute.Size = new System.Drawing.Size(60, 25);
            this.lbMute.TabIndex = 32;
            this.lbMute.Text = "Mute";
            // 
            // lbUp
            // 
            this.lbUp.AutoSize = true;
            this.lbUp.ForeColor = System.Drawing.Color.White;
            this.lbUp.Location = new System.Drawing.Point(865, 172);
            this.lbUp.Name = "lbUp";
            this.lbUp.Size = new System.Drawing.Size(39, 25);
            this.lbUp.TabIndex = 33;
            this.lbUp.Text = "Up";
            // 
            // lbConnectStatus
            // 
            this.lbConnectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectStatus.ForeColor = System.Drawing.Color.Khaki;
            this.lbConnectStatus.Location = new System.Drawing.Point(12, 4);
            this.lbConnectStatus.Name = "lbConnectStatus";
            this.lbConnectStatus.Size = new System.Drawing.Size(450, 23);
            this.lbConnectStatus.TabIndex = 34;
            this.lbConnectStatus.Text = "label2";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(-6, 546);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1000, 1);
            this.label2.TabIndex = 35;
            // 
            // HeosTrackInfoSong
            // 
            this.HeosTrackInfoSong.AutoSize = true;
            this.HeosTrackInfoSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeosTrackInfoSong.ForeColor = System.Drawing.Color.Khaki;
            this.HeosTrackInfoSong.Location = new System.Drawing.Point(486, 382);
            this.HeosTrackInfoSong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HeosTrackInfoSong.Name = "HeosTrackInfoSong";
            this.HeosTrackInfoSong.Size = new System.Drawing.Size(59, 24);
            this.HeosTrackInfoSong.TabIndex = 36;
            this.HeosTrackInfoSong.Text = "TEST";
            // 
            // HeosTrackInfoArtist
            // 
            this.HeosTrackInfoArtist.AutoSize = true;
            this.HeosTrackInfoArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeosTrackInfoArtist.ForeColor = System.Drawing.Color.Khaki;
            this.HeosTrackInfoArtist.Location = new System.Drawing.Point(485, 315);
            this.HeosTrackInfoArtist.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HeosTrackInfoArtist.Name = "HeosTrackInfoArtist";
            this.HeosTrackInfoArtist.Size = new System.Drawing.Size(59, 24);
            this.HeosTrackInfoArtist.TabIndex = 37;
            this.HeosTrackInfoArtist.Text = "TEST";
            // 
            // lbHeosArtist
            // 
            this.lbHeosArtist.AutoSize = true;
            this.lbHeosArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosArtist.ForeColor = System.Drawing.Color.White;
            this.lbHeosArtist.Location = new System.Drawing.Point(406, 315);
            this.lbHeosArtist.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosArtist.Name = "lbHeosArtist";
            this.lbHeosArtist.Size = new System.Drawing.Size(68, 26);
            this.lbHeosArtist.TabIndex = 38;
            this.lbHeosArtist.Text = "Artist:";
            // 
            // lbHeosAlbum
            // 
            this.lbHeosAlbum.AutoSize = true;
            this.lbHeosAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosAlbum.ForeColor = System.Drawing.Color.White;
            this.lbHeosAlbum.Location = new System.Drawing.Point(406, 348);
            this.lbHeosAlbum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosAlbum.Name = "lbHeosAlbum";
            this.lbHeosAlbum.Size = new System.Drawing.Size(81, 26);
            this.lbHeosAlbum.TabIndex = 39;
            this.lbHeosAlbum.Text = "Album:";
            // 
            // lbHeosSong
            // 
            this.lbHeosSong.AutoSize = true;
            this.lbHeosSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosSong.ForeColor = System.Drawing.Color.White;
            this.lbHeosSong.Location = new System.Drawing.Point(407, 380);
            this.lbHeosSong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosSong.Name = "lbHeosSong";
            this.lbHeosSong.Size = new System.Drawing.Size(69, 26);
            this.lbHeosSong.TabIndex = 40;
            this.lbHeosSong.Text = "Song:";
            // 
            // lbHeosPlayPause
            // 
            this.lbHeosPlayPause.AutoSize = true;
            this.lbHeosPlayPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosPlayPause.ForeColor = System.Drawing.Color.White;
            this.lbHeosPlayPause.Location = new System.Drawing.Point(40, 502);
            this.lbHeosPlayPause.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosPlayPause.Name = "lbHeosPlayPause";
            this.lbHeosPlayPause.Size = new System.Drawing.Size(123, 26);
            this.lbHeosPlayPause.TabIndex = 45;
            this.lbHeosPlayPause.Text = "Play/Pause";
            // 
            // lbHeosPlayBack
            // 
            this.lbHeosPlayBack.AutoSize = true;
            this.lbHeosPlayBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosPlayBack.ForeColor = System.Drawing.Color.White;
            this.lbHeosPlayBack.Location = new System.Drawing.Point(222, 502);
            this.lbHeosPlayBack.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosPlayBack.Name = "lbHeosPlayBack";
            this.lbHeosPlayBack.Size = new System.Drawing.Size(61, 26);
            this.lbHeosPlayBack.TabIndex = 46;
            this.lbHeosPlayBack.Text = "Back";
            // 
            // lbHeosPlaySkip
            // 
            this.lbHeosPlaySkip.AutoSize = true;
            this.lbHeosPlaySkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosPlaySkip.ForeColor = System.Drawing.Color.White;
            this.lbHeosPlaySkip.Location = new System.Drawing.Point(377, 502);
            this.lbHeosPlaySkip.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosPlaySkip.Name = "lbHeosPlaySkip";
            this.lbHeosPlaySkip.Size = new System.Drawing.Size(55, 26);
            this.lbHeosPlaySkip.TabIndex = 47;
            this.lbHeosPlaySkip.Text = "Skip";
            // 
            // lbHeosPlayShuffle
            // 
            this.lbHeosPlayShuffle.AutoSize = true;
            this.lbHeosPlayShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosPlayShuffle.ForeColor = System.Drawing.Color.White;
            this.lbHeosPlayShuffle.Location = new System.Drawing.Point(515, 504);
            this.lbHeosPlayShuffle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosPlayShuffle.Name = "lbHeosPlayShuffle";
            this.lbHeosPlayShuffle.Size = new System.Drawing.Size(80, 26);
            this.lbHeosPlayShuffle.TabIndex = 48;
            this.lbHeosPlayShuffle.Text = "Shuffle";
            // 
            // btnHeosPlayRepeatAll
            // 
            this.btnHeosPlayRepeatAll.BackColor = System.Drawing.Color.Transparent;
            this.btnHeosPlayRepeatAll.BackgroundImage = global::AVRControl.Properties.Resources.RepeatAllIcon;
            this.btnHeosPlayRepeatAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeosPlayRepeatAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayRepeatAll.Location = new System.Drawing.Point(669, 443);
            this.btnHeosPlayRepeatAll.Margin = new System.Windows.Forms.Padding(6);
            this.btnHeosPlayRepeatAll.Name = "btnHeosPlayRepeatAll";
            this.btnHeosPlayRepeatAll.Size = new System.Drawing.Size(73, 53);
            this.btnHeosPlayRepeatAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHeosPlayRepeatAll.TabIndex = 49;
            this.btnHeosPlayRepeatAll.TabStop = false;
            this.btnHeosPlayRepeatAll.Click += new System.EventHandler(this.btnHeosPlayRepeatAll_Click);
            this.btnHeosPlayRepeatAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayRepeatAll_MouseDown);
            this.btnHeosPlayRepeatAll.MouseEnter += new System.EventHandler(this.btnHeosPlayRepeatAll_MouseHover);
            this.btnHeosPlayRepeatAll.MouseLeave += new System.EventHandler(this.btnHeosPlayRepeatAll_MouseUp);
            this.btnHeosPlayRepeatAll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayRepeatAll_MouseUp);
            // 
            // btnHeosPlayShuffle
            // 
            this.btnHeosPlayShuffle.BackColor = System.Drawing.Color.Transparent;
            this.btnHeosPlayShuffle.BackgroundImage = global::AVRControl.Properties.Resources.ShuffleIcon;
            this.btnHeosPlayShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeosPlayShuffle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayShuffle.Location = new System.Drawing.Point(518, 443);
            this.btnHeosPlayShuffle.Margin = new System.Windows.Forms.Padding(6);
            this.btnHeosPlayShuffle.Name = "btnHeosPlayShuffle";
            this.btnHeosPlayShuffle.Size = new System.Drawing.Size(73, 53);
            this.btnHeosPlayShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHeosPlayShuffle.TabIndex = 44;
            this.btnHeosPlayShuffle.TabStop = false;
            this.btnHeosPlayShuffle.Click += new System.EventHandler(this.btnHeosPlayShuffle_Click);
            this.btnHeosPlayShuffle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayShuffle_MouseDown);
            this.btnHeosPlayShuffle.MouseEnter += new System.EventHandler(this.btnHeosPlayShuffle_MouseHover);
            this.btnHeosPlayShuffle.MouseLeave += new System.EventHandler(this.btnHeosPlayShuffle_MouseUp);
            this.btnHeosPlayShuffle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayShuffle_MouseUp);
            // 
            // btnHeosPlayBack
            // 
            this.btnHeosPlayBack.BackColor = System.Drawing.Color.Transparent;
            this.btnHeosPlayBack.BackgroundImage = global::AVRControl.Properties.Resources.BackIcon;
            this.btnHeosPlayBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeosPlayBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayBack.Location = new System.Drawing.Point(216, 443);
            this.btnHeosPlayBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnHeosPlayBack.Name = "btnHeosPlayBack";
            this.btnHeosPlayBack.Size = new System.Drawing.Size(73, 53);
            this.btnHeosPlayBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHeosPlayBack.TabIndex = 43;
            this.btnHeosPlayBack.TabStop = false;
            this.btnHeosPlayBack.Click += new System.EventHandler(this.btnHeosPlayBack_Click);
            this.btnHeosPlayBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayBack_MouseDown);
            this.btnHeosPlayBack.MouseEnter += new System.EventHandler(this.btnHeosPlayBack_MouseHover);
            this.btnHeosPlayBack.MouseLeave += new System.EventHandler(this.btnHeosPlayBack_MouseUp);
            this.btnHeosPlayBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayBack_MouseUp);
            // 
            // btnHeosPlaySkip
            // 
            this.btnHeosPlaySkip.BackColor = System.Drawing.Color.Transparent;
            this.btnHeosPlaySkip.BackgroundImage = global::AVRControl.Properties.Resources.SkipIcon;
            this.btnHeosPlaySkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeosPlaySkip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlaySkip.Location = new System.Drawing.Point(367, 443);
            this.btnHeosPlaySkip.Margin = new System.Windows.Forms.Padding(6);
            this.btnHeosPlaySkip.Name = "btnHeosPlaySkip";
            this.btnHeosPlaySkip.Size = new System.Drawing.Size(73, 53);
            this.btnHeosPlaySkip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHeosPlaySkip.TabIndex = 42;
            this.btnHeosPlaySkip.TabStop = false;
            this.btnHeosPlaySkip.Click += new System.EventHandler(this.btnHeosPlaySkip_Click);
            this.btnHeosPlaySkip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlaySkip_MouseDown);
            this.btnHeosPlaySkip.MouseEnter += new System.EventHandler(this.btnHeosPlaySkip_MouseHover);
            this.btnHeosPlaySkip.MouseLeave += new System.EventHandler(this.btnHeosPlaySkip_MouseUp);
            this.btnHeosPlaySkip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlaySkip_MouseUp);
            // 
            // btnHeosPlayPause
            // 
            this.btnHeosPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btnHeosPlayPause.BackgroundImage = global::AVRControl.Properties.Resources.PauseIcon;
            this.btnHeosPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeosPlayPause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayPause.Location = new System.Drawing.Point(65, 443);
            this.btnHeosPlayPause.Margin = new System.Windows.Forms.Padding(6);
            this.btnHeosPlayPause.Name = "btnHeosPlayPause";
            this.btnHeosPlayPause.Size = new System.Drawing.Size(73, 53);
            this.btnHeosPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHeosPlayPause.TabIndex = 41;
            this.btnHeosPlayPause.TabStop = false;
            this.btnHeosPlayPause.Click += new System.EventHandler(this.btnHeosPlayPause_Click);
            this.btnHeosPlayPause.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayPause_MouseDown);
            this.btnHeosPlayPause.MouseEnter += new System.EventHandler(this.btnHeosPlayPause_MouseHover);
            this.btnHeosPlayPause.MouseLeave += new System.EventHandler(this.btnHeosPlayPause_MouseUp);
            this.btnHeosPlayPause.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayPause_MouseUp);
            // 
            // btnToggleMute
            // 
            this.btnToggleMute.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleMute.BackgroundImage = global::AVRControl.Properties.Resources.Vol_Mute;
            this.btnToggleMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnToggleMute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnToggleMute.Location = new System.Drawing.Point(433, 114);
            this.btnToggleMute.Margin = new System.Windows.Forms.Padding(6);
            this.btnToggleMute.Name = "btnToggleMute";
            this.btnToggleMute.Size = new System.Drawing.Size(73, 53);
            this.btnToggleMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnToggleMute.TabIndex = 14;
            this.btnToggleMute.TabStop = false;
            this.btnToggleMute.Click += new System.EventHandler(this.BtnToggleMute_Click);
            this.btnToggleMute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnToggleMute_MouseDown);
            this.btnToggleMute.MouseEnter += new System.EventHandler(this.BtnToggleMute_MouseHover);
            this.btnToggleMute.MouseLeave += new System.EventHandler(this.BtnToggleMute_MouseLeave);
            this.btnToggleMute.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnToggleMute_MouseLeave);
            // 
            // btnVolDown
            // 
            this.btnVolDown.BackColor = System.Drawing.Color.Transparent;
            this.btnVolDown.BackgroundImage = global::AVRControl.Properties.Resources.Vol_Down;
            this.btnVolDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnVolDown.Location = new System.Drawing.Point(11, 114);
            this.btnVolDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnVolDown.Name = "btnVolDown";
            this.btnVolDown.Size = new System.Drawing.Size(73, 53);
            this.btnVolDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolDown.TabIndex = 14;
            this.btnVolDown.TabStop = false;
            this.btnVolDown.Click += new System.EventHandler(this.BtnVolDown_Click);
            this.btnVolDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnVolDown_MouseDown);
            this.btnVolDown.MouseEnter += new System.EventHandler(this.BtnVolDown_MouseHover);
            this.btnVolDown.MouseLeave += new System.EventHandler(this.BtnVolDown_MouseUp);
            this.btnVolDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnVolDown_MouseUp);
            // 
            // btnVolUp
            // 
            this.btnVolUp.BackColor = System.Drawing.Color.Transparent;
            this.btnVolUp.BackgroundImage = global::AVRControl.Properties.Resources.Vol_Up;
            this.btnVolUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnVolUp.Location = new System.Drawing.Point(847, 114);
            this.btnVolUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnVolUp.Name = "btnVolUp";
            this.btnVolUp.Size = new System.Drawing.Size(73, 53);
            this.btnVolUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolUp.TabIndex = 14;
            this.btnVolUp.TabStop = false;
            this.btnVolUp.Click += new System.EventHandler(this.BtnVolUp_Click);
            this.btnVolUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnVolUp_MouseDown);
            this.btnVolUp.MouseEnter += new System.EventHandler(this.BtnVolUp_MouseHover);
            this.btnVolUp.MouseLeave += new System.EventHandler(this.BtnVolUp_MouseUp);
            this.btnVolUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnVolUp_MouseUp);
            // 
            // LogoPicture
            // 
            this.LogoPicture.BackColor = System.Drawing.Color.Transparent;
            this.LogoPicture.Image = global::AVRControl.Properties.Resources.apple_klein;
            this.LogoPicture.Location = new System.Drawing.Point(756, 665);
            this.LogoPicture.Margin = new System.Windows.Forms.Padding(6);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(200, 96);
            this.LogoPicture.TabIndex = 14;
            this.LogoPicture.TabStop = false;
            // 
            // lbHeosPlayRepeatAll
            // 
            this.lbHeosPlayRepeatAll.AutoSize = true;
            this.lbHeosPlayRepeatAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosPlayRepeatAll.ForeColor = System.Drawing.Color.White;
            this.lbHeosPlayRepeatAll.Location = new System.Drawing.Point(650, 504);
            this.lbHeosPlayRepeatAll.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosPlayRepeatAll.Name = "lbHeosPlayRepeatAll";
            this.lbHeosPlayRepeatAll.Size = new System.Drawing.Size(113, 26);
            this.lbHeosPlayRepeatAll.TabIndex = 50;
            this.lbHeosPlayRepeatAll.Text = "Repeat All";
            // 
            // btnHeosPlayRepeatOne
            // 
            this.btnHeosPlayRepeatOne.BackColor = System.Drawing.Color.Transparent;
            this.btnHeosPlayRepeatOne.BackgroundImage = global::AVRControl.Properties.Resources.RepeatOneIcon;
            this.btnHeosPlayRepeatOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeosPlayRepeatOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayRepeatOne.Location = new System.Drawing.Point(820, 443);
            this.btnHeosPlayRepeatOne.Margin = new System.Windows.Forms.Padding(6);
            this.btnHeosPlayRepeatOne.Name = "btnHeosPlayRepeatOne";
            this.btnHeosPlayRepeatOne.Size = new System.Drawing.Size(73, 53);
            this.btnHeosPlayRepeatOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHeosPlayRepeatOne.TabIndex = 51;
            this.btnHeosPlayRepeatOne.TabStop = false;
            this.btnHeosPlayRepeatOne.Click += new System.EventHandler(this.btnHeosPlayRepeatOne_Click);
            this.btnHeosPlayRepeatOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayRepeatOne_MouseDown);
            this.btnHeosPlayRepeatOne.MouseEnter += new System.EventHandler(this.btnHeosPlayRepeatOne_MouseHover);
            this.btnHeosPlayRepeatOne.MouseLeave += new System.EventHandler(this.btnHeosPlayRepeatOne_MouseUp);
            this.btnHeosPlayRepeatOne.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayRepeatOne_MouseUp);
            // 
            // lbHeosPlayRepeatOne
            // 
            this.lbHeosPlayRepeatOne.AutoSize = true;
            this.lbHeosPlayRepeatOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosPlayRepeatOne.ForeColor = System.Drawing.Color.White;
            this.lbHeosPlayRepeatOne.Location = new System.Drawing.Point(797, 502);
            this.lbHeosPlayRepeatOne.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosPlayRepeatOne.Name = "lbHeosPlayRepeatOne";
            this.lbHeosPlayRepeatOne.Size = new System.Drawing.Size(129, 26);
            this.lbHeosPlayRepeatOne.TabIndex = 52;
            this.lbHeosPlayRepeatOne.Text = "Repeat One";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(-6, 425);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1000, 1);
            this.label9.TabIndex = 53;
            // 
            // pbAlbumArt
            // 
            this.pbAlbumArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAlbumArt.Location = new System.Drawing.Point(423, 612);
            this.pbAlbumArt.Name = "pbAlbumArt";
            this.pbAlbumArt.Size = new System.Drawing.Size(112, 123);
            this.pbAlbumArt.TabIndex = 54;
            this.pbAlbumArt.TabStop = false;
            // 
            // lbAlbumCover
            // 
            this.lbAlbumCover.AutoSize = true;
            this.lbAlbumCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlbumCover.ForeColor = System.Drawing.Color.White;
            this.lbAlbumCover.Location = new System.Drawing.Point(411, 736);
            this.lbAlbumCover.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAlbumCover.Name = "lbAlbumCover";
            this.lbAlbumCover.Size = new System.Drawing.Size(139, 26);
            this.lbAlbumCover.TabIndex = 55;
            this.lbAlbumCover.Text = "Album Cover";
            // 
            // lblTime
            // 
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(408, 583);
            this.lblTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(161, 27);
            this.lblTime.TabIndex = 57;
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(45, 562);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(868, 10);
            this.pbProgress.Step = 1;
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgress.TabIndex = 58;
            // 
            // lbHeosAVRName
            // 
            this.lbHeosAVRName.AutoSize = true;
            this.lbHeosAVRName.ForeColor = System.Drawing.Color.White;
            this.lbHeosAVRName.Location = new System.Drawing.Point(24, 623);
            this.lbHeosAVRName.Name = "lbHeosAVRName";
            this.lbHeosAVRName.Size = new System.Drawing.Size(73, 25);
            this.lbHeosAVRName.TabIndex = 59;
            this.lbHeosAVRName.Text = "Client:";
            // 
            // lbHeosAVRVersion
            // 
            this.lbHeosAVRVersion.AutoSize = true;
            this.lbHeosAVRVersion.ForeColor = System.Drawing.Color.White;
            this.lbHeosAVRVersion.Location = new System.Drawing.Point(22, 655);
            this.lbHeosAVRVersion.Name = "lbHeosAVRVersion";
            this.lbHeosAVRVersion.Size = new System.Drawing.Size(91, 25);
            this.lbHeosAVRVersion.TabIndex = 60;
            this.lbHeosAVRVersion.Text = "Version:";
            // 
            // lbHeosAVRID
            // 
            this.lbHeosAVRID.AutoSize = true;
            this.lbHeosAVRID.ForeColor = System.Drawing.Color.White;
            this.lbHeosAVRID.Location = new System.Drawing.Point(22, 689);
            this.lbHeosAVRID.Name = "lbHeosAVRID";
            this.lbHeosAVRID.Size = new System.Drawing.Size(105, 25);
            this.lbHeosAVRID.TabIndex = 61;
            this.lbHeosAVRID.Text = "Player ID:";
            // 
            // lbHeosAVRNetType
            // 
            this.lbHeosAVRNetType.AutoSize = true;
            this.lbHeosAVRNetType.ForeColor = System.Drawing.Color.White;
            this.lbHeosAVRNetType.Location = new System.Drawing.Point(22, 722);
            this.lbHeosAVRNetType.Name = "lbHeosAVRNetType";
            this.lbHeosAVRNetType.Size = new System.Drawing.Size(99, 25);
            this.lbHeosAVRNetType.TabIndex = 62;
            this.lbHeosAVRNetType.Text = "NetType:";
            // 
            // lbHeosAVRName_Data
            // 
            this.lbHeosAVRName_Data.AutoSize = true;
            this.lbHeosAVRName_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosAVRName_Data.ForeColor = System.Drawing.Color.Khaki;
            this.lbHeosAVRName_Data.Location = new System.Drawing.Point(123, 624);
            this.lbHeosAVRName_Data.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosAVRName_Data.Name = "lbHeosAVRName_Data";
            this.lbHeosAVRName_Data.Size = new System.Drawing.Size(59, 24);
            this.lbHeosAVRName_Data.TabIndex = 63;
            this.lbHeosAVRName_Data.Text = "TEST";
            // 
            // lbHeosAVRVersion_Data
            // 
            this.lbHeosAVRVersion_Data.AutoSize = true;
            this.lbHeosAVRVersion_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosAVRVersion_Data.ForeColor = System.Drawing.Color.Khaki;
            this.lbHeosAVRVersion_Data.Location = new System.Drawing.Point(124, 657);
            this.lbHeosAVRVersion_Data.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosAVRVersion_Data.Name = "lbHeosAVRVersion_Data";
            this.lbHeosAVRVersion_Data.Size = new System.Drawing.Size(59, 24);
            this.lbHeosAVRVersion_Data.TabIndex = 64;
            this.lbHeosAVRVersion_Data.Text = "TEST";
            // 
            // lbHeosAVRID_Data
            // 
            this.lbHeosAVRID_Data.AutoSize = true;
            this.lbHeosAVRID_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosAVRID_Data.ForeColor = System.Drawing.Color.Khaki;
            this.lbHeosAVRID_Data.Location = new System.Drawing.Point(124, 690);
            this.lbHeosAVRID_Data.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosAVRID_Data.Name = "lbHeosAVRID_Data";
            this.lbHeosAVRID_Data.Size = new System.Drawing.Size(59, 24);
            this.lbHeosAVRID_Data.TabIndex = 65;
            this.lbHeosAVRID_Data.Text = "TEST";
            // 
            // lbHeosAVRNetType_Data
            // 
            this.lbHeosAVRNetType_Data.AutoSize = true;
            this.lbHeosAVRNetType_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosAVRNetType_Data.ForeColor = System.Drawing.Color.Khaki;
            this.lbHeosAVRNetType_Data.Location = new System.Drawing.Point(124, 723);
            this.lbHeosAVRNetType_Data.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosAVRNetType_Data.Name = "lbHeosAVRNetType_Data";
            this.lbHeosAVRNetType_Data.Size = new System.Drawing.Size(59, 24);
            this.lbHeosAVRNetType_Data.TabIndex = 66;
            this.lbHeosAVRNetType_Data.Text = "TEST";
            // 
            // AVRControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(988, 769);
            this.Controls.Add(this.lbHeosAVRNetType_Data);
            this.Controls.Add(this.lbHeosAVRID_Data);
            this.Controls.Add(this.lbHeosAVRVersion_Data);
            this.Controls.Add(this.lbHeosAVRName_Data);
            this.Controls.Add(this.lbHeosAVRNetType);
            this.Controls.Add(this.lbHeosAVRID);
            this.Controls.Add(this.lbHeosAVRVersion);
            this.Controls.Add(this.lbHeosAVRName);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lbAlbumCover);
            this.Controls.Add(this.pbAlbumArt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbHeosPlayRepeatOne);
            this.Controls.Add(this.btnHeosPlayRepeatOne);
            this.Controls.Add(this.lbHeosPlayRepeatAll);
            this.Controls.Add(this.btnHeosPlayRepeatAll);
            this.Controls.Add(this.lbHeosPlayShuffle);
            this.Controls.Add(this.lbHeosPlaySkip);
            this.Controls.Add(this.lbHeosPlayBack);
            this.Controls.Add(this.lbHeosPlayPause);
            this.Controls.Add(this.btnHeosPlayShuffle);
            this.Controls.Add(this.btnHeosPlayBack);
            this.Controls.Add(this.btnHeosPlaySkip);
            this.Controls.Add(this.btnHeosPlayPause);
            this.Controls.Add(this.lbHeosSong);
            this.Controls.Add(this.lbHeosAlbum);
            this.Controls.Add(this.lbHeosArtist);
            this.Controls.Add(this.HeosTrackInfoArtist);
            this.Controls.Add(this.HeosTrackInfoSong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbConnectStatus);
            this.Controls.Add(this.lbUp);
            this.Controls.Add(this.lbMute);
            this.Controls.Add(this.lbDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.btnToggleMute);
            this.Controls.Add(this.btnVolDown);
            this.Controls.Add(this.btnVolUp);
            this.Controls.Add(this.SliderVolume);
            this.Controls.Add(this.ShowVolume);
            this.Controls.Add(this.HorizontalLine);
            this.Controls.Add(this.CopyrightNote);
            this.Controls.Add(this.InfoNote);
            this.Controls.Add(this.PowerToggle);
            this.Controls.Add(this.LabelPowerToggle);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.lbVol10);
            this.Controls.Add(this.lbVol20);
            this.Controls.Add(this.lbVol30);
            this.Controls.Add(this.lbVol40);
            this.Controls.Add(this.lbVol50);
            this.Controls.Add(this.lbVol60);
            this.Controls.Add(this.lbVol70);
            this.Controls.Add(this.lbVol80);
            this.Controls.Add(this.lbVol90);
            this.Controls.Add(this.lbVol100);
            this.Controls.Add(this.lbAVRSource);
            this.Controls.Add(this.AVRSource);
            this.Controls.Add(this.lbAVRSourceAudio);
            this.Controls.Add(this.AVRSourceAudio);
            this.Controls.Add(this.lbAVRSoundMode);
            this.Controls.Add(this.AVRSoundMode);
            this.Controls.Add(this.HeosTrackInfoAlbum);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AVRControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVRControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.AVRControl_Load);
            this.Shown += new System.EventHandler(this.AVRControl_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.SliderVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayRepeatAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlaySkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayRepeatOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnVolUp;
        private System.Windows.Forms.PictureBox btnVolDown;
        private System.Windows.Forms.TrackBar SliderVolume;
        private System.Windows.Forms.Label ShowVolume;
        private System.Windows.Forms.Label HorizontalLine;
        private System.Windows.Forms.Label CopyrightNote;
        private System.Windows.Forms.Label InfoNote;
        private System.Windows.Forms.PictureBox btnToggleMute;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.CheckBox PowerToggle;
        private System.Windows.Forms.Label LabelPowerToggle;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbVol10;
        private System.Windows.Forms.Label lbVol20;
        private System.Windows.Forms.Label lbVol30;
        private System.Windows.Forms.Label lbVol40;
        private System.Windows.Forms.Label lbVol50;
        private System.Windows.Forms.Label lbVol60;
        private System.Windows.Forms.Label lbVol70;
        private System.Windows.Forms.Label lbVol80;
        private System.Windows.Forms.Label lbVol90;
        private System.Windows.Forms.Label lbVol100;
        private System.Windows.Forms.Label lbAVRSource;
        private System.Windows.Forms.Label AVRSource;
        private System.Windows.Forms.Label lbAVRSourceAudio;
        private System.Windows.Forms.Label AVRSourceAudio;
        private System.Windows.Forms.Label lbAVRSoundMode;
        private System.Windows.Forms.Label AVRSoundMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDown;
        private System.Windows.Forms.Label lbMute;
        private System.Windows.Forms.Label lbUp;
        private System.Windows.Forms.Label lbConnectStatus;
        public System.Windows.Forms.Label HeosTrackInfoAlbum;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label HeosTrackInfoSong;
        public System.Windows.Forms.Label HeosTrackInfoArtist;
        private System.Windows.Forms.Label lbHeosArtist;
        private System.Windows.Forms.Label lbHeosAlbum;
        private System.Windows.Forms.Label lbHeosSong;
        private PictureBox btnHeosPlayPause;
        private PictureBox btnHeosPlaySkip;
        private PictureBox btnHeosPlayBack;
        private PictureBox btnHeosPlayShuffle;
        private System.Windows.Forms.Label lbHeosPlayPause;
        private System.Windows.Forms.Label lbHeosPlayBack;
        private System.Windows.Forms.Label lbHeosPlaySkip;
        private System.Windows.Forms.Label lbHeosPlayShuffle;
        private PictureBox btnHeosPlayRepeatAll;
        private System.Windows.Forms.Label lbHeosPlayRepeatAll;
        private PictureBox btnHeosPlayRepeatOne;
        private System.Windows.Forms.Label lbHeosPlayRepeatOne;
        private System.Windows.Forms.Label label9;
        private PictureBox pbAlbumArt;
        private System.Windows.Forms.Label lbAlbumCover;
        private System.Windows.Forms.Label lblTime;
        private ProgressBar pbProgress;
        private System.Windows.Forms.Label lbHeosAVRName;
        private System.Windows.Forms.Label lbHeosAVRVersion;
        private System.Windows.Forms.Label lbHeosAVRID;
        private System.Windows.Forms.Label lbHeosAVRNetType;
        public System.Windows.Forms.Label lbHeosAVRName_Data;
        public System.Windows.Forms.Label lbHeosAVRVersion_Data;
        public System.Windows.Forms.Label lbHeosAVRID_Data;
        public System.Windows.Forms.Label lbHeosAVRNetType_Data;
    }
}

