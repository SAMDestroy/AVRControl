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

using System.Drawing.Drawing2D;

namespace AVRControl
{
    public partial class AVRControl
    {
        private void PrepareIcons()
        {
            var colorMap = new Dictionary<IndicatorType, Color>
            {
                { IndicatorType.Send, Color.LimeGreen },
                { IndicatorType.Receive, Color.Yellow },
                { IndicatorType.Status, Color.Orange },
                { IndicatorType.Error, Color.Red }
            };

            int size = 128;
            int dotSize = size / 3;
            int offset = (size - dotSize) / 2;

            foreach (var entry in colorMap)
            {
                using Bitmap bmp = new(size, size, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    g.DrawIcon(_appIcon, 0, 0);

                    using (SolidBrush brush = new(entry.Value))
                    {
                        g.FillEllipse(brush, offset, offset, dotSize, dotSize);
                    }

                    using Pen pen = new(Color.FromArgb(100, 0, 0, 0), 2);
                    g.DrawEllipse(pen, offset, offset, dotSize, dotSize);
                }

                IntPtr hIcon = bmp.GetHicon();
                _indicatorIcons[entry.Key] = (Icon)Icon.FromHandle(hIcon).Clone();
                DestroyIcon(hIcon);
            }

            _iconResetTimer = new System.Windows.Forms.Timer { Interval = 200 };
            _iconResetTimer.Tick += (s, e) =>
            {
                _iconResetTimer.Stop();
                if (notifyIcon1.Visible) notifyIcon1.Icon = _appIcon;
            };
        }
        public void FlashIcon(IndicatorType type)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => FlashIcon(type)));
                return;
            }

            if (!notifyIcon1.Visible) return;

            if (type == IndicatorType.Send)
            {
                _blockReceiveUntil = DateTime.Now.AddMilliseconds(600);
            }
            else if (type == IndicatorType.Receive)
            {
                if (DateTime.Now < _blockReceiveUntil) return;
            }

            if (_indicatorIcons.TryGetValue(type, out var icon))
            {
                notifyIcon1.Icon = _indicatorIcons[type];
                _iconResetTimer?.Stop();

                if (type != IndicatorType.Error)
                {
                    _iconResetTimer?.Start();
                }
            }
        }
        private void SyncAudioModeRadioButtons(string modeText)
        {
            RadioButton? targetButton = null;

            switch (modeText)
            {
                case "STEREO": targetButton = rbModeStereo; break;
                case "M CH STEREO":
                case "MULTI CH STEREO": targetButton = rbModeMultiChStereo; break;
                case "DOLBY AUDIO-DSUR":
                case "DOLBY DIGITAL":
                case "DOLBY SURROUND": targetButton = rbModeDolby; break;

                case "DOLBY AUDIO-TRUEHD+DSUR":
                case "DOLBY AUDIO-TRUE HD+DSUR":
                case "DOLBY TRUEHD+DSUR":
                case "TRUEHD+DSUR": targetButton = rbModeTrueHd; break;

                case "DOLBY AUDIO-DD+DSUR":
                case "DOLBY DIGITAL PLUS":
                case "DOLBY D+ +DSUR":
                case "DOLBY D+ +NEURAL:X":
                case "DOLBY AUDIO-DD+":
                case "DOLBY D+": targetButton = rbModeDolbyDigitalPlus; break;

                case "DOLBY ATMOS":
                case "DOLBY AUDIO-TRUEHD":
                case "DOLBY TRUEHD":
                case "TRUEHD": targetButton = rbModeAtmos; break;

                case "DTS HD MSTR":
                case "DTS SURROUND": targetButton = rbModeDtsHd; break;

                case "NEURAL:X":
                case "DTS NEURAL:X": targetButton = rbModeDtsx; break;

                case "DTS:X":
                case "DTS:X MSTR": targetButton = rbModeDtsxNative; break;

                case "AURO-3D":
                case "AURO3D":
                case "AURO2DSURR":
                case "AURO-2D": targetButton = rbModeAuro3d; break;

                case "GAME": targetButton = rbModeGame; break;
                case "MULTI CH IN": targetButton = rbModeMultiChIn; break;
                case "DIRECT": targetButton = rbModeDirect; break;
                case "PURE DIRECT": targetButton = rbModePureDirect; break;
                case "MONO": targetButton = rbModeMono; break;
                case "JAZZ CLUB": targetButton = rbModeJazzClub; break;
                case "ROCK ARENA": targetButton = rbModeRockArena; break;
                case "MATRIX": targetButton = rbModeMatrix; break;
                case "VIRTUAL": targetButton = rbModeVirtual; break;
                default: break;
            }

            if (targetButton != null && !targetButton.Checked)
            {
                grpStandardModes.SuspendLayout();
                grpPuristModes.SuspendLayout();
                grpDspModes.SuspendLayout();

                var audioModeBoxes = new List<GroupBox> { grpStandardModes, grpPuristModes, grpDspModes };
                foreach (GroupBox box in audioModeBoxes)
                {
                    foreach (Control ctrl in box.Controls)
                    {
                        if (ctrl is RadioButton rb && rb != targetButton && rb.Checked)
                        {
                            rb.Checked = false;
                        }
                    }
                }

                targetButton.Checked = true;

                grpStandardModes.ResumeLayout();
                grpPuristModes.ResumeLayout();
                grpDspModes.ResumeLayout();
            }
        }
        private void timerProgress_Tick(object? sender, EventArgs e)
        {
            if (!IsAVROn) { return; }

            if (_maxDuration > 0)
            {
                _localCurPos += timerProgress.Interval;

                if (_localCurPos <= _maxDuration)
                {
                    double percent = (double)_localCurPos / _maxDuration;
                    pnlProgressBar.Width = (int)(pnlProgressBack.ClientRectangle.Width * Math.Min(percent, 1.0));

                    lblTime.Text = $"{FormatTime(_localCurPos)} / {FormatTime(_maxDuration)}";
                }
            }
        }
        private void StopHeosTimeline()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(StopHeosTimeline));
                return;
            }

            _maxDuration = 0;
            _localCurPos = 0;
            timerProgress.Stop();
            pnlProgressBar.Width = 0;
            lblTime.Text = "00:00 / 00:00";
        }
        private void ResetTimelineImmediate()
        {
            _localCurPos = 0;
            _lastUserInteraction = DateTime.Now;

            if (this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pnlProgressBar.Width = 0;
                    lblTime.Text = "00:00 / 00:00";
                });
            }
        }
        private static string ExtractJsonValue(string data, string key)
        {
            if (string.IsNullOrEmpty(data) || string.IsNullOrEmpty(key)) return "";

            int start = -1;
            int end = -1;

            string patternJson = "\"" + key + "\"";
            int keyIdx = data.IndexOf(patternJson);
            if (keyIdx != -1)
            {
                int colonIdx = data.IndexOf(':', keyIdx + patternJson.Length);
                if (colonIdx != -1)
                {
                    start = colonIdx + 1;
                    while (start < data.Length && (data[start] == ' ' || data[start] == '\"')) start++;

                    end = data.IndexOfAny(['\"', ',', '}', '&'], start);
                }
            }

            if (start == -1)
            {
                string patternMsg = key + "=";
                int msgIdx = data.IndexOf(patternMsg);
                if (msgIdx != -1)
                {
                    start = msgIdx + patternMsg.Length;
                    end = data.IndexOfAny(['&', '\"', '}', ' '], start);
                }
            }

            if (start != -1)
            {
                if (end == -1) end = data.Length;
                string result = data[start..end].Trim();
                return result.Replace("\"", "");
            }

            return "";
        }
        private static string FormatTime(int ms)
        {
            TimeSpan t = TimeSpan.FromMilliseconds(ms);
            return string.Format("{0:D2}:{1:D2}", t.Minutes + (t.Hours * 60), t.Seconds);
        }
        private void UpdateSpeakerSlider(string data, int val)
        {
            if (data.Contains("CVC")) { tbSpeakerCenter.Value = val; lbSpeakerCenterShowValue.Text = GetDBString(val); }
            else if (data.Contains("CVSW2")) { tbSpeakerSubwoofer2.Value = val; lbSpeakerSubwoofer2ShowValue.Text = GetDBString(val); }
            else if (data.Contains("CVSW")) { tbSpeakerSubwoofer1.Value = val; lbSpeakerSubwoofer1ShowValue.Text = GetDBString(val); }
            else if (data.Contains("CVFL")) { tbSpeakerFrontL.Value = val; lbSpeakerFrontLShowValue.Text = GetDBString(val); }
            else if (data.Contains("CVFR")) { tbSpeakerFrontR.Value = val; lbSpeakerFrontRShowValue.Text = GetDBString(val); }
            else if (data.Contains("CVSL")) { tbSpeakerSurroundL.Value = val; lbSpeakerSurroundLShowValue.Text = GetDBString(val); }
            else if (data.Contains("CVSR")) { tbSpeakerSurroundR.Value = val; lbSpeakerSurroundRShowValue.Text = GetDBString(val); }
        }
        private static string GetDBString(int value)
        {
            double db = (value - 50) / 2.0;

            if (Math.Abs(db) < 0.01) db = 0.0;

            string sign = (db > 0) ? "+" : "";

            return sign + db.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture) + " dB";
        }
    }
}