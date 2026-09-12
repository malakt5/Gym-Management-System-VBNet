# Gym Management System — VB.NET

## 📌 Project Overview

This project is a **VB.NET event-driven application** designed to manage the activities and operations of a gym.

The application provides a graphical user interface that allows a manager to manage **subscribers, staff members, sports activities, schedules, memberships, and payments**.

The project was developed as part of the **Event-Driven Programming (PEVEN)** course during the 2025–2026 academic year.

## 🚀 Features

### 👥 Subscriber Management

* Add new subscribers
* Modify subscriber information
* Delete subscribers
* Search for subscribers using different criteria
* Display subscriber information in a `DataGridView`
* Store subscriber data in a text file

### 👨‍💼 Staff Management

* Add, modify, and delete staff members
* Manage positions such as coach, nutritionist, receptionist, and technician
* Store personal and professional information
* Save data to a text file

### 🏋️ Sports Activity Management

* Add new sports activities
* Modify and delete activities
* Define activity category, type, level, and intensity
* Manage activity duration
* Display activities using a `DataGridView`

### 📅 Schedule Management

* Create and modify training schedules
* Associate coaches with activities
* Select the date, time, and room
* Validate coach information before creating a schedule
* Save schedules to a text file

### 💳 Membership & Payment Management

* Manage subscription types
* Define subscription start and end dates
* Track payment status
* Add, modify, and delete payment records
* Save payment information to a text file

## 🖥️ User Interface

The application is organized into multiple forms:

| Form  | Main Function                      |
| ----- | ---------------------------------- |
| Form1 | Main dashboard and navigation      |
| Form2 | Subscriber search and consultation |
| Form3 | Subscriber management              |
| Form4 | Staff management                   |
| Form5 | Sports activity management         |
| Form6 | Schedule management                |
| Form7 | Membership and payment management  |

The main dashboard provides general indicators such as the number of active subscribers, monthly revenue, and the number of courses scheduled for the day.

## 🛠️ Technologies & Concepts

* **VB.NET**
* Event-Driven Programming
* Graphical User Interfaces (GUI)
* Windows Forms
* `TextBox`
* `ComboBox`
* `DateTimePicker`
* `DataGridView`
* `MenuStrip`
* Data Validation
* CRUD Operations
* File Handling
* User Input Management

## 💾 Data Persistence

The application stores its information in text files to ensure data persistence and traceability.

Examples include:

```text
abonnés.txt
membre.txt
activités.txt
plannings.txt
paiements.txt
```

The application provides update/save functionality for each management module.

## 🎯 Academic Objective

The main objective of this project was to apply **event-driven programming concepts** to the development of a practical management application.

The project provided practical experience in:

* Designing graphical user interfaces
* Handling user interactions and events
* Validating input data
* Implementing CRUD operations
* Managing multiple application forms
* Reading and writing data to files

## 👩‍💻 Authors

**Malak Touibi**
**Chahd Sami**

Event-Driven Programming (PEVEN) — ISG Tunis
