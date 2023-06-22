CREATE PROCEDURE [dbo].[DeleteUniverse]
(
@UniverseName VARCHAR(25)
)
AS

BEGIN
SET NOCOUNT ON;

BEGIN TRY
BEGIN TRANSACTION

    

    --Check if the universe exists
    IF EXISTS (SELECT * FROM Alternate_Universe WHERE name = @UniverseName)
        BEGIN

            DECLARE @storyName VARCHAR(70)

            --Delete from the dependent tables
            SELECT @storyName = title from Stories WHERE universe_name = @UniverseName

            EXEC dbo.DeleteStory @StoryName = @storyName
            
            DELETE FROM Exists_On WHERE universe_name = @UniverseName

            --Delete the universe from the Alternate_universe table
            DELETE FROM Alternate_Universe WHERE name = @UniverseName

            --Commit the transaction
            SELECT 'Success' AS Result
            COMMIT TRANSACTION
        END
    ELSE

        BEGIN
        --If the universe doesn't exist, rollback the transaction
        SELECT 'Alternate Universe not found, rollbacking transaction.' AS Result
        ROLLBACK TRANSACTION
    END
    END TRY

        BEGIN CATCH
            --If there's a problem with the transaction, rollback the transaction
            SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
            ROLLBACK TRANSACTION       
        END CATCH
        
    END