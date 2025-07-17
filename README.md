# Mabup - Gestor de Tareas Académicas

**Mabup** es una aplicación de escritorio desarrollada en C# con Windows Forms, diseñada para ayudar a estudiantes en la gestión eficiente de sus tareas académicas. La aplicación permite organizar, programar y dar seguimiento a las actividades escolares de manera intuitiva y personalizada.

## Propósito General

Esta aplicación tiene como objetivo principal proporcionar una herramienta integral para la gestión de tareas académicas, permitiendo a los usuarios:

- Registrar y autenticar usuarios de forma segura.
- Crear, organizar y dar seguimiento a tareas académicas.
- Clasificar tareas por materia, dificultad y fecha de entrega.
- Gestionar horarios y plazos de entrega.
- Evaluar el tiempo estimado de trabajo por tarea.

## Funcionalidades de los Formularios

### 1. **frmLogIn** - Inicio de Sesión
- **Propósito**: Formulario principal de autenticación de usuarios.
- **Funciones**:
    - Validación de credenciales contra base de datos SQL Server.
    - Acceso seguro al sistema mediante usuario y contraseña.
    - Redirección al formulario de registro para nuevos usuarios.
    - Mensajes de bienvenida personalizados.
    - Transición automática a la ventana principal tras autenticación exitosa.

![gif funcionalidad de Login](https://media0.giphy.com/media/v1.Y2lkPTc5MGI3NjExaXl5MXM2Z3ZuYTNiajl0NDJrNnU2MDJrcDE3OW1xYmNyOW1mODdtMSZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/Zed5WMuOKCJVuehdKP/giphy.gif)

### 2. **frmRegistro** - Registro de Usuarios
- **Propósito**: Permite el registro de nuevos usuarios en el sistema.
- **Funciones**:
    - Captura de datos personales (nombre, apellidos, correo).
    - Creación de credenciales de acceso.
    - Validación de campos obligatorios.
    - Generación automática de ID único para cada usuario.
    - Inserción segura de datos en la base de datos.
    - Transición hacia configuración de tiempo estimado de trabajo.
      
![gif funcionalidad de registro](./assets/login.gif)

### 3. **frmGestor_Tareas** - Gestor Principal de Tareas
- **Propósito**: Interfaz central para la administración de tareas.
- **Funciones**:
    - Visualización de tareas pendientes en lista organizada.
    - Acceso rápido para agregar nuevas tareas.
    - Marcado de tareas como completadas.
    - Actualización de test de rapidez personal.
    - Búsqueda y filtrado de tareas por nombre.
    - Navegación fluida entre diferentes secciones.

### 4. **frmAgregar_Tarea** - Creación de Nuevas Tareas
- **Propósito**: Formulario dedicado para el registro detallado de tareas.
- **Funciones**:
    - Captura de información completa de la tarea (título, fecha, hora).
    - Selección de materia desde catálogo predefinido.
    - Clasificación por nivel de dificultad (escala 1-10).
    - Definición de temas específicos por materia.
    - Programación de fecha y hora de entrega.
    - Validación de campos obligatorios antes del guardado.
    - Confirmación visual de tarea agregada exitosamente.
 
![gif funcionalidad de registro](./assets/login.gif)


## Características Técnicas

- **Framework**: .NET Framework 4.7.2
- **Base de Datos**: SQL Server con conexión integrada
- **Interfaz**: Windows Forms con diseño personalizado
- **Validaciones**: Controles de entrada y manejo de errores
- **Navegación**: Sistema de formularios interconectados

## Requisitos del Sistema

- .NET Framework 4.7.2 o superior
- SQL Server (base de datos: BD_Mabup)
- Visual Studio 2022 para desarrollo
- Windows 7 o superior

## Instalación y Configuración

1.  Clona o descarga el proyecto.
2.  Configura la conexión a SQL Server en el código.
3.  Ejecuta los scripts de base de datos necesarios.
4.  Compila y ejecuta desde Visual Studio 2022.

## Uso

1.  Ejecuta la aplicación.
2.  Regístrate como nuevo usuario o inicia sesión.
3.  Utiliza el gestor de tareas para organizar tu trabajo académico.
4.  Agrega tareas con detalles específicos.
5.  Marca tareas como completadas según avances.

---

**Desarrollado por**: Edgar Diego Piña Vargas  
**Versión**: 2021  
**Licencia**: Proyecto Académico
