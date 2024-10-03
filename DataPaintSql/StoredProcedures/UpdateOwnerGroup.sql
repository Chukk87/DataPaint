CREATE PROCEDURE App.UpdateSecurityGroup
    @SecurityGroupId UNIQUEIDENTIFIER,
    @SecurityGroupName NVARCHAR(100),
    @SecurityType INT,
    @AuthorisationType INT,
    @VisibleToAll BIT,
    @ErrorCode INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE App.SecurityGroups
        SET 
            SecurityGroupName = @SecurityGroupName,
            SecurityType = @SecurityType,
            AuthorisationType = @AuthorisationType,
            VisibleToAll = @VisibleToAll
        WHERE Id = @SecurityGroupId;

        COMMIT TRANSACTION;

        SET @ErrorCode = 0;

    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        SELECT ERROR_NUMBER() AS ErrorNumber, ERROR_MESSAGE() AS ErrorMessage;
        SET @ErrorCode = ERROR_NUMBER();
    END CATCH;
END;