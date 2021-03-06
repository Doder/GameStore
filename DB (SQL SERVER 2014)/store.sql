IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'store')
	DROP DATABASE [store]
GO

CREATE DATABASE [store]  ON (NAME = N'store_Data', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\store_Data.MDF' , SIZE = 5, FILEGROWTH = 10%) LOG ON (NAME = N'store_Log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\store_Log.LDF' , SIZE = 5, FILEGROWTH = 10%)
 COLLATE SQL_Latin1_General_CP1_CI_AS
GO

exec sp_configure 'user instances enabled', '1'

use [store]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_developer]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[game] DROP CONSTRAINT FK_developer
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_userr]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[rent] DROP CONSTRAINT FK_userr
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[developer]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[developer]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[game]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[game]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[userr]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[userr]
GO


CREATE TABLE [dbo].[developer] (
	[name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[game] (
	[title] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[mark] [int] NOT NULL ,
	[pub_year] [int] NOT NULL ,
	[price] [float] NOT NULL ,
	[developer] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[userr] (
	[email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[surname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[phone_number] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[address] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[birthday] [date] NOT NULL ,
	[balance] [float] NOT NULL ,
	[admin][int] NOT NULL,
	[password][varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[cart] (
	[id] [int] NOT NULL IDENTITY(1,1) ,
	[game_title] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[developer] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[userr] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO



ALTER TABLE [dbo].[developer] ADD 
	CONSTRAINT [PK_developer] PRIMARY KEY  CLUSTERED 
	(
		[name]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[game] ADD 
	CONSTRAINT [DF_game_price] DEFAULT (0) FOR [price],
	CONSTRAINT [PK_game] PRIMARY KEY  CLUSTERED 
	(
		[title],[developer]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[userr] ADD 
	CONSTRAINT [DF_balance] DEFAULT (0) FOR [balance],
	CONSTRAINT [PK_userr] PRIMARY KEY  CLUSTERED 
	(
		[email]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[game] ADD 
	CONSTRAINT [FK_developer] FOREIGN KEY 
	(
		[developer]
	) REFERENCES [dbo].[developer] (
		[name]
	)
GO

ALTER TABLE [dbo].[cart] ADD 
	CONSTRAINT [PK_cart] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
	
GO

ALTER TABLE [dbo].[cart] ADD 
CONSTRAINT [FK_userr] FOREIGN KEY
	(
		[userr]
	) REFERENCES [dbo].[userr]
	(
		[email]
	)
GO

ALTER TABLE [dbo].[cart] ADD 
CONSTRAINT [FK_game] FOREIGN KEY
	(
		[game_title],[developer]
	) REFERENCES [dbo].[game]
	(
		[title],[developer]
	)
GO
