CREATE PROCEDURE [dbo].[AddExistsOn]

@champion_name			VARCHAR(25),
@universe_name			VARCHAR(25)

AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
    INSERT INTO Exists_On VALUES (@champion_name, @universe_name)
    SELECT 'Success' AS Result
    COMMIT TRANSACTION
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
        ROLLBACK TRANSACTION;     
    END CATCH

END
