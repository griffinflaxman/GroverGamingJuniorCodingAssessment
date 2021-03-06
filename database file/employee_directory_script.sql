USE [master]
GO
/****** Object:  Database [EmployeeDirectory_GroverGaming]    Script Date: 3/1/2021 12:19:25 AM ******/
CREATE DATABASE [EmployeeDirectory_GroverGaming]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeDirectory_GroverGaming', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EmployeeDirectory_GroverGaming.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EmployeeDirectory_GroverGaming_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EmployeeDirectory_GroverGaming_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeDirectory_GroverGaming].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET ARITHABORT OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET  MULTI_USER 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET DELAYED_DURABILITY = DISABLED 
GO
USE [EmployeeDirectory_GroverGaming]
GO
/****** Object:  Table [dbo].[Directory]    Script Date: 3/1/2021 12:19:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Directory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Title] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Directory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [EmployeeDirectory_GroverGaming] SET  READ_WRITE 
GO
