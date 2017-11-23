﻿CREATE TABLE Users
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Login]	NVARCHAR(20) NOT NULL,
	[Password] NVARCHAR(20) NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	[Surname] NVARCHAR(50) NOT NULL,
	[Birth] DATE NOT NULL
);
CREATE TABLE Bounds
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[UserId] INT NOT NULL,
	[TelegramAccount] NVARCHAR(50) NOT NULL,
	[InstagramAccount] NVARCHAR(50) NOT NULL,
	[InstagramPassword] NVARCHAR(50) NOT NULL
);
CREATE TABLE Filters
(
	[BoundId] INT NOT NULL,
	[Filter] NVARCHAR(20) NOT NULL PRIMARY KEY
);