# AVRControl

A lightweight C# Windows Forms tool for basic Telnet control of Denon and Marantz AVRs.
Tested on Denon X4500H with 5.1 Audyssey Setup

<img src="Screenshot1.png" width="525" alt="AVRControl Main-Page">
<img src="Screenshot2.png" width="525" alt="AVRControl Speaker-Page">
<img src="Screenshot3.png" width="525" alt="AVRControl Modes-Page">

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

🚀 **AVRControl v1.7.0.0 – Dynamic Feedback Update**
* This release introduces a dynamic system tray notification system providing immediate visual feedback for network communication and device status.
* Further optimizations have been applied to the communication protocol and internal resource management to reduce overhead.

✨ **New Features**

* **Dynamic Tray Activity Indicators:** Implementation of a color-coded notification system within the system tray icon. A visual indicator (dot) signals active data transmission (Send/Receive), status changes, or connection errors.
* **Context-Aware Visual States:**
	* **LimeGreen:** Command transmission (Outgoing).
	* **DeepSkyBlue:** Data reception/confirmation (Incoming).
	* **Orange:** Status or track information change (HEOS/System).
	* **Red:** Persistent connection error or Watchdog timeout.
* **Automatic Echo Suppression:** Integrated logic to suppress redundant visual "flickering" caused by immediate command-response cycles.

🛠️ **Technical Improvements**

* **Optimized XML Queries:** Reduced the frequency and volume of XML device information requests to minimize network traffic and receiver processing load.
* **High-Resolution Icon Rendering:** Tray indicators are now dynamically rendered at runtime from 128x128 32-bit master assets, ensuring crisp visual clarity across different Windows scaling factors (DPI).
* **Refined Audio Mode Mappings:** Minor adjustments to the internal sound mode logic for improved compatibility with varying AVR firmware versions.
* **UI/Cosmetic Adjustments:** Refined alignment of control elements and minor color corrections for better interface consistency.

🐛 **Bugfixes**

* **Fixed:** Resolved several minor logic bugs within the Telnet parser and UI event handlers.
* **Fixed:** Improved thread-safe handling of background updates to prevent occasional UI synchronization issues.
* **Fixed:** Eliminated potential GDI object leaks during rapid icon state transitions.

**Developer Note:**

* Version 1.7.0.0 focuses on granular resource management and real-time feedback. The dynamic tray icon system was implemented using a **GDI+ Icon Factory pattern**, generating variants of the master resource in RAM during initialization to avoid disk I/O and CPU spikes during runtime. 
* To ensure long-term stability, specific **Win32 API (user32.dll)** calls were integrated to explicitly manage icon handles (DestroyIcon), preventing GDI handle exhaustion common in high-frequency UI updates.
* Leveraging the **.NET 10 SDK**, adopted modern C# 12/13 features like **Collection Expressions []** and strict **Nullable Reference Type** handling. This ensures a modern, type-safe codebase while maintaining the project's philosophy of explicit, readable, and maintainable open-source code over excessive abstraction.

**License**

This project is licensed under the GPL V3 License. See the LICENSE file for details.
This means you are free to use, modify, and distribute the software, provided that the original copyright notice is included.

Created for personal needs – I hope you find it useful!
cya
SAMDestroy