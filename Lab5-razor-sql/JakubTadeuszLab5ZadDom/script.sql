USE [master]
GO
/****** Object:  Database [MWitcherDB]    Script Date: 31.05.2021 07:31:20 ******/
CREATE DATABASE [MWitcherDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MWitcherDB', FILENAME = N'D:\sqlServer\SQLServer2019\MSSQL15.MSSQLSERVER01\MSSQL\DATA\MWitcherDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MWitcherDB_log', FILENAME = N'D:\sqlServer\SQLServer2019\MSSQL15.MSSQLSERVER01\MSSQL\DATA\MWitcherDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MWitcherDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MWitcherDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MWitcherDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MWitcherDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MWitcherDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MWitcherDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MWitcherDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MWitcherDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MWitcherDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MWitcherDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MWitcherDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MWitcherDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MWitcherDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MWitcherDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MWitcherDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MWitcherDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MWitcherDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MWitcherDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MWitcherDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MWitcherDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MWitcherDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MWitcherDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MWitcherDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [MWitcherDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MWitcherDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MWitcherDB] SET  MULTI_USER 
GO
ALTER DATABASE [MWitcherDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MWitcherDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MWitcherDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MWitcherDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MWitcherDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MWitcherDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MWitcherDB', N'ON'
GO
ALTER DATABASE [MWitcherDB] SET QUERY_STORE = OFF
GO
USE [MWitcherDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 31.05.2021 07:31:20 ******/
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
/****** Object:  Table [dbo].[Beasts]    Script Date: 31.05.2021 07:31:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beasts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[MarketValue] [money] NULL,
	[TypeId] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Beasts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BeastTypes]    Script Date: 31.05.2021 07:31:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BeastTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_BeastTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contracts]    Script Date: 31.05.2021 07:31:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contracts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateAdded] [datetime2](7) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContractorName] [nvarchar](50) NOT NULL,
	[Region] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Status] [int] NOT NULL,
	[Prize] [money] NULL,
	[WitcherId] [int] NULL,
 CONSTRAINT [PK_Contracts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Witchers]    Script Date: 31.05.2021 07:31:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Witchers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[SchoolId] [int] NOT NULL,
 CONSTRAINT [PK_Witchers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WitcherSchools]    Script Date: 31.05.2021 07:31:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WitcherSchools](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Headquarters] [nvarchar](50) NULL,
 CONSTRAINT [PK_WitcherSchools] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210527114605_initial', N'5.0.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210527115248_initial_new', N'5.0.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210527115437_initial_new2', N'5.0.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210527201324_initial3', N'5.0.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210528083100_desc_size_removal', N'5.0.6')
GO
SET IDENTITY_INSERT [dbo].[Beasts] ON 

INSERT [dbo].[Beasts] ([Id], [Name], [MarketValue], [TypeId], [Description]) VALUES (1, N'Bazyliszek', 500.0000, 2, N'Krąży opinia, że bazyliszka można zabić lustrem, ale jak mówi dowcipniś Geralt – jedynie gdy trafi się go w łeb. Jest to potwór niezwykle niebezpieczny, gdyż lata, atakuje pazurami i pluje jadem. Takim wachlarzem możliwości zabił już niejednego. Dlatego nie dziwi fakt, że dla wiedźmina stanowi spore wyzwanie. Ważne, by podczas walki zażyć eliksir Wilga, który uodparnia na działanie trucizn. W związku z tym, że bazyliszek jest niezwykle szybki warto użyć znaku Aard, który może wytrącić go z równo')
INSERT [dbo].[Beasts] ([Id], [Name], [MarketValue], [TypeId], [Description]) VALUES (2, N'Oszluzg', 1000.0000, 2, N'Drakonid szarawej barwy podobny do zielonego smoka, niektóre osobniki osiągają nawet wymiary swojego słynnego kuzyna.
Bywa mylony ze smokiem, ponieważ jest latającym gadem. Posiada długi dziób i jeśli spojrzeć na niego oczami mieszkańca naszego świata, to wygląda jak szary pterozaur. Jako swoje kryjówki wykorzystują jaskinie i zagłębienia terenów. Kiedyś można je było spotkać w każdym miejscu kontynentu.')
INSERT [dbo].[Beasts] ([Id], [Name], [MarketValue], [TypeId], [Description]) VALUES (3, N'Gryf', 0.0000, 3, N'Gryf z wyglądu jest połączeniem lwa (ogon i sierść) oraz orła (ostry, zakrzywiony dziób, pazury i ogromne skrzydła). Jego dietę stanowią duże zwierzęta kopytne, jednak zmuszony do zmiany przyzwyczajeń żywieniowych, nie pogardzi ludzkim mięsem. Zaciekle broni swojego terytorium, które najczęściej znajduje się w górach, w miejscach trudno dostępnych. Jednak wraz z ekspansją człowieka, gryfy zaczęły wić swoje gniazda w pobliżu osad tym samym łatwo zdobywając dostęp do pożywienia. Mówi się, że przedstawiciele tego gatunku wiążą się za młodu na całe życie i często nawet po śmierci partnera nie opuszczają wspólnego gniazda.')
INSERT [dbo].[Beasts] ([Id], [Name], [MarketValue], [TypeId], [Description]) VALUES (4, N'Harpia', 300.0000, 3, N'Harpie to kreatury przypominające wyglądem skrzydlate kobiety. Trudno pomylić je jednak z płcią piękną ze względu na ich pokurczony, ptasi łebek z zakrzywionym dziobem. Harpie występują zwykle w dość licznych koloniach w górach, na wzgórzach, ale także w opuszczonych wieżach i twierdzach, gdzie wiją swe gniazda. Atakują z powietrza, pikując ku ofierze próbują rozszarpać ją krzywymi pazurami. Atak harpii nie jest jednak na tyle potężny, by wprawiony wojownik nie mógł go sparować lub wykonać udany kontratak. Lepiej jednak nie czekać na jej atak, a zawczasu sprowadzić ją na ziemie za pomocą kuszy, znaku Aard, bądź Igni.')
INSERT [dbo].[Beasts] ([Id], [Name], [MarketValue], [TypeId], [Description]) VALUES (5, N'Ghul', 100.0000, 4, N'Ghule są najczęściej spotykane na cmentarzach, w pobliżu krypt, czy na polach bitew, gdyż jego dietę stanowią zwłoki. Warto jednak zaznaczyć, że z przyjemnością polują także na żywych przedstawicieli ludzkiego gatunku. Czynią to jedynie w grupach, którymi często dowodzi alghul. Mają człekokształtną budowę ciała, jednak poruszają się na czterech kończynach. Są bardzo szybkie i w grupie mogą stanowić poważne zagrożenie nawet dla wiedźmina.')
INSERT [dbo].[Beasts] ([Id], [Name], [MarketValue], [TypeId], [Description]) VALUES (6, N'Baba wodna', 200.0000, 4, N'Jej naturalne środowisko stanowią okolice zbiorników wodnych. Na terenach podmokłych ma przewagę nad przeciwnikiem, gdyż atakuje często z zaskoczenia wynurzając się spod ziemi. By oślepić wroga rzuca w niego błotem, a następnie atakuje ostrymi pazurami lub długi jęzorem. Baba wodna pomimo przynależności do płci pięknej, urodą nie grzeszy. Zapachem zresztą również. Przygarbiona, z włosami przypominającymi wodorosty, krzywymi zębami i smrodem mułu nie stanowi wzoru kobiecości.')
INSERT [dbo].[Beasts] ([Id], [Name], [MarketValue], [TypeId], [Description]) VALUES (7, N'Alghul', 300.0000, 4, N'Trupojady te atakują w sposób podobny do ghuli, co nie powinno dziwić, gdyż można powiedzieć, że alghule są trudniejszymi do pokonania kuzynami ghuli. Trudność sprawia ich zdolność do przybrania kolców, które pełnią rolę pancerza, wówczas zadanie im obrażeń nie jest możliwe. Aby się ich pozbyć, użyj znaku Aksji, który jednocześnie na chwilę oszołomi przeciwnika. Alghule są również wrażliwe na ogień.')
SET IDENTITY_INSERT [dbo].[Beasts] OFF
GO
SET IDENTITY_INSERT [dbo].[BeastTypes] ON 

INSERT [dbo].[BeastTypes] ([Id], [Name], [Description]) VALUES (2, N'Drakonid', N'Rząd stworzeń spokrewnionych ze smokami, nie obejmujący jednak smoków właściwych. Odżywiają się mięsem. Drakonidy są terytorialne. Żyją i polują samotnie, choć są okresy, w których łączą się w pary lub stada.')
INSERT [dbo].[BeastTypes] ([Id], [Name], [Description]) VALUES (3, N'Hybryda', N'Monstra będące połączeniem innych ras')
INSERT [dbo].[BeastTypes] ([Id], [Name], [Description]) VALUES (4, N'Trupojad', N'Potwory pożerające zwłoki.')
SET IDENTITY_INSERT [dbo].[BeastTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Contracts] ON 

INSERT [dbo].[Contracts] ([Id], [DateAdded], [Name], [ContractorName], [Region], [Description], [PhoneNumber], [Status], [Prize], [WitcherId]) VALUES (2, CAST(N'2021-05-28T15:37:36.0000000' AS DateTime2), N'Zlecenie na utopce', N'Wielebny', N'Podgrodzie', N'Kościół Wiecznego Ognia poszukuje osoby, która zajmie się utopcami nawiedzającymi brzeg rzeki. Warunkiem wypłaty będzie dowód zabicia 3 bestii, czyli ich mózgi. Pytać Wielebnego.', N'+48 678 234 346', 2, 100.0000, 3)
INSERT [dbo].[Contracts] ([Id], [DateAdded], [Name], [ContractorName], [Region], [Description], [PhoneNumber], [Status], [Prize], [WitcherId]) VALUES (3, CAST(N'2021-05-29T12:59:22.3951672' AS DateTime2), N'Licho przy studni', N'Odolan', N'Biały Sad', N'Dobrzy ludzie,Wiem, że jest wojna i każdy ma własne zmartwienia, ale może znajdzie się ktoś, kto pomoże człowiekowi w potrzebie. Wszyscy pewno znacie studnię, co wśród ruin stoi, i licho, które zazdrośnie jej strzeże – a jak nie znacie, tedy się zapytajcie, to wam opowiem. Tak czy owak, ten, kto zdoła potwora od studni przegnać, dostanie mieszek pełen złota. Nie mitrężcie tylko, bo sprawa pilna.', N'+48 564 346 235', 0, 200.0000, 2)
INSERT [dbo].[Contracts] ([Id], [DateAdded], [Name], [ContractorName], [Region], [Description], [PhoneNumber], [Status], [Prize], [WitcherId]) VALUES (4, CAST(N'2021-05-30T20:05:55.3390951' AS DateTime2), N'Potwór z lasu', N'kapitan Felix Grubb', N'Velen', N'Ogłasza się co następuje!

W lesie pod Novigradem potwór jakowyś siedzi i wielkie szkody wobec naszego wysiłku wojskowego czyni. Ten, kto potwora wytropi i zabije, nie tylko wykona patriotyczny obowiązek i przyczyni się do niechybnej wiktorii Północy zjednoczonej pod berłem miłościwie panującego nam Radowida, ale i otrzyma sowitą nagrodę pieniężną. Wspólnie ku zwycięstwu!

— kapitan Felix Grubb.

[Dopisek] Uwaga! Ogłoszenie wciąż aktualne.

[Dopisek] Uwaga! Jeśli potwór nie zostanie zabity w ciągu najbliższego miesiąca, podatki dla całej okolicy wzrosną o jedną piątą. ', N'+48 999 999 999', 1, NULL, 4)
INSERT [dbo].[Contracts] ([Id], [DateAdded], [Name], [ContractorName], [Region], [Description], [PhoneNumber], [Status], [Prize], [WitcherId]) VALUES (5, CAST(N'2021-05-28T17:53:55.0000000' AS DateTime2), N'Leśnica', N'Bolko, sołtys Podgajów', N'Wieś Podgaje', N'Słuchajcie, słuchajcie!

Na polach pod wsią naszą diabelstwo się jakieś zalęgło, ni to duch, ni mara. Stary Wilem klnie się na grób matki, że to nawet Leśnica być może. Czy Leśnica, czy upiór, niech każdy się ma na baczności i na pola w pojedynkę niech nikt nie wychodzi, a bez kosy albo grabi to już na pewno. Kto by zaś odwagi i szczęścia miał na tyle, żeby zjawę przegnać, ten sowicie wynagrodzony zostanie. ', N'-', 1, 300.0000, 3)
INSERT [dbo].[Contracts] ([Id], [DateAdded], [Name], [ContractorName], [Region], [Description], [PhoneNumber], [Status], [Prize], [WitcherId]) VALUES (6, CAST(N'2021-05-30T15:31:16.0456892' AS DateTime2), N'Pomocy', N'Wójt', N'Blaviken', N'Potrzebna pomoc w przegonieniu dwóch zbirów przebranych za trubadurów, napadających na podróżnych w pobliskim lesie.
Zainteresowani proszeni o zgłoszenie się do wójta.', N'-', 0, 150.0000, 2)
INSERT [dbo].[Contracts] ([Id], [DateAdded], [Name], [ContractorName], [Region], [Description], [PhoneNumber], [Status], [Prize], [WitcherId]) VALUES (7, CAST(N'2021-05-30T19:58:16.8246038' AS DateTime2), N'Potwory na bagnie', N'Yaren Bolt', N'Wyzima', N'Potrzebny chętny do pozbycia się dwóch ogrów. Bestie zagnieździły się w okolicy starego drzewa na bagnie.

UWAGA
Zlecenie tylko dla doświadczonych podróżników', N'+48 734 345 346', 3, 800.0000, 2)
SET IDENTITY_INSERT [dbo].[Contracts] OFF
GO
SET IDENTITY_INSERT [dbo].[Witchers] ON 

INSERT [dbo].[Witchers] ([Id], [Name], [PhoneNumber], [SchoolId]) VALUES (2, N'Geralt', N'+48 713 213 950', 1)
INSERT [dbo].[Witchers] ([Id], [Name], [PhoneNumber], [SchoolId]) VALUES (3, N'Brehen', N'+48 764 345 235', 2)
INSERT [dbo].[Witchers] ([Id], [Name], [PhoneNumber], [SchoolId]) VALUES (4, N'Vesemir', N'-', 1)
SET IDENTITY_INSERT [dbo].[Witchers] OFF
GO
SET IDENTITY_INSERT [dbo].[WitcherSchools] ON 

INSERT [dbo].[WitcherSchools] ([Id], [Name], [Description], [Headquarters]) VALUES (1, N'Szkoła Cechu Wilka', N'Jedna ze szkół wiedźmińskiego cechu rezydująca w zamku Kaer Morhen w królestwie Kaedwen. Jej symbolem jest medalion w kształcie wilczej paszczy z wyszczerzonymi kłami. Szkoła została zaatakowana i zniszczona przez tłum fanatyków. Zachowały się tylko ruiny, w których zimują wiedźmini, a na stałe mieszkał tylko nauczyciel szermierki – Vesemir.', N'Kaer Morhen')
INSERT [dbo].[WitcherSchools] ([Id], [Name], [Description], [Headquarters]) VALUES (2, N'Szkoła Cechu Kota', N'Jej symbolem jest medalion w kształcie kociej paszczy z wyszczerzonymi kłami.
Brak jest jednak dokładniejszych informacji na temat szkoły kota, z wyjątkiem informacji jakoby wiedźmini ze Szkoły Kota służyli jako szpiedzy, najemnicy i skrytobójcy, a wielu z nich było nawet psychopatami, lubującymi się w mordowaniu.', N'Zamek Stygga')
INSERT [dbo].[WitcherSchools] ([Id], [Name], [Description], [Headquarters]) VALUES (3, N'Szkoła cechu Gryfa', N'Gryfici rezydowali na obrzeżach królestwa Koviru i Poviss. Swoją nazwę szkoła wzięła od nauczyciela Erlanda z Larvik, Taliesina Bleddyn Yorath aep Lywelyn zwanego Gryfem od herbu na swojej tarczy. Mówi się też że szkoła wzięła swoją nazwe od wytępienia przez jej wychowanków prawie wszystkich gryfów grasujących w Górach Smoczych. Siedzibą Gryfitów była twierdza Kaer Seren bądź w Starzej Mowie (Caer y Seren) co w tłumaczeniu na Wspólny to Warownia Wśród Gwiazd bądź po prostu Warownia Gwiazdy, w której znajdowała się swego czasu największa biblioteka dzieł magicznych na całej północy. Biblioteka była jednocześnie największym skarbem wiedźminów, jak i przyczyną ich zguby. Wiedźmini ci rozwinęli naukę magii do bardzo zaawansowanego stopnia, co osiągnęli dzięki zgromadzonym księgom i innym składzie podawanych mutagenów. Ostatnią próbą która musi przejść każdy młody wiedźmin, jest albo samotne wytropienie gryfa w górach i wykradniecie mu jajka, albo wyrecytowanie z pamięci księgi Liber Tenebranum. Żaden wiedźmin w historii nie wybrał drugiej opcji. Natomiast sama Warownia była początkowo jednym z wielu miejsc, w których magowie próbowali tworzyć wiedźminów. W Kaer Seren na środku dziedzińca stał elfi obelisk nasączony magią powietrza co czyniło Kaer Seren wyjątkowym Wiedźmińskim Siedliszczem jako że cała twierdza aż biła Mocą tegoż żywiołu. Co zapewne ułatwiało Gryfitom w poszerzaniu wiedzy o magii i rozwijaniu Znaków.', N'Kaer Seren')
INSERT [dbo].[WitcherSchools] ([Id], [Name], [Description], [Headquarters]) VALUES (4, N'Szkoła Cechu Żmii', N'Nie jest znane dokładne położenie głównej siedziby Wiedźmińskiej Szkoły Cechy Żmii, wiadomo jedynie, że znajdowała się na południu. Jej znakiem cechowym był srebrny medalion w kształcie poskręcanego węża. Wiedźmini z niej pochodzący, oprócz podstawowej wiedzy na temat potworów oraz technik walki z nimi, posiadali również wiele informacji na temat Dzikiego Gonu, przez co sami spekulowali, czy poznanie prawdy na temat upiornego orszaku miało być rzeczywistym powodem założenia szkoły. Z czasem organizacja upadła, a wiedźmini, którzy wówczas jeszcze żyli, zmuszeni byli do funkcjonowania bez głównej siedziby, włócząc się po Kontynencie.

Sytuację tę wykorzystał cesarz Emhyr var Emreis, który obiecał odbudować Szkołę Żmii i przywrócić jej szacunek społeczeństwa w zamian za zamordowanie władców panujących na północy. Żmije, pod dowództwem Letho z Gulety, zorganizowały udane zamachy na Demawenda oraz Foltesta, co wywołało chaos wśród Królestw Północy. Nilfgaard z zaskoczenia zaatakował sąsiadów, jednocześnie nie będąc podejrzanym w sprawie królobójców, ponieważ winą obarczono Lożę Czarodziejek. Emhyr zdradził jednak wiedźminów – nie byli mu już potrzebni, a więc powziął środki mające na celu zabicie ich, aby nikt nie dowiedział się, kto był ich prawdziwym zleceniodawcą.', N'Gorthur Gvaed')
SET IDENTITY_INSERT [dbo].[WitcherSchools] OFF
GO
/****** Object:  Index [IX_Beasts_TypeId]    Script Date: 31.05.2021 07:31:20 ******/
CREATE NONCLUSTERED INDEX [IX_Beasts_TypeId] ON [dbo].[Beasts]
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Contracts_WitcherId]    Script Date: 31.05.2021 07:31:20 ******/
CREATE NONCLUSTERED INDEX [IX_Contracts_WitcherId] ON [dbo].[Contracts]
(
	[WitcherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Witchers_SchoolId]    Script Date: 31.05.2021 07:31:20 ******/
CREATE NONCLUSTERED INDEX [IX_Witchers_SchoolId] ON [dbo].[Witchers]
(
	[SchoolId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Beasts]  WITH CHECK ADD  CONSTRAINT [FK_Beasts_BeastTypes_TypeId] FOREIGN KEY([TypeId])
REFERENCES [dbo].[BeastTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Beasts] CHECK CONSTRAINT [FK_Beasts_BeastTypes_TypeId]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_Contracts_Witchers_WitcherId] FOREIGN KEY([WitcherId])
REFERENCES [dbo].[Witchers] ([Id])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_Contracts_Witchers_WitcherId]
GO
ALTER TABLE [dbo].[Witchers]  WITH CHECK ADD  CONSTRAINT [FK_Witchers_WitcherSchools_SchoolId] FOREIGN KEY([SchoolId])
REFERENCES [dbo].[WitcherSchools] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Witchers] CHECK CONSTRAINT [FK_Witchers_WitcherSchools_SchoolId]
GO
USE [master]
GO
ALTER DATABASE [MWitcherDB] SET  READ_WRITE 
GO
