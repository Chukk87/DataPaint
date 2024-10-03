CREATE PROCEDURE [App].[AddUserToSecurityGroup]
    @SecurityGroupId UNIQUEIDENTIFIER,
    @UserId UNIQUEIDENTIFIER,
    @UserType INT,
    @ErrorCode INT OUTPUT
AS 
BEGIN 
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Check if the user is already part of the security group
        IF NOT EXISTS (SELECT 1 
                       FROM App.UserSecurity 
                       WHERE SecurityGroupId = @SecurityGroupId 
                         AND UserId = @UserId)
        BEGIN
            -- Insert the new user into the security group
            INSERT INTO App.UserSecurity
            (
                SecurityGroupId,
                UserId,
                UserType
            )
            VALUES 
            (
                @SecurityGroupId,
                @UserId,
                @UserType
            );

            -- If successful, set the error code to 0 (no error)
            SET @ErrorCode = 0;
        END
        ELSE
        BEGIN
            -- If the record already exists, set a custom error code (e.g., 1001 for "already exists")
            SET @ErrorCode = 1001;  -- Error code to indicate that the record already exists
        END

        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        -- Rollback in case of an error
        ROLLBACK TRANSACTION;

        -- Log the error and return an error code
        SET @ErrorCode = ERROR_NUMBER();
        SELECT ERROR_NUMBER() AS ErrorNumber, ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END;
GO