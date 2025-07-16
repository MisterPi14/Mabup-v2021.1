\# Mabup - Gestor de Tareas Académicas



\*\*Mabup\*\* es una aplicación de escritorio desarrollada en C# con Windows Forms, diseñada para ayudar a estudiantes en la gestión eficiente de sus tareas académicas. La aplicación permite organizar, programar y dar seguimiento a las actividades escolares de manera intuitiva y personalizada.



\## Propósito General



Esta aplicación tiene como objetivo principal proporcionar una herramienta integral para la gestión de tareas académicas, permitiendo a los usuarios:



\- Registrar y autenticar usuarios de forma segura

\- Crear, organizar y dar seguimiento a tareas académicas

\- Clasificar tareas por materia, dificultad y fecha de entrega

\- Gestionar horarios y plazos de entrega

\- Evaluar el tiempo estimado de trabajo por tarea



\## Funcionalidades de los Formularios



\### 1. \*\*frmLogIn\*\* - Inicio de Sesión

\- \*\*Propósito\*\*: Formulario principal de autenticación de usuarios

\- \*\*Funciones\*\*:

&nbsp; - Validación de credenciales contra base de datos SQL Server

&nbsp; - Acceso seguro al sistema mediante usuario y contraseña

&nbsp; - Redirección al formulario de registro para nuevos usuarios

&nbsp; - Mensajes de bienvenida personalizados

&nbsp; - Transición automática a la ventana principal tras autenticación exitosa



\### 2. \*\*frmRegistro\*\* - Registro de Usuarios

\- \*\*Propósito\*\*: Permite el registro de nuevos usuarios en el sistema

\- \*\*Funciones\*\*:

&nbsp; - Captura de datos personales (nombre, apellidos, correo)

&nbsp; - Creación de credenciales de acceso

&nbsp; - Validación de campos obligatorios

&nbsp; - Generación automática de ID único para cada usuario

&nbsp; - Inserción segura de datos en la base de datos

&nbsp; - Transición hacia configuración de tiempo estimado de trabajo



\### 3. \*\*frmGestor\_Tareas\*\* - Gestor Principal de Tareas

\- \*\*Propósito\*\*: Interfaz central para la administración de tareas

\- \*\*Funciones\*\*:

&nbsp; - Visualización de tareas pendientes en lista organizada

&nbsp; - Acceso rápido para agregar nuevas tareas

&nbsp; - Marcado de tareas como completadas

&nbsp; - Actualización de test de rapidez personal

&nbsp; - Búsqueda y filtrado de tareas por nombre

&nbsp; - Navegación fluida entre diferentes secciones



\### 4. \*\*frmAgregar\_Tarea\*\* - Creación de Nuevas Tareas

\- \*\*Propósito\*\*: Formulario dedicado para el registro detallado de tareas

\- \*\*Funciones\*\*:

&nbsp; - Captura de información completa de la tarea (título, fecha, hora)

&nbsp; - Selección de materia desde catálogo predefinido

&nbsp; - Clasificación por nivel de dificultad (escala 1-10)

&nbsp; - Definición de temas específicos por materia

&nbsp; - Programación de fecha y hora de entrega

&nbsp; - Validación de campos obligatorios antes del guardado

&nbsp; - Confirmación visual de tarea agregada exitosamente



\## Características Técnicas



\- \*\*Framework\*\*: .NET Framework 4.7.2

\- \*\*Base de Datos\*\*: SQL Server con conexión integrada

\- \*\*Interfaz\*\*: Windows Forms con diseño personalizado

\- \*\*Validaciones\*\*: Controles de entrada y manejo de errores

\- \*\*Navegación\*\*: Sistema de formularios interconectados



\## Requisitos del Sistema



\- .NET Framework 4.7.2 o superior

\- SQL Server (base de datos: BD\_Mabup)

\- Visual Studio 2022 para desarrollo

\- Windows 7 o superior



\## Instalación y Configuración



1\. Clona o descarga el proyecto

2\. Configura la conexión a SQL Server en el código

3\. Ejecuta los scripts de base de datos necesarios

4\. Compila y ejecuta desde Visual Studio 2022



\## Uso



1\. Ejecuta la aplicación

2\. Regístrate como nuevo usuario o inicia sesión

3\. Utiliza el gestor de tareas para organizar tu trabajo académico

4\. Agrega tareas con detalles específicos

5\. Marca tareas como completadas según avances



---



\*\*Desarrollado por\*\*: Edgar Diego Piña Vargas  

\*\*Versión\*\*: 2021  

\*\*Licencia\*\*: Proyecto Académico



