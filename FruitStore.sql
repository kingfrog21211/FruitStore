USE [master]
GO
/****** Object:  Database [FruitsStore]    Script Date: 09/25/2021 14:10:33 ******/
CREATE DATABASE [FruitsStore]
GO
ALTER DATABASE [FruitsStore] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FruitsStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FruitsStore] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [FruitsStore] SET ANSI_NULLS OFF
GO
ALTER DATABASE [FruitsStore] SET ANSI_PADDING OFF
GO
ALTER DATABASE [FruitsStore] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [FruitsStore] SET ARITHABORT OFF
GO
ALTER DATABASE [FruitsStore] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [FruitsStore] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [FruitsStore] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [FruitsStore] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [FruitsStore] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [FruitsStore] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [FruitsStore] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [FruitsStore] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [FruitsStore] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [FruitsStore] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [FruitsStore] SET  DISABLE_BROKER
GO
ALTER DATABASE [FruitsStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [FruitsStore] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [FruitsStore] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [FruitsStore] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [FruitsStore] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [FruitsStore] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [FruitsStore] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [FruitsStore] SET  READ_WRITE
GO
ALTER DATABASE [FruitsStore] SET RECOVERY SIMPLE
GO
ALTER DATABASE [FruitsStore] SET  MULTI_USER
GO
ALTER DATABASE [FruitsStore] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [FruitsStore] SET DB_CHAINING OFF
GO
USE [FruitsStore]
GO
/****** Object:  ForeignKey [FK_TimeSheet_Employees]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[TimeSheet] DROP CONSTRAINT [FK_TimeSheet_Employees]
GO
/****** Object:  ForeignKey [FK_Products_Suppliers]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_Suppliers]
GO
/****** Object:  ForeignKey [FK_Orders_Customers]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_Customers]
GO
/****** Object:  ForeignKey [FK_Orders_Employees]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_Employees]
GO
/****** Object:  ForeignKey [FK_Orders_Shippers]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_Shippers]
GO
/****** Object:  ForeignKey [FK_OrderDetails_Orders]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_OrderDetails_Orders]
GO
/****** Object:  ForeignKey [FK_OrderDetails_Products]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_OrderDetails_Products]
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraSPDonHang]    Script Date: 09/25/2021 14:10:37 ******/
DROP PROCEDURE [dbo].[sp_KiemTraSPDonHang]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails] DROP CONSTRAINT [FK_OrderDetails_Products]
GO
DROP TABLE [dbo].[OrderDetails]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_Orders_Shippers]
GO
DROP TABLE [dbo].[Orders]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_Suppliers]
GO
DROP TABLE [dbo].[Products]
GO
/****** Object:  Table [dbo].[TimeSheet]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[TimeSheet] DROP CONSTRAINT [FK_TimeSheet_Employees]
GO
DROP TABLE [dbo].[TimeSheet]
GO
/****** Object:  StoredProcedure [dbo].[sp_DangNhap]    Script Date: 09/25/2021 14:10:37 ******/
DROP PROCEDURE [dbo].[sp_DangNhap]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09/25/2021 14:10:34 ******/
DROP TABLE [dbo].[Users]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 09/25/2021 14:10:34 ******/
DROP TABLE [dbo].[Suppliers]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 09/25/2021 14:10:34 ******/
DROP TABLE [dbo].[Customers]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 09/25/2021 14:10:34 ******/
DROP TABLE [dbo].[Employees]
GO
/****** Object:  Table [dbo].[Shippers]    Script Date: 09/25/2021 14:10:34 ******/
DROP TABLE [dbo].[Shippers]
GO
/****** Object:  Table [dbo].[Shippers]    Script Date: 09/25/2021 14:10:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shippers](
	[ShipperID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[Phone] [nvarchar](24) NULL,
 CONSTRAINT [PK_Shippers] PRIMARY KEY CLUSTERED 
(
	[ShipperID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Shippers] ON
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (1, N'Speedy Express', N'(503) 555-9831')
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (2, N'United Package', N'(503) 555-3199')
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (3, N'Federal Shipping', N'(503) 555-9931')
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (4, N'Alliance Shippers', N'1-800-222-0451')
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (5, N'UPS', N'1-800-782-7892')
INSERT [dbo].[Shippers] ([ShipperID], [CompanyName], [Phone]) VALUES (6, N'DHL', N'1-800-225-5345')
SET IDENTITY_INSERT [dbo].[Shippers] OFF
/****** Object:  Table [dbo].[Employees]    Script Date: 09/25/2021 14:10:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nchar](20) NOT NULL,
	[FirstName] [nchar](10) NOT NULL,
	[BirthDate] [datetime] NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Homephone] [nvarchar](24) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [BirthDate], [Address], [City], [Homephone]) VALUES (1, N'Davolio             ', N'Nancy     ', CAST(0x00008E9400000000 AS DateTime), N'507 - 20th Ave. E.\nApt. 2A', N'Seattle', N'2065559857')
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [BirthDate], [Address], [City], [Homephone]) VALUES (2, N'Fuller              ', N'Andrew    ', CAST(0x00008A9600000000 AS DateTime), N'908 W. Capital Way', N'Tacoma', N'2065559482')
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [BirthDate], [Address], [City], [Homephone]) VALUES (3, N'Leverling           ', N'Janet     ', CAST(0x00007E7F00000000 AS DateTime), N'722 Moss Bay Blvd.', N'Kirkland', N'2065553412')
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [BirthDate], [Address], [City], [Homephone]) VALUES (4, N'Peacock             ', N'Margaret  ', CAST(0x00008E4400000000 AS DateTime), N'4110 Old Redmond Rd.', N'Redmond', N'2065558122')
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [BirthDate], [Address], [City], [Homephone]) VALUES (5, N'Buchanan            ', N'Steven    ', CAST(0x00008D7D00000000 AS DateTime), N'14 Garrett Hill', N'London', N'715554848')
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [BirthDate], [Address], [City], [Homephone]) VALUES (6, N'Suyama              ', N'Michael   ', CAST(0x00008F6300000000 AS DateTime), N'Coventry House\nMiner Rd.', N'London', N'715557773')
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [BirthDate], [Address], [City], [Homephone]) VALUES (7, N'King                ', N'Robert    ', CAST(0x00008F4100000000 AS DateTime), N'Edgeham Hollow\nWinchester Way', N'London', N'715555598')
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [BirthDate], [Address], [City], [Homephone]) VALUES (8, N'Callahan            ', N'Laura     ', CAST(0x000084B800000000 AS DateTime), N'4726 - 11th Ave. N.E.', N'Seattle', N'2065551189')
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [BirthDate], [Address], [City], [Homephone]) VALUES (9, N'Dodsworth           ', N'Anne      ', CAST(0x000087A400000000 AS DateTime), N'7 Houndstooth Rd.', N'London', N'715554444')
SET IDENTITY_INSERT [dbo].[Employees] OFF
/****** Object:  Table [dbo].[Customers]    Script Date: 09/25/2021 14:10:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [nchar](5) NOT NULL,
	[CustomerName] [nvarchar](40) NOT NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Phone] [nvarchar](24) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'ALFKI', N'Alfreds Futterkiste', N'Obere Str. 57', N'Berlin', N'030-0074321')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'ANATR', N'Ana Trujillo Emparedados y helados', N'Avda. de la Constituci?n 2222', N'México D.F.', N'(5) 555-4729')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'ANTON', N'Antonio Moreno Taquer?a', N'Mataderos  2312', N'México D.F.', N'(5) 555-3932')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'AROUT', N'Around the Horn', N'120 Hanover Sq.', N'London', N'(171) 555-7788')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'BERGS', N'Berglunds snabbk?p', N'Berguvsv?gen  8', N'Lule?', N'0921-12 34 65')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'BLAUS', N'Blauer See Delikatessen', N'Forsterstr. 57', N'Mannheim', N'0621-08460')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'BLONP', N'Blondesddsl père et fils', N'24, place Kléber', N'Strasbourg', N'88.60.15.31')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'BOLID', N'B?lido Comidas preparadas', N'C/ Araquil, 67', N'Madrid', N'(91) 555 22 82')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'BONAP', N'Bon app''', N'12, rue des Bouchers', N'Marseille', N'91.24.45.40')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'BOTTM', N'Bottom-Dollar Markets', N'23 Tsawassen Blvd.', N'Tsawassen', N'(604) 555-4729')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'BSBEV', N'B''s Beverages', N'Fauntleroy Circus', N'London', N'(171) 555-1212')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'CACTU', N'Cactus Comidas para llevar', N'Cerrito 333', N'Buenos Aires', N'(1) 135-5555')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'CENTC', N'Centro comercial Moctezuma', N'Sierras de Granada 9993', N'México D.F.', N'(5) 555-3392')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'CHOPS', N'Chop-suey Chinese', N'Hauptstr. 29', N'Bern', N'0452-076545')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'COMMI', N'Comércio Mineiro', N'Av. dos Lus?adas, 23', N'Sao Paulo', N'(11) 555-7647')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'CONSH', N'Consolidated Holdings', N'Berkeley Gardens 12  Brewery', N'London', N'(171) 555-2282')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'DRACD', N'Drachenblut Delikatessen', N'Walserweg 21', N'Aachen', N'0241-039123')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'DUMON', N'Du monde entier', N'67, rue des Cinquante Otages', N'Nantes', N'40.67.88.88')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'EASTC', N'Eastern Connection', N'35 King George', N'London', N'(171) 555-0297')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'ERNSH', N'Ernst Handel', N'Kirchgasse 6', N'Graz', N'7675-3425')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'FAMIA', N'Familia Arquibaldo', N'Rua Or?s, 92', N'Sao Paulo', N'(11) 555-9857')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'FISSA', N'FISSA Fabrica Inter. Salchichas S.A.', N'C/ Moralzarzal, 86', N'Madrid', N'(91) 555 94 44')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'FOLIG', N'Folies gourmandes', N'184, chaussée de Tournai', N'Lille', N'20.16.10.16')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'FOLKO', N'Folk och f? HB', N'?kergatan 24', N'Br?cke', N'0695-34 67 21')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'FRANK', N'Frankenversand', N'Berliner Platz 43', N'München', N'089-0877310')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'FRANR', N'France restauration', N'54, rue Royale', N'Nantes', N'40.32.21.21')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'FRANS', N'Franchi S.p.A.', N'Via Monte Bianco 34', N'Torino', N'011-4988260')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'FURIB', N'Furia Bacalhau e Frutos do Mar', N'Jardim das rosas n. 32', N'Lisboa', N'(1) 354-2534')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'GALED', N'Galer?a del gastr?nomo', N'Rambla de Catalu?a, 23', N'Barcelona', N'(93) 203 4560')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'GODOS', N'Godos Cocina T?pica', N'C/ Romero, 33', N'Sevilla', N'(95) 555 82 82')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'GOURL', N'Gourmet Lanchonetes', N'Av. Brasil, 442', N'Campinas', N'(11) 555-9482')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'GREAL', N'Great Lakes Food Market', N'2732 Baker Blvd.', N'Eugene', N'(503) 555-7555')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'GROSR', N'GROSELLA-Restaurante', N'5? Ave. Los Palos Grandes', N'Caracas', N'(2) 283-2951')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'HANAR', N'Hanari Carnes', N'Rua do Paço, 67', N'Rio de Janeiro', N'(21) 555-0091')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'HILAA', N'HILARION-Abastos', N'Carrera 22 con Ave. Carlos Soublette #8-35', N'San Crist?bal', N'(5) 555-1340')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'HUNGC', N'Hungry Coyote Import Store', N'City Center Plaza 516 Main St.', N'Elgin', N'(503) 555-6874')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'HUNGO', N'Hungry Owl All-Night Grocers', N'8 Johnstown Road', N'Cork', N'2967 542')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'ISLAT', N'Island Trading', N'Garden House Crowther Way', N'Cowes', N'(198) 555-8888')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'KOENE', N'K?niglich Essen', N'Maubelstr. 90', N'Brandenburg', N'0555-09876')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'LACOR', N'La corne d''abondance', N'67, avenue de l''Europe', N'Versailles', N'30.59.84.10')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'LAMAI', N'La maison d''Asie', N'1 rue Alsace-Lorraine', N'Toulouse', N'61.77.61.10')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'LAUGB', N'Laughing Bacchus Wine Cellars', N'1900 Oak St.', N'Vancouver', N'(604) 555-3392')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'LAZYK', N'Lazy K Kountry Store', N'12 Orchestra Terrace', N'Walla Walla', N'(509) 555-7969')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'LEHMS', N'Lehmanns Marktstand', N'Magazinweg 7', N'Frankfurt a.M.', N'069-0245984')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'LETSS', N'Let''s Stop N Shop', N'87 Polk St. Suite 5', N'San Francisco', N'(415) 555-5938')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'LILAS', N'LILA-Supermercado', N'Carrera 52 con Ave. Bol?var #65-98 Llano Largo', N'Barquisimeto', N'(9) 331-6954')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'LINOD', N'LINO-Delicateses', N'Ave. 5 de Mayo Porlamar', N'I. de Margarita', N'(8) 34-56-12')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'LONEP', N'Lonesome Pine Restaurant', N'89 Chiaroscuro Rd.', N'Portland', N'(503) 555-9573')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'MAGAA', N'Magazzini Alimentari Riuniti', N'Via Ludovico il Moro 22', N'Bergamo', N'035-640230')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'MAISD', N'Maison Dewey', N'Rue Joseph-Bens 532', N'Bruxelles', N'(02) 201 24 67')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'MEREP', N'Mère Paillarde', N'43 rue St. Laurent', N'Montréal', N'(514) 555-8054')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'MORGK', N'Morgenstern Gesundkost', N'Heerstr. 22', N'Leipzig', N'0342-023176')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'NORTS', N'North/South', N'South House 300 Queensbridge', N'London', N'(171) 555-7733')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'OCEAN', N'Océano Atl?ntico Ltda.', N'Ing. Gustavo Moncada 8585 Piso 20-A', N'Buenos Aires', N'(1) 135-5333')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'OLDWO', N'Old World Delicatessen', N'2743 Bering St.', N'Anchorage', N'(907) 555-7584')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'OTTIK', N'Ottilies K?seladen', N'Mehrheimerstr. 369', N'K?ln', N'0221-0644327')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'PERIC', N'Pericles Comidas cl?sicas', N'Calle Dr. Jorge Cash 321', N'México D.F.', N'(5) 552-3745')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'PICCO', N'Piccolo und mehr', N'Geislweg 14', N'Salzburg', N'6562-9722')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'PRINI', N'Princesa Isabel Vinhos', N'Estrada da sa?de n. 58', N'Lisboa', N'(1) 356-5634')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'QUEDE', N'Que Del?cia', N'Rua da Panificadora, 12', N'Rio de Janeiro', N'(21) 555-4252')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'QUEEN', N'Queen Cozinha', N'Alameda dos Canàrios, 891', N'Sao Paulo', N'(11) 555-1189')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'QUICK', N'QUICK-Stop', N'Taucherstra?e 10', N'Cunewalde', N'0372-035188')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'RANCH', N'Rancho grande', N'Av. del Libertador 900', N'Buenos Aires', N'(1) 123-5555')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'RATTC', N'Rattlesnake Canyon Grocery', N'2817 Milton Dr.', N'Albuquerque', N'(505) 555-5939')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'REGGC', N'Reggiani Caseifici', N'Strada Provinciale 124', N'Reggio Emilia', N'0522-556721')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'RICAR', N'Ricardo Adocicados', N'Av. Copacabana, 267', N'Rio de Janeiro', N'(21) 555-3412')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'RICSU', N'Richter Supermarkt', N'Grenzacherweg 237', N'Genève', N'0897-034214')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'ROMEY', N'Romero y tomillo', N'Gran V?a, 1', N'Madrid', N'(91) 745 6200')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'SANTG', N'Santé Gourmet', N'Erling Skakkes gate 78', N'Stavern', N'07-98 92 35')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'SAVEA', N'Save-a-lot Markets', N'187 Suffolk Ln.', N'Boise', N'(208) 555-8097')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'SEVES', N'Seven Seas Imports', N'90 Wadhurst Rd.', N'London', N'(171) 555-1717')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'SIMOB', N'Simons bistro', N'Vinb?ltet 34', N'Kobenhavn', N'31 12 34 56')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'SPECD', N'Spécialités du monde', N'25, rue Lauriston', N'Paris', N'(1) 47.55.60.10')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'SPLIR', N'Split Rail Beer & Ale', N'P.O. Box 555', N'Lander', N'(307) 555-4680')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'SUPRD', N'Suprêmes délices', N'Boulevard Tirou, 255', N'Charleroi', N'(071) 23 67 22 20')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'THEBI', N'The Big Cheese', N'89 Jefferson Way Suite 2', N'Portland', N'(503) 555-3612')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'THECR', N'The Cracker Box', N'55 Grizzly Peak Rd.', N'Butte', N'(406) 555-5834')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'TOMSP', N'Toms Spezialit?ten', N'Luisenstr. 48', N'Münster', N'0251-031259')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'TORTU', N'Tortuga Restaurante', N'Avda. Azteca 123', N'México D.F.', N'(5) 555-2933')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'TRADH', N'Tradiç?o Hipermercados', N'Av. Inês de Castro, 414', N'Sao Paulo', N'(11) 555-2167')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'TRAIH', N'Trail''s Head Gourmet Provisioners', N'722 DaVinci Blvd.', N'Kirkland', N'(206) 555-8257')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'TTCM ', N'Tran Thi Cam My', N'my', N'my', N'123')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'VAFFE', N'Vaffeljernet', N'Smagsloget 45', N'?rhus', N'86 21 32 43')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'VICTE', N'Victuailles en stock', N'2, rue du Commerce', N'Lyon', N'78.32.54.86')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'VINET', N'Vins et alcools Chevalier', N'59 rue de l''Abbaye', N'Reims', N'26.47.15.10')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'WANDK', N'Die Wandernde Kuh', N'Adenauerallee 900', N'Stuttgart', N'0711-020361')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'WARTH', N'Wartian Herkku', N'Torikatu 38', N'Oulu', N'981-443655')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'WELLI', N'Wellington Importadora', N'Rua do Mercado, 12', N'Resende', N'(14) 555-8122')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'WHITC', N'White Clover Markets', N'305 - 14th Ave. S. Suite 3B', N'Seattle', N'(206) 555-4112')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'WILMK', N'Wilman Kala', N'Keskuskatu 45', N'Helsinki', N'90-224 8858')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Address], [City], [Phone]) VALUES (N'WOLZA', N'Wolski  Zajazd', N'ul. Filtrowa 68', N'Warszawa', N'(26) 642-7012')
/****** Object:  Table [dbo].[Suppliers]    Script Date: 09/25/2021 14:10:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Country] [nvarchar](15) NULL,
	[Phone] [nvarchar](24) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (1, N'Exotic Liquids', N'49 Gilbert St.', N'London', N'UK', N'(171) 555-2222')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (2, N'New Orleans Cajun Delights', N'P.O. Box 78934', N'New Orleans', N'USA', N'(100) 555-4822')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (3, N'Grandma Kelly''s Homestead', N'707 Oxford Rd.', N'Ann Arbor', N'USA', N'(313) 555-5735')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (4, N'Tokyo Traders', N'9-8 Sekimai Musashino-shi', N'Tokyo', N'Japan', N'(03) 3555-5011')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (5, N'Cooperativa de Quesos ''Las Cabras''', N'Calle del Rosal 4', N'Oviedo', N'Spain', N'(98) 598 76 54')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (6, N'Mayumi''s', N'92 Setsuko Chuo-ku', N'Osaka', N'Japan', N'(06) 431-7877')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (7, N'Pavlova, Ltd.', N'74 Rose St. Moonie Ponds', N'Melbourne', N'Australia', N'(03) 444-2343')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (8, N'Specialty Biscuits, Ltd.', N'29 King''s Way', N'Manchester', N'UK', N'(161) 555-4448')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (9, N'PB Kn?ckebr?d AB', N'Kaloadagatan 13', N'G?teborg', N'Sweden', N'031-987 65 43')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (10, N'Refrescos Americanas LTDA', N'Av. das Americanas 12.890', N'Sao Paulo', N'Brazil', N'(11) 555 4640')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (11, N'Heli Sü?waren GmbH & Co. KG', N'Tiergartenstra?e 5', N'Berlin', N'Germany', N'(010) 9984510')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (12, N'Plutzer Lebensmittelgro?m?rkte AG', N'Bogenallee 51', N'Frankfurt', N'Germany', N'(069) 992755')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (13, N'Nord-Ost-Fisch Handelsgesellschaft mbH', N'Frahmredder 112a', N'Cuxhaven', N'Germany', N'(04721) 8713')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (14, N'Formaggi Fortini s.r.l.', N'Viale Dante, 75', N'Ravenna', N'Italy', N'(0544) 60323')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (15, N'Norske Meierier', N'Hatlevegen 5', N'Sandvika', N'Norway', N'(0)2-953010')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (16, N'Bigfoot Breweries', N'3400 - 8th Avenue Suite 210', N'Bend', N'USA', N'(503) 555-9931')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (17, N'Svensk Sj?f?da AB', N'Brovallav?gen 231', N'Stockholm', N'Sweden', N'08-123 45 67')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (18, N'Aux joyeux ecclésiastiques', N'203, Rue des Francs-Bourgeois', N'Paris', N'France', N'(1) 03.83.00.68')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (19, N'New England Seafood Cannery', N'Order Processing Dept. 2100 Paul Revere Blvd.', N'Boston', N'USA', N'(617) 555-3267')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (20, N'Leka Trading', N'471 Serangoon Loop, Suite #402', N'Singapore', N'Singapore', N'555-8787')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (21, N'Lyngbysild', N'Lyngbysild Fiskebakken 10', N'Lyngby', N'Denmark', N'43844108')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (22, N'Zaanse Snoepfabriek', N'Verkoop Rijnweg 22', N'Zaandam', N'Netherlands', N'(12345) 1212')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (23, N'Karkki Oy', N'Valtakatu 12', N'Lappeenranta', N'Finland', N'(953) 10956')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (24, N'G''day, Mate', N'170 Prince Edward Parade Hunter''s Hill', N'Sydney', N'Australia', N'(02) 555-5914')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (25, N'Ma Maison', N'2960 Rue St. Laurent', N'Montréal', N'Canada', N'(514) 555-9022')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (26, N'Pasta Buttini s.r.l.', N'Via dei Gelsomini, 153', N'Salerno', N'Italy', N'(089) 6547665')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (27, N'Escargots Nouveaux', N'22, rue H. Voiron', N'Montceau', N'France', N'85.57.00.07')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (28, N'Gai pâturage', N'Bat. B 3, rue des Alpes', N'Annecy', N'France', N'38.76.98.06')
INSERT [dbo].[Suppliers] ([SupplierID], [CompanyName], [Address], [City], [Country], [Phone]) VALUES (29, N'Forêts d''érables', N'148 rue Chasseur', N'Ste-Hyacinthe', N'Canada', N'(514) 555-2955')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
/****** Object:  Table [dbo].[Users]    Script Date: 09/25/2021 14:10:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [nvarchar](50) NOT NULL,
	[Password] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Users] ([UserID], [Password]) VALUES (N'1854050060', 2102)
INSERT [dbo].[Users] ([UserID], [Password]) VALUES (N'admin', 1)
/****** Object:  StoredProcedure [dbo].[sp_DangNhap]    Script Date: 09/25/2021 14:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DangNhap]
@UserID nvarchar(50),
@Password int
as begin
declare @count int
declare @res bit
select @count = COUNT(*) from Users where UserID = @UserID and Password = @Password
if @count >0
set @res = 1
else
set @res = 0
select @res
end
GO
/****** Object:  Table [dbo].[TimeSheet]    Script Date: 09/25/2021 14:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeSheet](
	[WorkDate] [datetime] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[TimeFrom] [nvarchar](50) NULL,
	[TimeTo] [nvarchar](50) NULL,
	[Hours] [int] NULL,
	[Notes] [nvarchar](50) NULL,
 CONSTRAINT [PK_TimeSheet] PRIMARY KEY CLUSTERED 
(
	[WorkDate] ASC,
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TimeSheet] ([WorkDate], [EmployeeID], [TimeFrom], [TimeTo], [Hours], [Notes]) VALUES (CAST(0x0000AD9700000000 AS DateTime), 3, N'7h00', N'12h00', 5, N'')
INSERT [dbo].[TimeSheet] ([WorkDate], [EmployeeID], [TimeFrom], [TimeTo], [Hours], [Notes]) VALUES (CAST(0x0000AD9700000000 AS DateTime), 4, N'12h00', N'22h00', 10, N'')
INSERT [dbo].[TimeSheet] ([WorkDate], [EmployeeID], [TimeFrom], [TimeTo], [Hours], [Notes]) VALUES (CAST(0x0000ADA300000000 AS DateTime), 2, N'12h00', N'17h00', 5, N'')
INSERT [dbo].[TimeSheet] ([WorkDate], [EmployeeID], [TimeFrom], [TimeTo], [Hours], [Notes]) VALUES (CAST(0x0000ADA300000000 AS DateTime), 9, N'7h00', N'12h00', 5, N'')
INSERT [dbo].[TimeSheet] ([WorkDate], [EmployeeID], [TimeFrom], [TimeTo], [Hours], [Notes]) VALUES (CAST(0x0000ADA900000000 AS DateTime), 2, N'12h00', N'17h00', 5, N'')
INSERT [dbo].[TimeSheet] ([WorkDate], [EmployeeID], [TimeFrom], [TimeTo], [Hours], [Notes]) VALUES (CAST(0x0000ADA900000000 AS DateTime), 7, N'7h00', N'17h00', 10, N'')
INSERT [dbo].[TimeSheet] ([WorkDate], [EmployeeID], [TimeFrom], [TimeTo], [Hours], [Notes]) VALUES (CAST(0x0000ADAB00000000 AS DateTime), 5, N'17h00', N'22h00', 5, N'')
/****** Object:  Table [dbo].[Products]    Script Date: 09/25/2021 14:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[SupplierID] [int] NULL,
	[UnitPrice] [money] NULL,
	[UnitInStock] [smallint] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (1, N'Apple', 8, 18.0000, 508)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (2, N'Apricot', 1, 19.0000, 403)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (3, N'Avocado', 1, 10.0000, 205)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (4, N'Banana', 2, 22.0000, 215)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (5, N'Blackberry', 2, 21.3500, 150)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (6, N'Cantaloupe', 3, 25.0000, 230)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (7, N'Cherry', 3, 30.0000, 125)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (8, N'Chinese date', 3, 40.0000, 100)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (9, N'Cornelian cherry', 4, 97.0000, 132)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (10, N'Cranberry', 4, 31.0000, 214)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (11, N'Cucumber', 5, 21.0000, 201)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (12, N'Curry berry', 5, 38.0000, 112)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (13, N'Fig', 6, 6.0000, 123)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (14, N'Durian', 6, 23.2500, 20)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (15, N'Dragon fruit', 6, 13.0000, 301)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (16, N'Damson plum', 7, 17.4500, 403)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (17, N'Custard apple', 7, 39.0000, 306)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (18, N'Grapes', 7, 62.5000, 100)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (19, N'Green olive', 8, 9.2000, 153)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (20, N'Gooseberry', 8, 81.0000, 315)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (21, N'Grapefruit', 8, 10.0000, 30)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (22, N'Green plum', 9, 21.0000, 233)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (23, N'Guava', 9, 9.0000, 133)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (24, N'Hawthorn', 10, 4.5000, 51)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (25, N'Hyuganatsu', 11, 14.0000, 233)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (26, N'Lemon', 11, 31.2300, 145)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (27, N'Lime', 11, 43.9000, 189)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (28, N'Kumquat', 12, 45.6000, 185)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (29, N'Kiwi', 12, 123.7900, 556)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (30, N'King coconut', 13, 25.8900, 123)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (31, N'Coconut', 14, 12.5000, 520)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (32, N'Kaffir lime', 14, 32.0000, 131)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (33, N'Jackfruit', 15, 2.5000, 211)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (34, N'Ichang papeda', 16, 14.0000, 111)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (35, N'Mango', 16, 18.0000, 533)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (36, N'Mangosteen', 17, 19.0000, 388)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (37, N'Orange', 17, 26.0000, 880)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (38, N'Papaya', 18, 263.5000, 100)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (39, N'Peach', 18, 18.0000, 560)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (40, N'Pineapple', 19, 18.4000, 65)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (41, N'Plum', 19, 9.6500, 237)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (42, N'Raisins', 20, 14.0000, 36)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (43, N'Strawberry', 20, 46.0000, 262)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (44, N'Tomato', 20, 19.4500, 156)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (45, N'Watermelon', 21, 9.5000, 83)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (46, N'Rambutan', 21, 12.0000, 682)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (47, N'Jujube', 22, 9.5000, 315)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (48, N'Feijoa', 22, 12.7500, 956)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (49, N'Chico fruit', 23, 20.0000, 451)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (50, N'Star apple', 23, 16.2500, 122)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (51, N'Black berry', 24, 53.0000, 313)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (52, N'Blueberry', 24, 7.0000, 122)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (53, N'Mulberry', 24, 32.8000, 75)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (54, N'Persimmon', 25, 7.4500, 26)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (55, N'Pomegranate', 25, 24.0000, 115)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (56, N'Pear', 26, 38.0000, 21)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (57, N'Litchi', 26, 19.5000, 36)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (58, N'Loquat', 27, 13.2500, 62)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (59, N'Physalis', 28, 55.0000, 79)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (60, N'Date', 28, 34.0000, 19)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (61, N'Passion fruit', 29, 28.5000, 113)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (62, N'Sapodilla', 29, 49.3000, 17)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (63, N'Corn', 7, 43.9000, 24)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (64, N'Raspberry', 12, 33.2500, 22)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (65, N'Shaddock', 2, 21.0500, 76)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (66, N'Jamunfruit', 2, 17.0000, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (67, N'Hanepoot', 16, 14.0000, 52)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (68, N'Melon', 8, 12.5000, 6)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (69, N'Pumpkin', 15, 36.0000, 26)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (70, N'Lychee', 7, 15.0000, 15)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (71, N'Elderberry', 15, 21.5000, 26)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (72, N'Grewia', 14, 34.8000, 14)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (73, N'Carambola', 17, 15.0000, 101)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (74, N'Cranberry', 4, 10.0000, 4)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (75, N'Red currant', 12, 7.7500, 125)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (76, N'Tamarind', 23, 18.0000, 57)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (77, N'Sugacane', 12, 13.0000, 32)
INSERT [dbo].[Products] ([ProductID], [ProductName], [SupplierID], [UnitPrice], [UnitInStock]) VALUES (78, N'san pham ', 9, 15.0000, 100)
SET IDENTITY_INSERT [dbo].[Products] OFF
/****** Object:  Table [dbo].[Orders]    Script Date: 09/25/2021 14:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [nchar](5) NULL,
	[EmployeeID] [int] NULL,
	[OrderDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[ShipperID] [int] NULL,
	[ShipAddress] [nvarchar](60) NULL,
	[ShipCity] [nvarchar](15) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Orders] ON
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10248, N'VINET', 5, CAST(0x0000ABEE00000000 AS DateTime), CAST(0x0000ABEF00000000 AS DateTime), 1, N'59 rue de l''Abbaye', N'Reims')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10249, N'TOMSP', 6, CAST(0x0000ABEF00000000 AS DateTime), CAST(0x0000ABF000000000 AS DateTime), 2, N'Luisenstr. 48', N'Münster')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10250, N'HANAR', 4, CAST(0x0000ABF200000000 AS DateTime), CAST(0x0000ABF400000000 AS DateTime), 6, N'Rua do Paço, 67', N'Rio de Janeiro')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10251, N'VICTE', 3, CAST(0x0000ABF200000000 AS DateTime), CAST(0x0000ABF300000000 AS DateTime), 1, N'2, rue du Commerce', N'Lyon')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10252, N'SUPRD', 4, CAST(0x0000ABF300000000 AS DateTime), CAST(0x0000ABF400000000 AS DateTime), 3, N'Boulevard Tirou, 255', N'Charleroi')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10253, N'HANAR', 3, CAST(0x0000ABF400000000 AS DateTime), CAST(0x0000ABF500000000 AS DateTime), 5, N'Rua do Paço, 67', N'Rio de Janeiro')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10254, N'CHOPS', 5, CAST(0x0000ABF500000000 AS DateTime), CAST(0x0000ABF600000000 AS DateTime), 2, N'Hauptstr. 31', N'Bern')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10255, N'RICSU', 9, CAST(0x0000ABF600000000 AS DateTime), CAST(0x0000ABF700000000 AS DateTime), 4, N'Starenweg 5', N'Genève')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10256, N'WELLI', 3, CAST(0x0000ABF900000000 AS DateTime), CAST(0x0000ABFB00000000 AS DateTime), 6, N'Rua do Mercado, 12', N'Resende')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10257, N'HILAA', 4, CAST(0x0000ABFA00000000 AS DateTime), CAST(0x0000AC0000000000 AS DateTime), 5, N'Carrera 22 con Ave. Carlos Soublette #8-35', N'San Crist?bal')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10258, N'ERNSH', 1, CAST(0x0000ABFB00000000 AS DateTime), CAST(0x0000AC0100000000 AS DateTime), 5, N'Kirchgasse 6', N'Graz')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10259, N'CENTC', 4, CAST(0x0000ABFC00000000 AS DateTime), CAST(0x0000AC0300000000 AS DateTime), 2, N'Sierras de Granada 9993', N'México D.F.')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10260, N'OTTIK', 4, CAST(0x0000ABFD00000000 AS DateTime), CAST(0x0000AC0700000000 AS DateTime), 1, N'Mehrheimerstr. 369', N'K?ln')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10261, N'QUEDE', 4, CAST(0x0000ABFD00000000 AS DateTime), CAST(0x0000AC0800000000 AS DateTime), 4, N'Rua da Panificadora, 12', N'Rio de Janeiro')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10262, N'RATTC', 8, CAST(0x0000AC0000000000 AS DateTime), CAST(0x0000AC0300000000 AS DateTime), 3, N'2817 Milton Dr.', N'Albuquerque')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10263, N'ERNSH', 9, CAST(0x0000AC0100000000 AS DateTime), CAST(0x0000AC0900000000 AS DateTime), 3, N'Kirchgasse 6', N'Graz')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10264, N'FOLKO', 6, CAST(0x0000AC0200000000 AS DateTime), CAST(0x0000AC0300000000 AS DateTime), 6, N'?kergatan 24', N'Br?cke')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10265, N'BLONP', 2, CAST(0x0000AC0300000000 AS DateTime), CAST(0x0000AC0A00000000 AS DateTime), 2, N'24, place Kléber', N'Strasbourg')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10266, N'WARTH', 3, CAST(0x0000AC0400000000 AS DateTime), CAST(0x0000AC0900000000 AS DateTime), 5, N'Torikatu 38', N'Oulu')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10267, N'FRANK', 4, CAST(0x0000AC0700000000 AS DateTime), CAST(0x0000AC0F00000000 AS DateTime), 3, N'Berliner Platz 43', N'München')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10268, N'GROSR', 8, CAST(0x0000AC0800000000 AS DateTime), CAST(0x0000AC0B00000000 AS DateTime), 4, N'5? Ave. Los Palos Grandes', N'Caracas')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10269, N'WHITC', 5, CAST(0x0000AC0900000000 AS DateTime), CAST(0x0000AC1200000000 AS DateTime), 2, N'1029 - 12th Ave. S.', N'Seattle')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10270, N'WARTH', 1, CAST(0x0000AC0A00000000 AS DateTime), CAST(0x0000AC0B00000000 AS DateTime), 1, N'Torikatu 38', N'Oulu')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10271, N'SPLIR', 6, CAST(0x0000AC0A00000000 AS DateTime), CAST(0x0000AC2700000000 AS DateTime), 6, N'P.O. Box 555', N'Lander')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10272, N'RATTC', 6, CAST(0x0000AC0B00000000 AS DateTime), CAST(0x0000AC0F00000000 AS DateTime), 6, N'2817 Milton Dr.', N'Albuquerque')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10273, N'QUICK', 3, CAST(0x0000AC0E00000000 AS DateTime), CAST(0x0000AC1500000000 AS DateTime), 5, N'Taucherstra?e 10', N'Cunewalde')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10274, N'VINET', 6, CAST(0x0000AC0F00000000 AS DateTime), CAST(0x0000AC1900000000 AS DateTime), 1, N'59 rue de l''Abbaye', N'Reims')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10275, N'MAGAA', 1, CAST(0x0000AC1000000000 AS DateTime), CAST(0x0000AC1200000000 AS DateTime), 1, N'Via Ludovico il Moro 22', N'Bergamo')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10276, N'TORTU', 8, CAST(0x0000AC1100000000 AS DateTime), CAST(0x0000AC1700000000 AS DateTime), 5, N'Avda. Azteca 123', N'México D.F.')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10277, N'MORGK', 2, CAST(0x0000AC1200000000 AS DateTime), CAST(0x0000AC1600000000 AS DateTime), 5, N'Heerstr. 22', N'Leipzig')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10278, N'BERGS', 8, CAST(0x0000AC1500000000 AS DateTime), CAST(0x0000AC1900000000 AS DateTime), 6, N'Berguvsv?gen  8', N'Lule?')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10279, N'LEHMS', 8, CAST(0x0000AC1600000000 AS DateTime), CAST(0x0000AC1900000000 AS DateTime), 6, N'Magazinweg 7', N'Frankfurt a.M.')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10280, N'BERGS', 2, CAST(0x0000AC1700000000 AS DateTime), CAST(0x0000AC3400000000 AS DateTime), 6, N'Berguvsv?gen  8', N'Lule?')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10281, N'ROMEY', 4, CAST(0x0000AC1700000000 AS DateTime), CAST(0x0000AC1E00000000 AS DateTime), 3, N'Gran V?a, 1', N'Madrid')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10282, N'ROMEY', 4, CAST(0x0000AC1800000000 AS DateTime), CAST(0x0000AC1E00000000 AS DateTime), 1, N'Gran V?a, 1', N'Madrid')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10283, N'LILAS', 3, CAST(0x0000AC1900000000 AS DateTime), CAST(0x0000AC2000000000 AS DateTime), 2, N'Carrera 52 con Ave. Bol?var #65-98 Llano Largo', N'Barquisimeto')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [ShippedDate], [ShipperID], [ShipAddress], [ShipCity]) VALUES (10288, N'QUICK', 1, CAST(0x0000AD5800000000 AS DateTime), CAST(0x0000AD6000000000 AS DateTime), 4, N'my tran', N'th')
SET IDENTITY_INSERT [dbo].[Orders] OFF
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 09/25/2021 14:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [smallint] NOT NULL,
	[Discount] [real] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10248, 11, 21.0000, 12, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10248, 42, 14.0000, 10, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10248, 72, 34.8000, 5, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10249, 14, 23.2500, 9, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10249, 51, 53.0000, 40, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10250, 41, 9.6500, 10, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10250, 51, 53.0000, 35, 0.15)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10250, 65, 21.0500, 15, 0.15)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10251, 22, 21.0000, 6, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10251, 57, 19.5000, 15, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10251, 65, 21.0500, 20, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10252, 20, 81.0000, 40, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10252, 33, 2.5000, 25, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10252, 60, 34.0000, 40, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10253, 31, 12.5000, 20, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10253, 39, 18.0000, 42, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10253, 49, 20.0000, 40, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10254, 24, 4.5000, 15, 0.15)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10254, 55, 24.0000, 21, 0.15)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10254, 74, 10.0000, 21, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10255, 2, 19.0000, 20, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10255, 16, 17.4500, 35, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10255, 36, 19.0000, 25, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10255, 59, 55.0000, 30, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10256, 53, 32.0000, 15, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10256, 77, 13.0000, 12, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10257, 27, 43.9000, 25, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10257, 39, 18.0000, 6, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10257, 77, 13.0000, 15, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10258, 2, 19.0000, 50, 0.2)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10258, 5, 21.3500, 65, 0.2)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10258, 32, 32.0000, 6, 0.2)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10259, 21, 10.0000, 10, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10259, 37, 26.0000, 1, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10260, 41, 9.6500, 16, 0.25)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10260, 57, 19.5000, 50, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10260, 62, 49.3000, 15, 0.25)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10260, 70, 15.0000, 21, 0.25)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10261, 21, 10.0000, 20, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10261, 35, 18.0000, 20, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10262, 5, 21.3500, 12, 0.2)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10262, 7, 30.0000, 15, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10262, 56, 38.0000, 2, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10263, 16, 17.4500, 60, 0.25)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10263, 24, 4.5000, 28, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10263, 30, 25.8900, 60, 0.25)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10263, 74, 10.0000, 36, 0.25)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10264, 2, 19.0000, 35, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10264, 41, 9.6500, 25, 0.15)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10265, 17, 39.0000, 30, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10265, 70, 15.0000, 20, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10266, 12, 38.0000, 12, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10267, 40, 18.4000, 50, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10267, 59, 55.0000, 70, 0.15)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10267, 76, 18.0000, 15, 0.15)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10268, 29, 123.7900, 10, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10268, 72, 34.8000, 4, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10269, 33, 2.5000, 60, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10269, 72, 34.8000, 20, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10270, 36, 19.0000, 30, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10270, 43, 46.0000, 25, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10271, 33, 2.5000, 24, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10272, 20, 81.0000, 6, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10272, 31, 12.5000, 40, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10272, 72, 34.8000, 24, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10273, 10, 31.0000, 24, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10273, 31, 12.5000, 15, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10273, 33, 2.5000, 20, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10273, 40, 18.4000, 60, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10273, 76, 18.0000, 33, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10274, 71, 21.5000, 20, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10274, 72, 34.8000, 7, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10275, 24, 4.5000, 12, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10275, 59, 55.0000, 6, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10276, 10, 31.0000, 15, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10276, 13, 6.0000, 10, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10277, 28, 45.6000, 20, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10277, 62, 49.3000, 12, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10278, 44, 19.4500, 16, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10278, 59, 55.0000, 15, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10278, 63, 43.9000, 8, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10278, 73, 15.0000, 25, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10279, 17, 39.0000, 15, 0.25)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10280, 24, 4.5000, 12, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10280, 55, 24.0000, 20, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10280, 75, 7.7500, 30, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10281, 19, 9.2000, 1, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10281, 24, 4.5000, 6, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10281, 35, 18.0000, 4, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10282, 30, 25.8900, 6, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10282, 57, 19.5000, 2, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10283, 15, 13.0000, 20, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10283, 19, 9.2000, 18, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10283, 60, 34.0000, 35, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10283, 72, 34.8000, 3, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10288, 7, 30.0000, 1, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10288, 8, 40.0000, 1, 0.05)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10288, 10, 31.0000, 1, 0)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (10288, 77, 13.0000, 1, 0.1)
/****** Object:  StoredProcedure [dbo].[sp_KiemTraSPDonHang]    Script Date: 09/25/2021 14:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_KiemTraSPDonHang] @MaDH int, @MaSP int
as
begin
	set nocount on
	declare @sl int
	select @sl=COUNT(*) from [OrderDetails]
	where OrderID=@MaDH and ProductID=@MaSP
	select @sl as alias
end
GO
/****** Object:  ForeignKey [FK_TimeSheet_Employees]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[TimeSheet]  WITH CHECK ADD  CONSTRAINT [FK_TimeSheet_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[TimeSheet] CHECK CONSTRAINT [FK_TimeSheet_Employees]
GO
/****** Object:  ForeignKey [FK_Products_Suppliers]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
/****** Object:  ForeignKey [FK_Orders_Customers]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
/****** Object:  ForeignKey [FK_Orders_Employees]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
/****** Object:  ForeignKey [FK_Orders_Shippers]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Shippers] FOREIGN KEY([ShipperID])
REFERENCES [dbo].[Shippers] ([ShipperID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Shippers]
GO
/****** Object:  ForeignKey [FK_OrderDetails_Orders]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
/****** Object:  ForeignKey [FK_OrderDetails_Products]    Script Date: 09/25/2021 14:10:37 ******/
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
