CREATE PROCEDURE [dbo].[UpdateUniverse]

@name			VARCHAR(25),
@skinLine		VARCHAR(50),
@art			VARCHAR(350),
@yearCreated	INT		

AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
    
    --Check if the Universe exists
    IF EXISTS (SELECT * FROM Alternate_Universe WHERE name = @name)
        BEGIN
            UPDATE Alternate_Universe
            SET 
                skinLine = @skinLine,	
                art =  @art,	
                yearCreated  = @yearCreated
                
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

