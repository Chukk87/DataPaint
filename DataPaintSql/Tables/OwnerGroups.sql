CREATE TABLE [App].[OwnerGroups]
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	[GroupName] NVARCHAR(50),
	[ContactEmail] NVARCHAR(320),
	[PhoneNumber] VARCHAR(15)
)