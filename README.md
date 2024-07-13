# Guía de usos: Postable - RESTful API para Gestión de Posts

### Introducción

Posteable - RESTfulAPI permite a los usuarios interactuar con publicaciones (Posts). Esta API debe ser capaz de manejar diferentes operaciones dependiendo de si el usuario está registrado o no.

### Características Técnicas

#### Tecnologías y Herramientas

- **Lenguaje:** C#.
- **Framework:** .Net Entity Framework Core
- **Autenticación/Autorización:** JWT.
- **Base de Datos:** MS SQL Server.

#### Get Started

#### Migrations
- Actualizar el archivo appsettings.Develepont.json e indicar el nombre del servidor de su bd en "DefaultConnection": "Server=YourServerName....."
- Ejecutar "dotnet ef database update", para crear la base de datos.

#### Endpoints
- Para tener una lista de los endpoints se recomienda importar el archivo PostableRESTfulApi.postman_collection.json a Postman.

### Entidades disponibles:

1. **Users**

- `Id`: Identificador único del usuario. _Restricción_: Clave primaria.
- `Username`: Apodo de usuario. _Restricción_: Único, no nulo.
- `Password`: Contraseña del usuario, almacenada de manera segura. _Restricción_: No nulo.
- `Email`: Email del usuario. _Restricción_: Único, puede ser nulo.
- `FirstName`: Nombre del usuario. _Restricción_: Puede ser nulo.
- `LastName`: Apellido del usuario. _Restricción_: Puede ser nulo.
- `Role`: Rol del usuario, con valores 'user' o 'admin'. _Restricción_: No nulo, "user" por defecto.
- `CreatedAt`: Fecha y hora de creación del usuario. _Restricción_: No nulo.

2. **Posts**

- `Id`: Identificador único del post. _Restricción_: Clave primaria.
- `UserId`: Identificador del usuario que creó el post. _Restricción_: Clave foránea, no nulo.
- `Content`: Contenido del post. _Restricción_: No nulo.
- `CreatedAt`: Fecha y hora de creación del post. _Restricción_: No nulo.

3. **Likes**

- `Id`: Identificador único del like. _Restricción_: Clave primaria.
- `PostId`: Identificador del post al que se le dio like. _Restricción_: Clave foránea, no nulo.
- `UserId`: Identificador del usuario que dio like. _Restricción_: Clave foránea, no nulo.
- `CreatedAt`: Fecha y hora en que se dio el like. _Restricción_: No nulo.

### Restricciones y Relaciones Adicionales

- **Unicidad en Likes:** La combinación de `PostId` y `UserId` en la tabla `Likes` debe ser única para evitar likes duplicados.
- **Restricciones de Datos:** Deberás aplicar restricciones adecuadas en cuanto a longitud y formato de los datos según tu criterio (por ejemplo, definir una longitud máxima de `Username` o validar el formato de `Email`).

## Endpoints

### GetPosts

- **GET `/posts` (Ver Todos los Posts con Paginación y Filtros)**
  - **Descripción:** Retorna una lista de posts disponibles en la plataforma, con opciones de filtrado por usuario y ordenación.
  - **Parámetros Query:**
    - `username`: Filtrar posts por nombre de usuario (opcional).
    - `orderBy`: Criterio de ordenación, opciones: `createdAt`, `likesCount` (opcional, por defecto `createdAt`).
    - `order`: Dirección de la ordenación, opciones: `asc`, `desc` (opcional, por defecto `asc`).
  - **Respuesta:**
    - **200 OK:** Lista paginada de posts en formato JSON.
  - **Ejemplo de Respuesta:**
    ```json
    [
      {
        "id": 1,
        "content": "Este es un post",
        "createdAt": "2024-01-19 07:37:16-08",
        "username": "usuario1",
        "likesCount": 5
      },
      ...
    ]
    ```
  - **Ejemplo de Uso:**
    - Para obtener la lista de posts filtrando por el usuario 'usuarioEjemplo', ordenados por número de likes en orden descendente:
      - `GET /posts?username=usuarioEjemplo&orderBy=likesCount&order=desc`

### RegisterPost

- **POST `/posts` (Crear Nuevo Post)**

  - **Descripción:** Permite a un *usuario registrado* crear un nuevo post.
  - **Body:**
    - `content`: Texto del post.
  - **Respuesta:**
    - **201 Created:** Post creado exitosamente.
    - **400 Bad Request:** Si falta información o el formato es incorrecto.
    - **401 Unauthorized:** Si el usuario no está autenticado.
  - **Ejemplo de Respuesta:**
    ```json
    {
      "id": 10,
      "content": "Mi post actualizado",
      "createdAt": "2024-01-19 10:37:16-08",
      "username": "mi-usuario",
      "likesCount": 0
    }
    ```
