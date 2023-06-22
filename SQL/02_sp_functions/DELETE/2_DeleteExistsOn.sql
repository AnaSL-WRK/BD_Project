CREATE PROCEDURE [dbo].[DeleteExistsOn]
(
@champion_name		VARCHAR(25),
@universe_name		VARCHAR(25)
)
AS

BEGIN
SET NOCOUNT ON;

BEGIN TRY
BEGIN TRANSACTION

--Check if the Universe and champion exist
IF EXISTS (SELECT * FROM Alternate_Universe WHERE name = @universe_name)
    Begin
        IF EXISTS (SELECT * FROM Champion WITH (INDEX(idx_Champion_Name)) WHERE name = @champion_name)
            BEGIN

            --Delete from the Exists On table
            DELETE FROM Exists_On WHERE champion_name = @champion_name AND universe_name = @universe_name ;

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
        --If the Universe doesn't exist, rollback the transaction
        Select 'Universe not found, rollbacking transaction.' As Result
        ROLLBACK TRANSACTION
        END
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
        ROLLBACK TRANSACTION     
    END CATCH
    
END