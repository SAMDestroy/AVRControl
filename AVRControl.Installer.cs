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
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVRControl
{
    public partial class AVRControl : Form
    {
        private void RefreshInstallState()
        {
            string registryPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

            bool fileExistsInRoaming = System.IO.File.Exists(roamingPath);
            bool registryEntryExists = false;

            currentConfigPath = ConfigManager.GetConfigPath(roamingPath, isRunningFromRoaming);

            isRunningFromRoaming = Application.ExecutablePath.Equals(roamingPath, StringComparison.OrdinalIgnoreCase);

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath, false))
            {
                if (key != null)
                {
                    registryEntryExists = key.GetValue("AVRControl") != null;
                }
            }

            bool isInstalled = fileExistsInRoaming && registryEntryExists;

            if (isRunningFromRoaming)
            {
                btnInstall.Text = "Uninstall";
                cbSysTray.Checked = true;
                cbSysTray.Enabled = false;
            }
            else if (isInstalled)
            {
                btnInstall.Text = "Update";
                cbSysTray.Enabled = true;
            }
            else
            {
                btnInstall.Text = "Install";
                cbSysTray.Enabled = true;
            }

            CheckForGitHubUpdate();

            // Titel dynamisch setzen
            string mode = isRunningFromRoaming ? "[Installed]" : "[Portable]";
            this.Text = $"AVRControl v{Application.ProductVersion} {mode}";
        }

        // Github Update Part
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        private async Task<Version> GetGitHubVersionAsync()
        {
            string url = "https://api.github.com/repos/SAMDestroy/AVRControl/releases/latest";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "AVRControl-App");

                    string json = await client.GetStringAsync(url);
                    string searchPattern = "\"tag_name\":\"";
                    int startIndex = json.IndexOf(searchPattern);

                    if (startIndex != -1)
                    {
                        startIndex += searchPattern.Length;
                        int endIndex = json.IndexOf("\"", startIndex);

                        if (endIndex != -1)
                        {
                            string tagName = json.Substring(startIndex, endIndex - startIndex);
                            return new Version(tagName.Replace("v", ""));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("GitHub Check Error: " + ex.Message);
            }

            return null;
        }
        private async void CheckForGitHubUpdate()
        {
            Version githubVersion = await GetGitHubVersionAsync();
            Version localVersion = new Version(Application.ProductVersion);
            //Version localVersion = new Version("0.0.1"); // lokal test

            if (githubVersion != null && githubVersion > localVersion)
            {
                btnInstall.Text = "GitUpdate";
                btnInstall.BackColor = Color.Gold;
            }
        }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
