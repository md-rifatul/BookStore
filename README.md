# 📚 BookStore Application

A simple **ASP.NET Core MVC CRUD application** for managing books.  
This project demonstrates **Clean Architecture principles** using **Repository & Service layers**, along with proper **error handling**.

---

## 🚀 Features
- Create, Read, Update, Delete (CRUD) operations for books
- Repository & Service layer implementation
- Exception handling with user-friendly error messages
- Entity Framework Core for data access
- ASP.NET MVC views with validation

---

## 🛠️ Technologies Used
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **C#**
- **SQL Server (LocalDB)**
- **Bootstrap / Razor Views**

---

## 📂 Project Structure

```text
BookStore/
 ┣ 📂 Controllers
 ┃ ┣ 📜 BookController.cs
 ┃ ┗ 📜 HomeController.cs
 ┣ 📂 Models
 ┃ ┣ 📜 Book.cs
 ┃ ┗ 📜 ErrorViewModel.cs
 ┣ 📂 Repositories
 ┃ ┣ 📂 IRepositories
 ┃ ┃ ┗ 📜 IBookRepository.cs
 ┃ ┗ 📜 BookRepository.cs
 ┣ 📂 Services
 ┃ ┣ 📂 IServices
 ┃ ┃ ┗ 📜 IBookService.cs
 ┃ ┗ 📜 BookService.cs
 ┣ 📂 Views
 ┃ ┣ 📂 Book
 ┃ ┃ ┣ 📜 Create.cshtml
 ┃ ┃ ┣ 📜 Edit.cshtml
 ┃ ┃ ┣ 📜 Delete.cshtml
 ┃ ┃ ┣ 📜 Details.cshtml
 ┃ ┃ ┗ 📜 Index.cshtml
 ┃ ┣ 📂 Home
 ┃ ┗ 📂 Shared
 ┣ 📂 Data
 ┣ 📂 Migrations
 ┣ 📜 Program.cs / Startup.cs