### UpdatePost
- **PUT `/posts/:id` (Editar Post Existente)**

  - **Descripción:** Permite a un usuario registrado editar un post existente.
  - **Parámetros URL:**
    - `id`: Id del post a editar.
  - **Body:**
    - `content`: Texto actualizado del post. (El campo es opcional, pero se debe enviar al menos un campo para actualizar)
  - **Respuesta:**
    - **200 OK:** Post actualizado exitosamente. Devuelve el post actualizado.
    - **400 Bad Request:** Si falta información, el formato es incorrecto o no se envía ningún campo para actualizar.
    - **401 Unauthorized:** Si el usuario no está autenticado o no es el propietario del post.
    - **404 Not Found:** Si el post no existe.
  - **Ejemplo de Respuesta:**
    ```json
    {
      "id": 10,
      "content": "Mi post actualizado",
      "createdAt": "2024-01-19 10:37:16-08",
      "username": "mi-usuario",
      "likesCount": 0
    }
    ```
### RegisterLike
- **POST `/posts/:postId/like` (Dar Like a un Post)**

  - **Descripción:** Permite a un usuario registrado dar "Like" a un post.
  - **Parámetros deURL:**
    - `postId`: Id del post a dar like.
  - **Respuesta:**
    - **200 OK:** Like registrado.
    - **404 Not Found:** Si el post no existe.
    - **401 Unauthorized:** Si el usuario no está autenticado.
  - **Ejemplo de Respuesta:**
    ```json
    {
      "id": 15,
      "content": "Mi nuevo post",
      "createdAt": "2024-01-19 10:37:16-08",
      "username": "usuario",
      "likesCount": 1
    }
    ```
### DeleteLike
- **DELETE `/posts/:postId/like` (Eliminar Like de un Post)**
  - **Descripción:** Permite a un usuario eliminar su "like" de un post.
  - **Parámetros de URL:**
    - `postId`: ID del post a remover like.
  - **Respuesta:**
    - **200 OK:** Like eliminado.
    - **404 Not Found:** Si el post no existe o no tenía like previamente.
    - **401 Unauthorized:** Si el usuario no está autenticado.
  - **Ejemplo de Respuesta:**
    ```json
    {
      "id": 15,
      "content": "Mi nuevo post",
      "createdAt": "2024-01-19 10:37:16-08",
      "username": "usuario",
      "likesCount": 0
    }
    ```

### GetMe(Obtener mi perfil)

- **GET `/me` (Ver Perfil de Usuario)**

  - **Descripción:** Muestra el perfil del usuario autenticado.
  - **Respuesta:**
    - **200 OK:** Información del perfil en formato JSON.
    - **401 Unauthorized:** Si el usuario no está autenticado.
  - **Ejemplo de Respuesta:**
    ```json
    {
      "id": 2,
      "username": "miUsuario",
      "email": "miemail@example.com",
      "firstName": "Nombre",
      "lastName": "Apellido",
      "createdAt": "2024-01-19 10:37:16-08"
    }
    ```
### UpdateMe
- **PUT `/me` (Editar Cuenta de Usuario)**

  - **Descripción:** Permite al usuario editar su información de perfil.
  - **Body:**
    - `email`, `firstName`, `lastName`: Campos opcionales para actualizar.
  - **Respuesta:**
    - **200 OK:** Perfil actualizado.
    - **400 Bad Request:** Si el formato es incorrecto.
    - **401 Unauthorized:** Si el usuario no está autenticado.
  - **Ejemplo de Respuesta:**
    ```json
    {
      "id": 2,
      "username": "miUsuario",
      "email": "nuevo@mail.com",
      "firstName": "Nombre",
      "lastName": "Apellido",
      "createdAt": "2024-01-19 10:37:16-08"
    }
    ```
### DeleteMe
- **DELETE `/me` (Eliminar Cuenta de Usuario)**
  - **Descripción:** Permite al usuario eliminar su cuenta.
  - **Respuesta:**
    - **204 No Content:** Cuenta eliminada exitosamente.
    - **401 Unauthorized:** Si el usuario no está autenticado.

### Signup

- **POST `/signup` (Crear Cuenta)**
- **Descripción:** Permite a un nuevo usuario registrarse en la plataforma.
- **Body:**
  - `username`, `password`: Campos requeridos para el registro.
- **Respuesta:**
  - **201 Created:** Cuenta creada.
  - **400 Bad Request:** Si falta información o el formato es incorrecto.
- **Ejemplo de Respuesta:**

  ```json
  {
    "id": 20,
    "username": "nuevoUsuario",
    "email": "un-mail@example.com",
    "firstName": "Nombre",
    "lastName": "Apellido",
    "createdAt": "2024-01-19 10:37:16-08"
  }
  ```
### Login
- **POST `/login` (Iniciar Sesión)**
  - **Descripción:** Permite a un usuario existente iniciar sesión.
  - **Body:**
    - `username`, `password`: Credenciales requeridas para el inicio de sesión.
  - **Respuesta:**
    - **200 OK:** Sesión iniciada, retorna token JWT.
    - **401 Unauthorized:** Credenciales incorrectas.
  - **Ejemplo de Respuesta:**
    ```json
    {
      "token": "eyJhbGciOiJIUzI1NiIsInR5..."
    }
    ```
### Formato de respuesta de error
```json
{
  "status": 404,
  "error": "Not Found",
  "message": "El recurso solicitado no se encontró.",
  "details": "El post con id 123 no existe.",
  "timestamp": "2024-07-12T12:34:56Z",
  "path": "/api/posts/123"
}
```
