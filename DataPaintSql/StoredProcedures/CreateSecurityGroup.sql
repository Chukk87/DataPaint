--Creates a security Group which can be assigned in the application

CREATE PROCEDURE [App].[CreateSecurityGroup]
	@SecurityGroupName NVARCHAR(50),
    @ErrorCode INT OUTPUT
AS 
BEGIN 
     SET NOCOUNT ON 

     BEGIN TRY
        BEGIN TRAN
             INSERT INTO App.SecurityGroups
                  (                    
                    SecurityGroupName
                  )
             VALUES 
                  ( 
                    @SecurityGroupName
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