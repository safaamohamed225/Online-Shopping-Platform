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
<br/>
## 🛒 Overview

**Cartify** is a modern, full-featured e-commerce web application built with **ASP.NET Core**, designed to provide a seamless online shopping experience. The platform supports a wide range of products including electronics, clothing, and more, with a focus on performance, scalability, and user experience.

### ✨ Key Features

- **🛍️ Complete Shopping Experience**: Browse products, add to cart, and complete purchases
- **👥 User Management**: Secure authentication with role-based access control
- **🔧 Admin Dashboard**: Comprehensive management interface for products, orders, and users
- **📱 Responsive Design**: Optimized for desktop, tablet, and mobile devices
- **☁️ Cloud-Ready**: Deployed and optimized for Azure Cloud platform
- **🏗️ Clean Architecture**: Built with industry best practices and design patterns

## 🚀 Live Demo

🌐 **[View Live Application](https://cartify-demo.azurewebsites.net)**

*Demo Credentials:*
- **Admin**: admin@cartify.com / Admin123!
- **Customer**: demo@cartify.com / Demo123!

## 📋 Table of Contents

- [Features](#-features)
- [Technology Stack](#-technology-stack)
- [Architecture](#-architecture)
- [Getting Started](#-getting-started)
- [Installation](#-installation)
- [Configuration](#-configuration)
- [Usage](#-usage)
- [API Documentation](#-api-documentation)
- [Deployment](#-deployment)
- [Contributing](#-contributing)
- [License](#-license)

## 🎯 Features

### Customer Features
- **Product Catalog**: Browse and search through categorized products
- **Product Details**: Detailed product information with images and specifications
- **Shopping Cart**: Add, remove, and manage items in cart
- **User Accounts**: Registration, login, and profile management
- **Order Management**: Place orders and track order history
- **Wishlist**: Save favorite products for later
- **Reviews & Ratings**: Rate and review purchased products

### Admin Features
- **Dashboard**: Overview of sales, orders, and system metrics
- **Product Management**: CRUD operations for products and categories
- **Order Management**: Process and track customer orders
- **User Management**: Manage customer accounts and permissions
- **Inventory Control**: Track stock levels and manage product availability
- **Reports**: Generate sales and performance reports

### Technical Features
- **Secure Authentication**: JWT-based authentication with role authorization
- **Data Validation**: Comprehensive input validation and error handling
- **Search & Filtering**: Advanced product search and filtering capabilities
- **Performance Optimization**: Caching, lazy loading, and database optimization
- **Responsive UI**: Mobile-first design with Bootstrap integration

## 🛠️ Technology Stack

### Backend
- **Framework**: ASP.NET Core 8.0
- **Language**: C# 12
- **Database**: SQL Server / Azure SQL Database
- **ORM**: Entity Framework Core
- **Authentication**: ASP.NET Core Identity + JWT
- **API**: RESTful Web API

### Frontend
- **Framework**: ASP.NET Core MVC / Razor Pages
- **Styling**: Bootstrap 5, Custom CSS
- **JavaScript**: jQuery, AJAX
- **Icons**: Font Awesome
- **Charts**: Chart.js (for admin dashboard)

### Cloud & DevOps
- **Hosting**: Microsoft Azure (App Service)
- **Database**: Azure SQL Database
- **Storage**: Azure Blob Storage (for images)
- **CI/CD**: Azure DevOps / GitHub Actions
- **Monitoring**: Application Insights

### Tools & Libraries
- **Email Service**: SendGrid / SMTP
- **Payment Processing**: Stripe / PayPal (configurable)
- **Image Processing**: ImageSharp
- **Logging**: Serilog
- **Testing**: xUnit, Moq

## 🏗️ Architecture

Cartify follows **Clean Architecture** principles with clear separation of concerns:

```
📁 Cartify.Solution/
├── 📁 Cartify.Web/              # Presentation Layer (MVC)
├── 📁 Cartify.API/              # Web API Layer
├── 📁 Cartify.Application/      # Application Layer (Business Logic)
├── 📁 Cartify.Domain/           # Domain Layer (Entities, Interfaces)
├── 📁 Cartify.Infrastructure/   # Infrastructure Layer (Data Access)
├── 📁 Cartify.Shared/           # Shared Components
└── 📁 Cartify.Tests/            # Unit & Integration Tests
```

### Design Patterns Used
- **Repository Pattern**: Data access abstraction
- **Unit of Work**: Transaction management
- **Dependency Injection**: Loose coupling and testability
- **CQRS**: Command Query Responsibility Segregation
- **Specification Pattern**: Query logic encapsulation

## 🚀 Getting Started

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/)

### Quick Start
```bash
# Clone the repository
git clone https://github.com/safaamohamed225/cartify.git

# Navigate to project directory
cd cartify

# Restore dependencies
dotnet restore

# Update database
dotnet ef database update

# Run the application
dotnet run --project Cartify.Web
```

## 📦 Installation

### 1. Clone the Repository
```bash
git clone https://github.com/safaamohamed225/cartify.git
cd cartify
```

### 2. Install Dependencies
```bash
dotnet restore
```

### 3. Configure Database
Update the connection string in `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CartifyDB;Trusted_Connection=true;MultipleActiveResultSets=true"
  }
}
```

### 4. Apply Migrations
```bash
dotnet ef database update --project Cartify.Infrastructure --startup-project Cartify.Web
```

### 5. Seed Initial Data
```bash
dotnet run --project Cartify.Web --seed-data
```

### 6. Run the Application
```bash
dotnet run --project Cartify.Web
```

Navigate to `https://localhost:5001` to access the application.

## ⚙️ Configuration

### Environment Variables
Create an `appsettings.Development.json` file for local development:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Your_Database_Connection_String"
  },
  "JwtSettings": {
    "Secret": "Your_JWT_Secret_Key_Here",
    "Issuer": "Cartify",
    "Audience": "CartifyUsers",
    "ExpiryMinutes": 60
  },
  "EmailSettings": {
    "SmtpServer": "smtp.gmail.com",
    "SmtpPort": 587,
    "FromEmail": "noreply@cartify.com",
    "FromName": "Cartify",
    "Username": "your_email@gmail.com",
    "Password": "your_app_password"
  },
  "PaymentSettings": {
    "StripePublishableKey": "pk_test_...",
    "StripeSecretKey": "sk_test_..."
  }
}
```

### Azure Configuration
For production deployment, configure these settings in Azure App Service:
- `ConnectionStrings__DefaultConnection`
- `JwtSettings__Secret`
- `EmailSettings__Username`
- `EmailSettings__Password`
- `PaymentSettings__StripeSecretKey`

## 📖 Usage

### For Customers
1. **Registration**: Create a new account or sign in with existing credentials
2. **Shopping**: Browse products by category or use the search function
3. **Cart Management**: Add products to cart and proceed to checkout
4. **Order Tracking**: View order history and track current orders

### For Administrators
1. **Access Admin Panel**: Login with admin credentials and navigate to `/Admin`
2. **Manage Products**: Add, edit, or delete products and categories
3. **Process Orders**: View and update order statuses
4. **User Management**: Manage customer accounts and permissions
5. **Analytics**: View sales reports and system metrics

## 📚 API Documentation

### Authentication Endpoints
```http
POST /api/auth/login
POST /api/auth/register
POST /api/auth/refresh-token
```

### Product Endpoints
```http
GET /api/products
GET /api/products/{id}
POST /api/products
PUT /api/products/{id}
DELETE /api/products/{id}
```

### Order Endpoints
```http
GET /api/orders
GET /api/orders/{id}
POST /api/orders
PUT /api/orders/{id}/status
```

For complete API documentation, visit `/swagger` when running the application.

## 🚀 Deployment

### Azure Deployment

1. **Create Azure Resources**:
   ```bash
   az group create --name CartifyRG --location "East US"
   az sql server create --name cartify-sql-server --resource-group CartifyRG --location "East US" --admin-user cartifyadmin
   az sql db create --resource-group CartifyRG --server cartify-sql-server --name CartifyDB --service-objective S0
   az appservice plan create --name CartifyPlan --resource-group CartifyRG --sku B1
   az webapp create --resource-group CartifyRG --plan CartifyPlan --name cartify-app
   ```

2. **Configure Connection Strings**:
   ```bash
   az webapp config connection-string set --resource-group CartifyRG --name cartify-app --connection-string-type SQLAzure --settings DefaultConnection="Server=tcp:cartify-sql-server.database.windows.net;Database=CartifyDB;User ID=cartifyadmin;Password=YourPassword123!;Encrypt=true;Connection Timeout=30;"
   ```

3. **Deploy Application**:
   ```bash
   dotnet publish --configuration Release
   az webapp deploy --resource-group CartifyRG --name cartify-app --src-path ./bin/Release/net8.0/publish.zip
   ```

### Docker Deployment

1. **Build Docker Image**:
   ```bash
   docker build -t cartify .
   ```

2. **Run Container**:
   ```bash
   docker run -d -p 80:80 --name cartify-container cartify
   ```

## 🧪 Testing

Run the test suite:
```bash
# Run all tests
dotnet test

# Run with coverage
dotnet test --collect:"XPlat Code Coverage"

# Run specific test project
dotnet test Cartify.Tests.Unit
```

## 📈 Performance

- **Response Time**: Average API response time < 200ms
- **Database**: Optimized queries with proper indexing
- **Caching**: Redis caching for frequently accessed data
- **CDN**: Azure CDN for static assets
- **Monitoring**: Application Insights for performance tracking

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
