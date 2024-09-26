--Creates an Owner Group which can be assigned in the application to imported data for visibility

CREATE PROCEDURE [App].[CreateOwnerGroup]
	@GroupName NVARCHAR(50),
	@ContactEmail NVARCHAR(320),
	@PhoneNumber VARCHAR(15),
    @ErrorCode INT OUTPUT
AS 
BEGIN 
     SET NOCOUNT ON 

     BEGIN TRY
        BEGIN TRAN
             INSERT INTO App.OwnerGroups
                  (                    
                    GroupName,
                    ContactEmail,
                    PhoneNumber
                  )
             VALUES 
                  ( 
                    @GroupName,
                    @ContactEmail,
                    @PhoneNumber
                  )
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