# AVRControl

A lightweight C# Windows Forms tool for basic Telnet control of Denon and Marantz AVRs.

![screenshot](Screenshot.png)

## Overview
AVRControl is a portable application designed for quick and easy control of your AV Receiver directly from your Windows desktop.
No installation required.

### Features
*   *Permanent Telnet Connection:* Real-time status updates and basic controls.
*   *HEOS Support:* Automatically establishes a permanent HEOS telnet connection when a network stream is active.
*   *Source Naming:* Uses an XML Parser to fetch the "Friendly Name" of the current input source.
*   *Portable:* Run it from any folder. Settings are stored in a local AVRControl.cfg.
*   *Compatibility:* Successfully tested on *Windows 11 24H2*.

## Requirements
*   *Operating System:* Windows 10 / 11.
*   *AVR Settings:* You *must* enable "Network Control / IP Control" on your AVR:
    *   Setup -> Network -> Network Control -> Set to "ON" or "Always On".
*   *Network:* Your PC and AVR must be in the same network.

## How to use
1.  Download the latest build from the [Releases] tab.
2.  Start AVRControl.exe.
3.  Enter the *IP Address* of your AVR.
4.  Click *Save*.
5.  The tool connects automatically and saves your IP in AVRControl.cfg.

<hr>
CHANGELOG:

🚀 **AVRControl v1.1.0 – The Architecture Update**
This release marks a major milestone in system stability, modular design, and user flexibility.

💡 **Deployment Options & Flexibility**

- **Portable Mode:** Run the app directly from any folder. Perfect for users who prefer to pin the app to the Taskbar or manage their own custom Autostart entries. In this mode, the Systray option can be toggled on or off freely.
- **Installation Mode:** Use the built-in "Install" feature to automatically set up AVRControl in your Roaming directory with a Windows Autostart entry. Note: To ensure seamless background operation, the Systray mode is permanently enabled and locked when installed.

✨ **New Features**

- **Enhanced Tray Menu:** New context menu featuring a direct link to the GitHub project page, a dedicated "Show/Hide" toggle, and modernized icons.
- **Smart Config System:** Migrated to a key-value based configuration (AVRControl.cfg). Settings like IP and Systray status are now stored securely with specific identifiers.
- **Robust XML Parsing:** Friendly name retrieval (e.g., "PlayStation") is now asynchronous. Built-in timeouts and fallbacks prevent crashes during AVR reboots or firmware updates.

🛠️ **Technical Improvements**

- **Modular Architecture:** Fully transitioned to Partial Classes. Logic is now separated into specialized modules (Parser, Toggles, Setup, Helpers), significantly improving maintainability.
- **Zero-Dependency Release:** The GitHub update system now uses native string parsing. The application requires no external DLLs and remains a clean, single EXE file.
- **Optimized State Management:** Separated connection status (Port Check) from actual Power Status (Telnet feedback) to prevent false UI indications.

🐛 **Bugfixes**

- Fixed: "Connection Refused" exception handled for port 8080 during AVR boot cycles.
- Fixed: Initializing issue where isRunningFromRoaming failed to detect the installation status in partial classes.
- Fixed: Eliminated UI flickering and redundant config write-access through improved focus checks.

## License
This project is licensed under the GPU V3 License. See the LICENSE file for details.
This means you are free to use, modify, and distribute the software, provided that the original copyright notice is included.

---
Created for personal needs – I hope you find it useful!

cya
SAMDestroy
