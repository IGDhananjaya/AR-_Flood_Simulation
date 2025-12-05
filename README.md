# AR Flood Simulation: Nakhon Phanom Case Study

![Unity](https://img.shields.io/badge/Engine-Unity-black?style=flat&logo=unity)
![Platform](https://img.shields.io/badge/Platform-Android-green?style=flat&logo=android)
![AR](https://img.shields.io/badge/AR-Vuforia-orange)
![Status](https://img.shields.io/badge/Status-Completed-success)

**AR Flood Simulation** is an Android-based Augmented Reality application designed to visualize flood risks based on rainfall intensity. The simulation focuses on a factory area in **Nakhon Phanom, Thailand**, providing a real-time, interactive 3D visualization of water levels rising and spreading across the terrain.

[cite_start]This project was developed as a "Proyek Independen Mahasiswa" (Student Independent Project) at **Universitas Pendidikan Ganesha**, in collaboration with **King Mongkut's University of Technology Thonburi (KMUTT)**, Thailand[cite: 1, 12, 33].

## 📖 Table of Contents
- [About the Project](#-about-the-project)
- [Features](#-features)
- [Tech Stack](#-tech-stack)
- [Rainfall Categories](#-rainfall-categories)
- [Installation & Usage](#-installation--usage)
- [Screenshots](#-screenshots)
- [Team](#-team)

## ℹ️ About the Project
Flooding is a complex challenge in urban areas, often caused by high rainfall exceeding drainage capacity. [cite_start]Static flood maps are often difficult for the general public to interpret[cite: 28, 30]. 

This application aims to:
1. Visualize flood potential interactively using AR.
2. Provide concrete educational media regarding the impact of rainfall on the environment.
3. Support disaster mitigation awareness.

[cite_start]The app simulates the overflow of the Mekong river and drainage systems around a specific factory site in Nakhon Phanom based on user-selected rainfall data[cite: 32].

## 🌟 Features
* **Marker-Based Tracking:** Uses Vuforia to detect a specific map marker of the factory area[.
* [cite_start]**Interactive UI:** Clean interface with 'Scan AR', 'Guide', and 'About' menus.
* **Rainfall Simulation Selector:** Users can choose between 4 intensity levels:
    * Light
    * Medium
    * Heavy
    * [cite_start]Very Heavy[cite: 469].
* [cite_start]**Real-time 3D Animation:** Visualizes rain effects and rising water levels (puddles to severe flooding) overlaid on the physical map[cite: 365, 420].

## 🛠 Tech Stack
* [cite_start]**Engine:** Unity[cite: 190].
* [cite_start]**AR SDK:** Vuforia Qualcomm (Target Management System)[cite: 211].
* [cite_start]**3D Modeling:** Blender (for environment and water animation)[cite: 204].
* [cite_start]**Debugging:** RenderDoc (for graphics debugging)[cite: 198].
* [cite_start]**Development Method:** MDLC (Multimedia Development Life Cycle)[cite: 223].

## 🌧 Rainfall Categories
[cite_start]The simulation logic is based on the following rainfall data[cite: 323]:

| Category | Intensity (mm/6 hours) | Intensity (mm/day) | Risk Level |
| :--- | :--- | :--- | :--- |
| **Light** | < 7.5 | < 10 | Low risk, minimal impact |
| **Medium** | 7.5 - 35 | 10 - 50 | Potential puddles in low areas |
| **Heavy** | 35 - 70 | 50 - 100 | Urban flooding likely |
| **Very Heavy** | > 70 | > 100 | Severe flood risk, evacuation needed |

## 📲 Installation & Usage
### Prerequisites
* [cite_start]Android Device with **Android 10 (API Level 29)** or higher[cite: 351].
* [cite_start]Minimum RAM: 4GB[cite: 567].
* Rear Camera functioning.

### Steps
1.  [cite_start]Download the `.apk` file from the [Releases Section](#) (or use the drive link provided in documentation [cite: 506]).
2.  Install the application on your Android device.
3.  [cite_start]**Print or Display the Marker:** You need the specific satellite map image of the Nakhon Pathom factory (found in `Assets/Marker` or the images folder of this repo)[cite: 372].
4.  [cite_start]Open the App and tap **"Scan AR"**[cite: 343].
5.  Point your camera at the marker until the 3D terrain appears.
6.  Select a rainfall button to see the flood simulation.

> [cite_start]**Demo Video:** Watch the application in action [here](https://youtu.be/qeHYk8OmlG8)[cite: 511].

## 📸 Screenshots
*(Place your screenshots here, e.g., Main Menu, AR View, Flood Levels)*
<img src="ImageGithub/HomePage.jpeg" width="250"> <img src="ImageGithub/MainPage.jpeg" width="250"> 

## 👥 Team
**Universitas Pendidikan Ganesha (Software Engineering Technology)**
* [cite_start]**I Gede Dhananjaya** (Developer: Unity Implementation, MDLC Logic) [cite: 7, 354]
* [cite_start]**Luh Ayu Febriasih** (Assets: 3D Modeling, Data Collection) [cite: 8, 354]

**Supervisors**
* Dr. Ni Wayan Marti, S.Kom., M.Kom.
* [cite_start]Dr. Ni Ketut Kertiasih, S.Si., M.Pd.[cite: 100, 101].

---
*This project is part of the Student Independent Project (PIM) 2025.*
