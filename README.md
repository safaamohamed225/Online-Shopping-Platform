# Cartify - Online Shopping Platform
[![.NET Core](https://img.shields.io/badge/.NET%20Core-8.0-512BD4?style=flat-square&logo=.net)](https://dotnet.microsoft.com/)
[![Azure](https://img.shields.io/badge/Azure-Deployed-0078D4?style=flat-square&logo=microsoft-azure)](https://azure.microsoft.com/)
[![MVC](https://img.shields.io/badge/ASP.NET-MVC-5C2D91?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/apps/aspnet/mvc)
[![Architecture](https://img.shields.io/badge/Architecture-N--Tier-orange?style=flat-square&logo=visualstudio)](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/)
[![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework-Core-512BD4?style=flat-square&logo=nuget)](https://learn.microsoft.com/en-us/ef/core/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-CC2927?style=flat-square&logo=microsoft-sql-server)](https://www.microsoft.com/en-us/sql-server)
[![License](https://img.shields.io/badge/License-MIT-green?style=flat-square)](LICENSE)
[![Build Status](https://img.shields.io/badge/Build-Passing-brightgreen?style=flat-square)](https://github.com/yourusername/cartify)

<img width="1536" height="1024" alt="dc661631-0f68-401e-baa3-620e7592836e" src="https://github.com/user-attachments/assets/d9a6673d-865d-4558-8e8c-26ef5d65f8ce" />

# 🛒 Overview
**Scalable E-commerce Platform with N-Tier Architecture**

**Cartify** is a modern, full-featured e-commerce web application built with **ASP.NET Core**, designed to provide a seamless online shopping experience. The platform supports a wide range of products including electronics, clothing, and more, with a focus on performance, scalability, and user experience.
# 🚀 Live Demo

🌐 **[View Live Application](https://cartify-demo.azurewebsites.net)**


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

## 🛠️ Tech Stack

**Backend:** ASP.NET Core MVC, Razor Pages, Entity Framework, LINQ, SQL Server  
**Frontend:** HTML5, CSS3, Bootstrap, jQuery  
**Architecture:** Repository Pattern, Unit of Work, Dependency Injection  
**Authentication:** Role-based Authorization System  
**Payment:** Stripe API Integration  
**Cloud:** Microsoft Azure

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
