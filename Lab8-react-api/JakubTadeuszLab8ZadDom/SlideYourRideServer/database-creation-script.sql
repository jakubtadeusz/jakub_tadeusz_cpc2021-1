USE [master]
GO
/****** Object:  Database [SlideYourRideDB]    Script Date: 28.06.2021 02:26:40 ******/
CREATE DATABASE [SlideYourRideDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SlideYourRideDB', FILENAME = N'D:\sqlServer\SQLServer2019\MSSQL15.MSSQLSERVER01\MSSQL\DATA\SlideYourRideDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SlideYourRideDB_log', FILENAME = N'D:\sqlServer\SQLServer2019\MSSQL15.MSSQLSERVER01\MSSQL\DATA\SlideYourRideDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SlideYourRideDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SlideYourRideDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SlideYourRideDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SlideYourRideDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SlideYourRideDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SlideYourRideDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SlideYourRideDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SlideYourRideDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET RECOVERY FULL 
GO
ALTER DATABASE [SlideYourRideDB] SET  MULTI_USER 
GO
ALTER DATABASE [SlideYourRideDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SlideYourRideDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SlideYourRideDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SlideYourRideDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SlideYourRideDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SlideYourRideDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SlideYourRideDB', N'ON'
GO
ALTER DATABASE [SlideYourRideDB] SET QUERY_STORE = OFF
GO
USE [SlideYourRideDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 28.06.2021 02:26:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stops]    Script Date: 28.06.2021 02:26:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stops](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StopName] [nvarchar](50) NOT NULL,
	[StopDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_Stops] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tracks]    Script Date: 28.06.2021 02:26:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Length] [int] NOT NULL,
	[Elevation] [int] NOT NULL,
	[TrackDescription] [nvarchar](max) NULL,
	[EndStopId] [int] NOT NULL,
	[StartStopId] [int] NOT NULL,
 CONSTRAINT [PK_Tracks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210623193703_initial', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210623194823_initial2', N'5.0.7')
GO
SET IDENTITY_INSERT [dbo].[Stops] ON 

INSERT [dbo].[Stops] ([Id], [StopName], [StopDescription]) VALUES (1, N'Dworzec', N'Dworzec PKP')
INSERT [dbo].[Stops] ([Id], [StopName], [StopDescription]) VALUES (2, N'Galeria handlowa', N'Galeria handlowa w pobliżu dworca')
INSERT [dbo].[Stops] ([Id], [StopName], [StopDescription]) VALUES (5, N'Rynek', N'Stary rynek')
INSERT [dbo].[Stops] ([Id], [StopName], [StopDescription]) VALUES (6, N'Supermarket', N'Supermarket w pobliżu rynku')
SET IDENTITY_INSERT [dbo].[Stops] OFF
GO
SET IDENTITY_INSERT [dbo].[Tracks] ON 

INSERT [dbo].[Tracks] ([Id], [Length], [Elevation], [TrackDescription], [EndStopId], [StartStopId]) VALUES (1, 500, -20, N'Droga z dworca do pobliskiej galerii', 2, 1)
INSERT [dbo].[Tracks] ([Id], [Length], [Elevation], [TrackDescription], [EndStopId], [StartStopId]) VALUES (2, 500, 20, N'Droga z galerii na dworzec', 1, 2)
INSERT [dbo].[Tracks] ([Id], [Length], [Elevation], [TrackDescription], [EndStopId], [StartStopId]) VALUES (10, 1500, 20, N'Trasa łącząca dworzec i rynek', 5, 1)
INSERT [dbo].[Tracks] ([Id], [Length], [Elevation], [TrackDescription], [EndStopId], [StartStopId]) VALUES (11, 1500, -20, N'Trasa łącząca dworzec i rynek', 1, 5)
INSERT [dbo].[Tracks] ([Id], [Length], [Elevation], [TrackDescription], [EndStopId], [StartStopId]) VALUES (14, 650, 20, N'Droga pomiędzy dworcem a supermarketem', 6, 2)
INSERT [dbo].[Tracks] ([Id], [Length], [Elevation], [TrackDescription], [EndStopId], [StartStopId]) VALUES (15, 650, -20, N'Droga pomiędzy dworcem a supermarketem', 2, 6)
INSERT [dbo].[Tracks] ([Id], [Length], [Elevation], [TrackDescription], [EndStopId], [StartStopId]) VALUES (16, 200, -40, N'Droga z dworca na rynek', 6, 5)
INSERT [dbo].[Tracks] ([Id], [Length], [Elevation], [TrackDescription], [EndStopId], [StartStopId]) VALUES (17, 200, 40, N'Droga z dworca na rynek', 5, 6)
INSERT [dbo].[Tracks] ([Id], [Length], [Elevation], [TrackDescription], [EndStopId], [StartStopId]) VALUES (18, 2000, 80, N'Droga z dworca do supermarketu', 6, 1)
INSERT [dbo].[Tracks] ([Id], [Length], [Elevation], [TrackDescription], [EndStopId], [StartStopId]) VALUES (19, 2000, -80, N'Droga z dworca do supermarketu', 1, 6)
INSERT [dbo].[Tracks] ([Id], [Length], [Elevation], [TrackDescription], [EndStopId], [StartStopId]) VALUES (20, 2500, -37, N'Droga pomiędzy rynkiem a galerią handlową', 5, 2)
INSERT [dbo].[Tracks] ([Id], [Length], [Elevation], [TrackDescription], [EndStopId], [StartStopId]) VALUES (21, 2500, 37, N'Droga pomiędzy rynkiem a galerią handlową', 2, 5)
SET IDENTITY_INSERT [dbo].[Tracks] OFF
GO
/****** Object:  Index [IX_Tracks_StartStopId]    Script Date: 28.06.2021 02:26:41 ******/
CREATE NONCLUSTERED INDEX [IX_Tracks_StartStopId] ON [dbo].[Tracks]
(
	[StartStopId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [SlideYourRideDB] SET  READ_WRITE 
GO
