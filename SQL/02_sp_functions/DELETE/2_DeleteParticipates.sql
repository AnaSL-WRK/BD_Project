CREATE PROCEDURE [dbo].[DeleteParticipates]
(
@champion_name		VARCHAR(25),
@stories_title		VARCHAR(70)
)
AS

BEGIN
SET NOCOUNT ON;

BEGIN TRY
BEGIN TRANSACTION

--Check if the Story and champion exist
IF EXISTS (SELECT * FROM Stories WHERE title = @stories_title)
    Begin
        IF EXISTS (SELECT * FROM Champion WHERE name = @champion_name)
            BEGIN

            --Delete from the Exists On table
            DELETE FROM Participates WHERE champion_name = @champion_name AND stories_title = @stories_title ;

            --Commit the transaction
            SELECT 'Success' AS Result
            COMMIT TRANSACTION
        END
        ELSE
            BEGIN
            --If the champion doesn't exist, rollback the transaction
            Select 'Champion not found, rollbacking transaction.' As Result
            ROLLBACK TRANSACTION
        END
    END
    ELSE

        BEGIN
        --If the Story doesn't exist, rollback the transaction
        Select 'Story not found, rollbacking transaction.' As Result
        ROLLBACK TRANSACTION
        END
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
        ROLLBACK TRANSACTION     
    END CATCH
    
END