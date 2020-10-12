USE [master]
GO
/****** Object:  Database [ProyectoFinal]    Script Date: 10/2/2020 6:17:46 p. m. ******/
CREATE DATABASE [ProyectoFinal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoFinal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ProyectoFinal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProyectoFinal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ProyectoFinal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProyectoFinal] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoFinal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoFinal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ProyectoFinal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoFinal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoFinal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoFinal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoFinal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoFinal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoFinal] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProyectoFinal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoFinal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoFinal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoFinal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoFinal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoFinal] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProyectoFinal] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoFinal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoFinal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoFinal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoFinal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProyectoFinal] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProyectoFinal] SET QUERY_STORE = OFF
GO
USE [ProyectoFinal]
GO
/****** Object:  Table [dbo].[altamed]    Script Date: 10/2/2020 6:17:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[altamed](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Paciente] [varchar](50) NULL,
	[Habitacion] [int] NULL,
	[Tipo] [varchar](25) NULL,
	[Fecha_de_Ingreso] [date] NULL,
	[Fecha_de_Salida] [date] NULL,
	[Monto] [varchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[citas]    Script Date: 10/2/2020 6:17:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[citas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Paciente] [varchar](50) NULL,
	[Fecha] [date] NULL,
	[Hora] [varchar](25) NULL,
	[Doctor] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[habitaciones]    Script Date: 10/2/2020 6:17:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[habitaciones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NULL,
	[Tipo] [varchar](15) NULL,
	[Precio_Por_Dia] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ingresos]    Script Date: 10/2/2020 6:17:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ingresos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Paciente] [varchar](50) NULL,
	[Habitacion] [int] NULL,
	[Tipo] [varchar](25) NULL,
	[Fecha_de_Ingreso] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[log_in]    Script Date: 10/2/2020 6:17:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[log_in](
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Sexo] [varchar](10) NULL,
	[Usuario] [varchar](50) NULL,
	[Contraseña] [varchar](16) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medicos]    Script Date: 10/2/2020 6:17:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](25) NULL,
	[Apellido] [varchar](25) NULL,
	[Exequatur] [varchar](35) NULL,
	[Especialidad] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pacientes]    Script Date: 10/2/2020 6:17:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pacientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](25) NULL,
	[Apellidos] [varchar](25) NULL,
	[Cedula] [varchar](13) NULL,
	[Asegurado] [varchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[altamed] ON 
GO
INSERT [dbo].[altamed] ([Id], [Paciente], [Habitacion], [Tipo], [Fecha_de_Ingreso], [Fecha_de_Salida], [Monto]) VALUES (2, N'Marcos ', 1305, N'Suite', CAST(N'2020-07-27' AS Date), CAST(N'2020-07-30' AS Date), N'RD$45000.00')
GO
SET IDENTITY_INSERT [dbo].[altamed] OFF
GO
SET IDENTITY_INSERT [dbo].[citas] ON 
GO
INSERT [dbo].[citas] ([Id], [Paciente], [Fecha], [Hora], [Doctor]) VALUES (1, N'Juan Pablo', CAST(N'2020-07-28' AS Date), N'9:00 p.m.', N'Jose  De La Cruz')
GO
INSERT [dbo].[citas] ([Id], [Paciente], [Fecha], [Hora], [Doctor]) VALUES (1004, N'Perla Montero', CAST(N'2020-08-07' AS Date), N'8:00 a.m.', N'Karina Peña')
GO
SET IDENTITY_INSERT [dbo].[citas] OFF
GO
SET IDENTITY_INSERT [dbo].[habitaciones] ON 
GO
INSERT [dbo].[habitaciones] ([Id], [Numero], [Tipo], [Precio_Por_Dia]) VALUES (2, 1305, N'Suite', N'15000')
GO
INSERT [dbo].[habitaciones] ([Id], [Numero], [Tipo], [Precio_Por_Dia]) VALUES (3, 206, N'Doble ', N'5000')
GO
INSERT [dbo].[habitaciones] ([Id], [Numero], [Tipo], [Precio_Por_Dia]) VALUES (4, 36, N'Privada', N'10000')
GO
SET IDENTITY_INSERT [dbo].[habitaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[ingresos] ON 
GO
INSERT [dbo].[ingresos] ([Id], [Paciente], [Habitacion], [Tipo], [Fecha_de_Ingreso]) VALUES (4, N'Lidia', 206, N'Doble ', CAST(N'2020-07-31' AS Date))
GO
INSERT [dbo].[ingresos] ([Id], [Paciente], [Habitacion], [Tipo], [Fecha_de_Ingreso]) VALUES (5, N'Perla Montero', 1305, N'Suite', CAST(N'2020-07-24' AS Date))
GO
INSERT [dbo].[ingresos] ([Id], [Paciente], [Habitacion], [Tipo], [Fecha_de_Ingreso]) VALUES (6, N'Marcos ', 1305, N'Suite', CAST(N'2020-07-28' AS Date))
GO
SET IDENTITY_INSERT [dbo].[ingresos] OFF
GO
INSERT [dbo].[log_in] ([Nombre], [Apellido], [Sexo], [Usuario], [Contraseña]) VALUES (N'Perla', N'Montero', N'Femenino', N'perlamontero', N'michi03')
GO
INSERT [dbo].[log_in] ([Nombre], [Apellido], [Sexo], [Usuario], [Contraseña]) VALUES (N'Michelle', N'Otaño', N'Femenino', N'michi25', N'2025')
GO
INSERT [dbo].[log_in] ([Nombre], [Apellido], [Sexo], [Usuario], [Contraseña]) VALUES (N'Juan', N'Mora', N'Femenino', N'Juanp', N'1630')
GO
INSERT [dbo].[log_in] ([Nombre], [Apellido], [Sexo], [Usuario], [Contraseña]) VALUES (N'Milagros', N'Otaño', N'Femenino', N'milagrosO', N'kjsdvnjkfn')
GO
INSERT [dbo].[log_in] ([Nombre], [Apellido], [Sexo], [Usuario], [Contraseña]) VALUES (N'Perla ', N'Otaño', N'Femenino', N'pmontero', N'michi20')
GO
SET IDENTITY_INSERT [dbo].[medicos] ON 
GO
INSERT [dbo].[medicos] ([Id], [Nombre], [Apellido], [Exequatur], [Especialidad]) VALUES (2, N'Jose ', N'De La Cruz', N'402-15', N'Cardiologo')
GO
INSERT [dbo].[medicos] ([Id], [Nombre], [Apellido], [Exequatur], [Especialidad]) VALUES (1004, N'Karina', N'Peña', N'502-97', N'Nefrologa')
GO
SET IDENTITY_INSERT [dbo].[medicos] OFF
GO
SET IDENTITY_INSERT [dbo].[pacientes] ON 
GO
INSERT [dbo].[pacientes] ([Id], [Nombres], [Apellidos], [Cedula], [Asegurado]) VALUES (1, N'Perla Michelle', N'Montero Otaño', N'402-0912826', N'No')
GO
INSERT [dbo].[pacientes] ([Id], [Nombres], [Apellidos], [Cedula], [Asegurado]) VALUES (2, N'Juan', N'Mora', N'402-1019873-1', N'Sí')
GO
SET IDENTITY_INSERT [dbo].[pacientes] OFF
GO
USE [master]
GO
ALTER DATABASE [ProyectoFinal] SET  READ_WRITE 
GO
