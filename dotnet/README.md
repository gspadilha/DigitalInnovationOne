# Aplicação ASP .NET (com Entity Framework)

## Passo a Passo no Linux
1. dotnet new mvc

1. dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

1. dotnet add package Microsoft.EntityFrameworkCore

1. dotnet add package Microsoft.EntityFrameworkCore.Tools

1. dotnet add package Microsoft.EntityFrameworkCore.Sqlite

1. dotnet add package Microsoft.EntityFrameworkCore.Sqlite.Design

1. dotnet tool install --global dotnet-ef

1. dotnet ef migrations add InitialCreate 

1. dotnet ef database update

1. dotnet tool install -g dotnet-aspnet-codegenerator

1. dotnet aspnet-codegenerator --project "/home/gspadilha/Desktop/DEV/NET/WebApplication" controller --force --controllerName ProdutosController --model WebApplication.Models.Produtos --dataContext WebApplication.Data.ApplicationDbContext --relativeFolderPath Controllers --controllerNamespace WebApplication.Controllers
