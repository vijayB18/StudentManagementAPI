# 🎓 Student Management System API

A full-featured backend API built using **ASP.NET Core Web API** with **JWT Authentication**, **SQLite Database**, and **Layered Architecture**.

---

## 🚀 Features

* ✅ CRUD Operations (Create, Read, Update, Delete Students)
* 🔐 JWT Authentication (Secure APIs)
* 🧱 Layered Architecture (Controller, Service, Repository)
* 🗄️ SQLite Database (No external setup required)
* 📘 Swagger UI for API testing
* ⚠️ Error handling and clean responses

---

## 🛠️ Tech Stack

* ASP.NET Core Web API (.NET 10)
* Entity Framework Core
* SQLite
* JWT Authentication
* Swagger (Swashbuckle)

---

## 📂 Project Structure

```
StudentManagementAPI/
│
├── Controllers/
│   ├── StudentController.cs
│   └── AuthController.cs
│
├── Services/
├── Repositories/
├── Models/
├── Data/
├── Middleware/
│
├── Program.cs
├── appsettings.json
└── README.md
```

---

## ⚙️ Setup Instructions

### 1️⃣ Clone Repository

```
git clone <your-repo-link>
cd StudentManagementAPI
```

---

### 2️⃣ Install Dependencies

```
dotnet restore
```

---

### 3️⃣ Run Database Migration

```
dotnet-ef migrations add InitialCreate
dotnet-ef database update
```

---

### 4️⃣ Run Application

```
dotnet run
```

---

### 5️⃣ Open Swagger

```
http://localhost:5126/swagger
```

---

## 🔐 Authentication (JWT)

### 🔑 Login API

```
POST /api/Auth/login
```

### Request Body

```json
{
  "username": "admin",
  "password": "1234"
}
```

### Response

```json
{
  "token": "your-jwt-token"
}
```

---

### 🔒 Using Token

1. Click **Authorize 🔒** in Swagger
2. Enter:

```
Bearer your-jwt-token
```

3. Access secured APIs

---

## API Endpoints

### Student APIs (Protected)

| Method | Endpoint          | Description      |
| ------ | ----------------- | ---------------- |
| GET    | /api/Student      | Get all students |
| POST   | /api/Student      | Add student      |
| PUT    | /api/Student      | Update student   |
| DELETE | /api/Student/{id} | Delete student   |

---

## Sample Student JSON

```json
{
  "name": "Vijay",
  "email": "vijay@test.com",
  "age": 22,
  "course": "CSE"
}
```

---

## Key Highlights

* Clean and scalable architecture
* Secure API endpoints using JWT
* Easy database setup using SQLite
* Ready for production-level enhancements

---

## Submission

* GitHub Repository Link: `<your-repo-link>`
* Includes working APIs, JWT security, and documentation

---

## 🙌 Author

Vijay

---
