# Marvel's Characters

A .NET Core Web API that shows heroe's characters and their information, based on Interactive API Tester from Marvel

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 

### Prerequisites

The API requires these tools to run normally. 

* [.NET Core SDK 3.1.101](https://dotnet.microsoft.com/download/dotnet-core/3.1)
* [.NET EF Core 3.1.1](https://www.nuget.org/packages/dotnet-ef/3.1.1)
* [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) or [SQL Server Docker Container](https://hub.docker.com/_/microsoft-mssql-server)(Requires Docker)

### Prepare database

First of all, prepare and up the database for the API. The solution uses the Entity Framework Core Code Firts to prepare, inicializate and populate the database. 
**Important**: check the connection string in the *appsettings.json* and change to the correct instance if necessary. 

To up the database, run this command in project directory: 

```
dotnet ef database update -p .\MarvelCharacters.Data\MarvelsCharacters.Data.csproj -s .\MarvelCharacters.Api\MarvelsCharacters.Api.csproj
```

### Prepare solution

To prepare the solution, run these comands in project directory

```
dotnet restore
```

And...

```
dotnet build
```

### Run API

To run de API, execute this comand inside project directory:

```
dotnet run -p .\MarvelCharacters.Api\MarvelsCharacters.Api.csproj
```

### Run Tests

To run the tests from the project, execute this comand inside project directory:

```
dotnet test
```