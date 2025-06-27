# 📦 Domain vs Infrastructure in C# Projects

In C# projects that follow **Clean Architecture** or **Domain-Driven Design (DDD)**, two common project or folder names you'll see are `.Domain` and `.Infrastructure`.

These layers serve different purposes in a clean and maintainable architecture.

---

## 🔍 Summary of Differences

| Layer / Project        | Purpose                                                       | Contains                                         |
|------------------------|---------------------------------------------------------------|--------------------------------------------------|
| `MyApp.Domain`         | Core business logic and domain rules                          | Entities, value objects, interfaces, enums       |
| `MyApp.Infrastructure` | Technical implementation details (e.g., databases, file I/O) | EF Core, file access, API clients, cloud SDKs    |

---

## 📁 `.Domain` – The Core of Your Application

The **Domain layer** defines what your application is and what it does. It contains **pure business logic** and should be **independent of any technical frameworks**.

### ✅ Contains:
- Domain Entities (e.g., `User`, `Order`)
- Value Objects (e.g., `EmailAddress`, `Money`)
- Domain Services (business logic across entities)
- Interfaces / Contracts (e.g., `IUserRepository`, `INotificationService`)
- Business rules and validation logic

### 🔒 Purpose:
- Represents the core problem domain
- Enforces business rules
- Easy to unit test
- No dependencies on other layers or frameworks

---

## 📁 `.Infrastructure` – Technical Implementation

The **Infrastructure layer** contains the actual implementations of abstractions defined in `.Domain`.

### ✅ Contains:
- Entity Framework `DbContext` and Repositories
- File I/O implementations
- Email/SMS/Cloud integrations
- Logging and telemetry tools
- Caching mechanisms

### 🔧 Depends on:
- `.Domain` (but NOT the other way around)
- External libraries and frameworks

### 🔌 Purpose:
- Handles real-world concerns (databases, APIs, etc.)
- Implements interfaces defined in `.Domain`
- Can be swapped without changing business logic

---

## 🔁 Example Interaction

### In `.Domain`:

```csharp
public interface IUserRepository
{
    User? GetById(Guid id);
    void Add(User user);
}
```

### In `.Infrastructure`:

```csharp
public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public User? GetById(Guid id) => _context.Users.Find(id);
    public void Add(User user) => _context.Users.Add(user);
}
```

### In Startup (`Program.cs`):

```csharp
builder.Services.AddScoped<IUserRepository, UserRepository>();
```

---

## 🧠 TL;DR

- **Domain**: Clean, pure, framework-free business rules.
- **Infrastructure**: Real-world implementations using tools and frameworks.

This separation allows your core application logic to be **testable**, **maintainable**, and **framework-agnostic**.

---
