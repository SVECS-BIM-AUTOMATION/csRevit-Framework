# Security & Data Privacy Manifest

The csRevit Framework is built from the ground up to meet the rigorous security protocols required by global Architecture, Engineering, and Construction (AEC) enterprise IT environments. 

Because csRevit operates as a native, decoupled C# microkernel that dynamically manages user interfaces and executes commands, we maintain absolute transparency regarding code execution and data handling.

---

## 🛡️ Data Privacy & Zero-Exfiltration Guarantee
* **No Project Data Harvesting:** The csRevit Framework **never** reads, stores, tracks, or exfiltrates proprietary Autodesk Revit project models (`.rvt`), family files (`.rfa`), or geometry design data.
* **No Cloud-Side Code Caching:** Your organization's proprietary automation logic (compiled C# binaries and scripts) remains completely within your own designated network infrastructure or company-controlled secure cloud storage. 
* **Minimal Telemetry:** The framework only communicates with our central license authentication server (`appstore.svecs.in`) to validate cryptographic license keys and verify core framework updates. No user behavioral data or design metadata is tracked.

## ⚙️ Secure Dynamic Execution Environment
* **Native C# Architecture:** Built entirely on the native .NET ecosystem, csRevit interacts directly with the Autodesk Revit API. It loads compiled, high-performance C# code efficiently without the security vulnerabilities or overhead associated with unverified runtime script interpretations.
* **Local Caching for Offline Resilience:** To prevent workflow disruptions due to network instability, csRevit securely caches framework UI layouts locally. If an internet or local network share disconnect occurs, the user's active Revit ribbon remains fully intact and stable.
* **EDR & Antivirus Compatibility:** The `csRevit Installer` executable releases are compiled using industry-standard methods to minimize false-positive flags from aggressive enterprise Endpoint Detection and Response (EDR) systems like Windows Defender, CrowdStrike, or SentinelOne.

## 🛟 Reporting Vulnerabilities
If you are an enterprise IT administrator or security researcher and discover a potential security issue within the core framework infrastructure, please do not open a public report. 

Please contact our security response team directly and confidentially:
📩 **Email:** [support@svecs.in](mailto:support@svecs.in)

We prioritize corporate security inquiries and will respond with an initial assessment within 24–48 business hours.
