CREATE TABLE [App].[User]
(
	[Id] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    [Username] NVARCHAR(50) UNIQUE NOT NULL,
	[Password] NVARCHAR(100) NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[Email] NVARCHAR(100) NOT NULL,
	[LoginAttempts] INT,
	[Locked] BIT
)
