CREATE PROCEDURE [App].[DeleteOwnerGroup]
    @Id INT,
    @ErrorCode INT OUTPUT
AS 
BEGIN 
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DELETE FROM App.OwnerGroups
        WHERE Id = @Id;

        COMMIT TRANSACTION;

        SET @ErrorCode = 0;

    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        SET @ErrorCode = ERROR_NUMBER();
    END CATCH;
END;