--Creates a security Group which can be assigned in the application

CREATE PROCEDURE [App].[CreateSecurityGroup]
    @SecurityGroupName NVARCHAR(50),
    @SecurityType INT,
    @AuthorisationType INT,
    @VisibleToAll BIT,
    @ErrorCode INT OUTPUT
AS 
BEGIN 
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Check if the security group already exists
        IF EXISTS (SELECT 1 
                   FROM App.SecurityGroups 
                   WHERE SecurityGroupName = @SecurityGroupName)
        BEGIN
            -- Set a custom error code (e.g., 1001 for "already exists")
            SET @ErrorCode = 1001;  -- Error code to indicate that the group already exists
            ROLLBACK TRANSACTION;     -- Rollback the transaction
            RETURN;                  -- Exit the procedure
        END

        -- If the group does not exist, proceed to insert
        INSERT INTO App.SecurityGroups
        (
            SecurityGroupName,
            SecurityType,
            AuthorisationType,
            VisibleToAll
        )
        VALUES 
        (
            @SecurityGroupName,
            @SecurityType,
            @AuthorisationType,
            @VisibleToAll
        );

        -- Set the error code to 0 (no error)
        SET @ErrorCode = 0;

        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        ROLLBACK TRANSACTION;
        -- Log the error and return an error code
        SET @ErrorCode = ERROR_NUMBER();
        SELECT ERROR_NUMBER() AS ErrorNumber, ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END;
GO