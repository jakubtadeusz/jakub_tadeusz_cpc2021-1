USE [master]
GO
/****** Object:  Database [LoanShark]    Script Date: 09.05.2021 23:55:24 ******/
CREATE DATABASE [LoanShark]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LoanShark', FILENAME = N'D:\sqlServer\SQLServer2019\MSSQL15.MSSQLSERVER01\MSSQL\DATA\LoanShark.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LoanShark_log', FILENAME = N'D:\sqlServer\SQLServer2019\MSSQL15.MSSQLSERVER01\MSSQL\DATA\LoanShark_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LoanShark] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LoanShark].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LoanShark] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LoanShark] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LoanShark] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LoanShark] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LoanShark] SET ARITHABORT OFF 
GO
ALTER DATABASE [LoanShark] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LoanShark] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LoanShark] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LoanShark] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LoanShark] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LoanShark] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LoanShark] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LoanShark] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LoanShark] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LoanShark] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LoanShark] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LoanShark] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LoanShark] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LoanShark] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LoanShark] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LoanShark] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LoanShark] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LoanShark] SET RECOVERY FULL 
GO
ALTER DATABASE [LoanShark] SET  MULTI_USER 
GO
ALTER DATABASE [LoanShark] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LoanShark] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LoanShark] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LoanShark] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LoanShark] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LoanShark] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LoanShark', N'ON'
GO
ALTER DATABASE [LoanShark] SET QUERY_STORE = OFF
GO
USE [LoanShark]
GO
/****** Object:  Table [dbo].[ClientContactHistory]    Script Date: 09.05.2021 23:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientContactHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[ContactType] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
	[ContractId] [int] NULL,
 CONSTRAINT [PK_ClientContactHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 09.05.2021 23:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](50) NOT NULL,
	[LastName] [nchar](50) NOT NULL,
	[PESEL] [bigint] NOT NULL,
	[Street] [nchar](50) NULL,
	[FlatNumber] [nchar](10) NULL,
	[City] [nchar](50) NULL,
	[PostalCode] [int] NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactTypes]    Script Date: 09.05.2021 23:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContactName] [nchar](50) NOT NULL,
 CONSTRAINT [PK_ContactTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractOperations]    Script Date: 09.05.2021 23:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractOperations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContractId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[ClientId] [int] NULL,
	[PaidAmount] [money] NULL,
	[Date] [datetime] NOT NULL,
	[DepositId] [int] NULL,
 CONSTRAINT [PK_ContractOperations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contracts]    Script Date: 09.05.2021 23:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contracts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContractTemplateId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[ClientId] [int] NULL,
	[DateStart] [date] NULL,
	[MonthLength] [int] NULL,
	[DepositId] [int] NULL,
	[ContractAmount] [money] NULL,
 CONSTRAINT [PK_Contracts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractTemplates]    Script Date: 09.05.2021 23:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractTemplates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContractName] [nchar](50) NOT NULL,
	[ContractMonthlyPercentageInterest] [decimal](5, 2) NULL,
	[ContractMinimumMonthDuration] [int] NULL,
	[ContractMaximumMonthDuration] [int] NULL,
	[DepositRequired] [bit] NOT NULL,
	[ContractMonthlyOperatingCost] [money] NULL,
	[ContractDocumentLocation] [nchar](50) NULL,
 CONSTRAINT [PK_ContractTemplates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deposits]    Script Date: 09.05.2021 23:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deposits](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepositName] [nchar](50) NOT NULL,
	[DepositValue] [money] NOT NULL,
	[DepositOwner] [int] NOT NULL,
 CONSTRAINT [PK_Deposits] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 09.05.2021 23:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](20) NOT NULL,
	[LastName] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09.05.2021 23:55:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nchar](50) NOT NULL,
	[Password] [nchar](50) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ClientContactHistory] ON 

INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (13, CAST(N'2021-09-05T23:11:09.000' AS DateTime), 4, 1, 2, 16)
INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (14, CAST(N'2021-09-05T23:11:16.000' AS DateTime), 4, 1, 3, 17)
INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (15, CAST(N'2021-09-05T23:11:21.000' AS DateTime), 5, 1, 3, 18)
INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (16, CAST(N'2021-09-05T23:11:37.000' AS DateTime), 4, 1, 2, 19)
INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (17, CAST(N'2021-09-05T23:11:43.000' AS DateTime), 5, 1, 2, 20)
INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (18, CAST(N'2021-09-05T23:12:03.000' AS DateTime), 4, 1, 1, 21)
INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (19, CAST(N'2021-09-05T23:12:10.000' AS DateTime), 5, 1, 1, 22)
INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (20, CAST(N'2021-09-05T23:15:30.000' AS DateTime), 5, 1, 1, 23)
INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (21, CAST(N'2021-09-05T23:15:54.000' AS DateTime), 5, 1, 2, 24)
INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (22, CAST(N'2021-09-05T23:16:05.000' AS DateTime), 4, 1, 3, 25)
INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (23, CAST(N'2021-09-05T23:16:53.000' AS DateTime), 5, 1, 3, 26)
INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (24, CAST(N'2021-09-05T23:18:47.000' AS DateTime), 2, 1, 1, 0)
INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (25, CAST(N'2021-09-05T23:18:48.000' AS DateTime), 1, 1, 1, 0)
INSERT [dbo].[ClientContactHistory] ([Id], [Date], [ContactType], [EmployeeId], [ClientId], [ContractId]) VALUES (26, CAST(N'2021-09-05T23:18:49.000' AS DateTime), 3, 1, 1, 0)
SET IDENTITY_INSERT [dbo].[ClientContactHistory] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Id], [FirstName], [LastName], [PESEL], [Street], [FlatNumber], [City], [PostalCode]) VALUES (1, N'Grzegorz                                          ', N'Brzęczyszczykiewicz                               ', 23546784957, N'Grzybowa                                          ', N'15/35     ', N'Warszawa                                          ', 2456)
INSERT [dbo].[Clients] ([Id], [FirstName], [LastName], [PESEL], [Street], [FlatNumber], [City], [PostalCode]) VALUES (2, N'Krzysztof                                         ', N'Kowalski                                          ', 12345678907, N'Kryształowa                                       ', N'45/23     ', N'Warszawa                                          ', 2545)
INSERT [dbo].[Clients] ([Id], [FirstName], [LastName], [PESEL], [Street], [FlatNumber], [City], [PostalCode]) VALUES (3, N'Marcin                                            ', N'Górecki                                           ', 23455673928, N'Kolejowa                                          ', N'15/76     ', N'Wrocław                                           ', 50234)
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[ContactTypes] ON 

INSERT [dbo].[ContactTypes] ([Id], [ContactName]) VALUES (1, N'SMS                                               ')
INSERT [dbo].[ContactTypes] ([Id], [ContactName]) VALUES (2, N'PHONECALL                                         ')
INSERT [dbo].[ContactTypes] ([Id], [ContactName]) VALUES (3, N'EMAIL                                             ')
INSERT [dbo].[ContactTypes] ([Id], [ContactName]) VALUES (4, N'CONTRACT                                          ')
INSERT [dbo].[ContactTypes] ([Id], [ContactName]) VALUES (5, N'DEPOSIT                                           ')
SET IDENTITY_INSERT [dbo].[ContactTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[ContractOperations] ON 

INSERT [dbo].[ContractOperations] ([Id], [ContractId], [EmployeeId], [ClientId], [PaidAmount], [Date], [DepositId]) VALUES (1, 1, 1, NULL, 10000.0000, CAST(N'2021-02-05T21:09:25.000' AS DateTime), NULL)
INSERT [dbo].[ContractOperations] ([Id], [ContractId], [EmployeeId], [ClientId], [PaidAmount], [Date], [DepositId]) VALUES (2, 3, 1, NULL, -3000.0000, CAST(N'2021-02-05T21:09:31.000' AS DateTime), NULL)
INSERT [dbo].[ContractOperations] ([Id], [ContractId], [EmployeeId], [ClientId], [PaidAmount], [Date], [DepositId]) VALUES (3, 1, 1, NULL, 3000.0000, CAST(N'2021-02-05T21:09:36.000' AS DateTime), NULL)
INSERT [dbo].[ContractOperations] ([Id], [ContractId], [EmployeeId], [ClientId], [PaidAmount], [Date], [DepositId]) VALUES (4, 3, 1, NULL, -3000.0000, CAST(N'2021-02-05T21:09:38.000' AS DateTime), NULL)
INSERT [dbo].[ContractOperations] ([Id], [ContractId], [EmployeeId], [ClientId], [PaidAmount], [Date], [DepositId]) VALUES (18, 16, 1, 2, -500.0000, CAST(N'2021-09-05T23:11:09.000' AS DateTime), NULL)
INSERT [dbo].[ContractOperations] ([Id], [ContractId], [EmployeeId], [ClientId], [PaidAmount], [Date], [DepositId]) VALUES (25, 23, 1, 1, -700.0000, CAST(N'2021-09-05T23:15:30.000' AS DateTime), 6)
INSERT [dbo].[ContractOperations] ([Id], [ContractId], [EmployeeId], [ClientId], [PaidAmount], [Date], [DepositId]) VALUES (26, 24, 1, 2, -1200.0000, CAST(N'2021-09-05T23:15:54.000' AS DateTime), 7)
INSERT [dbo].[ContractOperations] ([Id], [ContractId], [EmployeeId], [ClientId], [PaidAmount], [Date], [DepositId]) VALUES (28, 26, 1, 3, -12000.0000, CAST(N'2021-09-05T23:16:53.000' AS DateTime), 8)
INSERT [dbo].[ContractOperations] ([Id], [ContractId], [EmployeeId], [ClientId], [PaidAmount], [Date], [DepositId]) VALUES (29, 1, 1, NULL, 30000.0000, CAST(N'2021-09-05T23:17:01.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[ContractOperations] OFF
GO
SET IDENTITY_INSERT [dbo].[Contracts] ON 

INSERT [dbo].[Contracts] ([Id], [ContractTemplateId], [EmployeeId], [ClientId], [DateStart], [MonthLength], [DepositId], [ContractAmount]) VALUES (1, 2, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Contracts] ([Id], [ContractTemplateId], [EmployeeId], [ClientId], [DateStart], [MonthLength], [DepositId], [ContractAmount]) VALUES (3, 3, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Contracts] ([Id], [ContractTemplateId], [EmployeeId], [ClientId], [DateStart], [MonthLength], [DepositId], [ContractAmount]) VALUES (16, 14, 1, 2, CAST(N'2021-09-05' AS Date), 2, NULL, 500.0000)
INSERT [dbo].[Contracts] ([Id], [ContractTemplateId], [EmployeeId], [ClientId], [DateStart], [MonthLength], [DepositId], [ContractAmount]) VALUES (23, 15, 1, 1, CAST(N'2021-09-05' AS Date), 2, 6, 700.0000)
INSERT [dbo].[Contracts] ([Id], [ContractTemplateId], [EmployeeId], [ClientId], [DateStart], [MonthLength], [DepositId], [ContractAmount]) VALUES (24, 15, 1, 2, CAST(N'2021-09-05' AS Date), 1, 7, 1200.0000)
INSERT [dbo].[Contracts] ([Id], [ContractTemplateId], [EmployeeId], [ClientId], [DateStart], [MonthLength], [DepositId], [ContractAmount]) VALUES (25, 2, 1, 3, CAST(N'2021-09-05' AS Date), 4, NULL, 12000.0000)
INSERT [dbo].[Contracts] ([Id], [ContractTemplateId], [EmployeeId], [ClientId], [DateStart], [MonthLength], [DepositId], [ContractAmount]) VALUES (26, 15, 1, 3, CAST(N'2021-09-05' AS Date), 4, 8, 12000.0000)
SET IDENTITY_INSERT [dbo].[Contracts] OFF
GO
SET IDENTITY_INSERT [dbo].[ContractTemplates] ON 

INSERT [dbo].[ContractTemplates] ([Id], [ContractName], [ContractMonthlyPercentageInterest], [ContractMinimumMonthDuration], [ContractMaximumMonthDuration], [DepositRequired], [ContractMonthlyOperatingCost], [ContractDocumentLocation]) VALUES (2, N'Wpłata gotówki                                    ', NULL, NULL, NULL, 0, NULL, NULL)
INSERT [dbo].[ContractTemplates] ([Id], [ContractName], [ContractMonthlyPercentageInterest], [ContractMinimumMonthDuration], [ContractMaximumMonthDuration], [DepositRequired], [ContractMonthlyOperatingCost], [ContractDocumentLocation]) VALUES (3, N'Wypłata gotówki                                   ', NULL, NULL, NULL, 0, NULL, NULL)
INSERT [dbo].[ContractTemplates] ([Id], [ContractName], [ContractMonthlyPercentageInterest], [ContractMinimumMonthDuration], [ContractMaximumMonthDuration], [DepositRequired], [ContractMonthlyOperatingCost], [ContractDocumentLocation]) VALUES (14, N'Umowa pożyczki                                    ', CAST(10.00 AS Decimal(5, 2)), 0, 4, 0, 20.0000, N'                                                  ')
INSERT [dbo].[ContractTemplates] ([Id], [ContractName], [ContractMonthlyPercentageInterest], [ContractMinimumMonthDuration], [ContractMaximumMonthDuration], [DepositRequired], [ContractMonthlyOperatingCost], [ContractDocumentLocation]) VALUES (15, N'Umowa pożyczki pod zastaw                         ', CAST(5.00 AS Decimal(5, 2)), 0, 4, 1, 10.0000, N'                                                  ')
SET IDENTITY_INSERT [dbo].[ContractTemplates] OFF
GO
SET IDENTITY_INSERT [dbo].[Deposits] ON 

INSERT [dbo].[Deposits] ([Id], [DepositName], [DepositValue], [DepositOwner]) VALUES (6, N'Telefon                                           ', 800.0000, 1)
INSERT [dbo].[Deposits] ([Id], [DepositName], [DepositValue], [DepositOwner]) VALUES (7, N'Telewizor                                         ', 1500.0000, 2)
INSERT [dbo].[Deposits] ([Id], [DepositName], [DepositValue], [DepositOwner]) VALUES (8, N'Samochód                                          ', 15000.0000, 3)
SET IDENTITY_INSERT [dbo].[Deposits] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Id], [FirstName], [LastName]) VALUES (1, N'Jan                 ', N'Kowalski                                          ')
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName]) VALUES (2, N'Krzysztof           ', N'Brzeszczyński                                     ')
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName]) VALUES (3, N'Kamil               ', N'Góra                                              ')
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName]) VALUES (4, N'Marta               ', N'Noga                                              ')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Login], [Password], [UserId]) VALUES (1, N'JanKow                                            ', N'qwerty                                            ', 1)
INSERT [dbo].[Users] ([Id], [Login], [Password], [UserId]) VALUES (2, N'KrzBrze                                           ', N'asdfgh                                            ', 2)
INSERT [dbo].[Users] ([Id], [Login], [Password], [UserId]) VALUES (3, N'KamG                                              ', N'test                                              ', 3)
INSERT [dbo].[Users] ([Id], [Login], [Password], [UserId]) VALUES (4, N'MartaN                                            ', N'qwerty1234                                        ', 4)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_Contracts_Clients] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_Contracts_Clients]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_Contracts_ContractTemplates] FOREIGN KEY([ContractTemplateId])
REFERENCES [dbo].[ContractTemplates] ([Id])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_Contracts_ContractTemplates]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_Contracts_Deposits] FOREIGN KEY([DepositId])
REFERENCES [dbo].[Deposits] ([Id])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_Contracts_Deposits]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_Contracts_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_Contracts_Employees]
GO
ALTER TABLE [dbo].[Deposits]  WITH CHECK ADD  CONSTRAINT [FK_Deposits_Clients] FOREIGN KEY([DepositOwner])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[Deposits] CHECK CONSTRAINT [FK_Deposits_Clients]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Employees] FOREIGN KEY([UserId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Employees]
GO
USE [master]
GO
ALTER DATABASE [LoanShark] SET  READ_WRITE 
GO
