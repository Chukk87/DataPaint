CREATE PROCEDURE App.UpdateOwnerGroup
    @Id INT,
    @GroupName NVARCHAR(50),
    @ContactEmail NVARCHAR(320),
    @PhoneNumber NVARCHAR(100),
    @ErrorCode INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE App.OwnerGroups
        SET 
            GroupName = @GroupName,
            ContactEmail = @ContactEmail,
            PhoneNumber = @PhoneNumber
        WHERE Id = @Id;

        COMMIT TRANSACTION;

        SET @ErrorCode = 0;

    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        SET @ErrorCode = ERROR_NUMBER();
    END CATCH;
END;