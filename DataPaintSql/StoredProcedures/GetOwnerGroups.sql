CREATE PROCEDURE [App].[GetOwnerGroups]

AS
BEGIN
    SELECT Id, GroupName, ContactEmail, PhoneNumber
    FROM OwnerGroups
END;
