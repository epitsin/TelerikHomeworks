USE [master]
GO
/****** Object:  Database [LivingSystem]    Script Date: 20-Aug-14 5:15:40 PM ******/
CREATE DATABASE [LivingSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LivingSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LivingSystem.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LivingSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LivingSystem_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LivingSystem] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LivingSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LivingSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LivingSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LivingSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LivingSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LivingSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [LivingSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LivingSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LivingSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LivingSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LivingSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LivingSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LivingSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LivingSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LivingSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LivingSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LivingSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LivingSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LivingSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LivingSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LivingSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LivingSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LivingSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LivingSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LivingSystem] SET  MULTI_USER 
GO
ALTER DATABASE [LivingSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LivingSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LivingSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LivingSystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LivingSystem] SET DELAYED_DURABILITY = DISABLED 
GO
USE [LivingSystem]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 20-Aug-14 5:15:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[Address_Text] [nchar](100) NOT NULL,
	[TownID] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continent]    Script Date: 20-Aug-14 5:15:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continent](
	[ContinentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Continent] PRIMARY KEY CLUSTERED 
(
	[ContinentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 20-Aug-14 5:15:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](20) NOT NULL,
	[ContinentID] [int] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 20-Aug-14 5:15:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](20) NOT NULL,
	[SecondName] [nchar](20) NOT NULL,
	[AddressID] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Town]    Script Date: 20-Aug-14 5:15:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[TownID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](20) NOT NULL,
	[CountryID] [int] NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[TownID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([AddressID], [Address_Text], [TownID]) VALUES (1, N'Mladost 1                                                                                           ', 1)
INSERT [dbo].[Address] ([AddressID], [Address_Text], [TownID]) VALUES (2, N'Shanzelize                                                                                          ', 2)
INSERT [dbo].[Address] ([AddressID], [Address_Text], [TownID]) VALUES (3, N'The Middle of Nowhere                                                                               ', 3)
SET IDENTITY_INSERT [dbo].[Address] OFF
SET IDENTITY_INSERT [dbo].[Continent] ON 

INSERT [dbo].[Continent] ([ContinentID], [Name]) VALUES (1, N'Africa              ')
INSERT [dbo].[Continent] ([ContinentID], [Name]) VALUES (2, N'Europe              ')
INSERT [dbo].[Continent] ([ContinentID], [Name]) VALUES (3, N'Asia                ')
INSERT [dbo].[Continent] ([ContinentID], [Name]) VALUES (4, N'Australia           ')
INSERT [dbo].[Continent] ([ContinentID], [Name]) VALUES (5, N'North America       ')
INSERT [dbo].[Continent] ([ContinentID], [Name]) VALUES (6, N'South America       ')
SET IDENTITY_INSERT [dbo].[Continent] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([CountryID], [Name], [ContinentID]) VALUES (1, N'Egypt               ', 1)
INSERT [dbo].[Country] ([CountryID], [Name], [ContinentID]) VALUES (2, N'Syria               ', 1)
INSERT [dbo].[Country] ([CountryID], [Name], [ContinentID]) VALUES (3, N'Bulgaria            ', 2)
INSERT [dbo].[Country] ([CountryID], [Name], [ContinentID]) VALUES (4, N'France              ', 2)
INSERT [dbo].[Country] ([CountryID], [Name], [ContinentID]) VALUES (5, N'China               ', 3)
INSERT [dbo].[Country] ([CountryID], [Name], [ContinentID]) VALUES (6, N'India               ', 3)
INSERT [dbo].[Country] ([CountryID], [Name], [ContinentID]) VALUES (7, N'Australia           ', 4)
INSERT [dbo].[Country] ([CountryID], [Name], [ContinentID]) VALUES (8, N'USA                 ', 5)
INSERT [dbo].[Country] ([CountryID], [Name], [ContinentID]) VALUES (9, N'Canada              ', 5)
INSERT [dbo].[Country] ([CountryID], [Name], [ContinentID]) VALUES (10, N'Brazil              ', 6)
INSERT [dbo].[Country] ([CountryID], [Name], [ContinentID]) VALUES (11, N'Peru                ', 6)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([PersonID], [FirstName], [SecondName], [AddressID]) VALUES (1, N'Pesho               ', N'Peshov              ', 1)
INSERT [dbo].[Person] ([PersonID], [FirstName], [SecondName], [AddressID]) VALUES (2, N'Lui                 ', N'The Fifth           ', 2)
INSERT [dbo].[Person] ([PersonID], [FirstName], [SecondName], [AddressID]) VALUES (3, N'Dalai               ', N'Lama                ', 3)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Town] ON 

INSERT [dbo].[Town] ([TownID], [Name], [CountryID]) VALUES (1, N'Sofia               ', 3)
INSERT [dbo].[Town] ([TownID], [Name], [CountryID]) VALUES (2, N'Paris               ', 4)
INSERT [dbo].[Town] ([TownID], [Name], [CountryID]) VALUES (3, N'Delhi               ', 6)
INSERT [dbo].[Town] ([TownID], [Name], [CountryID]) VALUES (4, N'Toronto             ', 9)
INSERT [dbo].[Town] ([TownID], [Name], [CountryID]) VALUES (5, N'Machu Pichu         ', 11)
SET IDENTITY_INSERT [dbo].[Town] OFF
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Town] FOREIGN KEY([TownID])
REFERENCES [dbo].[Town] ([TownID])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Town]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Continent] FOREIGN KEY([ContinentID])
REFERENCES [dbo].[Continent] ([ContinentID])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Continent]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Address] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Address] ([AddressID])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Address]
GO
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_Country] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Country] ([CountryID])
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_Country]
GO
USE [master]
GO
ALTER DATABASE [LivingSystem] SET  READ_WRITE 
GO
