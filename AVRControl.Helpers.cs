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
using System.Windows.Forms;

namespace AVRControl
{
    public partial class AVRControl : Form
    {
        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (!IsAVROn)
            {
                timerProgress.Stop();
                return;
            }

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

    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}