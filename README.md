# 📦 Sistema de Préstamos de Artículos
Este proyecto es una aplicación web diseñada para gestionar el préstamo y devolución de artículos dentro de una institución, permitiendo registrar empleados, clientes, artículos, préstamos y usuarios mediante una interfaz moderna y funcional.


 📑 Tabla de Contenidos
    Tecnologías

  Características

   Requisitos

   Instalación

  Ejecución

  Estructura del Proyecto


# 🚀 Tecnologías


# 🔧 Backend

ASP.NET Core 7.0

Entity Framework Core

SQL Server

# 🖥️ Frontend

HTML + CSS + JavaScript

Bootstrap 5.3

# ✅ Características


Gestión de Artículos (CRUD)

Gestión de Empleados (CRUD + creación de usuarios)

Gestión de Clientes (por implementar)

Gestión de Préstamos y Devoluciones (por implementar)

Control de acceso por roles (Administrador / Operador)

Buscadores y filtros en tablas

Interfaz unificada sin redirecciones

# 💻 Requisitos


Visual Studio 2022 
.NET SDK 7.0 o superior

SQL Server (local o en Azure)

Navegador Web moderno

Git instalado

## 🧩 Funcionalidades principales

- Gestión de Artículos (CRUD)
- Gestión de Empleados y asignación de Usuario
- Gestión de Clientes
- Gestión de Préstamos con historial y observaciones
- Login con roles: Administrador, Operador y Cliente
- Vistas independientes por rol
- Generación de reportes PDF y Excel
- Sistema Responsive basado en HTML + JS + CSS + Bootstrap
- Base de datos en SQL Server con relaciones integradas

---


## 📊 Reportes Generados

| Código | Requisito Funcional                  | Descripción                                                                 |

|--------|--------------------------------------|-----------------------------------------------------------------------------|

| RF4.1  | Exportar listado de artículos a PDF  | Botón “Exportar PDF” genera documento con columnas clave desde el navegador. |

| RF4.2  | Exportar listado de préstamos a Excel| Botón “Exportar Excel” genera archivo .xlsx descargable desde el navegador.  |

Los botones se encuentran implementados dentro de la vista principal (admin.html u operador.html) al lado superior derecho de las tablas.

# ⚙️ Instalación (local)


Clona el repositorio:


    git clone https://github.com/tu-usuario/nombre-repo.git
    cd nombre-repo

    
Configura la conexión a la base de datos en appsettings.json:

     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=PrestamosDB;Trusted_Connection=True;"
     }

     
Ejecuta las migraciones (si tienes Entity Framework configurado):


    dotnet ef database update

    
Ejecuta el backend:


     dotnet run

     
Abre el archivo login.html en tu navegador para iniciar el frontend.

# 🗂️ Estructura del Proyecto

/Capa_Entities

  └── Models (Clases: Articulo, Empleado, Usuario, etc.)

/Capa_DataAccess

  └── Context (DbContext)
  
  └── Repositories (Interfaces y clases)

/Capa_Business

  └── Services (Lógica de negocio)
  
/wwwroot

  ├── html
  
  ├── css
  
  └── js
