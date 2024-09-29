--Gets application security for Users

CREATE PROCEDURE [App].[GetUserSecurity]

AS
BEGIN
    SELECT [Id], [UserId], [UserType]
    FROM [App].[UserSecurity]
END;
