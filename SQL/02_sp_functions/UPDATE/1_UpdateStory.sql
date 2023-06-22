CREATE PROCEDURE [dbo].[UpdateStory]

@title			VARCHAR(70),
@author			VARCHAR(20),
@link			VARCHAR(150),
@type 			VARCHAR(50),
@universe_name	VARCHAR(25)	

AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
    
    --Check if the Story exists
    IF EXISTS (SELECT * FROM Stories WHERE title = @title)
        BEGIN
            UPDATE Stories
            SET 
                author = @author,	
                link =  @link,	
                type  = @type,
                universe_name = @universe_name
                
            WHERE title = @title;
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

