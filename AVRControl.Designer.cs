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
using System.Runtime.InteropServices;
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED

                return cp;
            }
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {            
            this.components = new System.ComponentModel.Container();
            this.CopyrightNote = new System.Windows.Forms.Label();
            this.InfoNote = new System.Windows.Forms.Label();
            this.LabelPowerToggle = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.PowerToggle = new System.Windows.Forms.CheckBox();
            this.lbConnectStatus = new System.Windows.Forms.Label();
            this.cbSysTray = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gitHubPageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemShowHide = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInstall = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlProgressBack = new System.Windows.Forms.Panel();
            this.pnlProgressBar = new System.Windows.Forms.Panel();
            this.lbHeosAVRNetType_Data = new System.Windows.Forms.Label();
            this.lbHeosAVRID_Data = new System.Windows.Forms.Label();
            this.lbHeosAVRVersion_Data = new System.Windows.Forms.Label();
            this.lbHeosAVRName_Data = new System.Windows.Forms.Label();
            this.lbHeosAVRNetType = new System.Windows.Forms.Label();
            this.lbHeosAVRID = new System.Windows.Forms.Label();
            this.lbHeosAVRVersion = new System.Windows.Forms.Label();
            this.lbHeosAVRName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbAlbumCover = new System.Windows.Forms.Label();
            this.pbAlbumArt = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbHeosPlayRepeatOne = new System.Windows.Forms.Label();
            this.btnHeosPlayRepeatOne = new System.Windows.Forms.PictureBox();
            this.lbHeosPlayRepeatAll = new System.Windows.Forms.Label();
            this.btnHeosPlayRepeatAll = new System.Windows.Forms.PictureBox();
            this.lbHeosPlayShuffle = new System.Windows.Forms.Label();
            this.lbHeosPlaySkip = new System.Windows.Forms.Label();
            this.lbHeosPlayBack = new System.Windows.Forms.Label();
            this.lbHeosPlayPause = new System.Windows.Forms.Label();
            this.btnHeosPlayShuffle = new System.Windows.Forms.PictureBox();
            this.btnHeosPlayBack = new System.Windows.Forms.PictureBox();
            this.btnHeosPlaySkip = new System.Windows.Forms.PictureBox();
            this.btnHeosPlayPause = new System.Windows.Forms.PictureBox();
            this.lbHeosSong = new System.Windows.Forms.Label();
            this.lbHeosAlbum = new System.Windows.Forms.Label();
            this.lbHeosArtist = new System.Windows.Forms.Label();
            this.HeosTrackInfoArtist = new System.Windows.Forms.Label();
            this.HeosTrackInfoSong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUp = new System.Windows.Forms.Label();
            this.lbMute = new System.Windows.Forms.Label();
            this.lbDown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToggleMute = new System.Windows.Forms.PictureBox();
            this.btnVolDown = new System.Windows.Forms.PictureBox();
            this.btnVolUp = new System.Windows.Forms.PictureBox();
            this.SliderVolume = new System.Windows.Forms.TrackBar();
            this.ShowVolume = new System.Windows.Forms.Label();
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
            this.HeosTrackInfoAlbum = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnResetSpeaker = new System.Windows.Forms.Button();
            this.lbSpeakerSubMasterShowValue = new System.Windows.Forms.Label();
            this.tbSpeakerSubMaster = new System.Windows.Forms.TrackBar();
            this.lbSpeakerSubwoofer2ShowValue = new System.Windows.Forms.Label();
            this.lbSpeakerSubwoofer1ShowValue = new System.Windows.Forms.Label();
            this.lbSpeakerSurroundRShowValue = new System.Windows.Forms.Label();
            this.lbSpeakerSurroundLShowValue = new System.Windows.Forms.Label();
            this.lbSpeakerFrontRShowValue = new System.Windows.Forms.Label();
            this.lbSpeakerCenterShowValue = new System.Windows.Forms.Label();
            this.lbSpeakerFrontLShowValue = new System.Windows.Forms.Label();
            this.tbSpeakerSubwoofer2 = new System.Windows.Forms.TrackBar();
            this.tbSpeakerSubwoofer1 = new System.Windows.Forms.TrackBar();
            this.tbSpeakerSurroundR = new System.Windows.Forms.TrackBar();
            this.tbSpeakerSurroundL = new System.Windows.Forms.TrackBar();
            this.tbSpeakerFrontR = new System.Windows.Forms.TrackBar();
            this.tbSpeakerCenter = new System.Windows.Forms.TrackBar();
            this.tbSpeakerFrontL = new System.Windows.Forms.TrackBar();
            this.lbSpeakerSubwoofer1and2 = new System.Windows.Forms.Label();
            this.lbSpeakerSubwoofer2 = new System.Windows.Forms.Label();
            this.lbSpeakerSubwoofer1 = new System.Windows.Forms.Label();
            this.lbSpeakerSurroundR = new System.Windows.Forms.Label();
            this.lbSpeakerSurroundL = new System.Windows.Forms.Label();
            this.lbSpeakerFrontR = new System.Windows.Forms.Label();
            this.lbSpeakerCenter = new System.Windows.Forms.Label();
            this.lbSpeakerFrontL = new System.Windows.Forms.Label();
            this.pnlTabOverlay = new System.Windows.Forms.Label();
            this.lblTabMain = new System.Windows.Forms.Label();
            this.lblTabSpeaker = new System.Windows.Forms.Label();
            this.lbBottomOverlay = new System.Windows.Forms.Label();
            this.HorizontalLine = new System.Windows.Forms.Label();
            this.cmsTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlProgressBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayRepeatOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayRepeatAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlaySkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderVolume)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerSubMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerSubwoofer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerSubwoofer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerSurroundR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerSurroundL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerFrontR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerFrontL)).BeginInit();
            this.SuspendLayout();
            // 
            // CopyrightNote
            // 
            this.CopyrightNote.AutoSize = true;
            this.CopyrightNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic);
            this.CopyrightNote.ForeColor = System.Drawing.Color.White;
            this.CopyrightNote.Location = new System.Drawing.Point(820, 914);
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
            this.InfoNote.Location = new System.Drawing.Point(635, 16);
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
            this.LabelPowerToggle.Location = new System.Drawing.Point(496, 16);
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
            this.btnSave.Location = new System.Drawing.Point(320, 41);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 44);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PowerToggle
            // 
            this.PowerToggle.Appearance = System.Windows.Forms.Appearance.Button;
            this.PowerToggle.BackColor = System.Drawing.Color.SlateGray;
            this.PowerToggle.Enabled = false;
            this.PowerToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.PowerToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerToggle.ForeColor = System.Drawing.Color.White;
            this.PowerToggle.Location = new System.Drawing.Point(499, 47);
            this.PowerToggle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.PowerToggle.Name = "PowerToggle";
            this.PowerToggle.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PowerToggle.Size = new System.Drawing.Size(120, 35);
            this.PowerToggle.TabIndex = 12;
            this.PowerToggle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PowerToggle.UseVisualStyleBackColor = false;
            this.PowerToggle.Click += new System.EventHandler(this.PowerToggle_Click);
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
            // cbSysTray
            // 
            this.cbSysTray.AutoSize = true;
            this.cbSysTray.ForeColor = System.Drawing.Color.White;
            this.cbSysTray.Location = new System.Drawing.Point(840, 56);
            this.cbSysTray.Name = "cbSysTray";
            this.cbSysTray.Size = new System.Drawing.Size(123, 29);
            this.cbSysTray.TabIndex = 67;
            this.cbSysTray.Text = "SysTray";
            this.cbSysTray.UseVisualStyleBackColor = true;
            this.cbSysTray.CheckedChanged += new System.EventHandler(this.cbSysTray_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cmsTray;
            this.notifyIcon1.Text = "AVRControl";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // cmsTray
            // 
            this.cmsTray.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubPageToolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItemShowHide,
            this.quitToolStripMenuItem});
            this.cmsTray.Name = "cmsTray";
            this.cmsTray.Size = new System.Drawing.Size(222, 124);
            // 
            // gitHubPageToolStripMenuItem1
            // 
            this.gitHubPageToolStripMenuItem1.Image = global::AVRControl.Properties.Resources.github;
            this.gitHubPageToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gitHubPageToolStripMenuItem1.Name = "gitHubPageToolStripMenuItem1";
            this.gitHubPageToolStripMenuItem1.Size = new System.Drawing.Size(221, 38);
            this.gitHubPageToolStripMenuItem1.Text = "GitHub Page";
            this.gitHubPageToolStripMenuItem1.Click += new System.EventHandler(this.gitHubPageToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // toolStripMenuItemShowHide
            // 
            this.toolStripMenuItemShowHide.Image = global::AVRControl.Properties.Resources.showhide;
            this.toolStripMenuItemShowHide.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemShowHide.Name = "toolStripMenuItemShowHide";
            this.toolStripMenuItemShowHide.Size = new System.Drawing.Size(221, 38);
            this.toolStripMenuItemShowHide.Text = "Show/Hide";
            this.toolStripMenuItemShowHide.Click += new System.EventHandler(this.toolStripMenuItemShowHide_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = global::AVRControl.Properties.Resources.quit;
            this.quitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(221, 38);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.Color.DarkGray;
            this.btnInstall.Location = new System.Drawing.Point(838, 6);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(142, 44);
            this.btnInstall.TabIndex = 68;
            this.btnInstall.Text = "button1";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.BackColor = System.Drawing.Color.Transparent;
            this.LogoPicture.Image = global::AVRControl.Properties.Resources.apple_klein;
            this.LogoPicture.Location = new System.Drawing.Point(756, 846);
            this.LogoPicture.Margin = new System.Windows.Forms.Padding(6);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(200, 96);
            this.LogoPicture.TabIndex = 14;
            this.LogoPicture.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-8, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 739);
            this.tabControl1.TabIndex = 69;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage1.Controls.Add(this.pnlProgressBack);
            this.tabPage1.Controls.Add(this.lbHeosAVRNetType_Data);
            this.tabPage1.Controls.Add(this.lbHeosAVRID_Data);
            this.tabPage1.Controls.Add(this.lbHeosAVRVersion_Data);
            this.tabPage1.Controls.Add(this.lbHeosAVRName_Data);
            this.tabPage1.Controls.Add(this.lbHeosAVRNetType);
            this.tabPage1.Controls.Add(this.lbHeosAVRID);
            this.tabPage1.Controls.Add(this.lbHeosAVRVersion);
            this.tabPage1.Controls.Add(this.lbHeosAVRName);
            this.tabPage1.Controls.Add(this.lblTime);
            this.tabPage1.Controls.Add(this.lbAlbumCover);
            this.tabPage1.Controls.Add(this.pbAlbumArt);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lbHeosPlayRepeatOne);
            this.tabPage1.Controls.Add(this.btnHeosPlayRepeatOne);
            this.tabPage1.Controls.Add(this.lbHeosPlayRepeatAll);
            this.tabPage1.Controls.Add(this.btnHeosPlayRepeatAll);
            this.tabPage1.Controls.Add(this.lbHeosPlayShuffle);
            this.tabPage1.Controls.Add(this.lbHeosPlaySkip);
            this.tabPage1.Controls.Add(this.lbHeosPlayBack);
            this.tabPage1.Controls.Add(this.lbHeosPlayPause);
            this.tabPage1.Controls.Add(this.btnHeosPlayShuffle);
            this.tabPage1.Controls.Add(this.btnHeosPlayBack);
            this.tabPage1.Controls.Add(this.btnHeosPlaySkip);
            this.tabPage1.Controls.Add(this.btnHeosPlayPause);
            this.tabPage1.Controls.Add(this.lbHeosSong);
            this.tabPage1.Controls.Add(this.lbHeosAlbum);
            this.tabPage1.Controls.Add(this.lbHeosArtist);
            this.tabPage1.Controls.Add(this.HeosTrackInfoArtist);
            this.tabPage1.Controls.Add(this.HeosTrackInfoSong);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbUp);
            this.tabPage1.Controls.Add(this.lbMute);
            this.tabPage1.Controls.Add(this.lbDown);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnToggleMute);
            this.tabPage1.Controls.Add(this.btnVolDown);
            this.tabPage1.Controls.Add(this.btnVolUp);
            this.tabPage1.Controls.Add(this.SliderVolume);
            this.tabPage1.Controls.Add(this.ShowVolume);
            this.tabPage1.Controls.Add(this.lbVol10);
            this.tabPage1.Controls.Add(this.lbVol20);
            this.tabPage1.Controls.Add(this.lbVol30);
            this.tabPage1.Controls.Add(this.lbVol40);
            this.tabPage1.Controls.Add(this.lbVol50);
            this.tabPage1.Controls.Add(this.lbVol60);
            this.tabPage1.Controls.Add(this.lbVol70);
            this.tabPage1.Controls.Add(this.lbVol80);
            this.tabPage1.Controls.Add(this.lbVol90);
            this.tabPage1.Controls.Add(this.lbVol100);
            this.tabPage1.Controls.Add(this.lbAVRSource);
            this.tabPage1.Controls.Add(this.AVRSource);
            this.tabPage1.Controls.Add(this.lbAVRSourceAudio);
            this.tabPage1.Controls.Add(this.AVRSourceAudio);
            this.tabPage1.Controls.Add(this.lbAVRSoundMode);
            this.tabPage1.Controls.Add(this.AVRSoundMode);
            this.tabPage1.Controls.Add(this.HeosTrackInfoAlbum);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 692);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // pnlProgressBack
            // 
            this.pnlProgressBack.BackColor = System.Drawing.Color.DarkGray;
            this.pnlProgressBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProgressBack.Controls.Add(this.pnlProgressBar);
            this.pnlProgressBack.Location = new System.Drawing.Point(43, 457);
            this.pnlProgressBack.Name = "pnlProgressBack";
            this.pnlProgressBack.Size = new System.Drawing.Size(875, 13);
            this.pnlProgressBack.TabIndex = 124;
            // 
            // pnlProgressBar
            // 
            this.pnlProgressBar.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlProgressBar.Location = new System.Drawing.Point(1, 1);
            this.pnlProgressBar.Name = "pnlProgressBar";
            this.pnlProgressBar.Size = new System.Drawing.Size(1, 13);
            this.pnlProgressBar.TabIndex = 0;
            // 
            // lbHeosAVRNetType_Data
            // 
            this.lbHeosAVRNetType_Data.AutoSize = true;
            this.lbHeosAVRNetType_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosAVRNetType_Data.ForeColor = System.Drawing.Color.Khaki;
            this.lbHeosAVRNetType_Data.Location = new System.Drawing.Point(122, 622);
            this.lbHeosAVRNetType_Data.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosAVRNetType_Data.Name = "lbHeosAVRNetType_Data";
            this.lbHeosAVRNetType_Data.Size = new System.Drawing.Size(0, 24);
            this.lbHeosAVRNetType_Data.TabIndex = 123;
            // 
            // lbHeosAVRID_Data
            // 
            this.lbHeosAVRID_Data.AutoSize = true;
            this.lbHeosAVRID_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosAVRID_Data.ForeColor = System.Drawing.Color.Khaki;
            this.lbHeosAVRID_Data.Location = new System.Drawing.Point(122, 589);
            this.lbHeosAVRID_Data.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosAVRID_Data.Name = "lbHeosAVRID_Data";
            this.lbHeosAVRID_Data.Size = new System.Drawing.Size(0, 24);
            this.lbHeosAVRID_Data.TabIndex = 122;
            // 
            // lbHeosAVRVersion_Data
            // 
            this.lbHeosAVRVersion_Data.AutoSize = true;
            this.lbHeosAVRVersion_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosAVRVersion_Data.ForeColor = System.Drawing.Color.Khaki;
            this.lbHeosAVRVersion_Data.Location = new System.Drawing.Point(122, 556);
            this.lbHeosAVRVersion_Data.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosAVRVersion_Data.Name = "lbHeosAVRVersion_Data";
            this.lbHeosAVRVersion_Data.Size = new System.Drawing.Size(0, 24);
            this.lbHeosAVRVersion_Data.TabIndex = 121;
            // 
            // lbHeosAVRName_Data
            // 
            this.lbHeosAVRName_Data.AutoSize = true;
            this.lbHeosAVRName_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosAVRName_Data.ForeColor = System.Drawing.Color.Khaki;
            this.lbHeosAVRName_Data.Location = new System.Drawing.Point(121, 523);
            this.lbHeosAVRName_Data.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosAVRName_Data.Name = "lbHeosAVRName_Data";
            this.lbHeosAVRName_Data.Size = new System.Drawing.Size(0, 24);
            this.lbHeosAVRName_Data.TabIndex = 120;
            // 
            // lbHeosAVRNetType
            // 
            this.lbHeosAVRNetType.AutoSize = true;
            this.lbHeosAVRNetType.ForeColor = System.Drawing.Color.White;
            this.lbHeosAVRNetType.Location = new System.Drawing.Point(20, 621);
            this.lbHeosAVRNetType.Name = "lbHeosAVRNetType";
            this.lbHeosAVRNetType.Size = new System.Drawing.Size(99, 25);
            this.lbHeosAVRNetType.TabIndex = 119;
            this.lbHeosAVRNetType.Text = "NetType:";
            // 
            // lbHeosAVRID
            // 
            this.lbHeosAVRID.AutoSize = true;
            this.lbHeosAVRID.ForeColor = System.Drawing.Color.White;
            this.lbHeosAVRID.Location = new System.Drawing.Point(20, 588);
            this.lbHeosAVRID.Name = "lbHeosAVRID";
            this.lbHeosAVRID.Size = new System.Drawing.Size(105, 25);
            this.lbHeosAVRID.TabIndex = 118;
            this.lbHeosAVRID.Text = "Player ID:";
            // 
            // lbHeosAVRVersion
            // 
            this.lbHeosAVRVersion.AutoSize = true;
            this.lbHeosAVRVersion.ForeColor = System.Drawing.Color.White;
            this.lbHeosAVRVersion.Location = new System.Drawing.Point(20, 554);
            this.lbHeosAVRVersion.Name = "lbHeosAVRVersion";
            this.lbHeosAVRVersion.Size = new System.Drawing.Size(91, 25);
            this.lbHeosAVRVersion.TabIndex = 117;
            this.lbHeosAVRVersion.Text = "Version:";
            // 
            // lbHeosAVRName
            // 
            this.lbHeosAVRName.AutoSize = true;
            this.lbHeosAVRName.ForeColor = System.Drawing.Color.White;
            this.lbHeosAVRName.Location = new System.Drawing.Point(22, 522);
            this.lbHeosAVRName.Name = "lbHeosAVRName";
            this.lbHeosAVRName.Size = new System.Drawing.Size(73, 25);
            this.lbHeosAVRName.TabIndex = 116;
            this.lbHeosAVRName.Text = "Client:";
            // 
            // lblTime
            // 
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(406, 482);
            this.lblTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(161, 27);
            this.lblTime.TabIndex = 114;
            // 
            // lbAlbumCover
            // 
            this.lbAlbumCover.AutoSize = true;
            this.lbAlbumCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlbumCover.ForeColor = System.Drawing.Color.White;
            this.lbAlbumCover.Location = new System.Drawing.Point(409, 635);
            this.lbAlbumCover.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAlbumCover.Name = "lbAlbumCover";
            this.lbAlbumCover.Size = new System.Drawing.Size(139, 26);
            this.lbAlbumCover.TabIndex = 113;
            this.lbAlbumCover.Text = "Album Cover";
            // 
            // pbAlbumArt
            // 
            this.pbAlbumArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAlbumArt.Location = new System.Drawing.Point(421, 511);
            this.pbAlbumArt.Name = "pbAlbumArt";
            this.pbAlbumArt.Size = new System.Drawing.Size(112, 123);
            this.pbAlbumArt.TabIndex = 112;
            this.pbAlbumArt.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(-8, 326);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1000, 1);
            this.label9.TabIndex = 111;
            // 
            // lbHeosPlayRepeatOne
            // 
            this.lbHeosPlayRepeatOne.AutoSize = true;
            this.lbHeosPlayRepeatOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosPlayRepeatOne.ForeColor = System.Drawing.Color.White;
            this.lbHeosPlayRepeatOne.Location = new System.Drawing.Point(795, 403);
            this.lbHeosPlayRepeatOne.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosPlayRepeatOne.Name = "lbHeosPlayRepeatOne";
            this.lbHeosPlayRepeatOne.Size = new System.Drawing.Size(129, 26);
            this.lbHeosPlayRepeatOne.TabIndex = 110;
            this.lbHeosPlayRepeatOne.Text = "Repeat One";
            // 
            // btnHeosPlayRepeatOne
            // 
            this.btnHeosPlayRepeatOne.BackColor = System.Drawing.Color.Transparent;
            this.btnHeosPlayRepeatOne.BackgroundImage = global::AVRControl.Properties.Resources.RepeatOneIcon;
            this.btnHeosPlayRepeatOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeosPlayRepeatOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayRepeatOne.Location = new System.Drawing.Point(818, 344);
            this.btnHeosPlayRepeatOne.Margin = new System.Windows.Forms.Padding(6);
            this.btnHeosPlayRepeatOne.Name = "btnHeosPlayRepeatOne";
            this.btnHeosPlayRepeatOne.Size = new System.Drawing.Size(73, 53);
            this.btnHeosPlayRepeatOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHeosPlayRepeatOne.TabIndex = 109;
            this.btnHeosPlayRepeatOne.TabStop = false;
            this.btnHeosPlayRepeatOne.Click += new System.EventHandler(this.btnHeosPlayRepeatOne_Click);
            this.btnHeosPlayRepeatOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayRepeatOne_MouseDown);
            this.btnHeosPlayRepeatOne.MouseEnter += new System.EventHandler(this.btnHeosPlayRepeatOne_MouseEnter);
            this.btnHeosPlayRepeatOne.MouseLeave += new System.EventHandler(this.btnHeosPlayRepeatOne_MouseLeave);
            this.btnHeosPlayRepeatOne.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayRepeatOne_MouseUp);
            // 
            // lbHeosPlayRepeatAll
            // 
            this.lbHeosPlayRepeatAll.AutoSize = true;
            this.lbHeosPlayRepeatAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosPlayRepeatAll.ForeColor = System.Drawing.Color.White;
            this.lbHeosPlayRepeatAll.Location = new System.Drawing.Point(648, 405);
            this.lbHeosPlayRepeatAll.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosPlayRepeatAll.Name = "lbHeosPlayRepeatAll";
            this.lbHeosPlayRepeatAll.Size = new System.Drawing.Size(113, 26);
            this.lbHeosPlayRepeatAll.TabIndex = 108;
            this.lbHeosPlayRepeatAll.Text = "Repeat All";
            // 
            // btnHeosPlayRepeatAll
            // 
            this.btnHeosPlayRepeatAll.BackColor = System.Drawing.Color.Transparent;
            this.btnHeosPlayRepeatAll.BackgroundImage = global::AVRControl.Properties.Resources.RepeatAllIcon;
            this.btnHeosPlayRepeatAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeosPlayRepeatAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayRepeatAll.Location = new System.Drawing.Point(667, 344);
            this.btnHeosPlayRepeatAll.Margin = new System.Windows.Forms.Padding(6);
            this.btnHeosPlayRepeatAll.Name = "btnHeosPlayRepeatAll";
            this.btnHeosPlayRepeatAll.Size = new System.Drawing.Size(73, 53);
            this.btnHeosPlayRepeatAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHeosPlayRepeatAll.TabIndex = 107;
            this.btnHeosPlayRepeatAll.TabStop = false;
            this.btnHeosPlayRepeatAll.Click += new System.EventHandler(this.btnHeosPlayRepeatAll_Click);
            this.btnHeosPlayRepeatAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayRepeatAll_MouseDown);
            this.btnHeosPlayRepeatAll.MouseEnter += new System.EventHandler(this.btnHeosPlayRepeatAll_MouseEnter);
            this.btnHeosPlayRepeatAll.MouseLeave += new System.EventHandler(this.btnHeosPlayRepeatAll_MouseLeave);
            this.btnHeosPlayRepeatAll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayRepeatAll_MouseUp);
            // 
            // lbHeosPlayShuffle
            // 
            this.lbHeosPlayShuffle.AutoSize = true;
            this.lbHeosPlayShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosPlayShuffle.ForeColor = System.Drawing.Color.White;
            this.lbHeosPlayShuffle.Location = new System.Drawing.Point(513, 405);
            this.lbHeosPlayShuffle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosPlayShuffle.Name = "lbHeosPlayShuffle";
            this.lbHeosPlayShuffle.Size = new System.Drawing.Size(80, 26);
            this.lbHeosPlayShuffle.TabIndex = 106;
            this.lbHeosPlayShuffle.Text = "Shuffle";
            // 
            // lbHeosPlaySkip
            // 
            this.lbHeosPlaySkip.AutoSize = true;
            this.lbHeosPlaySkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosPlaySkip.ForeColor = System.Drawing.Color.White;
            this.lbHeosPlaySkip.Location = new System.Drawing.Point(375, 403);
            this.lbHeosPlaySkip.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosPlaySkip.Name = "lbHeosPlaySkip";
            this.lbHeosPlaySkip.Size = new System.Drawing.Size(55, 26);
            this.lbHeosPlaySkip.TabIndex = 105;
            this.lbHeosPlaySkip.Text = "Skip";
            // 
            // lbHeosPlayBack
            // 
            this.lbHeosPlayBack.AutoSize = true;
            this.lbHeosPlayBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosPlayBack.ForeColor = System.Drawing.Color.White;
            this.lbHeosPlayBack.Location = new System.Drawing.Point(220, 403);
            this.lbHeosPlayBack.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosPlayBack.Name = "lbHeosPlayBack";
            this.lbHeosPlayBack.Size = new System.Drawing.Size(61, 26);
            this.lbHeosPlayBack.TabIndex = 104;
            this.lbHeosPlayBack.Text = "Back";
            // 
            // lbHeosPlayPause
            // 
            this.lbHeosPlayPause.AutoSize = true;
            this.lbHeosPlayPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosPlayPause.ForeColor = System.Drawing.Color.White;
            this.lbHeosPlayPause.Location = new System.Drawing.Point(38, 403);
            this.lbHeosPlayPause.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosPlayPause.Name = "lbHeosPlayPause";
            this.lbHeosPlayPause.Size = new System.Drawing.Size(123, 26);
            this.lbHeosPlayPause.TabIndex = 103;
            this.lbHeosPlayPause.Text = "Play/Pause";
            // 
            // btnHeosPlayShuffle
            // 
            this.btnHeosPlayShuffle.BackColor = System.Drawing.Color.Transparent;
            this.btnHeosPlayShuffle.BackgroundImage = global::AVRControl.Properties.Resources.ShuffleIcon;
            this.btnHeosPlayShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeosPlayShuffle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayShuffle.Location = new System.Drawing.Point(516, 344);
            this.btnHeosPlayShuffle.Margin = new System.Windows.Forms.Padding(6);
            this.btnHeosPlayShuffle.Name = "btnHeosPlayShuffle";
            this.btnHeosPlayShuffle.Size = new System.Drawing.Size(73, 53);
            this.btnHeosPlayShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHeosPlayShuffle.TabIndex = 102;
            this.btnHeosPlayShuffle.TabStop = false;
            this.btnHeosPlayShuffle.Click += new System.EventHandler(this.btnHeosPlayShuffle_Click);
            this.btnHeosPlayShuffle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayShuffle_MouseDown);
            this.btnHeosPlayShuffle.MouseEnter += new System.EventHandler(this.btnHeosPlayShuffle_MouseEnter);
            this.btnHeosPlayShuffle.MouseLeave += new System.EventHandler(this.btnHeosPlayShuffle_MouseLeave);
            this.btnHeosPlayShuffle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayShuffle_MouseUp);
            // 
            // btnHeosPlayBack
            // 
            this.btnHeosPlayBack.BackColor = System.Drawing.Color.Transparent;
            this.btnHeosPlayBack.BackgroundImage = global::AVRControl.Properties.Resources.BackIcon;
            this.btnHeosPlayBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeosPlayBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayBack.Location = new System.Drawing.Point(214, 344);
            this.btnHeosPlayBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnHeosPlayBack.Name = "btnHeosPlayBack";
            this.btnHeosPlayBack.Size = new System.Drawing.Size(73, 53);
            this.btnHeosPlayBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHeosPlayBack.TabIndex = 101;
            this.btnHeosPlayBack.TabStop = false;
            this.btnHeosPlayBack.Click += new System.EventHandler(this.btnHeosPlayBack_Click);
            this.btnHeosPlayBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayBack_MouseDown);
            this.btnHeosPlayBack.MouseEnter += new System.EventHandler(this.btnHeosPlayBack_MouseEnter);
            this.btnHeosPlayBack.MouseLeave += new System.EventHandler(this.btnHeaosPlayBack_MouseLeave);
            this.btnHeosPlayBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayBack_MouseUp);
            // 
            // btnHeosPlaySkip
            // 
            this.btnHeosPlaySkip.BackColor = System.Drawing.Color.Transparent;
            this.btnHeosPlaySkip.BackgroundImage = global::AVRControl.Properties.Resources.SkipIcon;
            this.btnHeosPlaySkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeosPlaySkip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlaySkip.Location = new System.Drawing.Point(365, 344);
            this.btnHeosPlaySkip.Margin = new System.Windows.Forms.Padding(6);
            this.btnHeosPlaySkip.Name = "btnHeosPlaySkip";
            this.btnHeosPlaySkip.Size = new System.Drawing.Size(73, 53);
            this.btnHeosPlaySkip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHeosPlaySkip.TabIndex = 100;
            this.btnHeosPlaySkip.TabStop = false;
            this.btnHeosPlaySkip.Click += new System.EventHandler(this.btnHeosPlaySkip_Click);
            this.btnHeosPlaySkip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlaySkip_MouseDown);
            this.btnHeosPlaySkip.MouseEnter += new System.EventHandler(this.btnHeosPlaySkip_MouseEnter);
            this.btnHeosPlaySkip.MouseLeave += new System.EventHandler(this.btnHeosPlaySkip_MouseLeave);
            this.btnHeosPlaySkip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlaySkip_MouseUp);
            // 
            // btnHeosPlayPause
            // 
            this.btnHeosPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btnHeosPlayPause.BackgroundImage = global::AVRControl.Properties.Resources.PauseIcon;
            this.btnHeosPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeosPlayPause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHeosPlayPause.Location = new System.Drawing.Point(63, 344);
            this.btnHeosPlayPause.Margin = new System.Windows.Forms.Padding(6);
            this.btnHeosPlayPause.Name = "btnHeosPlayPause";
            this.btnHeosPlayPause.Size = new System.Drawing.Size(73, 53);
            this.btnHeosPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHeosPlayPause.TabIndex = 99;
            this.btnHeosPlayPause.TabStop = false;
            this.btnHeosPlayPause.Click += new System.EventHandler(this.btnHeosPlayPause_Click);
            this.btnHeosPlayPause.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayPause_MouseDown);
            this.btnHeosPlayPause.MouseEnter += new System.EventHandler(this.btnHeosPlayPause_MouseEnter);
            this.btnHeosPlayPause.MouseLeave += new System.EventHandler(this.btnHeosPlayPause_MouseLeave);
            this.btnHeosPlayPause.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHeosPlayPause_MouseUp);
            // 
            // lbHeosSong
            // 
            this.lbHeosSong.AutoSize = true;
            this.lbHeosSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosSong.ForeColor = System.Drawing.Color.White;
            this.lbHeosSong.Location = new System.Drawing.Point(444, 281);
            this.lbHeosSong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosSong.Name = "lbHeosSong";
            this.lbHeosSong.Size = new System.Drawing.Size(69, 26);
            this.lbHeosSong.TabIndex = 98;
            this.lbHeosSong.Text = "Song:";
            // 
            // lbHeosAlbum
            // 
            this.lbHeosAlbum.AutoSize = true;
            this.lbHeosAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosAlbum.ForeColor = System.Drawing.Color.White;
            this.lbHeosAlbum.Location = new System.Drawing.Point(443, 249);
            this.lbHeosAlbum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosAlbum.Name = "lbHeosAlbum";
            this.lbHeosAlbum.Size = new System.Drawing.Size(81, 26);
            this.lbHeosAlbum.TabIndex = 97;
            this.lbHeosAlbum.Text = "Album:";
            // 
            // lbHeosArtist
            // 
            this.lbHeosArtist.AutoSize = true;
            this.lbHeosArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeosArtist.ForeColor = System.Drawing.Color.White;
            this.lbHeosArtist.Location = new System.Drawing.Point(443, 216);
            this.lbHeosArtist.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHeosArtist.Name = "lbHeosArtist";
            this.lbHeosArtist.Size = new System.Drawing.Size(68, 26);
            this.lbHeosArtist.TabIndex = 96;
            this.lbHeosArtist.Text = "Artist:";
            // 
            // HeosTrackInfoArtist
            // 
            this.HeosTrackInfoArtist.AutoEllipsis = true;
            this.HeosTrackInfoArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeosTrackInfoArtist.ForeColor = System.Drawing.Color.Khaki;
            this.HeosTrackInfoArtist.Location = new System.Drawing.Point(522, 216);
            this.HeosTrackInfoArtist.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HeosTrackInfoArtist.Name = "HeosTrackInfoArtist";
            this.HeosTrackInfoArtist.Size = new System.Drawing.Size(441, 24);
            this.HeosTrackInfoArtist.TabIndex = 95;
            // 
            // HeosTrackInfoSong
            // 
            this.HeosTrackInfoSong.AutoEllipsis = true;
            this.HeosTrackInfoSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeosTrackInfoSong.ForeColor = System.Drawing.Color.Khaki;
            this.HeosTrackInfoSong.Location = new System.Drawing.Point(523, 283);
            this.HeosTrackInfoSong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HeosTrackInfoSong.Name = "HeosTrackInfoSong";
            this.HeosTrackInfoSong.Size = new System.Drawing.Size(440, 24);
            this.HeosTrackInfoSong.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(-8, 445);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1000, 1);
            this.label2.TabIndex = 93;
            // 
            // lbUp
            // 
            this.lbUp.AutoSize = true;
            this.lbUp.ForeColor = System.Drawing.Color.White;
            this.lbUp.Location = new System.Drawing.Point(863, 73);
            this.lbUp.Name = "lbUp";
            this.lbUp.Size = new System.Drawing.Size(39, 25);
            this.lbUp.TabIndex = 92;
            this.lbUp.Text = "Up";
            // 
            // lbMute
            // 
            this.lbMute.AutoSize = true;
            this.lbMute.ForeColor = System.Drawing.Color.White;
            this.lbMute.Location = new System.Drawing.Point(437, 73);
            this.lbMute.Name = "lbMute";
            this.lbMute.Size = new System.Drawing.Size(60, 25);
            this.lbMute.TabIndex = 91;
            this.lbMute.Text = "Mute";
            // 
            // lbDown
            // 
            this.lbDown.AutoSize = true;
            this.lbDown.ForeColor = System.Drawing.Color.White;
            this.lbDown.Location = new System.Drawing.Point(15, 73);
            this.lbDown.Name = "lbDown";
            this.lbDown.Size = new System.Drawing.Size(66, 25);
            this.lbDown.TabIndex = 90;
            this.lbDown.Text = "Down";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(-8, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 1);
            this.label1.TabIndex = 67;
            // 
            // btnToggleMute
            // 
            this.btnToggleMute.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleMute.BackgroundImage = global::AVRControl.Properties.Resources.Vol_Mute;
            this.btnToggleMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnToggleMute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnToggleMute.Location = new System.Drawing.Point(431, 15);
            this.btnToggleMute.Margin = new System.Windows.Forms.Padding(6);
            this.btnToggleMute.Name = "btnToggleMute";
            this.btnToggleMute.Size = new System.Drawing.Size(73, 53);
            this.btnToggleMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnToggleMute.TabIndex = 70;
            this.btnToggleMute.TabStop = false;
            this.btnToggleMute.Click += new System.EventHandler(this.BtnToggleMute_Click);
            this.btnToggleMute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnToggleMute_MouseDown);
            this.btnToggleMute.MouseEnter += new System.EventHandler(this.BtnToggleMute_MouseEnter);
            this.btnToggleMute.MouseLeave += new System.EventHandler(this.BtnToggleMute_MouseLeave);
            // 
            // btnVolDown
            // 
            this.btnVolDown.BackColor = System.Drawing.Color.Transparent;
            this.btnVolDown.BackgroundImage = global::AVRControl.Properties.Resources.Vol_Down;
            this.btnVolDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnVolDown.Location = new System.Drawing.Point(9, 15);
            this.btnVolDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnVolDown.Name = "btnVolDown";
            this.btnVolDown.Size = new System.Drawing.Size(73, 53);
            this.btnVolDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolDown.TabIndex = 72;
            this.btnVolDown.TabStop = false;
            this.btnVolDown.Click += new System.EventHandler(this.BtnVolDown_Click);
            this.btnVolDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnVolDown_MouseDown);
            this.btnVolDown.MouseEnter += new System.EventHandler(this.BtnVolDown_MouseEnter);
            this.btnVolDown.MouseLeave += new System.EventHandler(this.BtnVolDown_MouseLeave);
            this.btnVolDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnVolDown_MouseUp);
            // 
            // btnVolUp
            // 
            this.btnVolUp.BackColor = System.Drawing.Color.Transparent;
            this.btnVolUp.BackgroundImage = global::AVRControl.Properties.Resources.Vol_Up;
            this.btnVolUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnVolUp.Location = new System.Drawing.Point(845, 15);
            this.btnVolUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnVolUp.Name = "btnVolUp";
            this.btnVolUp.Size = new System.Drawing.Size(73, 53);
            this.btnVolUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolUp.TabIndex = 71;
            this.btnVolUp.TabStop = false;
            this.btnVolUp.Click += new System.EventHandler(this.BtnVolUp_Click);
            this.btnVolUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnVolUp_MouseDown);
            this.btnVolUp.MouseEnter += new System.EventHandler(this.BtnVolUp_MouseEnter);
            this.btnVolUp.MouseLeave += new System.EventHandler(this.BtnVolUp_MouseLeave);
            this.btnVolUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnVolUp_MouseUp);
            // 
            // SliderVolume
            // 
            this.SliderVolume.AutoSize = false;
            this.SliderVolume.Enabled = false;
            this.SliderVolume.Location = new System.Drawing.Point(21, 100);
            this.SliderVolume.Margin = new System.Windows.Forms.Padding(24, 23, 24, 0);
            this.SliderVolume.Maximum = 100;
            this.SliderVolume.MaximumSize = new System.Drawing.Size(880, 96);
            this.SliderVolume.Minimum = 10;
            this.SliderVolume.Name = "SliderVolume";
            this.SliderVolume.Size = new System.Drawing.Size(880, 58);
            this.SliderVolume.SmallChange = 2;
            this.SliderVolume.TabIndex = 68;
            this.SliderVolume.Text = "SliderVolume";
            this.SliderVolume.TickFrequency = 5;
            this.SliderVolume.Value = 10;
            this.SliderVolume.Scroll += new System.EventHandler(this.SliderVolume_Scroll);
            this.SliderVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SliderVolume_MouseUp);
            // 
            // ShowVolume
            // 
            this.ShowVolume.ForeColor = System.Drawing.Color.White;
            this.ShowVolume.Location = new System.Drawing.Point(895, 107);
            this.ShowVolume.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ShowVolume.Name = "ShowVolume";
            this.ShowVolume.Size = new System.Drawing.Size(80, 27);
            this.ShowVolume.TabIndex = 69;
            this.ShowVolume.Text = "Vol: 10";
            // 
            // lbVol10
            // 
            this.lbVol10.AutoSize = true;
            this.lbVol10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbVol10.Location = new System.Drawing.Point(31, 156);
            this.lbVol10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol10.Name = "lbVol10";
            this.lbVol10.Size = new System.Drawing.Size(30, 24);
            this.lbVol10.TabIndex = 73;
            this.lbVol10.Text = "10";
            // 
            // lbVol20
            // 
            this.lbVol20.AutoSize = true;
            this.lbVol20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol20.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbVol20.Location = new System.Drawing.Point(123, 156);
            this.lbVol20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol20.Name = "lbVol20";
            this.lbVol20.Size = new System.Drawing.Size(30, 24);
            this.lbVol20.TabIndex = 74;
            this.lbVol20.Text = "20";
            // 
            // lbVol30
            // 
            this.lbVol30.AutoSize = true;
            this.lbVol30.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol30.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbVol30.Location = new System.Drawing.Point(215, 156);
            this.lbVol30.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol30.Name = "lbVol30";
            this.lbVol30.Size = new System.Drawing.Size(30, 24);
            this.lbVol30.TabIndex = 75;
            this.lbVol30.Text = "30";
            // 
            // lbVol40
            // 
            this.lbVol40.AutoSize = true;
            this.lbVol40.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol40.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbVol40.Location = new System.Drawing.Point(307, 156);
            this.lbVol40.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol40.Name = "lbVol40";
            this.lbVol40.Size = new System.Drawing.Size(30, 24);
            this.lbVol40.TabIndex = 76;
            this.lbVol40.Text = "40";
            // 
            // lbVol50
            // 
            this.lbVol50.AutoSize = true;
            this.lbVol50.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol50.ForeColor = System.Drawing.Color.Beige;
            this.lbVol50.Location = new System.Drawing.Point(399, 156);
            this.lbVol50.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol50.Name = "lbVol50";
            this.lbVol50.Size = new System.Drawing.Size(32, 24);
            this.lbVol50.TabIndex = 77;
            this.lbVol50.Text = "50";
            // 
            // lbVol60
            // 
            this.lbVol60.AutoSize = true;
            this.lbVol60.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol60.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lbVol60.Location = new System.Drawing.Point(489, 156);
            this.lbVol60.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol60.Name = "lbVol60";
            this.lbVol60.Size = new System.Drawing.Size(30, 24);
            this.lbVol60.TabIndex = 78;
            this.lbVol60.Text = "60";
            // 
            // lbVol70
            // 
            this.lbVol70.AutoSize = true;
            this.lbVol70.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol70.ForeColor = System.Drawing.Color.Khaki;
            this.lbVol70.Location = new System.Drawing.Point(582, 156);
            this.lbVol70.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol70.Name = "lbVol70";
            this.lbVol70.Size = new System.Drawing.Size(30, 24);
            this.lbVol70.TabIndex = 79;
            this.lbVol70.Text = "70";
            // 
            // lbVol80
            // 
            this.lbVol80.AutoSize = true;
            this.lbVol80.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol80.ForeColor = System.Drawing.Color.Peru;
            this.lbVol80.Location = new System.Drawing.Point(674, 156);
            this.lbVol80.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol80.Name = "lbVol80";
            this.lbVol80.Size = new System.Drawing.Size(30, 24);
            this.lbVol80.TabIndex = 80;
            this.lbVol80.Text = "80";
            // 
            // lbVol90
            // 
            this.lbVol90.AutoSize = true;
            this.lbVol90.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol90.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbVol90.Location = new System.Drawing.Point(766, 156);
            this.lbVol90.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol90.Name = "lbVol90";
            this.lbVol90.Size = new System.Drawing.Size(30, 24);
            this.lbVol90.TabIndex = 81;
            this.lbVol90.Text = "90";
            // 
            // lbVol100
            // 
            this.lbVol100.AutoSize = true;
            this.lbVol100.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVol100.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbVol100.Location = new System.Drawing.Point(850, 156);
            this.lbVol100.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbVol100.Name = "lbVol100";
            this.lbVol100.Size = new System.Drawing.Size(40, 24);
            this.lbVol100.TabIndex = 82;
            this.lbVol100.Text = "100";
            // 
            // lbAVRSource
            // 
            this.lbAVRSource.AutoSize = true;
            this.lbAVRSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAVRSource.ForeColor = System.Drawing.Color.White;
            this.lbAVRSource.Location = new System.Drawing.Point(16, 219);
            this.lbAVRSource.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAVRSource.Name = "lbAVRSource";
            this.lbAVRSource.Size = new System.Drawing.Size(178, 26);
            this.lbAVRSource.TabIndex = 83;
            this.lbAVRSource.Text = "Selected Source:";
            // 
            // AVRSource
            // 
            this.AVRSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVRSource.ForeColor = System.Drawing.Color.DarkOrange;
            this.AVRSource.Location = new System.Drawing.Point(195, 219);
            this.AVRSource.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AVRSource.Name = "AVRSource";
            this.AVRSource.Size = new System.Drawing.Size(242, 24);
            this.AVRSource.TabIndex = 84;
            // 
            // lbAVRSourceAudio
            // 
            this.lbAVRSourceAudio.AutoSize = true;
            this.lbAVRSourceAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAVRSourceAudio.ForeColor = System.Drawing.Color.White;
            this.lbAVRSourceAudio.Location = new System.Drawing.Point(17, 250);
            this.lbAVRSourceAudio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAVRSourceAudio.Name = "lbAVRSourceAudio";
            this.lbAVRSourceAudio.Size = new System.Drawing.Size(143, 26);
            this.lbAVRSourceAudio.TabIndex = 85;
            this.lbAVRSourceAudio.Text = "SourceAudio:";
            // 
            // AVRSourceAudio
            // 
            this.AVRSourceAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVRSourceAudio.ForeColor = System.Drawing.Color.Khaki;
            this.AVRSourceAudio.Location = new System.Drawing.Point(198, 252);
            this.AVRSourceAudio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AVRSourceAudio.Name = "AVRSourceAudio";
            this.AVRSourceAudio.Size = new System.Drawing.Size(240, 24);
            this.AVRSourceAudio.TabIndex = 86;
            // 
            // lbAVRSoundMode
            // 
            this.lbAVRSoundMode.AutoSize = true;
            this.lbAVRSoundMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAVRSoundMode.ForeColor = System.Drawing.Color.White;
            this.lbAVRSoundMode.Location = new System.Drawing.Point(18, 281);
            this.lbAVRSoundMode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAVRSoundMode.Name = "lbAVRSoundMode";
            this.lbAVRSoundMode.Size = new System.Drawing.Size(135, 26);
            this.lbAVRSoundMode.TabIndex = 87;
            this.lbAVRSoundMode.Text = "SoundMode:";
            // 
            // AVRSoundMode
            // 
            this.AVRSoundMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVRSoundMode.ForeColor = System.Drawing.Color.Khaki;
            this.AVRSoundMode.Location = new System.Drawing.Point(198, 283);
            this.AVRSoundMode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AVRSoundMode.Name = "AVRSoundMode";
            this.AVRSoundMode.Size = new System.Drawing.Size(240, 24);
            this.AVRSoundMode.TabIndex = 89;
            // 
            // HeosTrackInfoAlbum
            // 
            this.HeosTrackInfoAlbum.AutoEllipsis = true;
            this.HeosTrackInfoAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeosTrackInfoAlbum.ForeColor = System.Drawing.Color.Khaki;
            this.HeosTrackInfoAlbum.Location = new System.Drawing.Point(522, 251);
            this.HeosTrackInfoAlbum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HeosTrackInfoAlbum.Name = "HeosTrackInfoAlbum";
            this.HeosTrackInfoAlbum.Size = new System.Drawing.Size(441, 24);
            this.HeosTrackInfoAlbum.TabIndex = 88;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage2.Controls.Add(this.btnResetSpeaker);
            this.tabPage2.Controls.Add(this.lbSpeakerSubMasterShowValue);
            this.tabPage2.Controls.Add(this.tbSpeakerSubMaster);
            this.tabPage2.Controls.Add(this.lbSpeakerSubwoofer2ShowValue);
            this.tabPage2.Controls.Add(this.lbSpeakerSubwoofer1ShowValue);
            this.tabPage2.Controls.Add(this.lbSpeakerSurroundRShowValue);
            this.tabPage2.Controls.Add(this.lbSpeakerSurroundLShowValue);
            this.tabPage2.Controls.Add(this.lbSpeakerFrontRShowValue);
            this.tabPage2.Controls.Add(this.lbSpeakerCenterShowValue);
            this.tabPage2.Controls.Add(this.lbSpeakerFrontLShowValue);
            this.tabPage2.Controls.Add(this.tbSpeakerSubwoofer2);
            this.tabPage2.Controls.Add(this.tbSpeakerSubwoofer1);
            this.tabPage2.Controls.Add(this.tbSpeakerSurroundR);
            this.tabPage2.Controls.Add(this.tbSpeakerSurroundL);
            this.tabPage2.Controls.Add(this.tbSpeakerFrontR);
            this.tabPage2.Controls.Add(this.tbSpeakerCenter);
            this.tabPage2.Controls.Add(this.tbSpeakerFrontL);
            this.tabPage2.Controls.Add(this.lbSpeakerSubwoofer1and2);
            this.tabPage2.Controls.Add(this.lbSpeakerSubwoofer2);
            this.tabPage2.Controls.Add(this.lbSpeakerSubwoofer1);
            this.tabPage2.Controls.Add(this.lbSpeakerSurroundR);
            this.tabPage2.Controls.Add(this.lbSpeakerSurroundL);
            this.tabPage2.Controls.Add(this.lbSpeakerFrontR);
            this.tabPage2.Controls.Add(this.lbSpeakerCenter);
            this.tabPage2.Controls.Add(this.lbSpeakerFrontL);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(994, 692);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // btnResetSpeaker
            // 
            this.btnResetSpeaker.BackColor = System.Drawing.Color.DarkGray;
            this.btnResetSpeaker.Location = new System.Drawing.Point(834, 642);
            this.btnResetSpeaker.Name = "btnResetSpeaker";
            this.btnResetSpeaker.Size = new System.Drawing.Size(142, 44);
            this.btnResetSpeaker.TabIndex = 69;
            this.btnResetSpeaker.Text = "Reset";
            this.btnResetSpeaker.UseVisualStyleBackColor = false;
            this.btnResetSpeaker.Click += new System.EventHandler(this.btnResetSpeaker_Click);
            // 
            // lbSpeakerSubMasterShowValue
            // 
            this.lbSpeakerSubMasterShowValue.AutoSize = true;
            this.lbSpeakerSubMasterShowValue.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerSubMasterShowValue.Location = new System.Drawing.Point(835, 591);
            this.lbSpeakerSubMasterShowValue.Name = "lbSpeakerSubMasterShowValue";
            this.lbSpeakerSubMasterShowValue.Size = new System.Drawing.Size(74, 25);
            this.lbSpeakerSubMasterShowValue.TabIndex = 23;
            this.lbSpeakerSubMasterShowValue.Text = "0.0 dB";
            // 
            // tbSpeakerSubMaster
            // 
            this.tbSpeakerSubMaster.AutoSize = false;
            this.tbSpeakerSubMaster.Location = new System.Drawing.Point(175, 579);
            this.tbSpeakerSubMaster.Maximum = 62;
            this.tbSpeakerSubMaster.Minimum = 38;
            this.tbSpeakerSubMaster.Name = "tbSpeakerSubMaster";
            this.tbSpeakerSubMaster.Size = new System.Drawing.Size(652, 54);
            this.tbSpeakerSubMaster.TabIndex = 22;
            this.tbSpeakerSubMaster.Value = 50;
            this.tbSpeakerSubMaster.Scroll += new System.EventHandler(this.tbSpeakerSubMaster_Scroll);
            this.tbSpeakerSubMaster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbSpeakerSubMaster_MouseDown);
            this.tbSpeakerSubMaster.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbSpeakerSubMaster_MouseUp);
            // 
            // lbSpeakerSubwoofer2ShowValue
            // 
            this.lbSpeakerSubwoofer2ShowValue.AutoSize = true;
            this.lbSpeakerSubwoofer2ShowValue.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerSubwoofer2ShowValue.Location = new System.Drawing.Point(835, 507);
            this.lbSpeakerSubwoofer2ShowValue.Name = "lbSpeakerSubwoofer2ShowValue";
            this.lbSpeakerSubwoofer2ShowValue.Size = new System.Drawing.Size(74, 25);
            this.lbSpeakerSubwoofer2ShowValue.TabIndex = 21;
            this.lbSpeakerSubwoofer2ShowValue.Text = "0.0 dB";
            // 
            // lbSpeakerSubwoofer1ShowValue
            // 
            this.lbSpeakerSubwoofer1ShowValue.AutoSize = true;
            this.lbSpeakerSubwoofer1ShowValue.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerSubwoofer1ShowValue.Location = new System.Drawing.Point(835, 428);
            this.lbSpeakerSubwoofer1ShowValue.Name = "lbSpeakerSubwoofer1ShowValue";
            this.lbSpeakerSubwoofer1ShowValue.Size = new System.Drawing.Size(74, 25);
            this.lbSpeakerSubwoofer1ShowValue.TabIndex = 20;
            this.lbSpeakerSubwoofer1ShowValue.Text = "0.0 dB";
            // 
            // lbSpeakerSurroundRShowValue
            // 
            this.lbSpeakerSurroundRShowValue.AutoSize = true;
            this.lbSpeakerSurroundRShowValue.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerSurroundRShowValue.Location = new System.Drawing.Point(835, 349);
            this.lbSpeakerSurroundRShowValue.Name = "lbSpeakerSurroundRShowValue";
            this.lbSpeakerSurroundRShowValue.Size = new System.Drawing.Size(74, 25);
            this.lbSpeakerSurroundRShowValue.TabIndex = 19;
            this.lbSpeakerSurroundRShowValue.Text = "0.0 dB";
            // 
            // lbSpeakerSurroundLShowValue
            // 
            this.lbSpeakerSurroundLShowValue.AutoSize = true;
            this.lbSpeakerSurroundLShowValue.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerSurroundLShowValue.Location = new System.Drawing.Point(835, 270);
            this.lbSpeakerSurroundLShowValue.Name = "lbSpeakerSurroundLShowValue";
            this.lbSpeakerSurroundLShowValue.Size = new System.Drawing.Size(74, 25);
            this.lbSpeakerSurroundLShowValue.TabIndex = 18;
            this.lbSpeakerSurroundLShowValue.Text = "0.0 dB";
            // 
            // lbSpeakerFrontRShowValue
            // 
            this.lbSpeakerFrontRShowValue.AutoSize = true;
            this.lbSpeakerFrontRShowValue.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerFrontRShowValue.Location = new System.Drawing.Point(835, 191);
            this.lbSpeakerFrontRShowValue.Name = "lbSpeakerFrontRShowValue";
            this.lbSpeakerFrontRShowValue.Size = new System.Drawing.Size(74, 25);
            this.lbSpeakerFrontRShowValue.TabIndex = 17;
            this.lbSpeakerFrontRShowValue.Text = "0.0 dB";
            // 
            // lbSpeakerCenterShowValue
            // 
            this.lbSpeakerCenterShowValue.AutoSize = true;
            this.lbSpeakerCenterShowValue.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerCenterShowValue.Location = new System.Drawing.Point(835, 112);
            this.lbSpeakerCenterShowValue.Name = "lbSpeakerCenterShowValue";
            this.lbSpeakerCenterShowValue.Size = new System.Drawing.Size(74, 25);
            this.lbSpeakerCenterShowValue.TabIndex = 16;
            this.lbSpeakerCenterShowValue.Text = "0.0 dB";
            // 
            // lbSpeakerFrontLShowValue
            // 
            this.lbSpeakerFrontLShowValue.AutoSize = true;
            this.lbSpeakerFrontLShowValue.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerFrontLShowValue.Location = new System.Drawing.Point(835, 32);
            this.lbSpeakerFrontLShowValue.Name = "lbSpeakerFrontLShowValue";
            this.lbSpeakerFrontLShowValue.Size = new System.Drawing.Size(74, 25);
            this.lbSpeakerFrontLShowValue.TabIndex = 15;
            this.lbSpeakerFrontLShowValue.Text = "0.0 dB";
            // 
            // tbSpeakerSubwoofer2
            // 
            this.tbSpeakerSubwoofer2.AutoSize = false;
            this.tbSpeakerSubwoofer2.Location = new System.Drawing.Point(175, 498);
            this.tbSpeakerSubwoofer2.Maximum = 62;
            this.tbSpeakerSubwoofer2.Minimum = 38;
            this.tbSpeakerSubwoofer2.Name = "tbSpeakerSubwoofer2";
            this.tbSpeakerSubwoofer2.Size = new System.Drawing.Size(652, 54);
            this.tbSpeakerSubwoofer2.TabIndex = 14;
            this.tbSpeakerSubwoofer2.Value = 50;
            this.tbSpeakerSubwoofer2.Scroll += new System.EventHandler(this.tbSpeakerSubwoofer2_Scroll);
            this.tbSpeakerSubwoofer2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbSpeakerSubwoofer2_MouseUp);
            // 
            // tbSpeakerSubwoofer1
            // 
            this.tbSpeakerSubwoofer1.AutoSize = false;
            this.tbSpeakerSubwoofer1.Location = new System.Drawing.Point(175, 419);
            this.tbSpeakerSubwoofer1.Maximum = 62;
            this.tbSpeakerSubwoofer1.Minimum = 38;
            this.tbSpeakerSubwoofer1.Name = "tbSpeakerSubwoofer1";
            this.tbSpeakerSubwoofer1.Size = new System.Drawing.Size(652, 54);
            this.tbSpeakerSubwoofer1.TabIndex = 13;
            this.tbSpeakerSubwoofer1.Value = 50;
            this.tbSpeakerSubwoofer1.Scroll += new System.EventHandler(this.tbSpeakerSubwoofer1_Scroll);
            this.tbSpeakerSubwoofer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbSpeakerSubwoofer1_MouseUp);
            // 
            // tbSpeakerSurroundR
            // 
            this.tbSpeakerSurroundR.AutoSize = false;
            this.tbSpeakerSurroundR.Location = new System.Drawing.Point(175, 340);
            this.tbSpeakerSurroundR.Maximum = 62;
            this.tbSpeakerSurroundR.Minimum = 38;
            this.tbSpeakerSurroundR.Name = "tbSpeakerSurroundR";
            this.tbSpeakerSurroundR.Size = new System.Drawing.Size(652, 54);
            this.tbSpeakerSurroundR.TabIndex = 12;
            this.tbSpeakerSurroundR.Value = 50;
            this.tbSpeakerSurroundR.Scroll += new System.EventHandler(this.tbSpeakerSurroundR_Scroll);
            this.tbSpeakerSurroundR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbSpeakerSurroundR_MouseUp);
            // 
            // tbSpeakerSurroundL
            // 
            this.tbSpeakerSurroundL.AutoSize = false;
            this.tbSpeakerSurroundL.Location = new System.Drawing.Point(175, 261);
            this.tbSpeakerSurroundL.Maximum = 62;
            this.tbSpeakerSurroundL.Minimum = 38;
            this.tbSpeakerSurroundL.Name = "tbSpeakerSurroundL";
            this.tbSpeakerSurroundL.Size = new System.Drawing.Size(652, 54);
            this.tbSpeakerSurroundL.TabIndex = 11;
            this.tbSpeakerSurroundL.Value = 50;
            this.tbSpeakerSurroundL.Scroll += new System.EventHandler(this.tbSpeakerSurroundL_Scroll);
            this.tbSpeakerSurroundL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbSpeakerSurroundL_MouseUp);
            // 
            // tbSpeakerFrontR
            // 
            this.tbSpeakerFrontR.AutoSize = false;
            this.tbSpeakerFrontR.Location = new System.Drawing.Point(175, 182);
            this.tbSpeakerFrontR.Maximum = 62;
            this.tbSpeakerFrontR.Minimum = 38;
            this.tbSpeakerFrontR.Name = "tbSpeakerFrontR";
            this.tbSpeakerFrontR.Size = new System.Drawing.Size(652, 54);
            this.tbSpeakerFrontR.TabIndex = 10;
            this.tbSpeakerFrontR.Value = 50;
            this.tbSpeakerFrontR.Scroll += new System.EventHandler(this.tbSpeakerFrontR_Scroll);
            this.tbSpeakerFrontR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbSpeakerFrontR_MouseUp);
            // 
            // tbSpeakerCenter
            // 
            this.tbSpeakerCenter.AutoSize = false;
            this.tbSpeakerCenter.Location = new System.Drawing.Point(175, 103);
            this.tbSpeakerCenter.Maximum = 62;
            this.tbSpeakerCenter.Minimum = 38;
            this.tbSpeakerCenter.Name = "tbSpeakerCenter";
            this.tbSpeakerCenter.Size = new System.Drawing.Size(652, 54);
            this.tbSpeakerCenter.TabIndex = 9;
            this.tbSpeakerCenter.Value = 50;
            this.tbSpeakerCenter.Scroll += new System.EventHandler(this.tbSpeakerCenter_Scroll);
            this.tbSpeakerCenter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbSpeakerCenter_MouseUp);
            // 
            // tbSpeakerFrontL
            // 
            this.tbSpeakerFrontL.AutoSize = false;
            this.tbSpeakerFrontL.Location = new System.Drawing.Point(175, 24);
            this.tbSpeakerFrontL.Maximum = 62;
            this.tbSpeakerFrontL.Minimum = 38;
            this.tbSpeakerFrontL.Name = "tbSpeakerFrontL";
            this.tbSpeakerFrontL.Size = new System.Drawing.Size(652, 54);
            this.tbSpeakerFrontL.TabIndex = 8;
            this.tbSpeakerFrontL.Value = 50;
            this.tbSpeakerFrontL.Scroll += new System.EventHandler(this.tbSpeakerFrontL_Scroll);
            this.tbSpeakerFrontL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbSpeakerFrontL_MouseUp);
            // 
            // lbSpeakerSubwoofer1and2
            // 
            this.lbSpeakerSubwoofer1and2.AutoSize = true;
            this.lbSpeakerSubwoofer1and2.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerSubwoofer1and2.Location = new System.Drawing.Point(22, 588);
            this.lbSpeakerSubwoofer1and2.Name = "lbSpeakerSubwoofer1and2";
            this.lbSpeakerSubwoofer1and2.Size = new System.Drawing.Size(156, 25);
            this.lbSpeakerSubwoofer1and2.TabIndex = 7;
            this.lbSpeakerSubwoofer1and2.Text = "Subwoofer 1+2";
            // 
            // lbSpeakerSubwoofer2
            // 
            this.lbSpeakerSubwoofer2.AutoSize = true;
            this.lbSpeakerSubwoofer2.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerSubwoofer2.Location = new System.Drawing.Point(24, 507);
            this.lbSpeakerSubwoofer2.Name = "lbSpeakerSubwoofer2";
            this.lbSpeakerSubwoofer2.Size = new System.Drawing.Size(132, 25);
            this.lbSpeakerSubwoofer2.TabIndex = 6;
            this.lbSpeakerSubwoofer2.Text = "Subwoofer 2";
            // 
            // lbSpeakerSubwoofer1
            // 
            this.lbSpeakerSubwoofer1.AutoSize = true;
            this.lbSpeakerSubwoofer1.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerSubwoofer1.Location = new System.Drawing.Point(24, 428);
            this.lbSpeakerSubwoofer1.Name = "lbSpeakerSubwoofer1";
            this.lbSpeakerSubwoofer1.Size = new System.Drawing.Size(132, 25);
            this.lbSpeakerSubwoofer1.TabIndex = 5;
            this.lbSpeakerSubwoofer1.Text = "Subwoofer 1";
            // 
            // lbSpeakerSurroundR
            // 
            this.lbSpeakerSurroundR.AutoSize = true;
            this.lbSpeakerSurroundR.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerSurroundR.Location = new System.Drawing.Point(24, 349);
            this.lbSpeakerSurroundR.Name = "lbSpeakerSurroundR";
            this.lbSpeakerSurroundR.Size = new System.Drawing.Size(121, 25);
            this.lbSpeakerSurroundR.TabIndex = 4;
            this.lbSpeakerSurroundR.Text = "Surround R";
            // 
            // lbSpeakerSurroundL
            // 
            this.lbSpeakerSurroundL.AutoSize = true;
            this.lbSpeakerSurroundL.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerSurroundL.Location = new System.Drawing.Point(22, 270);
            this.lbSpeakerSurroundL.Name = "lbSpeakerSurroundL";
            this.lbSpeakerSurroundL.Size = new System.Drawing.Size(118, 25);
            this.lbSpeakerSurroundL.TabIndex = 3;
            this.lbSpeakerSurroundL.Text = "Surround L";
            // 
            // lbSpeakerFrontR
            // 
            this.lbSpeakerFrontR.AutoSize = true;
            this.lbSpeakerFrontR.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerFrontR.Location = new System.Drawing.Point(24, 191);
            this.lbSpeakerFrontR.Name = "lbSpeakerFrontR";
            this.lbSpeakerFrontR.Size = new System.Drawing.Size(83, 25);
            this.lbSpeakerFrontR.TabIndex = 2;
            this.lbSpeakerFrontR.Text = "Front R";
            // 
            // lbSpeakerCenter
            // 
            this.lbSpeakerCenter.AutoSize = true;
            this.lbSpeakerCenter.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerCenter.Location = new System.Drawing.Point(22, 112);
            this.lbSpeakerCenter.Name = "lbSpeakerCenter";
            this.lbSpeakerCenter.Size = new System.Drawing.Size(76, 25);
            this.lbSpeakerCenter.TabIndex = 1;
            this.lbSpeakerCenter.Text = "Center";
            // 
            // lbSpeakerFrontL
            // 
            this.lbSpeakerFrontL.AutoSize = true;
            this.lbSpeakerFrontL.ForeColor = System.Drawing.Color.White;
            this.lbSpeakerFrontL.Location = new System.Drawing.Point(22, 33);
            this.lbSpeakerFrontL.Name = "lbSpeakerFrontL";
            this.lbSpeakerFrontL.Size = new System.Drawing.Size(80, 25);
            this.lbSpeakerFrontL.TabIndex = 0;
            this.lbSpeakerFrontL.Text = "Front L";
            // 
            // pnlTabOverlay
            // 
            this.pnlTabOverlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTabOverlay.Location = new System.Drawing.Point(-2, 101);
            this.pnlTabOverlay.Name = "pnlTabOverlay";
            this.pnlTabOverlay.Size = new System.Drawing.Size(993, 47);
            this.pnlTabOverlay.TabIndex = 70;
            // 
            // lblTabMain
            // 
            this.lblTabMain.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTabMain.Enabled = false;
            this.lblTabMain.ForeColor = System.Drawing.Color.White;
            this.lblTabMain.Location = new System.Drawing.Point(2, 109);
            this.lblTabMain.Name = "lblTabMain";
            this.lblTabMain.Size = new System.Drawing.Size(100, 38);
            this.lblTabMain.TabIndex = 71;
            this.lblTabMain.Text = "Main";
            this.lblTabMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTabMain.Click += new System.EventHandler(this.lblTabMain_Click);
            // 
            // lblTabSpeaker
            // 
            this.lblTabSpeaker.BackColor = System.Drawing.Color.Gray;
            this.lblTabSpeaker.Enabled = false;
            this.lblTabSpeaker.ForeColor = System.Drawing.Color.White;
            this.lblTabSpeaker.Location = new System.Drawing.Point(104, 109);
            this.lblTabSpeaker.Name = "lblTabSpeaker";
            this.lblTabSpeaker.Size = new System.Drawing.Size(100, 38);
            this.lblTabSpeaker.TabIndex = 72;
            this.lblTabSpeaker.Text = "Speaker";
            this.lblTabSpeaker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTabSpeaker.Click += new System.EventHandler(this.lblTabSpeaker_Click);
            // 
            // lbBottomOverlay
            // 
            this.lbBottomOverlay.Location = new System.Drawing.Point(-2, 836);
            this.lbBottomOverlay.Name = "lbBottomOverlay";
            this.lbBottomOverlay.Size = new System.Drawing.Size(1004, 5);
            this.lbBottomOverlay.TabIndex = 73;
            // 
            // HorizontalLine
            // 
            this.HorizontalLine.BackColor = System.Drawing.Color.DarkSlateGray;
            this.HorizontalLine.Location = new System.Drawing.Point(2, 100);
            this.HorizontalLine.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HorizontalLine.Name = "HorizontalLine";
            this.HorizontalLine.Size = new System.Drawing.Size(1000, 1);
            this.HorizontalLine.TabIndex = 9;
            // 
            // AVRControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(988, 951);
            this.Controls.Add(this.lbBottomOverlay);
            this.Controls.Add(this.lblTabSpeaker);
            this.Controls.Add(this.lblTabMain);
            this.Controls.Add(this.pnlTabOverlay);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.cbSysTray);
            this.Controls.Add(this.lbConnectStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.HorizontalLine);
            this.Controls.Add(this.CopyrightNote);
            this.Controls.Add(this.InfoNote);
            this.Controls.Add(this.PowerToggle);
            this.Controls.Add(this.LabelPowerToggle);
            this.Controls.Add(this.LogoPicture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::AVRControl.Properties.Resources.AVRControl;
            this.MaximizeBox = false;
            this.Name = "AVRControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVRControl";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Activated += new System.EventHandler(this.AVRControl_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.AVRControl_Load);
            this.Resize += new System.EventHandler(this.AVRControl_Resize);
            this.cmsTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlProgressBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayRepeatOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayRepeatAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlaySkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHeosPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderVolume)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerSubMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerSubwoofer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerSubwoofer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerSurroundR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerSurroundL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerFrontR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeakerFrontL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CopyrightNote;
        private System.Windows.Forms.Label InfoNote;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.CheckBox PowerToggle;
        private System.Windows.Forms.Label LabelPowerToggle;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbConnectStatus;
        private CheckBox cbSysTray;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip cmsTray;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Button btnInstall;
        private ToolStripMenuItem gitHubPageToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemShowHide;
        private TabPage tabPage1;
        public System.Windows.Forms.Label lbHeosAVRNetType_Data;
        public System.Windows.Forms.Label lbHeosAVRID_Data;
        public System.Windows.Forms.Label lbHeosAVRVersion_Data;
        public System.Windows.Forms.Label lbHeosAVRName_Data;
        private System.Windows.Forms.Label lbHeosAVRNetType;
        private System.Windows.Forms.Label lbHeosAVRID;
        private System.Windows.Forms.Label lbHeosAVRVersion;
        private System.Windows.Forms.Label lbHeosAVRName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lbAlbumCover;
        private PictureBox pbAlbumArt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbHeosPlayRepeatOne;
        private PictureBox btnHeosPlayRepeatOne;
        private System.Windows.Forms.Label lbHeosPlayRepeatAll;
        private PictureBox btnHeosPlayRepeatAll;
        private System.Windows.Forms.Label lbHeosPlayShuffle;
        private System.Windows.Forms.Label lbHeosPlaySkip;
        private System.Windows.Forms.Label lbHeosPlayBack;
        private System.Windows.Forms.Label lbHeosPlayPause;
        private PictureBox btnHeosPlayShuffle;
        private PictureBox btnHeosPlayBack;
        private PictureBox btnHeosPlaySkip;
        private PictureBox btnHeosPlayPause;
        private System.Windows.Forms.Label lbHeosSong;
        private System.Windows.Forms.Label lbHeosAlbum;
        private System.Windows.Forms.Label lbHeosArtist;
        public System.Windows.Forms.Label HeosTrackInfoArtist;
        public System.Windows.Forms.Label HeosTrackInfoSong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUp;
        private System.Windows.Forms.Label lbMute;
        private System.Windows.Forms.Label lbDown;
        private System.Windows.Forms.Label label1;
        private PictureBox btnToggleMute;
        private PictureBox btnVolDown;
        private PictureBox btnVolUp;
        private TrackBar SliderVolume;
        private System.Windows.Forms.Label ShowVolume;
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
        public System.Windows.Forms.Label HeosTrackInfoAlbum;
        private TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label pnlTabOverlay;
        private System.Windows.Forms.Label lblTabMain;
        private System.Windows.Forms.Label lblTabSpeaker;
        private System.Windows.Forms.Label lbSpeakerCenter;
        private System.Windows.Forms.Label lbSpeakerFrontL;
        private System.Windows.Forms.Label lbSpeakerSurroundR;
        private System.Windows.Forms.Label lbSpeakerSurroundL;
        private System.Windows.Forms.Label lbSpeakerFrontR;
        private TrackBar tbSpeakerFrontL;
        private System.Windows.Forms.Label lbSpeakerSubwoofer1and2;
        private System.Windows.Forms.Label lbSpeakerSubwoofer2;
        private System.Windows.Forms.Label lbSpeakerSubwoofer1;
        private TrackBar tbSpeakerSurroundR;
        private TrackBar tbSpeakerSurroundL;
        private TrackBar tbSpeakerFrontR;
        private TrackBar tbSpeakerCenter;
        private TrackBar tbSpeakerSubwoofer2;
        private TrackBar tbSpeakerSubwoofer1;
        private System.Windows.Forms.Label lbSpeakerCenterShowValue;
        private System.Windows.Forms.Label lbSpeakerFrontLShowValue;
        private System.Windows.Forms.Label lbSpeakerSubwoofer2ShowValue;
        private System.Windows.Forms.Label lbSpeakerSubwoofer1ShowValue;
        private System.Windows.Forms.Label lbSpeakerSurroundRShowValue;
        private System.Windows.Forms.Label lbSpeakerSurroundLShowValue;
        private System.Windows.Forms.Label lbSpeakerFrontRShowValue;
        private TrackBar tbSpeakerSubMaster;
        private System.Windows.Forms.Label lbSpeakerSubMasterShowValue;
        private System.Windows.Forms.Label lbBottomOverlay;
        private System.Windows.Forms.Label HorizontalLine;
        private Button btnResetSpeaker;
        private Panel pnlProgressBack;
        private Panel pnlProgressBar;
    }
}

