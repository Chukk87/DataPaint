CREATE PROCEDURE [App].[GetOwnerGroup]
	@Id INT
AS
BEGIN
    SELECT Id, GroupName, ContactEmail, PhoneNumber
    FROM OwnerGroups
    WHERE Id = @Id
END;
