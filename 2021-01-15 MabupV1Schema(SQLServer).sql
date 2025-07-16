USE [master]
GO
/****** Object:  Database [BD_Mabup]    Script Date: 18/01/2021 14:31:17 ******/
CREATE DATABASE [BD_Mabup]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_Mabup', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BD_Mabup.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD_Mabup_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BD_Mabup_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BD_Mabup] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_Mabup].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_Mabup] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_Mabup] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_Mabup] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_Mabup] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_Mabup] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_Mabup] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_Mabup] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_Mabup] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_Mabup] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_Mabup] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_Mabup] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_Mabup] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_Mabup] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_Mabup] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_Mabup] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BD_Mabup] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_Mabup] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_Mabup] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_Mabup] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_Mabup] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_Mabup] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_Mabup] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_Mabup] SET RECOVERY FULL 
GO
ALTER DATABASE [BD_Mabup] SET  MULTI_USER 
GO
ALTER DATABASE [BD_Mabup] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_Mabup] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_Mabup] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_Mabup] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD_Mabup] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_Mabup] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BD_Mabup', N'ON'
GO
ALTER DATABASE [BD_Mabup] SET QUERY_STORE = OFF
GO
USE [BD_Mabup]
GO
/****** Object:  Table [dbo].[tb_Tareas]    Script Date: 18/01/2021 14:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Tareas](
	[id] [int] NULL,
	[Num_Tarea] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](80) NULL,
	[Fecha_Inicio] [date] NULL,
	[Hora_Inicio] [time](7) NULL,
	[Fecha_Entrega] [date] NULL,
	[Hora_Entrega] [time](7) NULL,
	[Materia] [varchar](50) NULL,
	[Dificultad] [int] NULL,
	[Tema_Tarea] [varchar](80) NULL,
	[Completado] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Usuarios]    Script Date: 18/01/2021 14:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Usuarios](
	[id] [int] NOT NULL,
	[Usuario] [varchar](60) NULL,
	[Contraseña] [varchar](60) NULL,
	[Nombre] [varchar](50) NULL,
	[Ap_Pat] [varchar](50) NULL,
	[Ap_Mat] [varchar](50) NULL,
	[Estimado_de_tiempo] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Insertar datos en la tabla de Usuarios
INSERT INTO tb_Usuarios (id, Usuario, Contraseña, Nombre, Ap_Pat, Ap_Mat, Estimado_de_tiempo) VALUES (1, 'Mabup', '14', '', '', '', NULL);
INSERT INTO tb_Usuarios (id, Usuario, Contraseña, Nombre, Ap_Pat, Ap_Mat, Estimado_de_tiempo) VALUES (2, 'abc@hotmai.com', '123456789', 'Emily', 'Piña', 'Sanchez', '02:00:00');
INSERT INTO tb_Usuarios (id, Usuario, Contraseña, Nombre, Ap_Pat, Ap_Mat, Estimado_de_tiempo) VALUES (3, 'magpv@some.com', '123456789', 'Amelia Zarai', 'Sanchez', 'Gutierrez', '01:06:01');
INSERT INTO tb_Usuarios (id, Usuario, Contraseña, Nombre, Ap_Pat, Ap_Mat, Estimado_de_tiempo) VALUES (4, 'edv@yahoo.com', '123456789', 'Diego', 'Lopez', 'Cardenaz', '02:00:00');
INSERT INTO tb_Usuarios (id, Usuario, Contraseña, Nombre, Ap_Pat, Ap_Mat, Estimado_de_tiempo) VALUES (5, 'rock21@gmail.com', '123456789', 'maria guadalupe', 'vargas', 'najera', '05:10:03');
GO

-- Insertar datos en la tabla de Tareas
SET IDENTITY_INSERT [dbo].[tb_Tareas] ON 
GO
-- La columna Num_Tarea se autoincrementa, pero se especifica aquí para mantener los datos de ejemplo
INSERT INTO tb_Tareas (id, Num_Tarea, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (1, 1, 'Resumen micro', '2021-02-12', '11:23:00', '2021-02-12', '10:12:00', 'Microeconomia', 5, 'Costos', 0);
INSERT INTO tb_Tareas (id, Num_Tarea, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (2, 2, 'Resumen de derecho', '2021-01-14', '17:46:40', '2021-01-19', '09:11:00', 'Derecho', 5, 'rdh6t', 0);
INSERT INTO tb_Tareas (id, Num_Tarea, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (3, 3, 'xdtrgxd', '2021-01-14', '17:47:30', '2021-01-14', '05:45:00', 'zdfgr', 3, '6ytrdh', 0);
INSERT INTO tb_Tareas (id, Num_Tarea, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (3, 4, 'fjhxct', '2021-01-14', '17:47:45', '2021-01-14', '06:45:00', 'dxg', 4, 'dxrgxdrg', 1);
INSERT INTO tb_Tareas (id, Num_Tarea, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (2, 5, 'Ejercicios de Integrales', '2021-01-14', '19:44:59', '2021-01-22', '13:54:00', 'Matematicas', 9, 'cfth', 0);
INSERT INTO tb_Tareas (id, Num_Tarea, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (2, 6, 'Resumen De POO', '2021-01-14', '21:06:17', '2021-01-15', '08:16:00', 'Poo', 6, 'siefudhrt', 0);
INSERT INTO tb_Tareas (id, Num_Tarea, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (2, 7, 'Cuadro foda', '2021-01-14', '21:12:51', '2021-01-20', '12:21:00', 'Orientacion', 3, 'cfhtcfh', 0);
INSERT INTO tb_Tareas (id, Num_Tarea, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (4, 8, 'res', '2021-01-15', '01:31:26', '2021-01-15', '11:14:00', 'Microeconomia', 5, 'yjc', 1);
INSERT INTO tb_Tareas (id, Num_Tarea, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (5, 9, 'Resumen de fisica', '2021-01-15', '07:59:07', '2021-01-20', '10:03:00', 'Fisica', 7, 'MRU', 1);
INSERT INTO tb_Tareas (id, Num_Tarea, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (2, 10, 'dibujo', '2021-01-15', '21:48:28', '2021-01-20', '11:11:00', 'Biologia', 3, 'dibujo industrial', 1);
INSERT INTO tb_Tareas (id, Num_Tarea, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (4, 11, 'crisis economica en pandemia', '2021-01-15', '22:40:19', '2021-01-28', '15:00:00', 'Microeconomia', 8, 'desempleo y crisis economica en la actualidad', 1);
INSERT INTO tb_Tareas (id, Num_Tarea, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (2, 12, 'Graficas de punto de equilibrio', '2021-01-15', '02:09:43', '2021-01-27', '12:03:00', 'Microeconomia', 4, 'sdfsdf', 0);
INSERT INTO tb_Tareas (id, Num_Tarea, Titulo, Fecha_Inicio, Hora_Inicio, Fecha_Entrega, Hora_Entrega, Materia, Dificultad, Tema_Tarea, Completado) VALUES (5, 13, 'thfxcfht', '2021-01-15', '02:16:58', '2021-01-17', '00:00:00', 'Derecho', 3, 'fcthhtf', 0);
GO
SET IDENTITY_INSERT [dbo].[tb_Tareas] OFF
GO
USE [master]
GO
ALTER DATABASE [BD_Mabup] SET  READ_WRITE 
GO
 


 