﻿CREATE TABLE [App].[SecurityGroups]
(
	[Id] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	[SecurityGroupName] NVARCHAR(50),
	[Type] INT
)