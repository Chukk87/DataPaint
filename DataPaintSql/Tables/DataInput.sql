CREATE TABLE [App].[DataInput]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [InputName] NVARCHAR(100),
    [OwnerGroupId] INT,
    [ExtractionTypeId] INT,
    [DataTypeId] INT,
    [Location] NVARCHAR(256),
    [SheetsId] INT
)