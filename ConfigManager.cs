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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AVRControl
{
    public static class ConfigManager
    {
        public static string GetConfigPath(string roamingPath, bool isRunningFromRoaming)
        {
            if (isRunningFromRoaming)
            {
                return Path.Combine(Path.GetDirectoryName(roamingPath), "AVRControl.cfg");
            }
            return Path.Combine(Application.StartupPath, "AVRControl.cfg");
        }

        public static string GetValue(string configPath, string key)
        {
            if (!File.Exists(configPath)) return null;

            string[] lines = File.ReadAllLines(configPath);
            foreach (string line in lines)
            {
                if (line.StartsWith(key + ":", StringComparison.OrdinalIgnoreCase))
                {
                    return line.Substring(key.Length + 1).Trim();
                }
            }
            return null;
        }

        public static void SaveValue(string configPath, string key, string value)
        {
            string dir = Path.GetDirectoryName(configPath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            List<string> lines = File.Exists(configPath)
                ? File.ReadAllLines(configPath).ToList()
                : new List<string>();

            bool found = false;
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith(key + ":", StringComparison.OrdinalIgnoreCase))
                {
                    lines[i] = $"{key}:{value}";
                    found = true;
                    break;
                }
            }

            if (!found) lines.Add($"{key}:{value}");

            File.WriteAllLines(configPath, lines);
        }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
