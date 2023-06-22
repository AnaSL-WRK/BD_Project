CREATE PROCEDURE [dbo].[AdminLogin]
    @Username varchar(50),
    @Password varchar(50)
AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
    SET NOCOUNT ON

    DECLARE @HashPassword varbinary(64)

    IF NOT EXISTS (SELECT * FROM Admin WHERE username = @Username)
    BEGIN
        SELECT 'Invalid Username or Password' AS Result
        RETURN
    END

    SELECT @HashPassword = hashPassword FROM Admin WHERE username = @Username

    IF (HASHBYTES('SHA2_512', @Password) <> @HashPassword)
    BEGIN
        SELECT 'Invalid Username or Password' AS Result
        RETURN
    END

    SELECT 'Success' AS Result
    COMMIT TRANSACTION
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
        ROLLBACK TRANSACTION
    END CATCH

END

