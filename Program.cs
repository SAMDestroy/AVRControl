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
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AVRControl
{
    static class Program
    {
        private static Mutex mutex = new Mutex(true, "{AVRControl-9B2E-4D1C-8F1A}");

        [DllImport("shell32.dll", SetLastError = true)]
        static extern void SetCurrentProcessExplicitAppUserModelID([MarshalAs(UnmanagedType.LPWStr)] string AppID);

        [STAThread]
        static void Main()
        {
            if (!mutex.WaitOne(TimeSpan.FromSeconds(3), true))
            {
                MessageBox.Show("AVRControl already running...", "Info");
                return;
            }

            SetCurrentProcessExplicitAppUserModelID("SAMDestroy.AVRControl.Main");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AVRControl());
            GC.KeepAlive(mutex);
        }
    }
}
