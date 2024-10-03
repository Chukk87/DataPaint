CREATE PROCEDURE [App].[GetSecurityGroups]

AS
BEGIN
    SELECT [Id], [SecurityGroupName], [SecurityType], [AuthorisationType], [VisibleToAll]
    FROM App.SecurityGroups
END;
