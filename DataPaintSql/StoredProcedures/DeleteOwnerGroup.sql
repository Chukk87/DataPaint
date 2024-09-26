--Deletes an Owner Group

CREATE PROCEDURE [App].[DeleteOwnerGroup]
	@Id INT,
    @ErrorCode INT OUTPUT
AS 
BEGIN 
     SET NOCOUNT ON 

     BEGIN TRY
        BEGIN TRAN
             DELETE FROM App.OwnerGroups
             WHERE Id = @Id
        COMMIT TRAN
        SELECT  @ErrorCode=@@ERROR;
    END TRY

    BEGIN CATCH
        ROLLBACK tran
        SELECT ERROR_NUMBER();
        SELECT ERROR_MESSAGE();
        SELECT  @ErrorCode=@@ERROR
    END CATCH
END 

GO