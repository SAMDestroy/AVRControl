# AVRControl

A lightweight C# Windows Forms tool for basic Telnet control of Denon and Marantz AVRs.
Tested on Denon X4500H with 5.1 Audyssey Setup

<img src="Screenshot1.png" width="525" alt="AVRControl Main-Page">
<img src="Screenshot2.png" width="525" alt="AVRControl Speaker-Page">

## Overview
AVRControl is a portable application designed for quick and easy control of your AV Receiver directly from your Windows desktop.
No installation required.

### Features
*   **Permanent Telnet Connection:** Real-time status updates and basic controls.
*   **HEOS Support:** Automatically establishes a permanent HEOS telnet connection when a network stream is active.
*   **Source Naming:** Uses an XML Parser to fetch the "Friendly Name" of the current input source.
*   **Portable:** Run it from any folder. Settings are stored in a local AVRControl.cfg.
*   **Compatibility:** Successfully tested on *Windows 11 24H2*.

## Requirements
*   **Operating System:** Windows 10 / 11.
*   **AVR Settings:** You *must* enable "Network Control / IP Control" on your AVR:
*   Setup -> Network -> Network Control -> Set to "ON" or "Always On".
*   **Network:** Your PC and AVR must be in the same network.

## How to use
1.  Download the latest build from the [Releases] tab.
2.  Start AVRControl.exe.
3.  Enter the *IP Address* of your AVR.
4.  Click *Save*.
5.  The tool connects automatically and saves your IP in AVRControl.cfg.

<hr>
Changelog

🚀 **AVRControl v1.5.1.0 – The .NET 9 Modernization Update**
* This major update marks the transition to **.NET 9**, bringing significant performance gains and a completely overhauled deployment system.
* Beyond the "Self-Healing UI," modernized app’s DNA to ensure it runs natively and flawlessly on the latest Windows hardware.

✨ **New Features**
* **Native ARM64 Support:** AVRControl now runs natively on ARM-based Windows devices (like the new Surface Pro or Snapdragon X Elite PCs).
No more emulation – just pure, efficient performance.
* **Universal Deployment Options:** Two ways to run AVRControl:
* **Standalone (Zero-Install):** Everything included. Runs even if .NET is not installed on your PC.
* **Lightweight (Framework-Dependent):** A tiny, ultra-optimized executable for users who already have the .NET 9 Runtime.
* **Self-Healing UI Architecture:** The playback interface now features "Instant-Recovery" logic. If the app wakes up from standby, it actively heals the timeline and metadata within milliseconds of reconnection.
Persistent Service Guardian: Correctly maintains source metadata (Spotify/TuneIn) instead of allowing the AVR to overwrite them with a generic "HEOS" label.

🛠️ **Technical Improvements**

**.NET 9 SDK Migration:**
* Fully migrated to the modern SDK-style project system.
* Removed legacy AssemblyInfo.cs dependencies and centralized all metadata, resulting in a cleaner, faster-compiling codebase.

**Robust Metadata Engine:**
* Re-engineered the versioning system. Update checks now use direct Assembly metadata instead of fragile string parsing, making the update process "bulletproof" against modern Git-revisioning.

**Optimized Single-File Packaging:**
* Implemented advanced compression for our standalone releases, reducing the footprint of the "all-inclusive" EXE by over 50% while maintaining lightning-fast start times.
* Asynchronous Telnet Core 2.0: Optimized with SemaphoreSlim and StringBuilder buffering to handle high-traffic TCP fragmentation without losing commands.

🐛 **Bugfixes**

* **Fixed:** Resolved a critical crash in the update-check engine caused by modern Git-commit metadata in the version string.
* **Fixed:** Eliminated the "Suicidal Timer" glitch where the engine would stop during network watchdog resets.
* **Fixed:** Improved TCP Framing to prevent misinterpreted HEOS JSON strings caused by fragmented network packets.
* **Fixed:** Cleaned up obsolete COM-references and legacy GUIDs for a more secure and modern application footprint.

**Developer Note:**

* v1.5.1.0 is not just an update; it's a foundation for the future. By moving to .NET 9 and adopting a native 64-bit/ARM64 architecture,
* AVRControl is now faster and more reliable than ever. Whether you're on a high-end workstation or a mobile ARM tablet, your AVR control remains rock solid.

**License**

This project is licensed under the GPL V3 License. See the LICENSE file for details.
This means you are free to use, modify, and distribute the software, provided that the original copyright notice is included.

Created for personal needs – I hope you find it useful!
cya
SAMDestroy