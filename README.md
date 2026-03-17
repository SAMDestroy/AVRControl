# AVRControl

A lightweight C# Windows Forms tool for basic Telnet control of Denon and Marantz AVRs.
Tested on Denon X4500H with 5.1 Audyssey Setup

![screenshot](Screenshot1.png)
![screenshot](Screenshot2.png)

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


🚀 **AVRControl v1.2.0 – The Audio Precision Update**
This release introduces advanced speaker calibration tools and a high-resilience network engine for seamless control.


✨ **New Features**

- **Advanced Speaker Control:** A dedicated new tab for real-time channel level adjustments (Channel Volume Offset), mirroring the precision of the original web interface.
- **Master Subwoofer Slider:** Control both subwoofers simultaneously with the Master Slider. It features a smart Delta Protection system that preserves your custom level ratio between Sub 1 and Sub 2 while moving.
- **One-Click Speaker Reset:** A new global "Reset" button that instantly returns all speaker offsets to a neutral 0.0 dB state with a synchronized hardware refresh.
- **Authentic DB Display:** All speaker labels feature high-precision dB readouts, including the characteristic "+" and "-" prefixes (e.g., +1.5 dB) for a true AVR feel.


🛠️ **Technical Improvements**

- **Standby Resilience:** Completely overhauled the TCP Watchdog. The app now survives standby and hibernate cycles, performing a silent "Self-Healing" reconnect upon wake-up.
- **Smart Command Throttling:** Implemented a hardware-safe 50ms/100ms throttle for all sliders. This prevents network buffer overflows and ensures smooth, lag-free communication with the AVR.
- **Flicker-Free UI:** Introduced a new state-locking mechanism (isScrolling) that prevents sliders from "jumping" or "jittering" while the user is actively making adjustments.
- **Optimized Power Management:** Integrated an intelligent UI-Gate that automatically switches the app back to the Main Tab when the AVR is powered off, ensuring a clean state for the next session.


🐛 **Bugfixes**

- **Fixed:** Resolved the "Disappearing Icon" issue where the app icon would vanish from the taskbar after a Windows standby/resume cycle.
- **Fixed:** Improved Telnet parser stability to handle fragmented multi-line responses during high-traffic status updates.
- **Fixed:** Corrected the "Subwoofer EL" command syntax specifically for X-Series models to ensure 100% command acceptance.

**Developer Note:**
The new Speaker Control operates on the Channel Volume (CV) level. This allows for safe, temporary adjustments during playback without overwriting your permanent Audyssey room calibration.


## License
This project is licensed under the GPU V3 License. See the LICENSE file for details.
This means you are free to use, modify, and distribute the software, provided that the original copyright notice is included.

---
Created for personal needs – I hope you find it useful!

cya
SAMDestroy
