CREATE PROCEDURE [dbo].[DeleteChampion]
(
@ChampName VARCHAR(25)
)
AS

BEGIN
SET NOCOUNT ON;

BEGIN TRY
BEGIN TRANSACTION

--Check if the champion exists
IF EXISTS (SELECT * FROM Champion WITH (INDEX(idx_Champion_Name)) WHERE name = @ChampName)
    BEGIN

        --Delete from the dependent tables
        DELETE FROM Participates WHERE champion_name = @ChampName;
        DELETE FROM Exists_On WHERE champion_name = @ChampName;
        DELETE FROM Abilities WHERE champion_name = @ChampName;

        --Delete the champion from the Champion table
        DELETE FROM Champion WHERE name = @ChampName;

        --Commit the transaction
        SELECT 'Success' AS Result
        COMMIT TRANSACTION
    END
ELSE

    BEGIN
    --If the champion doesn't exist, rollback the transaction
    SELECT 'Champion not found, rollbacking transaction.' AS Result
    ROLLBACK TRANSACTION
END
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
        ROLLBACK TRANSACTION;    
    END CATCH
    
END