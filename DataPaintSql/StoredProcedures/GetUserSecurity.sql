--Gets application security for Users

CREATE PROCEDURE [App].[GetUserSecurity]

AS
BEGIN 
    SELECT [SecurityGroupId], [UserId], [UserType]
    FROM [App].[UserSecurity]
END;
