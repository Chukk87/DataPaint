CREATE PROCEDURE [App].[ValidateUser]
    @Username NVARCHAR(50),
    @Password NVARCHAR(100),
    @ReturnCode INT OUTPUT,
    @IsAdmin BIT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @StoredPassword NVARCHAR(100);
    DECLARE @LoginAttempts INT;
    DECLARE @Locked BIT;

    -- Check if the user exists and retrieve their password, login attempts, and locked status
    SELECT 
        @StoredPassword = [Password],
        @LoginAttempts = [LoginAttempts],
        @Locked = [Locked],
        @IsAdmin = [IsAdmin]
    FROM [App].[User]
    WHERE [Username] = @Username;

    -- If no user found, return code "Unknown"
    IF @StoredPassword IS NULL
    BEGIN
        SET @ReturnCode = 1; -- Unknown
        RETURN;
    END

    -- If account is locked, return code "Locked"
    IF @Locked = 1
    BEGIN
        SET @ReturnCode = 3; -- Locked
        RETURN;
    END

    -- Verify password
    IF @StoredPassword = @Password
    BEGIN
        UPDATE [App].[User]
        SET [LoginAttempts] = 0
        WHERE [Username] = @Username;

        SET @ReturnCode = 0; -- Valid
    END
    ELSE
    BEGIN
        IF @LoginAttempts >= 2
            BEGIN
                -- Increment login attempts on 3rd incorrect password and lock account
                UPDATE [App].[User]
                SET [LoginAttempts] = [LoginAttempts] + 1,
                    [Locked] = 1
                WHERE [Username] = @Username;

                SET @ReturnCode = 3; -- Locked
            END
        ELSE
            -- Increment login attempts on incorrect password
            UPDATE [App].[User]
            SET [LoginAttempts] = [LoginAttempts] + 1
            WHERE [Username] = @Username;

            SET @ReturnCode = 2; -- IncorrectPassword
    END
END;