# Contract Monthly Claim System (CMCS)

## 📌 Project Overview
The **Contract Monthly Claim System (CMCS)** is a .NET Core application designed to streamline the process of submitting, verifying, and approving monthly claims for Independent Contractor (IC) lecturers.  
The system provides role-based dashboards for **Lecturers**, **Programme Coordinators**, and **Academic Managers**, ensuring transparency, accountability, and efficiency in claim management.

This project forms part of the **PROG6212 Portfolio of Evidence (POE)** assessment.

---

## 🚀 Features (Prototype Stage)
- **Lecturer Dashboard**
  - Submit new claims (hours worked, hourly rate, notes).
  - Upload supporting documents (PDF, DOCX, XLSX).
  - View claim history with status tracking.

- **Programme Coordinator Dashboard**
  - Review and verify pending claims.
  - Approve or reject claims with feedback.
  - Search and filter claims for efficiency.

- **Academic Manager Dashboard**
  - Access consolidated claim summaries across programmes.
  - Generate reports and statistics (approved vs rejected claims).
  - Oversight of all claims in the system.

---

## 🗄️ Database Design
The database is structured around the following key entities:
- **Lecturer**
- **Claim**
- **Document**
- **User**
- ****

A UML class diagram has been created to model relationships between entities.

---

## 🎨 GUI / UI Design
The GUI has been designed as a **prototype** using ASP.NET Core MVC.  
It is not yet fully functional, but the front-end layout demonstrates:
- A clean and consistent design.
- Responsive interfaces accessible across desktop and mobile devices.
- Colour-coded actions (green = approve, red = reject).
- Tooltips and user guidance for accessibility.

---

## 🛠️ Technology Stack
- **Framework:** .NET Core MVC / WPF (prototype stage)  
- **Language:** C#  
- **Database:** SQL Server (planned)  
- **Version Control:** GitHub  

---

## 📂 Repository Structure
