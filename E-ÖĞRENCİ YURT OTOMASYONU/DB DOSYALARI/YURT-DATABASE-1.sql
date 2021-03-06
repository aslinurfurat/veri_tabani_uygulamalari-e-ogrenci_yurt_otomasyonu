USE [master]
GO
/****** Object:  Database [YurtOtomasyonDB]    Script Date: 16.12.2019 18:29:40 ******/
CREATE DATABASE [YurtOtomasyonDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YurtOtomasyonDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\YurtOtomasyonDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'YurtOtomasyonDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\YurtOtomasyonDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [YurtOtomasyonDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YurtOtomasyonDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YurtOtomasyonDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YurtOtomasyonDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YurtOtomasyonDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [YurtOtomasyonDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YurtOtomasyonDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [YurtOtomasyonDB] SET  MULTI_USER 
GO
ALTER DATABASE [YurtOtomasyonDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YurtOtomasyonDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YurtOtomasyonDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YurtOtomasyonDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [YurtOtomasyonDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [YurtOtomasyonDB] SET QUERY_STORE = OFF
GO
USE [YurtOtomasyonDB]
GO
/****** Object:  Table [dbo].[Izinler]    Script Date: 16.12.2019 18:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Izinler](
	[ogr_id] [int] NOT NULL,
	[adi_soyadi] [nvarchar](50) NULL,
	[baslangic_tarihi] [datetime] NULL,
	[bitis_tarihi] [datetime] NULL,
	[gidecegi_adres] [nvarchar](100) NULL,
	[telefon] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda_Bilgileri]    Script Date: 16.12.2019 18:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda_Bilgileri](
	[oda_id] [int] IDENTITY(1,1) NOT NULL,
	[oda_numarasi] [int] NULL,
	[oda_durumu] [nvarchar](50) NULL,
	[kat] [nvarchar](50) NULL,
	[yatak_id] [int] NOT NULL,
 CONSTRAINT [PK_Oda_Bilgileri] PRIMARY KEY CLUSTERED 
(
	[oda_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenciler]    Script Date: 16.12.2019 18:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenciler](
	[ogr_id] [int] IDENTITY(1,1) NOT NULL,
	[tc] [nvarchar](50) NULL,
	[adi_soyadi] [nvarchar](100) NULL,
	[dogum_tarihi] [datetime] NULL,
	[dogum_yeri] [nvarchar](50) NULL,
	[kayit_tarihi] [datetime] NULL,
	[okulu] [nvarchar](50) NULL,
	[bolumu] [nvarchar](50) NULL,
	[ogr_turu] [nvarchar](50) NULL,
	[tel_no] [nvarchar](50) NULL,
	[adres] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ogrenciler] PRIMARY KEY CLUSTERED 
(
	[ogr_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel_Bilgileri]    Script Date: 16.12.2019 18:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel_Bilgileri](
	[personel_id] [int] IDENTITY(1,1) NOT NULL,
	[p_adi_soyadi] [nvarchar](50) NULL,
	[ise_giris_tarihi] [datetime] NULL,
	[adres] [nvarchar](100) NULL,
	[tel_no] [nvarchar](20) NULL,
	[gorevi] [nvarchar](50) NULL,
	[maas] [int] NULL,
 CONSTRAINT [PK_Personel_Bilgileri] PRIMARY KEY CLUSTERED 
(
	[personel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ucret_Bilgisi]    Script Date: 16.12.2019 18:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ucret_Bilgisi](
	[ucret_id] [int] IDENTITY(1,1) NOT NULL,
	[ogr_id] [int] NULL,
	[miktar] [int] NULL,
	[odeme_tarihi] [datetime] NULL,
	[odenen_tutar] [int] NULL,
	[yeni_borc] [int] NULL,
 CONSTRAINT [PK_Ucret_Bilgisi] PRIMARY KEY CLUSTERED 
(
	[ucret_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yatak_Bilgileri]    Script Date: 16.12.2019 18:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yatak_Bilgileri](
	[yatak_id] [int] IDENTITY(1,1) NOT NULL,
	[ogr_id] [int] NOT NULL,
	[fiyat] [nvarchar](20) NULL,
	[yatak_durum] [bit] NULL,
	[yatak_numarasi] [int] NULL,
 CONSTRAINT [PK_Yatak_Bilgileri] PRIMARY KEY CLUSTERED 
(
	[yatak_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yonetici]    Script Date: 16.12.2019 18:29:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yonetici](
	[kullanici_adi] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
	[personel_id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Izinler]  WITH CHECK ADD  CONSTRAINT [FK_Izinler_Ogrenciler] FOREIGN KEY([ogr_id])
REFERENCES [dbo].[Ogrenciler] ([ogr_id])
GO
ALTER TABLE [dbo].[Izinler] CHECK CONSTRAINT [FK_Izinler_Ogrenciler]
GO
ALTER TABLE [dbo].[Oda_Bilgileri]  WITH CHECK ADD  CONSTRAINT [FK_Oda_Bilgileri_Yatak_Bilgileri] FOREIGN KEY([yatak_id])
REFERENCES [dbo].[Yatak_Bilgileri] ([yatak_id])
GO
ALTER TABLE [dbo].[Oda_Bilgileri] CHECK CONSTRAINT [FK_Oda_Bilgileri_Yatak_Bilgileri]
GO
ALTER TABLE [dbo].[Ucret_Bilgisi]  WITH CHECK ADD  CONSTRAINT [FK_Ucret_Bilgisi_Ogrenciler] FOREIGN KEY([ogr_id])
REFERENCES [dbo].[Ogrenciler] ([ogr_id])
GO
ALTER TABLE [dbo].[Ucret_Bilgisi] CHECK CONSTRAINT [FK_Ucret_Bilgisi_Ogrenciler]
GO
ALTER TABLE [dbo].[Yatak_Bilgileri]  WITH CHECK ADD  CONSTRAINT [FK_Yatak_Bilgileri_Ogrenciler1] FOREIGN KEY([ogr_id])
REFERENCES [dbo].[Ogrenciler] ([ogr_id])
GO
ALTER TABLE [dbo].[Yatak_Bilgileri] CHECK CONSTRAINT [FK_Yatak_Bilgileri_Ogrenciler1]
GO
ALTER TABLE [dbo].[Yonetici]  WITH CHECK ADD  CONSTRAINT [FK_Yönetici_Personel_Bilgileri] FOREIGN KEY([personel_id])
REFERENCES [dbo].[Personel_Bilgileri] ([personel_id])
GO
ALTER TABLE [dbo].[Yonetici] CHECK CONSTRAINT [FK_Yönetici_Personel_Bilgileri]
GO
USE [master]
GO
ALTER DATABASE [YurtOtomasyonDB] SET  READ_WRITE 
GO
