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
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace AVRControl
{
    public partial class AVRControl : Form
    {
        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (!IsAVROn) { timerProgress.Stop(); return; }

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
            // _isMusicPlaying = false;
            _maxDuration = 0;
            _localCurPos = 0;

            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate {
                    timerProgress.Stop();
                    pnlProgressBar.Width = 0;
                    lblTime.Text = "00:00 / 00:00";
                });
            }
        }

        private void ResetTimelineImmediate()
        {
            _localCurPos = 0;
            _lastUserInteraction = DateTime.Now;

            if (this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate {
                    pnlProgressBar.Width = 0;
                    lblTime.Text = "00:00 / 00:00";
                });
            }
        }

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
        private string GetDBString(int value)
        {
            double db = (value - 50) / 2.0;

            if (Math.Abs(db) < 0.01) db = 0.0;

            string sign = (db > 0) ? "+" : "";

            return sign + db.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture) + " dB";
        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}