# Footwear Shop Inventory Management System (FSIMS)

## 📖 Overview
The **Footwear Shop Inventory Management System** is a software application designed to help footwear shop owners manage their shop's inventory, automate operations, and generate customer bills efficiently. This system digitizes the traditional pen-and-paper record-keeping methods, ensuring that records are maintained safely without physical degradation over time. 

## ✨ Features
* **Inventory Management**: Allows shop operators to add, edit, or delete product details.
* **Stock Tracking**: Operators can define the cost price, selling price, and the total number of units available in stock.
* **Automated Billing**: Processes customer purchases, automatically updates the inventory count upon a sale, and generates swift billing receipts.
* **Analytics & Reporting**: Generates detailed reports in a single click, providing insights on monthly profit/loss and total sold product counts. 
* **Role-Based Workflows**:
  * *Operator*: Has full access to log in, manage inventory, execute sales, and view analysis sections.
  * *Customer*: Receives generated bills for purchased items.
  * *Owner*: Receives high-level reports concerning product availability, date-specific sales, and profit details.

## 💻 Tech Stack
* **Language/Framework**: VB.NET utilizing Windows Forms
* **Runtime**: Microsoft .NET Core 6 (Long Term Support)
* **Database Management**: SQLite (embedded within the app) and Oracle Database 10g XE support
* **Operating System**: Windows 10 and above (Tested successfully on Windows 10 and 11)

## 🛠️ System Requirements
* **OS**: Windows 10 or Windows 11
* **RAM**: At least 15MB to 100MB of free RAM
* **Storage**: At least 15MB to 100MB of secondary storage space
* **Dependencies**: .NET Core 6 Runtime

## 📂 Repository Structure
This repository contains the full source code and the accompanying structural/design documents:
* `Source Code/`: Contains the VB.NET forms and core logic (e.g., `HomeForm.vb`, `FilterViewForm.vb`, `ProductForm.vb`).
* `Documentation/`: Includes the Software Requirements Specification (SRS) report and presentation.
* `Diagrams/`: Contains the project architecture schemas including:
  * **Entity-Relationship (ER) Diagram** (`ER.drawio`): Demonstrating DB relationships between Customers, Products, and Transactions.
  * **Data Flow Diagrams** (`DFD0.drawio`, `DFD1.drawio`): Level 0, Level 1, and Level 2 mapping data lifecycles in the app.

## 🚀 Future Enhancements
* Implementation of a multi-user distributed system.
* Graphical User Interface (GUI) improvements.
* Codebase optimization for enhanced performance.
* Connectivity to a centralized data center.

## 🎓 Academic Credentials & Acknowledgements
This project was submitted as a partial fulfillment for the award of the degree of **Bachelor of Computer Application (BCA) Final Year (2023-24)**.

* **Developer**: Atul Verma (Roll No: 4309)
* **Guide**: Dr. Varsha Thakur
* **Institution**: Government Nagarjuna Post Graduate College of Science, Raipur
* **University**: Pt. Ravishankar Shukla University Raipur (C.G.)