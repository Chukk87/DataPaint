CREATE PROCEDURE [App].[GetSecurityGroups]

AS
BEGIN
    SELECT [Id], [SecurityGroupName], [Type]
    FROM App.SecurityGroups
END;

