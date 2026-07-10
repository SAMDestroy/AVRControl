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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVRControl));
            CopyrightNote = new System.Windows.Forms.Label();
            InfoNote = new System.Windows.Forms.Label();
            LabelPowerToggle = new System.Windows.Forms.Label();
            lblIP = new System.Windows.Forms.Label();
            tbIP = new TextBox();
            btnSave = new Button();
            PowerToggle = new CheckBox();
            lbConnectStatus = new System.Windows.Forms.Label();
            cbSysTray = new CheckBox();
            notifyIcon1 = new NotifyIcon(components);
            cmsTray = new ContextMenuStrip(components);
            gitHubPageToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItemShowHide = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            btnInstall = new Button();
            LogoPicture = new PictureBox();
            tabControl1 = new TabControl();
            tabMain = new TabPage();
            pnlProgressBack = new Panel();
            pnlProgressBar = new Panel();
            lbHeosAVRNetType_Data = new System.Windows.Forms.Label();
            lbHeosAVRID_Data = new System.Windows.Forms.Label();
            lbHeosAVRVersion_Data = new System.Windows.Forms.Label();
            lbHeosAVRName_Data = new System.Windows.Forms.Label();
            lbHeosAVRNetType = new System.Windows.Forms.Label();
            lbHeosAVRID = new System.Windows.Forms.Label();
            lbHeosAVRVersion = new System.Windows.Forms.Label();
            lbHeosAVRName = new System.Windows.Forms.Label();
            lblTime = new System.Windows.Forms.Label();
            lbAlbumCover = new System.Windows.Forms.Label();
            pbAlbumArt = new PictureBox();
            label9 = new System.Windows.Forms.Label();
            lbHeosPlayRepeatOne = new System.Windows.Forms.Label();
            btnHeosPlayRepeatOne = new PictureBox();
            lbHeosPlayRepeatAll = new System.Windows.Forms.Label();
            btnHeosPlayRepeatAll = new PictureBox();
            lbHeosPlayShuffle = new System.Windows.Forms.Label();
            lbHeosPlaySkip = new System.Windows.Forms.Label();
            lbHeosPlayBack = new System.Windows.Forms.Label();
            lbHeosPlayPause = new System.Windows.Forms.Label();
            btnHeosPlayShuffle = new PictureBox();
            btnHeosPlayBack = new PictureBox();
            btnHeosPlaySkip = new PictureBox();
            btnHeosPlayPause = new PictureBox();
            lbHeosSong = new System.Windows.Forms.Label();
            lbHeosAlbum = new System.Windows.Forms.Label();
            lbHeosArtist = new System.Windows.Forms.Label();
            HeosTrackInfoArtist = new System.Windows.Forms.Label();
            HeosTrackInfoSong = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lbUp = new System.Windows.Forms.Label();
            lbMute = new System.Windows.Forms.Label();
            lbDown = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnToggleMute = new PictureBox();
            btnVolDown = new PictureBox();
            btnVolUp = new PictureBox();
            lbVol10 = new System.Windows.Forms.Label();
            lbVol20 = new System.Windows.Forms.Label();
            lbVol30 = new System.Windows.Forms.Label();
            lbVol40 = new System.Windows.Forms.Label();
            lbVol50 = new System.Windows.Forms.Label();
            lbVol60 = new System.Windows.Forms.Label();
            lbVol70 = new System.Windows.Forms.Label();
            lbVol80 = new System.Windows.Forms.Label();
            lbVol90 = new System.Windows.Forms.Label();
            lbVol100 = new System.Windows.Forms.Label();
            lbAVRSource = new System.Windows.Forms.Label();
            AVRSource = new System.Windows.Forms.Label();
            lbAVRSourceAudio = new System.Windows.Forms.Label();
            AVRSourceAudio = new System.Windows.Forms.Label();
            lbAVRSoundMode = new System.Windows.Forms.Label();
            AVRSoundMode = new System.Windows.Forms.Label();
            HeosTrackInfoAlbum = new System.Windows.Forms.Label();
            SliderVolume = new TrackBar();
            ShowVolume = new System.Windows.Forms.Label();
            tabSpeaker = new TabPage();
            btnResetSpeaker = new Button();
            lbSpeakerSubMasterShowValue = new System.Windows.Forms.Label();
            tbSpeakerSubMaster = new TrackBar();
            lbSpeakerSubwoofer2ShowValue = new System.Windows.Forms.Label();
            lbSpeakerSubwoofer1ShowValue = new System.Windows.Forms.Label();
            lbSpeakerSurroundRShowValue = new System.Windows.Forms.Label();
            lbSpeakerSurroundLShowValue = new System.Windows.Forms.Label();
            lbSpeakerFrontRShowValue = new System.Windows.Forms.Label();
            lbSpeakerCenterShowValue = new System.Windows.Forms.Label();
            lbSpeakerFrontLShowValue = new System.Windows.Forms.Label();
            tbSpeakerSubwoofer2 = new TrackBar();
            tbSpeakerSubwoofer1 = new TrackBar();
            tbSpeakerSurroundR = new TrackBar();
            tbSpeakerSurroundL = new TrackBar();
            tbSpeakerFrontR = new TrackBar();
            tbSpeakerCenter = new TrackBar();
            tbSpeakerFrontL = new TrackBar();
            lbSpeakerSubwoofer1and2 = new System.Windows.Forms.Label();
            lbSpeakerSubwoofer2 = new System.Windows.Forms.Label();
            lbSpeakerSubwoofer1 = new System.Windows.Forms.Label();
            lbSpeakerSurroundR = new System.Windows.Forms.Label();
            lbSpeakerSurroundL = new System.Windows.Forms.Label();
            lbSpeakerFrontR = new System.Windows.Forms.Label();
            lbSpeakerCenter = new System.Windows.Forms.Label();
            lbSpeakerFrontL = new System.Windows.Forms.Label();
            tabModes = new TabPage();
            label4 = new System.Windows.Forms.Label();
            lblCurrentSource = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblCurrentSourceAudio = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            grpDspModes = new GroupBox();
            rbModeVirtual = new RadioButton();
            rbModeMatrix = new RadioButton();
            rbModeRockArena = new RadioButton();
            rbModeJazzClub = new RadioButton();
            lblCurrentAudioMode = new System.Windows.Forms.Label();
            grpPuristModes = new GroupBox();
            rbModeMultiChIn = new RadioButton();
            rbModeGame = new RadioButton();
            rbModeMono = new RadioButton();
            rbModePureDirect = new RadioButton();
            rbModeDirect = new RadioButton();
            rbModeStereo = new RadioButton();
            rbModeMultiChStereo = new RadioButton();
            grpStandardModes = new GroupBox();
            rbModeDolbyDigitalPlus = new RadioButton();
            rbModeDtsxNative = new RadioButton();
            rbModeDtsHd = new RadioButton();
            rbModeAtmos = new RadioButton();
            rbModeTrueHd = new RadioButton();
            rbModeAuro3d = new RadioButton();
            rbModeDtsx = new RadioButton();
            rbModeDolby = new RadioButton();
            pnlTabOverlay = new System.Windows.Forms.Label();
            lblTabMain = new System.Windows.Forms.Label();
            lblTabSpeaker = new System.Windows.Forms.Label();
            lbBottomOverlay = new System.Windows.Forms.Label();
            HorizontalLine = new System.Windows.Forms.Label();
            lblTabModes = new System.Windows.Forms.Label();
            cmsTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            tabControl1.SuspendLayout();
            tabMain.SuspendLayout();
            pnlProgressBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlbumArt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHeosPlayRepeatOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHeosPlayRepeatAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHeosPlayShuffle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHeosPlayBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHeosPlaySkip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHeosPlayPause).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnToggleMute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVolDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVolUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SliderVolume).BeginInit();
            tabSpeaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerSubMaster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerSubwoofer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerSubwoofer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerSurroundR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerSurroundL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerFrontR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerCenter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerFrontL).BeginInit();
            tabModes.SuspendLayout();
            grpDspModes.SuspendLayout();
            grpPuristModes.SuspendLayout();
            grpStandardModes.SuspendLayout();
            SuspendLayout();
            // 
            // CopyrightNote
            // 
            CopyrightNote.AutoSize = true;
            CopyrightNote.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Italic);
            CopyrightNote.ForeColor = Color.White;
            CopyrightNote.Location = new Point(547, 731);
            CopyrightNote.Margin = new Padding(4, 0, 4, 0);
            CopyrightNote.Name = "CopyrightNote";
            CopyrightNote.Size = new Size(105, 17);
            CopyrightNote.TabIndex = 10;
            CopyrightNote.Text = "by SAMDestroy";
            // 
            // InfoNote
            // 
            InfoNote.AutoSize = true;
            InfoNote.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InfoNote.ForeColor = Color.White;
            InfoNote.Location = new Point(423, 13);
            InfoNote.Margin = new Padding(4, 0, 4, 0);
            InfoNote.Name = "InfoNote";
            InfoNote.Size = new Size(129, 34);
            InfoNote.TabIndex = 11;
            InfoNote.Text = "Denon / Marantz\nAVR Telnet Control";
            // 
            // LabelPowerToggle
            // 
            LabelPowerToggle.AutoSize = true;
            LabelPowerToggle.ForeColor = Color.White;
            LabelPowerToggle.Location = new Point(331, 13);
            LabelPowerToggle.Margin = new Padding(2, 0, 2, 0);
            LabelPowerToggle.Name = "LabelPowerToggle";
            LabelPowerToggle.Size = new Size(86, 20);
            LabelPowerToggle.TabIndex = 13;
            LabelPowerToggle.Text = "Main Power";
            // 
            // lblIP
            // 
            lblIP.AutoSize = true;
            lblIP.ForeColor = Color.White;
            lblIP.Location = new Point(16, 38);
            lblIP.Margin = new Padding(4, 0, 4, 0);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(24, 20);
            lblIP.TabIndex = 3;
            lblIP.Text = "IP:";
            // 
            // tbIP
            // 
            tbIP.BackColor = Color.DarkGray;
            tbIP.Location = new Point(53, 34);
            tbIP.Margin = new Padding(4, 5, 4, 5);
            tbIP.Name = "tbIP";
            tbIP.Size = new Size(141, 27);
            tbIP.TabIndex = 2;
            tbIP.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGray;
            btnSave.Location = new Point(213, 33);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 35);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // PowerToggle
            // 
            PowerToggle.Appearance = Appearance.Button;
            PowerToggle.BackColor = Color.SlateGray;
            PowerToggle.Enabled = false;
            PowerToggle.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            PowerToggle.FlatStyle = FlatStyle.Flat;
            PowerToggle.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PowerToggle.ForeColor = Color.White;
            PowerToggle.Location = new Point(333, 35);
            PowerToggle.Margin = new Padding(2, 0, 2, 0);
            PowerToggle.Name = "PowerToggle";
            PowerToggle.Padding = new Padding(4, 0, 4, 0);
            PowerToggle.Size = new Size(80, 30);
            PowerToggle.TabIndex = 12;
            PowerToggle.TextAlign = ContentAlignment.MiddleCenter;
            PowerToggle.UseVisualStyleBackColor = false;
            PowerToggle.Click += PowerToggle_Click;
            // 
            // lbConnectStatus
            // 
            lbConnectStatus.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbConnectStatus.ForeColor = Color.Khaki;
            lbConnectStatus.Location = new Point(8, 3);
            lbConnectStatus.Margin = new Padding(2, 0, 2, 0);
            lbConnectStatus.Name = "lbConnectStatus";
            lbConnectStatus.Size = new Size(300, 18);
            lbConnectStatus.TabIndex = 34;
            lbConnectStatus.Text = "label2";
            // 
            // cbSysTray
            // 
            cbSysTray.AutoSize = true;
            cbSysTray.ForeColor = Color.White;
            cbSysTray.Location = new Point(560, 45);
            cbSysTray.Margin = new Padding(2);
            cbSysTray.Name = "cbSysTray";
            cbSysTray.Size = new Size(79, 24);
            cbSysTray.TabIndex = 67;
            cbSysTray.Text = "SysTray";
            cbSysTray.UseVisualStyleBackColor = true;
            cbSysTray.CheckedChanged += cbSysTray_CheckedChanged;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = cmsTray;
            notifyIcon1.Text = "AVRControl";
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            // 
            // cmsTray
            // 
            cmsTray.ImageScalingSize = new Size(32, 32);
            cmsTray.Items.AddRange(new ToolStripItem[] { gitHubPageToolStripMenuItem1, toolStripSeparator1, toolStripMenuItemShowHide, quitToolStripMenuItem });
            cmsTray.Name = "cmsTray";
            cmsTray.Size = new Size(162, 82);
            // 
            // gitHubPageToolStripMenuItem1
            // 
            gitHubPageToolStripMenuItem1.Image = (Image)resources.GetObject("gitHubPageToolStripMenuItem1.Image");
            gitHubPageToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            gitHubPageToolStripMenuItem1.Name = "gitHubPageToolStripMenuItem1";
            gitHubPageToolStripMenuItem1.Size = new Size(161, 24);
            gitHubPageToolStripMenuItem1.Text = "GitHub Page";
            gitHubPageToolStripMenuItem1.Click += gitHubPageToolStripMenuItem1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(158, 6);
            // 
            // toolStripMenuItemShowHide
            // 
            toolStripMenuItemShowHide.Image = (Image)resources.GetObject("toolStripMenuItemShowHide.Image");
            toolStripMenuItemShowHide.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItemShowHide.Name = "toolStripMenuItemShowHide";
            toolStripMenuItemShowHide.Size = new Size(161, 24);
            toolStripMenuItemShowHide.Text = "Show/Hide";
            toolStripMenuItemShowHide.Click += toolStripMenuItemShowHide_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Image = (Image)resources.GetObject("quitToolStripMenuItem.Image");
            quitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(161, 24);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // btnInstall
            // 
            btnInstall.BackColor = Color.DarkGray;
            btnInstall.Location = new Point(559, 5);
            btnInstall.Margin = new Padding(2);
            btnInstall.Name = "btnInstall";
            btnInstall.Size = new Size(95, 35);
            btnInstall.TabIndex = 68;
            btnInstall.Text = "button1";
            btnInstall.UseVisualStyleBackColor = false;
            btnInstall.Click += btnInstall_Click;
            // 
            // LogoPicture
            // 
            LogoPicture.BackColor = Color.Transparent;
            LogoPicture.Image = (Image)resources.GetObject("LogoPicture.Image");
            LogoPicture.Location = new Point(504, 698);
            LogoPicture.Margin = new Padding(4, 5, 4, 5);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(133, 56);
            LogoPicture.TabIndex = 14;
            LogoPicture.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMain);
            tabControl1.Controls.Add(tabSpeaker);
            tabControl1.Controls.Add(tabModes);
            tabControl1.Location = new Point(-5, 84);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(673, 591);
            tabControl1.TabIndex = 69;
            // 
            // tabMain
            // 
            tabMain.BackColor = Color.LightSlateGray;
            tabMain.Controls.Add(pnlProgressBack);
            tabMain.Controls.Add(lbHeosAVRNetType_Data);
            tabMain.Controls.Add(lbHeosAVRID_Data);
            tabMain.Controls.Add(lbHeosAVRVersion_Data);
            tabMain.Controls.Add(lbHeosAVRName_Data);
            tabMain.Controls.Add(lbHeosAVRNetType);
            tabMain.Controls.Add(lbHeosAVRID);
            tabMain.Controls.Add(lbHeosAVRVersion);
            tabMain.Controls.Add(lbHeosAVRName);
            tabMain.Controls.Add(lblTime);
            tabMain.Controls.Add(lbAlbumCover);
            tabMain.Controls.Add(pbAlbumArt);
            tabMain.Controls.Add(label9);
            tabMain.Controls.Add(lbHeosPlayRepeatOne);
            tabMain.Controls.Add(btnHeosPlayRepeatOne);
            tabMain.Controls.Add(lbHeosPlayRepeatAll);
            tabMain.Controls.Add(btnHeosPlayRepeatAll);
            tabMain.Controls.Add(lbHeosPlayShuffle);
            tabMain.Controls.Add(lbHeosPlaySkip);
            tabMain.Controls.Add(lbHeosPlayBack);
            tabMain.Controls.Add(lbHeosPlayPause);
            tabMain.Controls.Add(btnHeosPlayShuffle);
            tabMain.Controls.Add(btnHeosPlayBack);
            tabMain.Controls.Add(btnHeosPlaySkip);
            tabMain.Controls.Add(btnHeosPlayPause);
            tabMain.Controls.Add(lbHeosSong);
            tabMain.Controls.Add(lbHeosAlbum);
            tabMain.Controls.Add(lbHeosArtist);
            tabMain.Controls.Add(HeosTrackInfoArtist);
            tabMain.Controls.Add(HeosTrackInfoSong);
            tabMain.Controls.Add(label2);
            tabMain.Controls.Add(lbUp);
            tabMain.Controls.Add(lbMute);
            tabMain.Controls.Add(lbDown);
            tabMain.Controls.Add(label1);
            tabMain.Controls.Add(btnToggleMute);
            tabMain.Controls.Add(btnVolDown);
            tabMain.Controls.Add(btnVolUp);
            tabMain.Controls.Add(lbVol10);
            tabMain.Controls.Add(lbVol20);
            tabMain.Controls.Add(lbVol30);
            tabMain.Controls.Add(lbVol40);
            tabMain.Controls.Add(lbVol50);
            tabMain.Controls.Add(lbVol60);
            tabMain.Controls.Add(lbVol70);
            tabMain.Controls.Add(lbVol80);
            tabMain.Controls.Add(lbVol90);
            tabMain.Controls.Add(lbVol100);
            tabMain.Controls.Add(lbAVRSource);
            tabMain.Controls.Add(AVRSource);
            tabMain.Controls.Add(lbAVRSourceAudio);
            tabMain.Controls.Add(AVRSourceAudio);
            tabMain.Controls.Add(lbAVRSoundMode);
            tabMain.Controls.Add(AVRSoundMode);
            tabMain.Controls.Add(HeosTrackInfoAlbum);
            tabMain.Controls.Add(SliderVolume);
            tabMain.Controls.Add(ShowVolume);
            tabMain.Location = new Point(4, 29);
            tabMain.Margin = new Padding(2);
            tabMain.Name = "tabMain";
            tabMain.Padding = new Padding(2);
            tabMain.Size = new Size(665, 558);
            tabMain.TabIndex = 0;
            tabMain.Text = "Main";
            // 
            // pnlProgressBack
            // 
            pnlProgressBack.BackColor = Color.DarkGray;
            pnlProgressBack.BorderStyle = BorderStyle.FixedSingle;
            pnlProgressBack.Controls.Add(pnlProgressBar);
            pnlProgressBack.Location = new Point(29, 366);
            pnlProgressBack.Margin = new Padding(2);
            pnlProgressBack.Name = "pnlProgressBack";
            pnlProgressBack.Size = new Size(584, 11);
            pnlProgressBack.TabIndex = 124;
            // 
            // pnlProgressBar
            // 
            pnlProgressBar.BackColor = Color.SteelBlue;
            pnlProgressBar.Location = new Point(1, 1);
            pnlProgressBar.Margin = new Padding(2);
            pnlProgressBar.Name = "pnlProgressBar";
            pnlProgressBar.Size = new Size(1, 10);
            pnlProgressBar.TabIndex = 0;
            // 
            // lbHeosAVRNetType_Data
            // 
            lbHeosAVRNetType_Data.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeosAVRNetType_Data.ForeColor = Color.Khaki;
            lbHeosAVRNetType_Data.Location = new Point(92, 499);
            lbHeosAVRNetType_Data.Margin = new Padding(4, 0, 4, 0);
            lbHeosAVRNetType_Data.Name = "lbHeosAVRNetType_Data";
            lbHeosAVRNetType_Data.Size = new Size(170, 15);
            lbHeosAVRNetType_Data.TabIndex = 123;
            // 
            // lbHeosAVRID_Data
            // 
            lbHeosAVRID_Data.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeosAVRID_Data.ForeColor = Color.Khaki;
            lbHeosAVRID_Data.Location = new Point(92, 473);
            lbHeosAVRID_Data.Margin = new Padding(4, 0, 4, 0);
            lbHeosAVRID_Data.Name = "lbHeosAVRID_Data";
            lbHeosAVRID_Data.Size = new Size(170, 15);
            lbHeosAVRID_Data.TabIndex = 122;
            // 
            // lbHeosAVRVersion_Data
            // 
            lbHeosAVRVersion_Data.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeosAVRVersion_Data.ForeColor = Color.Khaki;
            lbHeosAVRVersion_Data.Location = new Point(92, 447);
            lbHeosAVRVersion_Data.Margin = new Padding(4, 0, 4, 0);
            lbHeosAVRVersion_Data.Name = "lbHeosAVRVersion_Data";
            lbHeosAVRVersion_Data.Size = new Size(170, 15);
            lbHeosAVRVersion_Data.TabIndex = 121;
            // 
            // lbHeosAVRName_Data
            // 
            lbHeosAVRName_Data.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeosAVRName_Data.ForeColor = Color.Khaki;
            lbHeosAVRName_Data.Location = new Point(92, 421);
            lbHeosAVRName_Data.Margin = new Padding(4, 0, 4, 0);
            lbHeosAVRName_Data.Name = "lbHeosAVRName_Data";
            lbHeosAVRName_Data.Size = new Size(170, 15);
            lbHeosAVRName_Data.TabIndex = 120;
            // 
            // lbHeosAVRNetType
            // 
            lbHeosAVRNetType.AutoSize = true;
            lbHeosAVRNetType.ForeColor = Color.White;
            lbHeosAVRNetType.Location = new Point(15, 496);
            lbHeosAVRNetType.Margin = new Padding(2, 0, 2, 0);
            lbHeosAVRNetType.Name = "lbHeosAVRNetType";
            lbHeosAVRNetType.Size = new Size(67, 20);
            lbHeosAVRNetType.TabIndex = 119;
            lbHeosAVRNetType.Text = "NetType:";
            // 
            // lbHeosAVRID
            // 
            lbHeosAVRID.AutoSize = true;
            lbHeosAVRID.ForeColor = Color.White;
            lbHeosAVRID.Location = new Point(15, 470);
            lbHeosAVRID.Margin = new Padding(2, 0, 2, 0);
            lbHeosAVRID.Name = "lbHeosAVRID";
            lbHeosAVRID.Size = new Size(71, 20);
            lbHeosAVRID.TabIndex = 118;
            lbHeosAVRID.Text = "Player ID:";
            // 
            // lbHeosAVRVersion
            // 
            lbHeosAVRVersion.AutoSize = true;
            lbHeosAVRVersion.ForeColor = Color.White;
            lbHeosAVRVersion.Location = new Point(15, 444);
            lbHeosAVRVersion.Margin = new Padding(2, 0, 2, 0);
            lbHeosAVRVersion.Name = "lbHeosAVRVersion";
            lbHeosAVRVersion.Size = new Size(60, 20);
            lbHeosAVRVersion.TabIndex = 117;
            lbHeosAVRVersion.Text = "Version:";
            // 
            // lbHeosAVRName
            // 
            lbHeosAVRName.AutoSize = true;
            lbHeosAVRName.ForeColor = Color.White;
            lbHeosAVRName.Location = new Point(15, 418);
            lbHeosAVRName.Margin = new Padding(2, 0, 2, 0);
            lbHeosAVRName.Name = "lbHeosAVRName";
            lbHeosAVRName.Size = new Size(50, 20);
            lbHeosAVRName.TabIndex = 116;
            lbHeosAVRName.Text = "Client:";
            // 
            // lblTime
            // 
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(271, 386);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(107, 22);
            lblTime.TabIndex = 114;
            // 
            // lbAlbumCover
            // 
            lbAlbumCover.AutoSize = true;
            lbAlbumCover.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAlbumCover.ForeColor = Color.White;
            lbAlbumCover.Location = new Point(277, 505);
            lbAlbumCover.Margin = new Padding(4, 0, 4, 0);
            lbAlbumCover.Name = "lbAlbumCover";
            lbAlbumCover.Size = new Size(88, 17);
            lbAlbumCover.TabIndex = 113;
            lbAlbumCover.Text = "Album Cover";
            // 
            // pbAlbumArt
            // 
            pbAlbumArt.BackgroundImageLayout = ImageLayout.Zoom;
            pbAlbumArt.Location = new Point(281, 409);
            pbAlbumArt.Margin = new Padding(2);
            pbAlbumArt.Name = "pbAlbumArt";
            pbAlbumArt.Size = new Size(75, 98);
            pbAlbumArt.TabIndex = 112;
            pbAlbumArt.TabStop = false;
            // 
            // label9
            // 
            label9.BackColor = Color.DarkGray;
            label9.Location = new Point(-5, 261);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(667, 1);
            label9.TabIndex = 111;
            // 
            // lbHeosPlayRepeatOne
            // 
            lbHeosPlayRepeatOne.AutoSize = true;
            lbHeosPlayRepeatOne.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeosPlayRepeatOne.ForeColor = Color.White;
            lbHeosPlayRepeatOne.Location = new Point(537, 325);
            lbHeosPlayRepeatOne.Margin = new Padding(4, 0, 4, 0);
            lbHeosPlayRepeatOne.Name = "lbHeosPlayRepeatOne";
            lbHeosPlayRepeatOne.Size = new Size(85, 17);
            lbHeosPlayRepeatOne.TabIndex = 110;
            lbHeosPlayRepeatOne.Text = "Repeat One";
            // 
            // btnHeosPlayRepeatOne
            // 
            btnHeosPlayRepeatOne.BackColor = Color.Transparent;
            btnHeosPlayRepeatOne.BackgroundImage = (Image)resources.GetObject("btnHeosPlayRepeatOne.BackgroundImage");
            btnHeosPlayRepeatOne.BackgroundImageLayout = ImageLayout.Center;
            btnHeosPlayRepeatOne.BorderStyle = BorderStyle.FixedSingle;
            btnHeosPlayRepeatOne.Location = new Point(552, 276);
            btnHeosPlayRepeatOne.Margin = new Padding(4, 5, 4, 5);
            btnHeosPlayRepeatOne.Name = "btnHeosPlayRepeatOne";
            btnHeosPlayRepeatOne.Size = new Size(49, 43);
            btnHeosPlayRepeatOne.SizeMode = PictureBoxSizeMode.Zoom;
            btnHeosPlayRepeatOne.TabIndex = 109;
            btnHeosPlayRepeatOne.TabStop = false;
            btnHeosPlayRepeatOne.Click += btnHeosPlayRepeatOne_Click;
            btnHeosPlayRepeatOne.MouseDown += btnHeosPlayRepeatOne_MouseDown;
            btnHeosPlayRepeatOne.MouseEnter += btnHeosPlayRepeatOne_MouseEnter;
            btnHeosPlayRepeatOne.MouseLeave += btnHeosPlayRepeatOne_MouseLeave;
            btnHeosPlayRepeatOne.MouseUp += btnHeosPlayRepeatOne_MouseUp;
            // 
            // lbHeosPlayRepeatAll
            // 
            lbHeosPlayRepeatAll.AutoSize = true;
            lbHeosPlayRepeatAll.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeosPlayRepeatAll.ForeColor = Color.White;
            lbHeosPlayRepeatAll.Location = new Point(441, 325);
            lbHeosPlayRepeatAll.Margin = new Padding(4, 0, 4, 0);
            lbHeosPlayRepeatAll.Name = "lbHeosPlayRepeatAll";
            lbHeosPlayRepeatAll.Size = new Size(73, 17);
            lbHeosPlayRepeatAll.TabIndex = 108;
            lbHeosPlayRepeatAll.Text = "Repeat All";
            // 
            // btnHeosPlayRepeatAll
            // 
            btnHeosPlayRepeatAll.BackColor = Color.Transparent;
            btnHeosPlayRepeatAll.BackgroundImage = (Image)resources.GetObject("btnHeosPlayRepeatAll.BackgroundImage");
            btnHeosPlayRepeatAll.BackgroundImageLayout = ImageLayout.Center;
            btnHeosPlayRepeatAll.BorderStyle = BorderStyle.FixedSingle;
            btnHeosPlayRepeatAll.Location = new Point(452, 276);
            btnHeosPlayRepeatAll.Margin = new Padding(4, 5, 4, 5);
            btnHeosPlayRepeatAll.Name = "btnHeosPlayRepeatAll";
            btnHeosPlayRepeatAll.Size = new Size(49, 43);
            btnHeosPlayRepeatAll.SizeMode = PictureBoxSizeMode.Zoom;
            btnHeosPlayRepeatAll.TabIndex = 107;
            btnHeosPlayRepeatAll.TabStop = false;
            btnHeosPlayRepeatAll.Click += btnHeosPlayRepeatAll_Click;
            btnHeosPlayRepeatAll.MouseDown += btnHeosPlayRepeatAll_MouseDown;
            btnHeosPlayRepeatAll.MouseEnter += btnHeosPlayRepeatAll_MouseEnter;
            btnHeosPlayRepeatAll.MouseLeave += btnHeosPlayRepeatAll_MouseLeave;
            btnHeosPlayRepeatAll.MouseUp += btnHeosPlayRepeatAll_MouseUp;
            // 
            // lbHeosPlayShuffle
            // 
            lbHeosPlayShuffle.AutoSize = true;
            lbHeosPlayShuffle.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeosPlayShuffle.ForeColor = Color.White;
            lbHeosPlayShuffle.Location = new Point(352, 325);
            lbHeosPlayShuffle.Margin = new Padding(4, 0, 4, 0);
            lbHeosPlayShuffle.Name = "lbHeosPlayShuffle";
            lbHeosPlayShuffle.Size = new Size(52, 17);
            lbHeosPlayShuffle.TabIndex = 106;
            lbHeosPlayShuffle.Text = "Shuffle";
            // 
            // lbHeosPlaySkip
            // 
            lbHeosPlaySkip.AutoSize = true;
            lbHeosPlaySkip.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeosPlaySkip.ForeColor = Color.White;
            lbHeosPlaySkip.Location = new Point(260, 325);
            lbHeosPlaySkip.Margin = new Padding(4, 0, 4, 0);
            lbHeosPlaySkip.Name = "lbHeosPlaySkip";
            lbHeosPlaySkip.Size = new Size(35, 17);
            lbHeosPlaySkip.TabIndex = 105;
            lbHeosPlaySkip.Text = "Skip";
            // 
            // lbHeosPlayBack
            // 
            lbHeosPlayBack.AutoSize = true;
            lbHeosPlayBack.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeosPlayBack.ForeColor = Color.White;
            lbHeosPlayBack.Location = new Point(158, 325);
            lbHeosPlayBack.Margin = new Padding(4, 0, 4, 0);
            lbHeosPlayBack.Name = "lbHeosPlayBack";
            lbHeosPlayBack.Size = new Size(39, 17);
            lbHeosPlayBack.TabIndex = 104;
            lbHeosPlayBack.Text = "Back";
            // 
            // lbHeosPlayPause
            // 
            lbHeosPlayPause.AutoSize = true;
            lbHeosPlayPause.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeosPlayPause.ForeColor = Color.White;
            lbHeosPlayPause.Location = new Point(35, 325);
            lbHeosPlayPause.Margin = new Padding(4, 0, 4, 0);
            lbHeosPlayPause.Name = "lbHeosPlayPause";
            lbHeosPlayPause.Size = new Size(79, 17);
            lbHeosPlayPause.TabIndex = 103;
            lbHeosPlayPause.Text = "Play/Pause";
            // 
            // btnHeosPlayShuffle
            // 
            btnHeosPlayShuffle.BackColor = Color.Transparent;
            btnHeosPlayShuffle.BackgroundImage = (Image)resources.GetObject("btnHeosPlayShuffle.BackgroundImage");
            btnHeosPlayShuffle.BackgroundImageLayout = ImageLayout.Center;
            btnHeosPlayShuffle.BorderStyle = BorderStyle.FixedSingle;
            btnHeosPlayShuffle.Location = new Point(352, 276);
            btnHeosPlayShuffle.Margin = new Padding(4, 5, 4, 5);
            btnHeosPlayShuffle.Name = "btnHeosPlayShuffle";
            btnHeosPlayShuffle.Size = new Size(49, 43);
            btnHeosPlayShuffle.SizeMode = PictureBoxSizeMode.Zoom;
            btnHeosPlayShuffle.TabIndex = 102;
            btnHeosPlayShuffle.TabStop = false;
            btnHeosPlayShuffle.Click += btnHeosPlayShuffle_Click;
            btnHeosPlayShuffle.MouseDown += btnHeosPlayShuffle_MouseDown;
            btnHeosPlayShuffle.MouseEnter += btnHeosPlayShuffle_MouseEnter;
            btnHeosPlayShuffle.MouseLeave += btnHeosPlayShuffle_MouseLeave;
            btnHeosPlayShuffle.MouseUp += btnHeosPlayShuffle_MouseUp;
            // 
            // btnHeosPlayBack
            // 
            btnHeosPlayBack.BackColor = Color.Transparent;
            btnHeosPlayBack.BackgroundImage = (Image)resources.GetObject("btnHeosPlayBack.BackgroundImage");
            btnHeosPlayBack.BackgroundImageLayout = ImageLayout.Center;
            btnHeosPlayBack.BorderStyle = BorderStyle.FixedSingle;
            btnHeosPlayBack.Location = new Point(152, 276);
            btnHeosPlayBack.Margin = new Padding(4, 5, 4, 5);
            btnHeosPlayBack.Name = "btnHeosPlayBack";
            btnHeosPlayBack.Size = new Size(49, 43);
            btnHeosPlayBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnHeosPlayBack.TabIndex = 101;
            btnHeosPlayBack.TabStop = false;
            btnHeosPlayBack.Click += btnHeosPlayBack_Click;
            btnHeosPlayBack.MouseDown += btnHeosPlayBack_MouseDown;
            btnHeosPlayBack.MouseEnter += btnHeosPlayBack_MouseEnter;
            btnHeosPlayBack.MouseLeave += btnHeaosPlayBack_MouseLeave;
            btnHeosPlayBack.MouseUp += btnHeosPlayBack_MouseUp;
            // 
            // btnHeosPlaySkip
            // 
            btnHeosPlaySkip.BackColor = Color.Transparent;
            btnHeosPlaySkip.BackgroundImage = (Image)resources.GetObject("btnHeosPlaySkip.BackgroundImage");
            btnHeosPlaySkip.BackgroundImageLayout = ImageLayout.Center;
            btnHeosPlaySkip.BorderStyle = BorderStyle.FixedSingle;
            btnHeosPlaySkip.Location = new Point(252, 276);
            btnHeosPlaySkip.Margin = new Padding(4, 5, 4, 5);
            btnHeosPlaySkip.Name = "btnHeosPlaySkip";
            btnHeosPlaySkip.Size = new Size(49, 43);
            btnHeosPlaySkip.SizeMode = PictureBoxSizeMode.Zoom;
            btnHeosPlaySkip.TabIndex = 100;
            btnHeosPlaySkip.TabStop = false;
            btnHeosPlaySkip.Click += btnHeosPlaySkip_Click;
            btnHeosPlaySkip.MouseDown += btnHeosPlaySkip_MouseDown;
            btnHeosPlaySkip.MouseEnter += btnHeosPlaySkip_MouseEnter;
            btnHeosPlaySkip.MouseLeave += btnHeosPlaySkip_MouseLeave;
            btnHeosPlaySkip.MouseUp += btnHeosPlaySkip_MouseUp;
            // 
            // btnHeosPlayPause
            // 
            btnHeosPlayPause.BackColor = Color.Transparent;
            btnHeosPlayPause.BackgroundImage = (Image)resources.GetObject("btnHeosPlayPause.BackgroundImage");
            btnHeosPlayPause.BackgroundImageLayout = ImageLayout.Center;
            btnHeosPlayPause.BorderStyle = BorderStyle.FixedSingle;
            btnHeosPlayPause.Location = new Point(51, 276);
            btnHeosPlayPause.Margin = new Padding(4, 5, 4, 5);
            btnHeosPlayPause.Name = "btnHeosPlayPause";
            btnHeosPlayPause.Size = new Size(49, 43);
            btnHeosPlayPause.SizeMode = PictureBoxSizeMode.Zoom;
            btnHeosPlayPause.TabIndex = 99;
            btnHeosPlayPause.TabStop = false;
            btnHeosPlayPause.Click += btnHeosPlayPause_Click;
            btnHeosPlayPause.MouseDown += btnHeosPlayPause_MouseDown;
            btnHeosPlayPause.MouseEnter += btnHeosPlayPause_MouseEnter;
            btnHeosPlayPause.MouseLeave += btnHeosPlayPause_MouseLeave;
            btnHeosPlayPause.MouseUp += btnHeosPlayPause_MouseUp;
            // 
            // lbHeosSong
            // 
            lbHeosSong.AutoSize = true;
            lbHeosSong.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeosSong.ForeColor = Color.White;
            lbHeosSong.Location = new Point(295, 225);
            lbHeosSong.Margin = new Padding(4, 0, 4, 0);
            lbHeosSong.Name = "lbHeosSong";
            lbHeosSong.Size = new Size(45, 17);
            lbHeosSong.TabIndex = 98;
            lbHeosSong.Text = "Song:";
            // 
            // lbHeosAlbum
            // 
            lbHeosAlbum.AutoSize = true;
            lbHeosAlbum.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeosAlbum.ForeColor = Color.White;
            lbHeosAlbum.Location = new Point(295, 200);
            lbHeosAlbum.Margin = new Padding(4, 0, 4, 0);
            lbHeosAlbum.Name = "lbHeosAlbum";
            lbHeosAlbum.Size = new Size(51, 17);
            lbHeosAlbum.TabIndex = 97;
            lbHeosAlbum.Text = "Album:";
            // 
            // lbHeosArtist
            // 
            lbHeosArtist.AutoSize = true;
            lbHeosArtist.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeosArtist.ForeColor = Color.White;
            lbHeosArtist.Location = new Point(295, 175);
            lbHeosArtist.Margin = new Padding(4, 0, 4, 0);
            lbHeosArtist.Name = "lbHeosArtist";
            lbHeosArtist.Size = new Size(44, 17);
            lbHeosArtist.TabIndex = 96;
            lbHeosArtist.Text = "Artist:";
            // 
            // HeosTrackInfoArtist
            // 
            HeosTrackInfoArtist.AutoEllipsis = true;
            HeosTrackInfoArtist.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeosTrackInfoArtist.ForeColor = Color.Khaki;
            HeosTrackInfoArtist.Location = new Point(348, 175);
            HeosTrackInfoArtist.Margin = new Padding(4, 0, 4, 0);
            HeosTrackInfoArtist.Name = "HeosTrackInfoArtist";
            HeosTrackInfoArtist.Size = new Size(294, 19);
            HeosTrackInfoArtist.TabIndex = 95;
            // 
            // HeosTrackInfoSong
            // 
            HeosTrackInfoSong.AutoEllipsis = true;
            HeosTrackInfoSong.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeosTrackInfoSong.ForeColor = Color.Khaki;
            HeosTrackInfoSong.Location = new Point(348, 225);
            HeosTrackInfoSong.Margin = new Padding(4, 0, 4, 0);
            HeosTrackInfoSong.Name = "HeosTrackInfoSong";
            HeosTrackInfoSong.Size = new Size(294, 19);
            HeosTrackInfoSong.TabIndex = 94;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkGray;
            label2.Location = new Point(-5, 356);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(667, 1);
            label2.TabIndex = 93;
            // 
            // lbUp
            // 
            lbUp.AutoSize = true;
            lbUp.ForeColor = Color.White;
            lbUp.Location = new Point(575, 62);
            lbUp.Margin = new Padding(2, 0, 2, 0);
            lbUp.Name = "lbUp";
            lbUp.Size = new Size(28, 20);
            lbUp.TabIndex = 92;
            lbUp.Text = "Up";
            // 
            // lbMute
            // 
            lbMute.AutoSize = true;
            lbMute.ForeColor = Color.White;
            lbMute.Location = new Point(291, 62);
            lbMute.Margin = new Padding(2, 0, 2, 0);
            lbMute.Name = "lbMute";
            lbMute.Size = new Size(43, 20);
            lbMute.TabIndex = 91;
            lbMute.Text = "Mute";
            // 
            // lbDown
            // 
            lbDown.AutoSize = true;
            lbDown.ForeColor = Color.White;
            lbDown.Location = new Point(10, 62);
            lbDown.Margin = new Padding(2, 0, 2, 0);
            lbDown.Name = "lbDown";
            lbDown.Size = new Size(48, 20);
            lbDown.TabIndex = 90;
            lbDown.Text = "Down";
            // 
            // label1
            // 
            label1.BackColor = Color.DarkGray;
            label1.Location = new Point(-5, 159);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(667, 1);
            label1.TabIndex = 67;
            // 
            // btnToggleMute
            // 
            btnToggleMute.BackColor = Color.Transparent;
            btnToggleMute.BackgroundImage = (Image)resources.GetObject("btnToggleMute.BackgroundImage");
            btnToggleMute.BackgroundImageLayout = ImageLayout.Center;
            btnToggleMute.BorderStyle = BorderStyle.FixedSingle;
            btnToggleMute.Location = new Point(287, 16);
            btnToggleMute.Margin = new Padding(4, 5, 4, 5);
            btnToggleMute.Name = "btnToggleMute";
            btnToggleMute.Size = new Size(49, 43);
            btnToggleMute.SizeMode = PictureBoxSizeMode.Zoom;
            btnToggleMute.TabIndex = 70;
            btnToggleMute.TabStop = false;
            btnToggleMute.Click += BtnToggleMute_Click;
            btnToggleMute.MouseDown += BtnToggleMute_MouseDown;
            btnToggleMute.MouseEnter += BtnToggleMute_MouseEnter;
            btnToggleMute.MouseLeave += BtnToggleMute_MouseLeave;
            // 
            // btnVolDown
            // 
            btnVolDown.BackColor = Color.Transparent;
            btnVolDown.BackgroundImage = (Image)resources.GetObject("btnVolDown.BackgroundImage");
            btnVolDown.BackgroundImageLayout = ImageLayout.Center;
            btnVolDown.BorderStyle = BorderStyle.FixedSingle;
            btnVolDown.Location = new Point(8, 16);
            btnVolDown.Margin = new Padding(4, 5, 4, 5);
            btnVolDown.Name = "btnVolDown";
            btnVolDown.Size = new Size(49, 43);
            btnVolDown.SizeMode = PictureBoxSizeMode.Zoom;
            btnVolDown.TabIndex = 72;
            btnVolDown.TabStop = false;
            btnVolDown.Click += BtnVolDown_Click;
            btnVolDown.MouseDown += BtnVolDown_MouseDown;
            btnVolDown.MouseEnter += BtnVolDown_MouseEnter;
            btnVolDown.MouseLeave += BtnVolDown_MouseLeave;
            btnVolDown.MouseUp += BtnVolDown_MouseUp;
            // 
            // btnVolUp
            // 
            btnVolUp.BackColor = Color.Transparent;
            btnVolUp.BackgroundImage = (Image)resources.GetObject("btnVolUp.BackgroundImage");
            btnVolUp.BackgroundImageLayout = ImageLayout.Center;
            btnVolUp.BorderStyle = BorderStyle.FixedSingle;
            btnVolUp.Location = new Point(563, 16);
            btnVolUp.Margin = new Padding(4, 5, 4, 5);
            btnVolUp.Name = "btnVolUp";
            btnVolUp.Size = new Size(49, 43);
            btnVolUp.SizeMode = PictureBoxSizeMode.Zoom;
            btnVolUp.TabIndex = 71;
            btnVolUp.TabStop = false;
            btnVolUp.Click += BtnVolUp_Click;
            btnVolUp.MouseDown += BtnVolUp_MouseDown;
            btnVolUp.MouseEnter += BtnVolUp_MouseEnter;
            btnVolUp.MouseLeave += BtnVolUp_MouseLeave;
            btnVolUp.MouseUp += BtnVolUp_MouseUp;
            // 
            // lbVol10
            // 
            lbVol10.AutoSize = true;
            lbVol10.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVol10.ForeColor = Color.DeepSkyBlue;
            lbVol10.Location = new Point(21, 127);
            lbVol10.Margin = new Padding(4, 0, 4, 0);
            lbVol10.Name = "lbVol10";
            lbVol10.Size = new Size(21, 15);
            lbVol10.TabIndex = 73;
            lbVol10.Text = "10";
            // 
            // lbVol20
            // 
            lbVol20.AutoSize = true;
            lbVol20.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVol20.ForeColor = Color.MediumTurquoise;
            lbVol20.Location = new Point(82, 127);
            lbVol20.Margin = new Padding(4, 0, 4, 0);
            lbVol20.Name = "lbVol20";
            lbVol20.Size = new Size(21, 15);
            lbVol20.TabIndex = 74;
            lbVol20.Text = "20";
            // 
            // lbVol30
            // 
            lbVol30.AutoSize = true;
            lbVol30.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVol30.ForeColor = Color.PaleGreen;
            lbVol30.Location = new Point(144, 127);
            lbVol30.Margin = new Padding(4, 0, 4, 0);
            lbVol30.Name = "lbVol30";
            lbVol30.Size = new Size(21, 15);
            lbVol30.TabIndex = 75;
            lbVol30.Text = "30";
            // 
            // lbVol40
            // 
            lbVol40.AutoSize = true;
            lbVol40.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVol40.ForeColor = Color.GreenYellow;
            lbVol40.Location = new Point(205, 127);
            lbVol40.Margin = new Padding(4, 0, 4, 0);
            lbVol40.Name = "lbVol40";
            lbVol40.Size = new Size(21, 15);
            lbVol40.TabIndex = 76;
            lbVol40.Text = "40";
            // 
            // lbVol50
            // 
            lbVol50.AutoSize = true;
            lbVol50.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbVol50.ForeColor = Color.Beige;
            lbVol50.Location = new Point(266, 127);
            lbVol50.Margin = new Padding(4, 0, 4, 0);
            lbVol50.Name = "lbVol50";
            lbVol50.Size = new Size(23, 15);
            lbVol50.TabIndex = 77;
            lbVol50.Text = "50";
            // 
            // lbVol60
            // 
            lbVol60.AutoSize = true;
            lbVol60.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVol60.ForeColor = Color.PaleGoldenrod;
            lbVol60.Location = new Point(328, 127);
            lbVol60.Margin = new Padding(4, 0, 4, 0);
            lbVol60.Name = "lbVol60";
            lbVol60.Size = new Size(21, 15);
            lbVol60.TabIndex = 78;
            lbVol60.Text = "60";
            // 
            // lbVol70
            // 
            lbVol70.AutoSize = true;
            lbVol70.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVol70.ForeColor = Color.Khaki;
            lbVol70.Location = new Point(389, 127);
            lbVol70.Margin = new Padding(4, 0, 4, 0);
            lbVol70.Name = "lbVol70";
            lbVol70.Size = new Size(21, 15);
            lbVol70.TabIndex = 79;
            lbVol70.Text = "70";
            // 
            // lbVol80
            // 
            lbVol80.AutoSize = true;
            lbVol80.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVol80.ForeColor = Color.SandyBrown;
            lbVol80.Location = new Point(450, 127);
            lbVol80.Margin = new Padding(4, 0, 4, 0);
            lbVol80.Name = "lbVol80";
            lbVol80.Size = new Size(21, 15);
            lbVol80.TabIndex = 80;
            lbVol80.Text = "80";
            // 
            // lbVol90
            // 
            lbVol90.AutoSize = true;
            lbVol90.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVol90.ForeColor = Color.DarkOrange;
            lbVol90.Location = new Point(512, 127);
            lbVol90.Margin = new Padding(4, 0, 4, 0);
            lbVol90.Name = "lbVol90";
            lbVol90.Size = new Size(21, 15);
            lbVol90.TabIndex = 81;
            lbVol90.Text = "90";
            // 
            // lbVol100
            // 
            lbVol100.AutoSize = true;
            lbVol100.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVol100.ForeColor = Color.OrangeRed;
            lbVol100.Location = new Point(570, 127);
            lbVol100.Margin = new Padding(4, 0, 4, 0);
            lbVol100.Name = "lbVol100";
            lbVol100.Size = new Size(28, 15);
            lbVol100.TabIndex = 82;
            lbVol100.Text = "100";
            // 
            // lbAVRSource
            // 
            lbAVRSource.AutoSize = true;
            lbAVRSource.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAVRSource.ForeColor = Color.White;
            lbAVRSource.Location = new Point(11, 175);
            lbAVRSource.Margin = new Padding(4, 0, 4, 0);
            lbAVRSource.Name = "lbAVRSource";
            lbAVRSource.Size = new Size(116, 17);
            lbAVRSource.TabIndex = 83;
            lbAVRSource.Text = "Selected Source:";
            // 
            // AVRSource
            // 
            AVRSource.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AVRSource.ForeColor = Color.DarkOrange;
            AVRSource.Location = new Point(130, 175);
            AVRSource.Margin = new Padding(4, 0, 4, 0);
            AVRSource.Name = "AVRSource";
            AVRSource.Size = new Size(160, 19);
            AVRSource.TabIndex = 84;
            // 
            // lbAVRSourceAudio
            // 
            lbAVRSourceAudio.AutoSize = true;
            lbAVRSourceAudio.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAVRSourceAudio.ForeColor = Color.White;
            lbAVRSourceAudio.Location = new Point(11, 200);
            lbAVRSourceAudio.Margin = new Padding(4, 0, 4, 0);
            lbAVRSourceAudio.Name = "lbAVRSourceAudio";
            lbAVRSourceAudio.Size = new Size(93, 17);
            lbAVRSourceAudio.TabIndex = 85;
            lbAVRSourceAudio.Text = "SourceAudio:";
            // 
            // AVRSourceAudio
            // 
            AVRSourceAudio.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AVRSourceAudio.ForeColor = Color.Khaki;
            AVRSourceAudio.Location = new Point(130, 200);
            AVRSourceAudio.Margin = new Padding(4, 0, 4, 0);
            AVRSourceAudio.Name = "AVRSourceAudio";
            AVRSourceAudio.Size = new Size(160, 19);
            AVRSourceAudio.TabIndex = 86;
            // 
            // lbAVRSoundMode
            // 
            lbAVRSoundMode.AutoSize = true;
            lbAVRSoundMode.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAVRSoundMode.ForeColor = Color.White;
            lbAVRSoundMode.Location = new Point(11, 225);
            lbAVRSoundMode.Margin = new Padding(4, 0, 4, 0);
            lbAVRSoundMode.Name = "lbAVRSoundMode";
            lbAVRSoundMode.Size = new Size(88, 17);
            lbAVRSoundMode.TabIndex = 87;
            lbAVRSoundMode.Text = "SoundMode:";
            // 
            // AVRSoundMode
            // 
            AVRSoundMode.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AVRSoundMode.ForeColor = Color.Khaki;
            AVRSoundMode.Location = new Point(130, 225);
            AVRSoundMode.Margin = new Padding(4, 0, 4, 0);
            AVRSoundMode.Name = "AVRSoundMode";
            AVRSoundMode.Size = new Size(160, 19);
            AVRSoundMode.TabIndex = 89;
            // 
            // HeosTrackInfoAlbum
            // 
            HeosTrackInfoAlbum.AutoEllipsis = true;
            HeosTrackInfoAlbum.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeosTrackInfoAlbum.ForeColor = Color.Khaki;
            HeosTrackInfoAlbum.Location = new Point(348, 200);
            HeosTrackInfoAlbum.Margin = new Padding(4, 0, 4, 0);
            HeosTrackInfoAlbum.Name = "HeosTrackInfoAlbum";
            HeosTrackInfoAlbum.Size = new Size(294, 19);
            HeosTrackInfoAlbum.TabIndex = 88;
            // 
            // SliderVolume
            // 
            SliderVolume.AutoSize = false;
            SliderVolume.Enabled = false;
            SliderVolume.Location = new Point(14, 90);
            SliderVolume.Margin = new Padding(16, 18, 16, 0);
            SliderVolume.Maximum = 100;
            SliderVolume.MaximumSize = new Size(587, 77);
            SliderVolume.Minimum = 10;
            SliderVolume.Name = "SliderVolume";
            SliderVolume.Size = new Size(587, 46);
            SliderVolume.SmallChange = 2;
            SliderVolume.TabIndex = 68;
            SliderVolume.Text = "SliderVolume";
            SliderVolume.TickFrequency = 5;
            SliderVolume.Value = 10;
            SliderVolume.Scroll += SliderVolume_Scroll;
            SliderVolume.MouseUp += SliderVolume_MouseUp;
            // 
            // ShowVolume
            // 
            ShowVolume.ForeColor = Color.White;
            ShowVolume.Location = new Point(597, 91);
            ShowVolume.Margin = new Padding(4, 0, 4, 0);
            ShowVolume.Name = "ShowVolume";
            ShowVolume.Size = new Size(53, 22);
            ShowVolume.TabIndex = 69;
            ShowVolume.Text = "Vol: 10";
            // 
            // tabSpeaker
            // 
            tabSpeaker.BackColor = Color.LightSlateGray;
            tabSpeaker.Controls.Add(btnResetSpeaker);
            tabSpeaker.Controls.Add(lbSpeakerSubMasterShowValue);
            tabSpeaker.Controls.Add(tbSpeakerSubMaster);
            tabSpeaker.Controls.Add(lbSpeakerSubwoofer2ShowValue);
            tabSpeaker.Controls.Add(lbSpeakerSubwoofer1ShowValue);
            tabSpeaker.Controls.Add(lbSpeakerSurroundRShowValue);
            tabSpeaker.Controls.Add(lbSpeakerSurroundLShowValue);
            tabSpeaker.Controls.Add(lbSpeakerFrontRShowValue);
            tabSpeaker.Controls.Add(lbSpeakerCenterShowValue);
            tabSpeaker.Controls.Add(lbSpeakerFrontLShowValue);
            tabSpeaker.Controls.Add(tbSpeakerSubwoofer2);
            tabSpeaker.Controls.Add(tbSpeakerSubwoofer1);
            tabSpeaker.Controls.Add(tbSpeakerSurroundR);
            tabSpeaker.Controls.Add(tbSpeakerSurroundL);
            tabSpeaker.Controls.Add(tbSpeakerFrontR);
            tabSpeaker.Controls.Add(tbSpeakerCenter);
            tabSpeaker.Controls.Add(tbSpeakerFrontL);
            tabSpeaker.Controls.Add(lbSpeakerSubwoofer1and2);
            tabSpeaker.Controls.Add(lbSpeakerSubwoofer2);
            tabSpeaker.Controls.Add(lbSpeakerSubwoofer1);
            tabSpeaker.Controls.Add(lbSpeakerSurroundR);
            tabSpeaker.Controls.Add(lbSpeakerSurroundL);
            tabSpeaker.Controls.Add(lbSpeakerFrontR);
            tabSpeaker.Controls.Add(lbSpeakerCenter);
            tabSpeaker.Controls.Add(lbSpeakerFrontL);
            tabSpeaker.Location = new Point(4, 29);
            tabSpeaker.Margin = new Padding(2);
            tabSpeaker.Name = "tabSpeaker";
            tabSpeaker.Padding = new Padding(2);
            tabSpeaker.Size = new Size(665, 558);
            tabSpeaker.TabIndex = 1;
            tabSpeaker.Text = "Speaker";
            // 
            // btnResetSpeaker
            // 
            btnResetSpeaker.BackColor = Color.DarkGray;
            btnResetSpeaker.Location = new Point(556, 514);
            btnResetSpeaker.Margin = new Padding(2);
            btnResetSpeaker.Name = "btnResetSpeaker";
            btnResetSpeaker.Size = new Size(95, 35);
            btnResetSpeaker.TabIndex = 69;
            btnResetSpeaker.Text = "Reset";
            btnResetSpeaker.UseVisualStyleBackColor = false;
            btnResetSpeaker.Click += btnResetSpeaker_Click;
            // 
            // lbSpeakerSubMasterShowValue
            // 
            lbSpeakerSubMasterShowValue.AutoSize = true;
            lbSpeakerSubMasterShowValue.ForeColor = Color.White;
            lbSpeakerSubMasterShowValue.Location = new Point(568, 465);
            lbSpeakerSubMasterShowValue.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerSubMasterShowValue.Name = "lbSpeakerSubMasterShowValue";
            lbSpeakerSubMasterShowValue.Size = new Size(50, 20);
            lbSpeakerSubMasterShowValue.TabIndex = 23;
            lbSpeakerSubMasterShowValue.Text = "0.0 dB";
            // 
            // tbSpeakerSubMaster
            // 
            tbSpeakerSubMaster.AutoSize = false;
            tbSpeakerSubMaster.Location = new Point(128, 463);
            tbSpeakerSubMaster.Margin = new Padding(2);
            tbSpeakerSubMaster.Maximum = 62;
            tbSpeakerSubMaster.Minimum = 38;
            tbSpeakerSubMaster.Name = "tbSpeakerSubMaster";
            tbSpeakerSubMaster.Size = new Size(435, 43);
            tbSpeakerSubMaster.TabIndex = 22;
            tbSpeakerSubMaster.Value = 50;
            tbSpeakerSubMaster.Scroll += tbSpeakerSubMaster_Scroll;
            tbSpeakerSubMaster.MouseDown += tbSpeakerSubMaster_MouseDown;
            tbSpeakerSubMaster.MouseUp += tbSpeakerSubMaster_MouseUp;
            // 
            // lbSpeakerSubwoofer2ShowValue
            // 
            lbSpeakerSubwoofer2ShowValue.AutoSize = true;
            lbSpeakerSubwoofer2ShowValue.ForeColor = Color.White;
            lbSpeakerSubwoofer2ShowValue.Location = new Point(568, 399);
            lbSpeakerSubwoofer2ShowValue.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerSubwoofer2ShowValue.Name = "lbSpeakerSubwoofer2ShowValue";
            lbSpeakerSubwoofer2ShowValue.Size = new Size(50, 20);
            lbSpeakerSubwoofer2ShowValue.TabIndex = 21;
            lbSpeakerSubwoofer2ShowValue.Text = "0.0 dB";
            // 
            // lbSpeakerSubwoofer1ShowValue
            // 
            lbSpeakerSubwoofer1ShowValue.AutoSize = true;
            lbSpeakerSubwoofer1ShowValue.ForeColor = Color.White;
            lbSpeakerSubwoofer1ShowValue.Location = new Point(568, 336);
            lbSpeakerSubwoofer1ShowValue.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerSubwoofer1ShowValue.Name = "lbSpeakerSubwoofer1ShowValue";
            lbSpeakerSubwoofer1ShowValue.Size = new Size(50, 20);
            lbSpeakerSubwoofer1ShowValue.TabIndex = 20;
            lbSpeakerSubwoofer1ShowValue.Text = "0.0 dB";
            // 
            // lbSpeakerSurroundRShowValue
            // 
            lbSpeakerSurroundRShowValue.AutoSize = true;
            lbSpeakerSurroundRShowValue.ForeColor = Color.White;
            lbSpeakerSurroundRShowValue.Location = new Point(568, 273);
            lbSpeakerSurroundRShowValue.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerSurroundRShowValue.Name = "lbSpeakerSurroundRShowValue";
            lbSpeakerSurroundRShowValue.Size = new Size(50, 20);
            lbSpeakerSurroundRShowValue.TabIndex = 19;
            lbSpeakerSurroundRShowValue.Text = "0.0 dB";
            // 
            // lbSpeakerSurroundLShowValue
            // 
            lbSpeakerSurroundLShowValue.AutoSize = true;
            lbSpeakerSurroundLShowValue.ForeColor = Color.White;
            lbSpeakerSurroundLShowValue.Location = new Point(568, 210);
            lbSpeakerSurroundLShowValue.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerSurroundLShowValue.Name = "lbSpeakerSurroundLShowValue";
            lbSpeakerSurroundLShowValue.Size = new Size(50, 20);
            lbSpeakerSurroundLShowValue.TabIndex = 18;
            lbSpeakerSurroundLShowValue.Text = "0.0 dB";
            // 
            // lbSpeakerFrontRShowValue
            // 
            lbSpeakerFrontRShowValue.AutoSize = true;
            lbSpeakerFrontRShowValue.ForeColor = Color.White;
            lbSpeakerFrontRShowValue.Location = new Point(568, 147);
            lbSpeakerFrontRShowValue.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerFrontRShowValue.Name = "lbSpeakerFrontRShowValue";
            lbSpeakerFrontRShowValue.Size = new Size(50, 20);
            lbSpeakerFrontRShowValue.TabIndex = 17;
            lbSpeakerFrontRShowValue.Text = "0.0 dB";
            // 
            // lbSpeakerCenterShowValue
            // 
            lbSpeakerCenterShowValue.AutoSize = true;
            lbSpeakerCenterShowValue.ForeColor = Color.White;
            lbSpeakerCenterShowValue.Location = new Point(568, 84);
            lbSpeakerCenterShowValue.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerCenterShowValue.Name = "lbSpeakerCenterShowValue";
            lbSpeakerCenterShowValue.Size = new Size(50, 20);
            lbSpeakerCenterShowValue.TabIndex = 16;
            lbSpeakerCenterShowValue.Text = "0.0 dB";
            // 
            // lbSpeakerFrontLShowValue
            // 
            lbSpeakerFrontLShowValue.AutoSize = true;
            lbSpeakerFrontLShowValue.ForeColor = Color.White;
            lbSpeakerFrontLShowValue.Location = new Point(568, 20);
            lbSpeakerFrontLShowValue.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerFrontLShowValue.Name = "lbSpeakerFrontLShowValue";
            lbSpeakerFrontLShowValue.Size = new Size(50, 20);
            lbSpeakerFrontLShowValue.TabIndex = 15;
            lbSpeakerFrontLShowValue.Text = "0.0 dB";
            // 
            // tbSpeakerSubwoofer2
            // 
            tbSpeakerSubwoofer2.AutoSize = false;
            tbSpeakerSubwoofer2.Location = new Point(128, 398);
            tbSpeakerSubwoofer2.Margin = new Padding(2);
            tbSpeakerSubwoofer2.Maximum = 62;
            tbSpeakerSubwoofer2.Minimum = 38;
            tbSpeakerSubwoofer2.Name = "tbSpeakerSubwoofer2";
            tbSpeakerSubwoofer2.Size = new Size(435, 43);
            tbSpeakerSubwoofer2.TabIndex = 14;
            tbSpeakerSubwoofer2.Value = 50;
            tbSpeakerSubwoofer2.Scroll += tbSpeakerSubwoofer2_Scroll;
            tbSpeakerSubwoofer2.MouseUp += tbSpeakerSubwoofer2_MouseUp;
            // 
            // tbSpeakerSubwoofer1
            // 
            tbSpeakerSubwoofer1.AutoSize = false;
            tbSpeakerSubwoofer1.Location = new Point(128, 335);
            tbSpeakerSubwoofer1.Margin = new Padding(2);
            tbSpeakerSubwoofer1.Maximum = 62;
            tbSpeakerSubwoofer1.Minimum = 38;
            tbSpeakerSubwoofer1.Name = "tbSpeakerSubwoofer1";
            tbSpeakerSubwoofer1.Size = new Size(435, 43);
            tbSpeakerSubwoofer1.TabIndex = 13;
            tbSpeakerSubwoofer1.Value = 50;
            tbSpeakerSubwoofer1.Scroll += tbSpeakerSubwoofer1_Scroll;
            tbSpeakerSubwoofer1.MouseUp += tbSpeakerSubwoofer1_MouseUp;
            // 
            // tbSpeakerSurroundR
            // 
            tbSpeakerSurroundR.AutoSize = false;
            tbSpeakerSurroundR.Location = new Point(128, 272);
            tbSpeakerSurroundR.Margin = new Padding(2);
            tbSpeakerSurroundR.Maximum = 62;
            tbSpeakerSurroundR.Minimum = 38;
            tbSpeakerSurroundR.Name = "tbSpeakerSurroundR";
            tbSpeakerSurroundR.Size = new Size(435, 43);
            tbSpeakerSurroundR.TabIndex = 12;
            tbSpeakerSurroundR.Value = 50;
            tbSpeakerSurroundR.Scroll += tbSpeakerSurroundR_Scroll;
            tbSpeakerSurroundR.MouseUp += tbSpeakerSurroundR_MouseUp;
            // 
            // tbSpeakerSurroundL
            // 
            tbSpeakerSurroundL.AutoSize = false;
            tbSpeakerSurroundL.Location = new Point(128, 209);
            tbSpeakerSurroundL.Margin = new Padding(2);
            tbSpeakerSurroundL.Maximum = 62;
            tbSpeakerSurroundL.Minimum = 38;
            tbSpeakerSurroundL.Name = "tbSpeakerSurroundL";
            tbSpeakerSurroundL.Size = new Size(435, 43);
            tbSpeakerSurroundL.TabIndex = 11;
            tbSpeakerSurroundL.Value = 50;
            tbSpeakerSurroundL.Scroll += tbSpeakerSurroundL_Scroll;
            tbSpeakerSurroundL.MouseUp += tbSpeakerSurroundL_MouseUp;
            // 
            // tbSpeakerFrontR
            // 
            tbSpeakerFrontR.AutoSize = false;
            tbSpeakerFrontR.Location = new Point(128, 146);
            tbSpeakerFrontR.Margin = new Padding(2);
            tbSpeakerFrontR.Maximum = 62;
            tbSpeakerFrontR.Minimum = 38;
            tbSpeakerFrontR.Name = "tbSpeakerFrontR";
            tbSpeakerFrontR.Size = new Size(435, 43);
            tbSpeakerFrontR.TabIndex = 10;
            tbSpeakerFrontR.Value = 50;
            tbSpeakerFrontR.Scroll += tbSpeakerFrontR_Scroll;
            tbSpeakerFrontR.MouseUp += tbSpeakerFrontR_MouseUp;
            // 
            // tbSpeakerCenter
            // 
            tbSpeakerCenter.AutoSize = false;
            tbSpeakerCenter.Location = new Point(128, 82);
            tbSpeakerCenter.Margin = new Padding(2);
            tbSpeakerCenter.Maximum = 62;
            tbSpeakerCenter.Minimum = 38;
            tbSpeakerCenter.Name = "tbSpeakerCenter";
            tbSpeakerCenter.Size = new Size(435, 43);
            tbSpeakerCenter.TabIndex = 9;
            tbSpeakerCenter.Value = 50;
            tbSpeakerCenter.Scroll += tbSpeakerCenter_Scroll;
            tbSpeakerCenter.MouseUp += tbSpeakerCenter_MouseUp;
            // 
            // tbSpeakerFrontL
            // 
            tbSpeakerFrontL.AutoSize = false;
            tbSpeakerFrontL.Location = new Point(128, 19);
            tbSpeakerFrontL.Margin = new Padding(2);
            tbSpeakerFrontL.Maximum = 62;
            tbSpeakerFrontL.Minimum = 38;
            tbSpeakerFrontL.Name = "tbSpeakerFrontL";
            tbSpeakerFrontL.Size = new Size(435, 43);
            tbSpeakerFrontL.TabIndex = 8;
            tbSpeakerFrontL.Value = 50;
            tbSpeakerFrontL.Scroll += tbSpeakerFrontL_Scroll;
            tbSpeakerFrontL.MouseUp += tbSpeakerFrontL_MouseUp;
            // 
            // lbSpeakerSubwoofer1and2
            // 
            lbSpeakerSubwoofer1and2.AutoSize = true;
            lbSpeakerSubwoofer1and2.ForeColor = Color.White;
            lbSpeakerSubwoofer1and2.Location = new Point(15, 465);
            lbSpeakerSubwoofer1and2.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerSubwoofer1and2.Name = "lbSpeakerSubwoofer1and2";
            lbSpeakerSubwoofer1and2.Size = new Size(111, 20);
            lbSpeakerSubwoofer1and2.TabIndex = 7;
            lbSpeakerSubwoofer1and2.Text = "Subwoofer 1+2";
            // 
            // lbSpeakerSubwoofer2
            // 
            lbSpeakerSubwoofer2.AutoSize = true;
            lbSpeakerSubwoofer2.ForeColor = Color.White;
            lbSpeakerSubwoofer2.Location = new Point(16, 401);
            lbSpeakerSubwoofer2.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerSubwoofer2.Name = "lbSpeakerSubwoofer2";
            lbSpeakerSubwoofer2.Size = new Size(93, 20);
            lbSpeakerSubwoofer2.TabIndex = 6;
            lbSpeakerSubwoofer2.Text = "Subwoofer 2";
            // 
            // lbSpeakerSubwoofer1
            // 
            lbSpeakerSubwoofer1.AutoSize = true;
            lbSpeakerSubwoofer1.ForeColor = Color.White;
            lbSpeakerSubwoofer1.Location = new Point(16, 337);
            lbSpeakerSubwoofer1.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerSubwoofer1.Name = "lbSpeakerSubwoofer1";
            lbSpeakerSubwoofer1.Size = new Size(93, 20);
            lbSpeakerSubwoofer1.TabIndex = 5;
            lbSpeakerSubwoofer1.Text = "Subwoofer 1";
            // 
            // lbSpeakerSurroundR
            // 
            lbSpeakerSurroundR.AutoSize = true;
            lbSpeakerSurroundR.ForeColor = Color.White;
            lbSpeakerSurroundR.Location = new Point(16, 274);
            lbSpeakerSurroundR.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerSurroundR.Name = "lbSpeakerSurroundR";
            lbSpeakerSurroundR.Size = new Size(82, 20);
            lbSpeakerSurroundR.TabIndex = 4;
            lbSpeakerSurroundR.Text = "Surround R";
            // 
            // lbSpeakerSurroundL
            // 
            lbSpeakerSurroundL.AutoSize = true;
            lbSpeakerSurroundL.ForeColor = Color.White;
            lbSpeakerSurroundL.Location = new Point(15, 211);
            lbSpeakerSurroundL.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerSurroundL.Name = "lbSpeakerSurroundL";
            lbSpeakerSurroundL.Size = new Size(80, 20);
            lbSpeakerSurroundL.TabIndex = 3;
            lbSpeakerSurroundL.Text = "Surround L";
            // 
            // lbSpeakerFrontR
            // 
            lbSpeakerFrontR.AutoSize = true;
            lbSpeakerFrontR.ForeColor = Color.White;
            lbSpeakerFrontR.Location = new Point(16, 148);
            lbSpeakerFrontR.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerFrontR.Name = "lbSpeakerFrontR";
            lbSpeakerFrontR.Size = new Size(56, 20);
            lbSpeakerFrontR.TabIndex = 2;
            lbSpeakerFrontR.Text = "Front R";
            // 
            // lbSpeakerCenter
            // 
            lbSpeakerCenter.AutoSize = true;
            lbSpeakerCenter.ForeColor = Color.White;
            lbSpeakerCenter.Location = new Point(15, 85);
            lbSpeakerCenter.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerCenter.Name = "lbSpeakerCenter";
            lbSpeakerCenter.Size = new Size(52, 20);
            lbSpeakerCenter.TabIndex = 1;
            lbSpeakerCenter.Text = "Center";
            // 
            // lbSpeakerFrontL
            // 
            lbSpeakerFrontL.AutoSize = true;
            lbSpeakerFrontL.ForeColor = Color.White;
            lbSpeakerFrontL.Location = new Point(15, 21);
            lbSpeakerFrontL.Margin = new Padding(2, 0, 2, 0);
            lbSpeakerFrontL.Name = "lbSpeakerFrontL";
            lbSpeakerFrontL.Size = new Size(54, 20);
            lbSpeakerFrontL.TabIndex = 0;
            lbSpeakerFrontL.Text = "Front L";
            // 
            // tabModes
            // 
            tabModes.BackColor = Color.LightSlateGray;
            tabModes.Controls.Add(label4);
            tabModes.Controls.Add(lblCurrentSource);
            tabModes.Controls.Add(label6);
            tabModes.Controls.Add(lblCurrentSourceAudio);
            tabModes.Controls.Add(label3);
            tabModes.Controls.Add(grpDspModes);
            tabModes.Controls.Add(lblCurrentAudioMode);
            tabModes.Controls.Add(grpPuristModes);
            tabModes.Controls.Add(grpStandardModes);
            tabModes.Location = new Point(4, 29);
            tabModes.Name = "tabModes";
            tabModes.Size = new Size(665, 558);
            tabModes.TabIndex = 2;
            tabModes.Text = "Modes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(339, 372);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 17);
            label4.TabIndex = 89;
            label4.Text = "Selected Source:";
            // 
            // lblCurrentSource
            // 
            lblCurrentSource.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
            lblCurrentSource.ForeColor = Color.DarkOrange;
            lblCurrentSource.Location = new Point(458, 372);
            lblCurrentSource.Margin = new Padding(4, 0, 4, 0);
            lblCurrentSource.Name = "lblCurrentSource";
            lblCurrentSource.Size = new Size(161, 19);
            lblCurrentSource.TabIndex = 90;
            lblCurrentSource.Text = "loading ...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(339, 405);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 17);
            label6.TabIndex = 91;
            label6.Text = "SourceAudio:";
            // 
            // lblCurrentSourceAudio
            // 
            lblCurrentSourceAudio.Font = new Font("Microsoft Sans Serif", 8F);
            lblCurrentSourceAudio.ForeColor = Color.Khaki;
            lblCurrentSourceAudio.Location = new Point(433, 405);
            lblCurrentSourceAudio.Margin = new Padding(4, 0, 4, 0);
            lblCurrentSourceAudio.Name = "lblCurrentSourceAudio";
            lblCurrentSourceAudio.Size = new Size(160, 19);
            lblCurrentSourceAudio.TabIndex = 92;
            lblCurrentSourceAudio.Text = "loading ...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(339, 439);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 17);
            label3.TabIndex = 88;
            label3.Text = "SoundMode:";
            // 
            // grpDspModes
            // 
            grpDspModes.Controls.Add(rbModeVirtual);
            grpDspModes.Controls.Add(rbModeMatrix);
            grpDspModes.Controls.Add(rbModeRockArena);
            grpDspModes.Controls.Add(rbModeJazzClub);
            grpDspModes.ForeColor = Color.Khaki;
            grpDspModes.Location = new Point(20, 354);
            grpDspModes.Name = "grpDspModes";
            grpDspModes.Size = new Size(300, 180);
            grpDspModes.TabIndex = 3;
            grpDspModes.TabStop = false;
            grpDspModes.Text = "DSP Modes";
            // 
            // rbModeVirtual
            // 
            rbModeVirtual.AutoSize = true;
            rbModeVirtual.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeVirtual.ForeColor = Color.White;
            rbModeVirtual.Location = new Point(23, 140);
            rbModeVirtual.Name = "rbModeVirtual";
            rbModeVirtual.Size = new Size(69, 21);
            rbModeVirtual.TabIndex = 3;
            rbModeVirtual.TabStop = true;
            rbModeVirtual.Tag = "VIRTUAL";
            rbModeVirtual.Text = "Virtual";
            rbModeVirtual.UseVisualStyleBackColor = true;
            rbModeVirtual.Click += rbAudioMode_Click;
            // 
            // rbModeMatrix
            // 
            rbModeMatrix.AutoSize = true;
            rbModeMatrix.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeMatrix.ForeColor = Color.White;
            rbModeMatrix.Location = new Point(23, 105);
            rbModeMatrix.Name = "rbModeMatrix";
            rbModeMatrix.Size = new Size(66, 21);
            rbModeMatrix.TabIndex = 2;
            rbModeMatrix.TabStop = true;
            rbModeMatrix.Tag = "MATRIX";
            rbModeMatrix.Text = "Matrix";
            rbModeMatrix.UseVisualStyleBackColor = true;
            rbModeMatrix.Click += rbAudioMode_Click;
            // 
            // rbModeRockArena
            // 
            rbModeRockArena.AutoSize = true;
            rbModeRockArena.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeRockArena.ForeColor = Color.White;
            rbModeRockArena.Location = new Point(23, 70);
            rbModeRockArena.Name = "rbModeRockArena";
            rbModeRockArena.Size = new Size(103, 21);
            rbModeRockArena.TabIndex = 1;
            rbModeRockArena.TabStop = true;
            rbModeRockArena.Tag = "ROCK ARENA";
            rbModeRockArena.Text = "Rock Arena";
            rbModeRockArena.UseVisualStyleBackColor = true;
            rbModeRockArena.Click += rbAudioMode_Click;
            // 
            // rbModeJazzClub
            // 
            rbModeJazzClub.AutoSize = true;
            rbModeJazzClub.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeJazzClub.ForeColor = Color.White;
            rbModeJazzClub.Location = new Point(23, 35);
            rbModeJazzClub.Name = "rbModeJazzClub";
            rbModeJazzClub.Size = new Size(90, 21);
            rbModeJazzClub.TabIndex = 0;
            rbModeJazzClub.TabStop = true;
            rbModeJazzClub.Tag = "JAZZ CLUB";
            rbModeJazzClub.Text = "Jazz Club";
            rbModeJazzClub.UseVisualStyleBackColor = true;
            rbModeJazzClub.Click += rbAudioMode_Click;
            // 
            // lblCurrentAudioMode
            // 
            lblCurrentAudioMode.AutoSize = true;
            lblCurrentAudioMode.Font = new Font("Microsoft Sans Serif", 8F);
            lblCurrentAudioMode.ForeColor = Color.Khaki;
            lblCurrentAudioMode.Location = new Point(433, 439);
            lblCurrentAudioMode.Name = "lblCurrentAudioMode";
            lblCurrentAudioMode.Size = new Size(70, 17);
            lblCurrentAudioMode.TabIndex = 2;
            lblCurrentAudioMode.Text = "loading ...";
            // 
            // grpPuristModes
            // 
            grpPuristModes.Controls.Add(rbModeMultiChIn);
            grpPuristModes.Controls.Add(rbModeGame);
            grpPuristModes.Controls.Add(rbModeMono);
            grpPuristModes.Controls.Add(rbModePureDirect);
            grpPuristModes.Controls.Add(rbModeDirect);
            grpPuristModes.Controls.Add(rbModeStereo);
            grpPuristModes.Controls.Add(rbModeMultiChStereo);
            grpPuristModes.ForeColor = Color.Khaki;
            grpPuristModes.Location = new Point(339, 25);
            grpPuristModes.Name = "grpPuristModes";
            grpPuristModes.Size = new Size(300, 320);
            grpPuristModes.TabIndex = 1;
            grpPuristModes.TabStop = false;
            grpPuristModes.Text = "Pure and Direct";
            // 
            // rbModeMultiChIn
            // 
            rbModeMultiChIn.AutoSize = true;
            rbModeMultiChIn.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeMultiChIn.ForeColor = Color.White;
            rbModeMultiChIn.Location = new Point(17, 104);
            rbModeMultiChIn.Name = "rbModeMultiChIn";
            rbModeMultiChIn.Size = new Size(94, 21);
            rbModeMultiChIn.TabIndex = 4;
            rbModeMultiChIn.TabStop = true;
            rbModeMultiChIn.Tag = "MULTI CH IN";
            rbModeMultiChIn.Text = "Multi Ch In";
            rbModeMultiChIn.UseVisualStyleBackColor = true;
            rbModeMultiChIn.Click += rbAudioMode_Click;
            // 
            // rbModeGame
            // 
            rbModeGame.AutoSize = true;
            rbModeGame.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeGame.ForeColor = Color.White;
            rbModeGame.Location = new Point(17, 239);
            rbModeGame.Name = "rbModeGame";
            rbModeGame.Size = new Size(129, 21);
            rbModeGame.TabIndex = 3;
            rbModeGame.TabStop = true;
            rbModeGame.Tag = "GAME";
            rbModeGame.Text = "Standard Game";
            rbModeGame.UseVisualStyleBackColor = true;
            rbModeGame.Click += rbAudioMode_Click;
            // 
            // rbModeMono
            // 
            rbModeMono.AutoSize = true;
            rbModeMono.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeMono.ForeColor = Color.White;
            rbModeMono.Location = new Point(17, 204);
            rbModeMono.Name = "rbModeMono";
            rbModeMono.Size = new Size(64, 21);
            rbModeMono.TabIndex = 2;
            rbModeMono.TabStop = true;
            rbModeMono.Tag = "MONO";
            rbModeMono.Text = "Mono";
            rbModeMono.UseVisualStyleBackColor = true;
            rbModeMono.Click += rbAudioMode_Click;
            // 
            // rbModePureDirect
            // 
            rbModePureDirect.AutoSize = true;
            rbModePureDirect.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModePureDirect.ForeColor = Color.White;
            rbModePureDirect.Location = new Point(17, 69);
            rbModePureDirect.Name = "rbModePureDirect";
            rbModePureDirect.Size = new Size(100, 21);
            rbModePureDirect.TabIndex = 1;
            rbModePureDirect.TabStop = true;
            rbModePureDirect.Tag = "PURE DIRECT";
            rbModePureDirect.Text = "Pure Direct";
            rbModePureDirect.UseVisualStyleBackColor = true;
            rbModePureDirect.Click += rbAudioMode_Click;
            // 
            // rbModeDirect
            // 
            rbModeDirect.AutoSize = true;
            rbModeDirect.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeDirect.ForeColor = Color.White;
            rbModeDirect.Location = new Point(17, 34);
            rbModeDirect.Name = "rbModeDirect";
            rbModeDirect.Size = new Size(66, 21);
            rbModeDirect.TabIndex = 0;
            rbModeDirect.TabStop = true;
            rbModeDirect.Tag = "DIRECT";
            rbModeDirect.Text = "Direct";
            rbModeDirect.UseVisualStyleBackColor = true;
            rbModeDirect.Click += rbAudioMode_Click;
            // 
            // rbModeStereo
            // 
            rbModeStereo.AutoSize = true;
            rbModeStereo.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeStereo.ForeColor = Color.White;
            rbModeStereo.Location = new Point(17, 170);
            rbModeStereo.Name = "rbModeStereo";
            rbModeStereo.Size = new Size(71, 21);
            rbModeStereo.TabIndex = 0;
            rbModeStereo.TabStop = true;
            rbModeStereo.Tag = "STEREO";
            rbModeStereo.Text = "Stereo";
            rbModeStereo.UseVisualStyleBackColor = true;
            rbModeStereo.Click += rbAudioMode_Click;
            // 
            // rbModeMultiChStereo
            // 
            rbModeMultiChStereo.AutoSize = true;
            rbModeMultiChStereo.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeMultiChStereo.ForeColor = Color.White;
            rbModeMultiChStereo.Location = new Point(17, 136);
            rbModeMultiChStereo.Name = "rbModeMultiChStereo";
            rbModeMultiChStereo.Size = new Size(125, 21);
            rbModeMultiChStereo.TabIndex = 1;
            rbModeMultiChStereo.TabStop = true;
            rbModeMultiChStereo.Tag = "M CH STEREO";
            rbModeMultiChStereo.Text = "Multi Ch Stereo";
            rbModeMultiChStereo.UseVisualStyleBackColor = true;
            rbModeMultiChStereo.Click += rbAudioMode_Click;
            // 
            // grpStandardModes
            // 
            grpStandardModes.Controls.Add(rbModeDolbyDigitalPlus);
            grpStandardModes.Controls.Add(rbModeDtsxNative);
            grpStandardModes.Controls.Add(rbModeDtsHd);
            grpStandardModes.Controls.Add(rbModeAtmos);
            grpStandardModes.Controls.Add(rbModeTrueHd);
            grpStandardModes.Controls.Add(rbModeAuro3d);
            grpStandardModes.Controls.Add(rbModeDtsx);
            grpStandardModes.Controls.Add(rbModeDolby);
            grpStandardModes.ForeColor = Color.Khaki;
            grpStandardModes.Location = new Point(20, 25);
            grpStandardModes.Name = "grpStandardModes";
            grpStandardModes.Size = new Size(300, 320);
            grpStandardModes.TabIndex = 0;
            grpStandardModes.TabStop = false;
            grpStandardModes.Text = "Standard and Upmixer";
            // 
            // rbModeDolbyDigitalPlus
            // 
            rbModeDolbyDigitalPlus.AutoSize = true;
            rbModeDolbyDigitalPlus.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeDolbyDigitalPlus.ForeColor = Color.White;
            rbModeDolbyDigitalPlus.Location = new Point(20, 104);
            rbModeDolbyDigitalPlus.Name = "rbModeDolbyDigitalPlus";
            rbModeDolbyDigitalPlus.Size = new Size(191, 21);
            rbModeDolbyDigitalPlus.TabIndex = 9;
            rbModeDolbyDigitalPlus.TabStop = true;
            rbModeDolbyDigitalPlus.Tag = "DOLBY DIGITAL";
            rbModeDolbyDigitalPlus.Text = "Dolby Digital Plus / +DSur";
            rbModeDolbyDigitalPlus.UseVisualStyleBackColor = true;
            // 
            // rbModeDtsxNative
            // 
            rbModeDtsxNative.AutoSize = true;
            rbModeDtsxNative.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeDtsxNative.ForeColor = Color.White;
            rbModeDtsxNative.Location = new Point(20, 237);
            rbModeDtsxNative.Name = "rbModeDtsxNative";
            rbModeDtsxNative.Size = new Size(70, 21);
            rbModeDtsxNative.TabIndex = 8;
            rbModeDtsxNative.TabStop = true;
            rbModeDtsxNative.Tag = "DTS SURROUND";
            rbModeDtsxNative.Text = "DTS:X";
            rbModeDtsxNative.UseVisualStyleBackColor = true;
            // 
            // rbModeDtsHd
            // 
            rbModeDtsHd.AutoSize = true;
            rbModeDtsHd.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeDtsHd.ForeColor = Color.White;
            rbModeDtsHd.Location = new Point(20, 204);
            rbModeDtsHd.Name = "rbModeDtsHd";
            rbModeDtsHd.Size = new Size(169, 21);
            rbModeDtsHd.TabIndex = 7;
            rbModeDtsHd.TabStop = true;
            rbModeDtsHd.Tag = "DTS SURROUND";
            rbModeDtsHd.Text = "DTS-HD Master Audio";
            rbModeDtsHd.UseVisualStyleBackColor = true;
            // 
            // rbModeAtmos
            // 
            rbModeAtmos.AutoSize = true;
            rbModeAtmos.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeAtmos.ForeColor = Color.White;
            rbModeAtmos.Location = new Point(20, 136);
            rbModeAtmos.Name = "rbModeAtmos";
            rbModeAtmos.Size = new Size(170, 21);
            rbModeAtmos.TabIndex = 6;
            rbModeAtmos.TabStop = true;
            rbModeAtmos.Tag = "DOLBY DIGITAL";
            rbModeAtmos.Text = "Dolby Atmos / TrueHD";
            rbModeAtmos.UseVisualStyleBackColor = true;
            // 
            // rbModeTrueHd
            // 
            rbModeTrueHd.AutoSize = true;
            rbModeTrueHd.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeTrueHd.ForeColor = Color.White;
            rbModeTrueHd.Location = new Point(20, 68);
            rbModeTrueHd.Name = "rbModeTrueHd";
            rbModeTrueHd.Size = new Size(167, 21);
            rbModeTrueHd.TabIndex = 5;
            rbModeTrueHd.TabStop = true;
            rbModeTrueHd.Tag = "DOLBY DIGITAL";
            rbModeTrueHd.Text = "Dolby TrueHD + DSur";
            rbModeTrueHd.UseVisualStyleBackColor = true;
            // 
            // rbModeAuro3d
            // 
            rbModeAuro3d.AutoSize = true;
            rbModeAuro3d.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeAuro3d.ForeColor = Color.White;
            rbModeAuro3d.Location = new Point(20, 170);
            rbModeAuro3d.Name = "rbModeAuro3d";
            rbModeAuro3d.Size = new Size(111, 21);
            rbModeAuro3d.TabIndex = 4;
            rbModeAuro3d.TabStop = true;
            rbModeAuro3d.Tag = "AURO3D";
            rbModeAuro3d.Text = "Auro 2D / 3D";
            rbModeAuro3d.UseVisualStyleBackColor = true;
            rbModeAuro3d.Click += rbAudioMode_Click;
            // 
            // rbModeDtsx
            // 
            rbModeDtsx.AutoSize = true;
            rbModeDtsx.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeDtsx.ForeColor = Color.White;
            rbModeDtsx.Location = new Point(20, 271);
            rbModeDtsx.Name = "rbModeDtsx";
            rbModeDtsx.Size = new Size(116, 21);
            rbModeDtsx.TabIndex = 3;
            rbModeDtsx.TabStop = true;
            rbModeDtsx.Tag = "DTS SURROUND";
            rbModeDtsx.Text = "DTS Neural:X";
            rbModeDtsx.UseVisualStyleBackColor = true;
            rbModeDtsx.Click += rbAudioMode_Click;
            // 
            // rbModeDolby
            // 
            rbModeDolby.AutoSize = true;
            rbModeDolby.Font = new Font("Microsoft Sans Serif", 7.875F);
            rbModeDolby.ForeColor = Color.White;
            rbModeDolby.Location = new Point(20, 34);
            rbModeDolby.Name = "rbModeDolby";
            rbModeDolby.Size = new Size(128, 21);
            rbModeDolby.TabIndex = 2;
            rbModeDolby.TabStop = true;
            rbModeDolby.Tag = "DOLBY DIGITAL";
            rbModeDolby.Text = "Dolby Surround";
            rbModeDolby.UseVisualStyleBackColor = true;
            rbModeDolby.Click += rbAudioMode_Click;
            // 
            // pnlTabOverlay
            // 
            pnlTabOverlay.BorderStyle = BorderStyle.FixedSingle;
            pnlTabOverlay.Location = new Point(-1, 81);
            pnlTabOverlay.Margin = new Padding(2, 0, 2, 0);
            pnlTabOverlay.Name = "pnlTabOverlay";
            pnlTabOverlay.Size = new Size(663, 38);
            pnlTabOverlay.TabIndex = 70;
            // 
            // lblTabMain
            // 
            lblTabMain.BackColor = Color.SteelBlue;
            lblTabMain.BorderStyle = BorderStyle.FixedSingle;
            lblTabMain.Enabled = false;
            lblTabMain.ForeColor = Color.White;
            lblTabMain.Location = new Point(1, 89);
            lblTabMain.Margin = new Padding(2, 0, 2, 0);
            lblTabMain.Name = "lblTabMain";
            lblTabMain.Size = new Size(67, 30);
            lblTabMain.TabIndex = 71;
            lblTabMain.Text = "Main";
            lblTabMain.TextAlign = ContentAlignment.MiddleCenter;
            lblTabMain.Click += lblTabMain_Click;
            // 
            // lblTabSpeaker
            // 
            lblTabSpeaker.BackColor = Color.Gray;
            lblTabSpeaker.BorderStyle = BorderStyle.FixedSingle;
            lblTabSpeaker.Enabled = false;
            lblTabSpeaker.ForeColor = Color.White;
            lblTabSpeaker.Location = new Point(67, 89);
            lblTabSpeaker.Margin = new Padding(2, 0, 2, 0);
            lblTabSpeaker.Name = "lblTabSpeaker";
            lblTabSpeaker.Size = new Size(67, 30);
            lblTabSpeaker.TabIndex = 72;
            lblTabSpeaker.Text = "Speaker";
            lblTabSpeaker.TextAlign = ContentAlignment.MiddleCenter;
            lblTabSpeaker.Click += lblTabSpeaker_Click;
            // 
            // lbBottomOverlay
            // 
            lbBottomOverlay.Location = new Point(-1, 669);
            lbBottomOverlay.Margin = new Padding(2, 0, 2, 0);
            lbBottomOverlay.Name = "lbBottomOverlay";
            lbBottomOverlay.Size = new Size(669, 4);
            lbBottomOverlay.TabIndex = 73;
            // 
            // HorizontalLine
            // 
            HorizontalLine.BackColor = Color.DarkSlateGray;
            HorizontalLine.Location = new Point(1, 80);
            HorizontalLine.Margin = new Padding(4, 0, 4, 0);
            HorizontalLine.Name = "HorizontalLine";
            HorizontalLine.Size = new Size(667, 1);
            HorizontalLine.TabIndex = 9;
            // 
            // lblTabModes
            // 
            lblTabModes.BackColor = Color.Gray;
            lblTabModes.BorderStyle = BorderStyle.FixedSingle;
            lblTabModes.Enabled = false;
            lblTabModes.ForeColor = Color.White;
            lblTabModes.Location = new Point(133, 89);
            lblTabModes.Margin = new Padding(2, 0, 2, 0);
            lblTabModes.Name = "lblTabModes";
            lblTabModes.Size = new Size(67, 30);
            lblTabModes.TabIndex = 74;
            lblTabModes.Text = "Modes";
            lblTabModes.TextAlign = ContentAlignment.MiddleCenter;
            lblTabModes.Click += lblTabModes_Click;
            // 
            // AVRControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(659, 761);
            Controls.Add(lbBottomOverlay);
            Controls.Add(lblTabSpeaker);
            Controls.Add(lblTabModes);
            Controls.Add(lblTabMain);
            Controls.Add(pnlTabOverlay);
            Controls.Add(tabControl1);
            Controls.Add(btnInstall);
            Controls.Add(cbSysTray);
            Controls.Add(lbConnectStatus);
            Controls.Add(btnSave);
            Controls.Add(tbIP);
            Controls.Add(lblIP);
            Controls.Add(HorizontalLine);
            Controls.Add(CopyrightNote);
            Controls.Add(InfoNote);
            Controls.Add(PowerToggle);
            Controls.Add(LabelPowerToggle);
            Controls.Add(LogoPicture);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "AVRControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AVRControl";
            WindowState = FormWindowState.Minimized;
            Activated += AVRControl_Activated;
            FormClosing += MainForm_FormClosing;
            Load += AVRControl_Load;
            Resize += AVRControl_Resize;
            cmsTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            tabControl1.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabMain.PerformLayout();
            pnlProgressBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAlbumArt).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHeosPlayRepeatOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHeosPlayRepeatAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHeosPlayShuffle).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHeosPlayBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHeosPlaySkip).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHeosPlayPause).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnToggleMute).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVolDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVolUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)SliderVolume).EndInit();
            tabSpeaker.ResumeLayout(false);
            tabSpeaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerSubMaster).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerSubwoofer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerSubwoofer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerSurroundR).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerSurroundL).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerFrontR).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerCenter).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeakerFrontL).EndInit();
            tabModes.ResumeLayout(false);
            tabModes.PerformLayout();
            grpDspModes.ResumeLayout(false);
            grpDspModes.PerformLayout();
            grpPuristModes.ResumeLayout(false);
            grpPuristModes.PerformLayout();
            grpStandardModes.ResumeLayout(false);
            grpStandardModes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
        private TabPage tabMain;
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
        private TabPage tabSpeaker;
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
        private TabPage tabModes;
        private System.Windows.Forms.Label lblTabModes;
        private GroupBox grpStandardModes;
        private GroupBox grpPuristModes;
        private System.Windows.Forms.Label lblCurrentAudioMode;
        private RadioButton rbModeStereo;
        private RadioButton rbModeDtsx;
        private RadioButton rbModeDolby;
        private RadioButton rbModeMultiChStereo;
        private RadioButton rbModePureDirect;
        private RadioButton rbModeDirect;
        private GroupBox grpDspModes;
        private RadioButton rbModeJazzClub;
        private RadioButton rbModeVirtual;
        private RadioButton rbModeMatrix;
        private RadioButton rbModeRockArena;
        private RadioButton rbModeMono;
        private RadioButton rbModeAuro3d;
        private RadioButton rbModeMultiChIn;
        private RadioButton rbModeGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrentSourceAudio;
        private RadioButton rbModeTrueHd;
        private RadioButton rbModeAtmos;
        private RadioButton rbModeDtsHd;
        private RadioButton rbModeDolbyDigitalPlus;
        private RadioButton rbModeDtsxNative;
    }
}

