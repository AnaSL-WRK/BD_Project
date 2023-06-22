CREATE PROCEDURE [dbo].[AddStory]

@title			VARCHAR(70),
@author			VARCHAR(20),
@link			VARCHAR(150),
@type 			VARCHAR(50),
@universe_name	VARCHAR(25)

AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
    INSERT INTO Stories VALUES (@title, @author, @link, @type, @universe_name)
    SELECT 'Success' AS Result
    COMMIT TRANSACTION
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
        ROLLBACK TRANSACTION     
    END CATCH

END
