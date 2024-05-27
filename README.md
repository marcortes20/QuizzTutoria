# Implementación de API con Entity Framework y Swagger

## Objetivo

El objetivo de esta práctica es diseñar y desarrollar una API utilizando Entity Framework y Swagger. Los estudiantes deberán crear un repositorio en GitHub para gestionar su código y seguir una serie de pasos para implementar la API con tres entidades: Clínica, Sucursal y Usuario. Esta práctica ayudará a los estudiantes a aplicar sus conocimientos en el uso de git y GitHub, Entity Framework, la creación de entidades, servicios, controladores, y la integración de Swagger para documentar la API.

## Requisitos Generales

- Cada estudiante debe crear un repositorio público en GitHub.
- El nombre del repositorio debe seguir el formato: `API_Clinica_{NombreApellido}`.
- Los estudiantes deben proporcionar el enlace del repositorio a más tardar a las 10:00 AM del día martes 21 de mayo para tener derecho a participar en un premio económico (se valoran los ejercicios plus).

## Premio y Retroalimentación

- Los proyectos entregados antes de las 10:00 AM serán elegibles para el premio económico y recibirán retroalimentación.
- Los proyectos entregados después de las 10:00 AM recibirán retroalimentación pero no serán elegibles para el premio.

## Requisitos Técnicos

### Entidades

#### Clínica:

- `Id` (int)
- `Nombre` (string)

#### Usuario:

- `Id` (int)
- `NombreDeUsuario` (string)
- `Contrasena` (string)

#### Expediente Médico:

- `Id` (int)
- `HistorialClinico` (string)
- `Alergias` (string)
- `GrupoSanguineo` (string)

#### Relaciones:

- Una Clínica tiene muchos Usuarios (uno a muchos).
- Un Usuario tiene un Expediente Médico (uno a uno).

### Servicios y Controladores

Implementar métodos `POST` y `GET` para cada entidad.

- `POST`: Agregar información a la tabla correspondiente.
- `GET`: Obtener los registros previamente ingresados.

### Ejercicios Plus:

- Implementar los métodos `PUT`, `DELETE` y `GetById` en todos los controladores.
- El método `GET` de Clínica debe devolver la información de la clínica, de los usuarios que pertenecen a la misma y de sus expedientes médicos.
- El método `GET` de Sucursal debe devolver información de la clínica a la que pertenece.

## Recursos

- [One-to-Many Relationships in EF Core](https://learn.microsoft.com/en-us/ef/core/modeling/relationships/one-to-many)
- [One-to-One Relationships in EF Core](https://learn.microsoft.com/en-us/ef/core/modeling/relationships/one-to-one)
