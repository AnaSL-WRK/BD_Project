CREATE PROCEDURE [dbo].[AddUniverse]

@name			VARCHAR(25),
@skinLine		VARCHAR(50),
@art			VARCHAR(350),
@yearCreated	INT			

AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
    INSERT INTO Alternate_Universe VALUES (@name, @skinLine, @art, @yearCreated)
    SELECT 'Success' AS Result
    COMMIT TRANSACTION
END TRY

    BEGIN CATCH
        --If there's a problem with the transaction, rollback the transaction
        SELECT '[ERROR] ' + ERROR_MESSAGE() AS Result
        ROLLBACK TRANSACTION    
    END CATCH

END
