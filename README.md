# 📘 Laboratorio 1: `personapi-dotnet`

 Arquitectura Monolítica con MVC y DAO

---

## 📌 Descripción

`personapi-dotnet` es una aplicación web monolítica desarrollada con ASP.NET Core MVC y Entity Framework Core.  
Implementa una API REST y una interfaz con vistas Razor para la gestión de personas, profesiones, teléfonos y estudios.  
El proyecto sigue el patrón **MVC con arquitectura en capas (DAO)**, usando SQL Server como base de datos relacional.

---

## 🧰 Stack utilizado

| Componente       | Versión / Tecnología                  |
|------------------|----------------------------------------|
| Framework        | .NET 6.0 (sin autenticación, sin HTTPS)|
| Lenguaje         | C#                                     |
| DBMS             | SQL Server 2019 Express                |
| ORM              | Entity Framework Core 6.0             |
| Frontend         | Razor Views (MVC tradicional)         |
| API              | REST con Swagger 3                     |
| IDE              | Visual Studio Community 2022          |

---

## ⚙️ Configuración del ambiente

### 1. Clona el repositorio:

   git clone https://github.com/tu_usuario/personapi-dotnet.git
   cd personapi-dotnet
### 2. Instalar dependencias del entorno
- [SQL Server 2019 Express](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)
- [SQL Server Management Studio 18](https://learn.microsoft.com/es-es/sql/ssms/download-sql-server-management-studio-ssms)
- [Visual Studio Community 2022](https://visualstudio.microsoft.com/es/vs/community/)
> Durante la instalación de Visual Studio, selecciona los siguientes componentes:

- ✅ Desarrollo ASP.NET y web  
- ✅ Almacenamiento y procesamiento de datos  
- ✅ Plantillas de proyecto y elementos de .NET Framework  
- ✅ Características avanzadas de ASP.NET  
---

### 🧱 3. Crear la base de datos

- **Nombre:** `persona_db`  
- **Propietario:** `sa`  
- **Instrucción:** Ejecuta el script `script.sql` incluido en el repositorio (contiene DDL + DML).

---

### 🔗 4. Configurar cadena de conexión

Edita el archivo `appsettings.json` y reemplaza la cadena de conexión:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=persona_db;Trusted_Connection=True;TrustServerCertificate=True"
}
```

## 🛠️ Compilación y ejecución

### ▶️ Ejecutar el proyecto en local

1. Abre el archivo `personapi-dotnet.sln` en Visual Studio 2022
2. Verifica que la cadena de conexión esté correctamente configurada en `appsettings.json`
3. Pulsa `Ctrl + F5` para iniciar sin depuración
4. El navegador se abrirá automáticamente con la URL: http://localhost:[Número de puerto]/


---

## 🚀 Acceso a funcionalidades

Puedes acceder a las funcionalidades del sistema a través de las siguientes rutas:

### 🌐 API REST (Swagger)

- `/swagger` → Documentación interactiva de la API REST (GET, POST, PUT, DELETE)

### 🖥️ Interfaz web (Razor Views)

- `/PersonaRepo` → Gestión visual de personas
- `/TelefonoRepo` → Gestión visual de teléfonos
- `/ProfesionRepo` → Gestión visual de profesiones
- `/EstudiosRepo` → Gestión visual de estudios

> También puedes probar los endpoints de la API usando [Postman](https://www.postman.com/) si lo deseas.

