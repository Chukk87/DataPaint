CREATE TABLE [App].[OwnerGroups]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[GroupName] NVARCHAR(50),
	[ContactEmail] NVARCHAR(320),
	[PhoneNumber] VARCHAR(15)
)