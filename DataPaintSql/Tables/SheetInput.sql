CREATE TABLE [dbo].[SheetInput]
(
	[DataInputId] INT,
	[SheetName] NVARCHAR(100),
	[IncludeHeader] BIT,
	[StartRow] INT,
	[EndRow] INT,
	[StartColumn] INT,
	[EndColumn] INT
)
