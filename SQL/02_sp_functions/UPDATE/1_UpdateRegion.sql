CREATE PROCEDURE [dbo].[UpdateRegion]

@name			VARCHAR(50),
@emblem			VARCHAR(350)

AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
    
    --Check if the Region exists
    IF EXISTS (SELECT * FROM Region WHERE name = @name)
        BEGIN
            UPDATE Region
            SET 
                emblem = @emblem
            WHERE name = @name;
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

