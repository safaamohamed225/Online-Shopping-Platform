# Cartify - Online Shopping Platform
## 🚀 Tech Stack

### 🔹 Backend
[![.NET Core](https://img.shields.io/badge/.NET%20Core-8.0-512BD4?style=flat-square&logo=.net)](https://dotnet.microsoft.com/)
[![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET-Core%20MVC-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/apps/aspnet/mvc)
[![Razor Pages](https://img.shields.io/badge/Razor-Pages-5C2D91?style=flat-square&logo=razor)](https://learn.microsoft.com/en-us/aspnet/core/razor-pages)
[![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework-Core-512BD4?style=flat-square&logo=nuget)](https://learn.microsoft.com/en-us/ef/core/)
[![LINQ](https://img.shields.io/badge/LINQ-Query-blue?style=flat-square&logo=dotnet)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-CC2927?style=flat-square&logo=microsoft-sql-server)](https://www.microsoft.com/en-us/sql-server)

### 🔹 Design Patterns & Architecture
[![Architecture](https://img.shields.io/badge/Architecture-N--Tier-orange?style=flat-square&logo=visualstudio)](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/)
[![Repository Pattern](https://img.shields.io/badge/Repository-Pattern-orange?style=flat-square&logo=github)](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design)
[![Unit of Work](https://img.shields.io/badge/Unit%20of%20Work-Pattern-lightgrey?style=flat-square&logo=dotnet)](https://martinfowler.com/eaaCatalog/unitOfWork.html)
[![Dependency Injection](https://img.shields.io/badge/Dependency-Injection-6DB33F?style=flat-square&logo=dependabot)](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)

### 🔹 Security
[![Authentication](https://img.shields.io/badge/User-Authentication-yellow?style=flat-square&logo=auth0)](https://learn.microsoft.com/en-us/aspnet/core/security/authentication)
[![Authorization](https://img.shields.io/badge/Role%20Based-Authorization-yellowgreen?style=flat-square&logo=lock)](https://learn.microsoft.com/en-us/aspnet/core/security/authorization/roles)
[![Stripe API](https://img.shields.io/badge/Stripe-API-626CD9?style=flat-square&logo=stripe)](https://stripe.com/)

### 🔹 Frontend
[![HTML5](https://img.shields.io/badge/HTML5-Frontend-E34F26?style=flat-square&logo=html5)](https://developer.mozilla.org/en-US/docs/Web/HTML)
[![CSS3](https://img.shields.io/badge/CSS3-Frontend-1572B6?style=flat-square&logo=css3)](https://developer.mozilla.org/en-US/docs/Web/CSS)
[![Bootstrap](https://img.shields.io/badge/Bootstrap-Framework-563D7C?style=flat-square&logo=bootstrap)](https://getbootstrap.com/)
[![jQuery](https://img.shields.io/badge/jQuery-Library-0769AD?style=flat-square&logo=jquery)](https://jquery.com/)

### 🔹 Cloud & Tools
[![Microsoft Azure](https://img.shields.io/badge/Microsoft-Azure%20Cloud-0078D4?style=flat-square&logo=microsoft-azure)](https://azure.microsoft.com/)
[![Azure](https://img.shields.io/badge/Azure-Deployed-0078D4?style=flat-square&logo=microsoft-azure)](https://azure.microsoft.com/)
[![Build Status](https://img.shields.io/badge/Build-Passing-brightgreen?style=flat-square)](https://github.com/yourusername/cartify)
[![License](https://img.shields.io/badge/License-MIT-green?style=flat-square)](LICENSE)



<img width="1536" height="1024" alt="dc661631-0f68-401e-baa3-620e7592836e" src="https://github.com/user-attachments/assets/d9a6673d-865d-4558-8e8c-26ef5d65f8ce" />

# 🛒 Overview
**Scalable E-commerce Platform with N-Tier Architecture**

**Cartify** is a modern, full-featured e-commerce web application built with **ASP.NET Core**, designed to provide a seamless online shopping experience. The platform supports a wide range of products including electronics, clothing, and more, with a focus on performance, scalability, and user experience.


## 🚀 Features

- **🛍️ Complete Shopping Experience**: Browse products, add to cart, and complete purchases
- **👥 User Management**: Secure authentication with role-based access control
- **🔧 Admin Dashboard**: Comprehensive management interface for products, orders, and users
- **📱 Responsive Design**: Optimized for desktop, tablet, and mobile devices
- **☁️ Cloud-Ready**: Deployed and optimized for Azure Cloud platform
- **🏗️ Clean Architecture**: Built with industry best practices and design patterns

### Customer Features
- Complete product catalog with browsing capabilities
- Shopping cart functionality with streamlined checkout
- Secure user authentication and account management
- Order management and tracking system

### Admin Features
- Comprehensive admin dashboard
- Inventory management system
- Order tracking and management
- User management with role-based access control

## 🏗️ Architecture

**N-Tier Architecture** with clean separation of concerns:

```
📁 Cartify/
├── 📁 Presentation Layer     # MVC Controllers & Razor Views
├── 📁 Business Logic Layer   # Service Classes & Business Rules
└── 📁 Data Access Layer      # Repository Pattern & Entity Framework
```

**Design Patterns:**
- Repository Pattern for data access abstraction
- Unit of Work for transaction management
- Dependency Injection for loose coupling and testability

## 🎯 Quick Start

### Prerequisites
- .NET SDK
- SQL Server
- Visual Studio or VS Code

### Setup
```bash
# Clone repository
git clone https://github.com/safaamohamed225/cartify.git
cd cartify

# Restore dependencies
dotnet restore

# Update database
dotnet ef database update

# Run application
dotnet run
```

Navigate to `https://localhost:5001`

## ⚙️ Configuration

Update `appsettings.json` with your settings:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CartifyDB;Trusted_Connection=true"
  },
  "Stripe": {
    "PublishableKey": "pk_test_your_key",
    "SecretKey": "sk_test_your_key"
  }
}
```

## 🔐 Authentication & Authorization

- **Role-based Access Control** separating customer and admin functionalities
- **Secure Authentication** system with user registration and login
- **Admin Dashboard** with restricted access for inventory and order management

## 💳 Payment Integration

- **Stripe API** integration for secure online payment processing
- Streamlined checkout process with real-time payment validation

## 🚀 Deployment

### Microsoft Azure
```bash
# Publish application
dotnet publish --configuration Release

# Deploy to Azure App Service
# Configure connection strings and Stripe keys in Azure portal
```

## 🧪 Testing

```bash
dotnet test
```

## 📝 Key Highlights

- **Scalable N-Tier Architecture** for maintainable and extensible code
- **Complete E-commerce Solution** with all essential shopping features  
- **Secure Payment Processing** through Stripe API integration
- **Role-based Security** ensuring proper access control
- **Cloud-Ready** deployment on Microsoft Azure

---
**Built with ASP.NET Core MVC & Clean Architecture Principles**


  ## 📄 License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
## 👤 Author

- Safaa Muhammad  
  - [GitHub](https://github.com/safaamohamed225)  
  - [LinkedIn](https://www.linkedin.com/in/safa-mohamed-dotnet/)  
## 🙏 Acknowledgments
This project was developed individually with the support of amazing open-source tools and frameworks:

## 🤝 Contributing

This project is currently developed and maintained individually.  
At the moment, external contributions are not open.  

However, feel free to open issues or start a discussion if you have suggestions or feedback.  

---

⭐ **Star this repository if you find it helpful!**

Developed with ❤️ by Safaa Muhammad
