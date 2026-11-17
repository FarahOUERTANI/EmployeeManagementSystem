# 👥 EmployeeManagementSystem

A web application for managing a company's **employees**: add, view, edit and delete staff records. It is built with **ASP.NET MVC 5** on the .NET Framework and **Entity Framework 6** (code-first) with SQL Server.

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?logo=dotnet&logoColor=white)
![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-5.2-5C2D91)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-6.5-6DB33F)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.2-7952B3?logo=bootstrap&logoColor=white)

---

## 📖 Overview

EmployeeManagementSystem is a classic **CRUD application** following the **Model-View-Controller** pattern. Employee data is stored in a SQL Server database created by **Entity Framework 6 Code-First Migrations**, and the pages are rendered with Razor and styled with Bootstrap 5.

## ✨ Features

- 📋 **List** all employees in a table
- ➕ **Add** a new employee
- 🔍 **View** an employee's details
- ✏️ **Edit** an employee
- 🗑️ **Delete** an employee, with a confirmation page
- 🛡️ Anti-forgery tokens and `[Bind]` whitelisting to prevent over-posting
- ✅ Client-side validation with jQuery Validation

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET MVC 5 (.NET Framework 4.7.2) |
| ORM | Entity Framework 6 (Code-First + Migrations) |
| Database | SQL Server LocalDB (`EmployeeDB`) |
| UI | Razor, Bootstrap 5, jQuery |
| Server | IIS Express |

> GitHub shows this repository as *JavaScript* only because of the bundled jQuery and Bootstrap files. The application itself is written in **C#**.

## 🗂️ Project Structure

```
EmployeeManagementSystem/
├── App_Start/                 # Bundles, filters, routes
├── Controllers/
│   ├── EmployeesController.cs # CRUD actions
│   └── HomeController.cs      # Home / About / Contact
├── Migrations/                # InitialCreate + Configuration
├── Models/
│   ├── Employee.cs            # Employee entity
│   └── EmployeeContext.cs     # EF6 DbContext ("DefaultConnection")
├── Views/
│   ├── Employees/             # Index, Details, Create, Edit, Delete
│   └── Shared/_Layout.cshtml
├── Content/ & Scripts/        # Bootstrap, jQuery, site styles
└── Web.config                 # Connection string & settings
```

## 🧩 Data Model — `Employee`

| Field | Type | Description |
|---|---|---|
| `Id` | int | Primary key |
| `Name` | string | Full name |
| `Position` | string | Job title |
| `Department` | string | Department |
| `HireDate` | DateTime | Hire date (shown as "Hire Date") |
| `Salary` | double | Salary |

## 🚀 Getting Started

### Prerequisites
- Windows with **Visual Studio 2019/2022** and the *ASP.NET and web development* workload
- **.NET Framework 4.7.2** developer pack
- **SQL Server LocalDB** (installed with Visual Studio)

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/FarahOUERTANI/EmployeeManagementSystem.git
   ```
2. Open `EmployeeManagementSystem.sln` in Visual Studio.
3. Restore the NuGet packages: right-click the solution → **Restore NuGet Packages**.
4. Create the database. In **Tools → NuGet Package Manager → Package Manager Console**, run:
   ```powershell
   Update-Database
   ```
   This creates the `EmployeeDB` database on `(localdb)\MSSQLLocalDB`, as configured in `Web.config`.
5. Press **F5** to run with IIS Express, then go to **/Employees**.

## 🧭 Usage

| Action | URL |
|---|---|
| Employee list | `/Employees` |
| Add employee | `/Employees/Create` |
| Edit employee | `/Employees/Edit/{id}` |
| Details | `/Employees/Details/{id}` |
| Delete | `/Employees/Delete/{id}` |

## 🔮 Possible Improvements
- Add an *Employees* link to the navigation bar
- Search and filter by name or department
- Validation rules (required fields, positive salary)
- Use `decimal` instead of `double` for salary
- A `Department` table with a foreign key instead of free text

## 👩‍💻 Author

**Farah Ouertani** – [github.com/FarahOUERTANI](https://github.com/FarahOUERTANI)
