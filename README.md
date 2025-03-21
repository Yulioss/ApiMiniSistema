# Proyecto ApiMiniSistema API REST con .NET Core y PostgreSQl
## Requisitos Previos

Antes de ejecutar el proyecto, asegúrate de tener instalado lo siguiente:

- [.NET Core 9.0 SDK](https://dotnet.microsoft.com/es-es/download)
- [PostgreSQl](https://www.postgresql.org/download/) 

Para verificar la instalación de .NET Core, ejecuta:
```sh
dotnet --version
```

## Ejecutar Scripts en la Base de Datos
```sh
CREATE DATABASE minisistema;

#Dentro de la BD creada
CREATE TABLE productos (
    id SERIAL PRIMARY KEY,
    nombre VARCHAR(20) NOT NULL,
    cantidad INT,
    movimiento VARCHAR(10) NOT NULL
);
```
## Variables de Entorno
```sh
Este proyecto usa variables de entorno. Puedes configurarlas en el archivo appsettings.json, incluyendo la configuracion de la conexion a la BD :

"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=minisistema;Username=postgres;Password=1234;"
  "UserAdmin": "admin",
	"PasswordAdmin": "123456"
},
```
