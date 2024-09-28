--Gets application Users

CREATE PROCEDURE [App].[GetUsers]

AS
BEGIN
    SELECT [Id], [Username], [Name], [LastName], [Email]
    FROM App.[User]
END;