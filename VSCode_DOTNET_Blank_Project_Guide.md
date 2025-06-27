# 📘 .NET Development with VS Code: Step-by-Step Guide

## Task 01: Create Solution and Projects

To create a blank solution named `LoremIpsum` and add three projects (`LoremIpsum.API`, `LoremIpsum.Infrastructure`, and `LoremIpsum.Domain`), follow these steps:

### Step-by-Step:

1. **Launch VS Code** and open the desired directory.
2. **Open the integrated terminal** with `Ctrl + \``.
3. **Create a blank solution**:
   ```bash
   dotnet new sln -n LoremIpsum
   ```
4. **Create a Web API project**:
   ```bash
   dotnet new webapi -n LoremIpsum.API
   ```
5. **Add API project to solution**:
   ```bash
   dotnet sln add ./path/to/LoremIpsum.API/LoremIpsum.API.csproj
   ```
6. **Create a class library for Infrastructure**:
   ```bash
   dotnet new classlib -n LoremIpsum.Infrastructure
   ```
7. **Add Infrastructure to solution**:
   ```bash
   dotnet sln add ./path/to/LoremIpsum.Infrastructure/LoremIpsum.Infrastructure.csproj
   ```
8. **Create a class library for Domain**:
   ```bash
   dotnet new classlib -n LoremIpsum.Domain
   ```
9. **Add Domain to solution**:
   ```bash
   dotnet sln add ./path/to/LoremIpsum.Domain/LoremIpsum.Domain.csproj
   ```

---

## Task 02: Adding Project Reference

1. Navigate to `LoremIpsum.Infrastructure`:
   ```bash
   dotnet add reference ../LoremIpsum.Domain/LoremIpsum.Domain.csproj
   ```
2. Navigate to `LoremIpsum.API`:
   ```bash
   dotnet add reference ../LoremIpsum.Infrastructure/LoremIpsum.Infrastructure.csproj
   ```

### To remove a reference:
```bash
dotnet remove reference ./path/to/project.csproj
```

---

## Task 03: Installing NuGet Packages

1. Navigate to `LoremIpsum.Domain` directory.
2. Install Entity Framework Core:
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore
   ```
3. Install EF Core Relational:
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore.Relational -version 8.0.1
   ```

### To remove a package:
```bash
dotnet remove package <PackageName>
```

---

## Task 04: Build Solution and Run Project

1. From the solution root:
   ```bash
   dotnet build
   ```
2. To run `LoremIpsum.API`:
   ```bash
   cd LoremIpsum.API
   dotnet run
   ```

### To stop:
Press `Ctrl + C`.

---

## Task 05: Run Multiple Projects

Assume another project `LoremIpsum.ExternalAPI` is added.

1. Install `concurrently`:
   ```bash
   npm install concurrently --force
   ```
2. Run both projects:
   ```bash
   concurrently "dotnet run --project LoremIpsum.API/LoremIpsum.API.csproj" "dotnet run --project LoremIpsum.ExternalAPI/LoremIpsum.ExternalAPI.csproj"
   ```

### If security error occurs in PowerShell:
```bash
Set-ExecutionPolicy RemoteSigned -Scope CurrentUser
```

---

## Task 06: Debug Project

1. Open VS Code at `LoremIpsum.API`.
2. Set breakpoints in `Program.cs` using F9 or gutter click.
3. Click “Run and Debug” → Select “C#”.
4. Choose `LoremIpsum.API [http]` as configuration.
5. Click “Run and Debug”.

---

**Source: [Medium Article](https://medium.com/@contact.angonchy/how-to-use-vscode-for-net-application-bbeb8f2d9feb)**
