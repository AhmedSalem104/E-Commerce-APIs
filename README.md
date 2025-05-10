# 🛍️ E-Commerce APIs

This is a layered architecture .NET project that provides RESTful APIs for an e-commerce platform. It is designed with scalability and modularity in mind using Clean Architecture principles.

## 📁 Project Structure

```
E-Commerce-APIs/
├── Core/               # Contains business entities and interfaces
├── Infrastructure/     # Contains database and external service implementations
├── Services/           # Contains business logic and application services
├── Shared/             # Contains shared utilities and helpers
├── E-Commerce-APIs.Api/      # API layer with Controllers and Endpoints
└── E-Commerce-APIs.sln       # Visual Studio solution file
```
## 🧱 Architecture

This project follows the **Layered Architecture** (also known as **Three-Tier Architecture**) and is influenced by **Clean Architecture** principles.

### Layers:

1. **Core Layer**
   - Contains domain entities and interfaces.
   - Independent of any external technologies or frameworks.
   - Represents the core business logic.

2. **Infrastructure Layer**
   - Provides implementations for data access (e.g., repositories using Entity Framework).
   - Implements interfaces defined in the Core layer.
   - Responsible for interacting with the database and external systems.

3. **Services Layer**
   - Contains application services and business logic orchestration.
   - Acts as a bridge between the API and Core logic.

4. **API Layer (Presentation Layer)**
   - Contains the controllers and API endpoints.
   - Handles HTTP requests and returns appropriate responses.
   - Depends on the Services layer to execute business rules.

### Benefits:
- Clear **separation of concerns** between layers.
- Promotes **testability**, **scalability**, and **maintainability**.
- Follows **Dependency Inversion Principle (DIP)** where upper layers depend on abstractions, not concrete implementations.

## 📦 Features

- User registration and authentication
- Product catalog (CRUD)
- Category management
- Shopping cart API
- Order processing

## 📌 Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Clean Architecture Pattern
- Repository & Unit of Work Pattern

