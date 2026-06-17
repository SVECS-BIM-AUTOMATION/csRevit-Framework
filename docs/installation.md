# 🚀 Getting Started & Installation Guide

Welcome to the csRevit Framework. [cite_start]Follow these steps to set up your master environment and local clients. [cite: 1]

## 1. Prerequisites
* Autodesk Revit 2019 through 2026 installed natively.
* [cite_start]Active read/write credentials to the corporate central deployment target drive (e.g., `Z:\BIM\csRevit_Master`). [cite: 3]
* [cite_start]A valid License Key or Trial Key from [the SVECS Appstore](https://appstore.svecs.in). [cite: 5]

## 2. Installing the Bootstrapper Engine
1. Secure the executable deployment pack (`csRevit_Installer.exe`) from the management dashboard or app portal.
2. Run the installer. The bootstrapper engine drops runtime binaries directly into the user application data directory:
   [cite_start]`C:\Users\%USERNAME%\AppData\Roaming\Autodesk\ApplicationPlugins\csRevit.bundle` [cite: 8]

## 3. Configuration & Dynamic Synchronization
1. Launch Autodesk Revit. Paste either the 15-Day Free Trial Key or Commercial License Key into the secure validation panel.
2. [cite_start]Navigate to the newly generated `csRevit Core` tab on the ribbon, click **Global Settings** (Gear Icon). [cite: 4]
3. [cite_start]Link the **Master Network Path** field directly to the shared network storage folder (e.g., `Z:\BIM\csRevit_Master`). [cite: 3]
4. [cite_start]Go to the csRevit Core tab and click the large **Sync Tools** button. [cite: 6] [cite_start]The framework will build your ribbon layout instantly mid-session without restarting Revit! [cite: 2, 36, 40]
