# Che Gato - E-Commerce y Gestión de Inventario 🐱

Plataforma de comercio electrónico de marca blanca (White-label) desarrollada con arquitectura limpia y multiplataforma.

## 🏗️ Arquitectura del Proyecto
La solución está dividida en dos proyectos principales:
* **`CheGato.Api`**: Backend desarrollado en ASP.NET Core con Entity Framework Core. Expone los endpoints (REST) y gestiona la conexión con la base de datos SQL Server.
* **`CheGato.App`**: Aplicación cliente multiplataforma desarrollada con .NET MAUI (iOS, Android, MacCatalyst, Windows). 

## 🚀 Tecnologías
* **Framework:** .NET 8 / .NET 10
* **Frontend:** .NET MAUI (XAML/C#)
* **Backend:** ASP.NET Core Web API
* **Base de Datos:** SQL Server (Entity Framework Core - Code First)

## ⚙️ Configuración Inicial
Para correr el proyecto localmente por primera vez, es necesario aplicar las migraciones a la base de datos:
1. Abrir la solución en Visual Studio.
2. Abrir la **Consola del Administrador de paquetes** (Package Manager Console).
3. Seleccionar `CheGato.Api` como proyecto predeterminado.
4. Ejecutar el comando para crear la tabla de productos:
