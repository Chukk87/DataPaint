CREATE PROCEDURE [App].[CreateOwnerGroup]
    @GroupName NVARCHAR(50),
    @ContactEmail NVARCHAR(320),
    @PhoneNumber NVARCHAR(100),
    @ErrorCode INT OUTPUT
AS 
BEGIN 
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

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
        );

        COMMIT TRANSACTION;

        SET @ErrorCode = 0;

    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        SET @ErrorCode = ERROR_NUMBER();
    END CATCH;
END;