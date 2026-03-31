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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AVRControl
{
    public partial class AVRControl : Form
    {
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
                            pbAlbumArt.SizeMode = PictureBoxSizeMode.Zoom;
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
                string state = ExtractJsonValue(json, "state").Trim().ToLower();

                string curPosStr = ExtractJsonValue(json, "cur_pos");
                string durationStr = ExtractJsonValue(json, "duration");

                int sid = 0;
                int.TryParse(sidStr, out sid);

                if (!timerProgress.Enabled && state != "pause")
                {
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
                            pnlProgressBar.Width = 0;
                            _localCurPos = curPos;
                        }

                        if (Math.Abs(_localCurPos - curPos) > 2000)
                        {
                            _localCurPos = curPos;
                        }

                        double percent = (double)_localCurPos / _maxDuration;
                        pnlProgressBar.Width = (int)(pnlProgressBack.ClientRectangle.Width * Math.Min(percent, 1.0));

                        lblTime.Text = $"{FormatTime(_localCurPos)} / {FormatTime(_maxDuration)}";

                        if (state == "play" && IsAVROn)
                        {
                            if (!timerProgress.Enabled) timerProgress.Start();
                        }
                        else
                        {
                            timerProgress.Stop();
                        }
                    }

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
                await _heosTelnet.SendAsync("heos://player/get_players");
                return;
            }

            string command = $"heos://player/get_now_playing_media?pid={_activePid}";
            await _heosTelnet.SendAsync(command);
        }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
