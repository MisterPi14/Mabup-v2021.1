# Mabup - Academic Task Manager

Mabup is a desktop application developed in C# with Windows Forms, designed to help students efficiently manage their academic tasks. The application allows for intuitive and personalized organization, scheduling, and tracking of school activities.

---

## General Purpose

The main objective of this application is to provide a comprehensive tool for managing academic tasks, allowing users to:

- Register users with an email account and password.
- Create, organize, and track academic tasks.
- Classify tasks by subject, difficulty, and due date.
- Manage schedules and deadlines.
- Estimate the time required for each task.

---

## Form Functionalities

### 1. `frmLogIn` – Login

**Purpose:** Main user authentication form.

**Functions:**

- Validates credentials against the database.
- Secure access to the system using a username and password.
- Redirects to the registration form for new users.
- Personalized welcome messages.
- Automatic transition to the main window after successful authentication.

![Login](https://media0.giphy.com/media/v1.Y2lkPTc5MGI3NjExaXl5MXM2Z3ZuYTNiajl0NDJrNnU2MDJrcDE3OW1xYmNyOW1mODdtMSZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/Zed5WMuOKCJVuehdKP/giphy.gif)

---

### 2. `frmRegistro` – User Registration

**Purpose:** Allows new users to register in the system.

**Functions:**

- Captures personal data (name, last names, email).
- Creates access credentials.
- Validates mandatory fields.
- Automatically generates a unique ID for each user.
- Securely inserts data into the database.
- Transitions to the personal estimated work time configuration for tasks.

![SignUp](https://media4.giphy.com/media/v1.Y2lkPTc5MGI3NjExaXN3ZnlvbDZicXk1NHNmaXZ5dGJyOWxmY3d5d2FkaHZ2ajFhOWRjeiZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/gFGJKkj8WPZP3tVPRk/giphy.gif)

---

### 3. `frmGestor_Tareas` – Main Task Manager

**Purpose:** Central interface for task management.

**Functions:**

- Displays pending tasks in an organized list.
- Access to the form for adding tasks.
- Option to mark tasks as completed (removing tasks from the list).
- Updates the personal estimated work time test for tasks.

![delete taks](https://media1.giphy.com/media/v1.Y2lkPTc5MGI3NjExdHRvY282NHZzd2QyN2FqN3pudDJlejg4NzZ1a2tlZ3VybjVtbXg2ayZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/1UH6bxI8WpSZ8TEd0J/giphy.gif)

---

### 4. `frmAgregar_Tarea` – Create New Tasks

**Purpose:** Form dedicated to the detailed registration of tasks.

**Functions:**

- Captures complete task information (title, date, time).
- Selects the subject.
- Classifies by difficulty level (scale 1–10).
- Defines specific topics by subject.
- Schedules the due date and time.
- Validates mandatory fields before saving.

![add tasks](https://media2.giphy.com/media/v1.Y2lkPTc5MGI3NjExanl0Z3Nubmx1NWhnc3dpdWg4ZTUzODlsd3RrZWRneTVkdHdxMDg2eiZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/ZjQGrz9PXogVi42Rr0/giphy.gif)

---

### 5. `frmGaleria_Video` – Video Gallery

**Purpose:** Provide access to audiovisual resources for academic support.

**Functions:**

- Displays educational videos related to the subjects.
- Browses and selects videos from the gallery.
- Integrated playback in the application.

![videoGallery](https://media3.giphy.com/media/v1.Y2lkPTc5MGI3NjExbXY5NDluemFoYzc1aXRveTd1a2dpa2UwNHY2YXNwdGVzbmdydDVzcyZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/j0LBR14si6jfH5NbjW/giphy.gif)

---

## Technical Characteristics

- **Framework:** .NET Framework 4.7.2  
- **Database:** Oracle 21c with integrated connection  
- **Interface:** Windows Forms with custom design  
- **Validations:** Input controls and error handling  
- **Navigation:** System of interconnected forms

  # System Requirements

- **.NET Framework 4.7.2 or higher**  
- **Oracle 21c** (Database: `BD_Mabup`)  
- **Visual Studio 2022** for development  
- **Windows 7 or higher**

---
# Installation and Configuration

To ensure the correct operation of Mabup, it is crucial to follow the installation and configuration steps below. This guide will walk you through preparing the environment, setting up the database, and compiling the project.

## 1. Prerequisites

Before you begin, make sure you have the following software installed:

- **.NET Framework 4.7.2**: This is the Microsoft execution environment on which the application is built. It provides the necessary libraries and components for Mabup's C# code to run correctly on Windows.

- **Oracle Database 21c**: This is the database management system where all the application's information, such as user profiles and tasks, will be stored. The project is specifically designed for this version.

- **Visual Studio 2022**: This is the Integrated Development Environment (IDE) that will be used to compile and run the application's source code.

## 2. Oracle Database Setup

The configuration of the database required for mabup is divided into two main phases, carried out using the provided SQL scripts.

### Step 2.1: Schema and User Creation

This project uses Oracle's multitenant architecture, which allows for multiple "Pluggable Databases" (PDBs) within a Container Database (CDB). For Mabup, the schema will be created in the default PDB, xepdb1.

1. Connect to your Oracle instance using a client like SQL Developer with a user that has administrative privileges, such as SYSTEM.
2. Execute the script `2025-07-16 MabupV1Schema(Oracle21c).sql`. This script automates the following administrative tasks:
   - Creates a Tablespace named `TBS_MABUPv1`, which is the disk space reserved for the application's data.
   - Creates the user `USR_MABUP` with the password `123456789` and assigns it to the newly created tablespace.
   - Defines the role `PROGRAMADOR`, which is granted the necessary permissions to create, modify, and interact with the database tables and procedures.
   - Assigns the `PROGRAMADOR` role to the `USR_MABUP` user, giving it all the privileges required for the application to function.

### Step 2.2: Table Creation and Data Loading

Once the base user and schema are ready, the data structure must be created.

1. Connect to the xepdb1 PDB with the `USR_MABUP` user you created in the previous step.
2. Execute the script `2025-07-16 MabupV1Tables-Data(Oracle21c).sql`. This script will:
   - Create the `tb_Usuarios` table to store profile information.
   - Create the `tb_Tareas` table to save all academic tasks.
   - Insert sample data into both tables so you can test the application immediately.

## 3. Project Configuration in Visual Studio

With the database ready, the next step is to configure the C# project to connect to it.

### Step 3.1: Oracle Client Installation (NuGet Package)

For the .NET application to communicate with the Oracle database, it needs a data provider. This project uses `Oracle.ManagedDataAccess`, a fully managed client distributed as a NuGet package, making it easy to install and manage.

1. Open the Mabup project in Visual Studio 2022.
2. Open the Package Manager Console: Go to the menu `Tools → NuGet Package Manager → Package Manager Console`.
3. Install the package: Type and run the following command:

```powershell
Install-Package Oracle.ManagedDataAccess
```
Visual Studio will automatically download and integrate the Oracle client into your project, adding the necessary libraries for the connection.

## 4. Compilation and Execution

Once all the previous steps are completed, you are ready to launch the application.

### Compile the project:
1. In Visual Studio, go to the `Build` menu
2. Select `Build Solution` (or press `Ctrl+Shift+B`)
3. This will:
   - Check that all the code is correct
   - Generate the executable file

### Run the application:
- Press the **Start** button (with the green play icon) in the Visual Studio toolbar
- Or press the `F5` key

> **Note**: If all steps were performed correctly, the login form (`frmLogIn`) will open, and you can start using Mabup.

## Usage Instructions

1. **Run** the application
2. **Register** as a new user or **log in**
3. **Use** the task manager to organize your academic work
4. **Add** tasks with specific details
5. **Mark** tasks as completed as you progress

---

**Developed by**: Edgar Diego Piña Vargas  
**Version**: 2021.1

