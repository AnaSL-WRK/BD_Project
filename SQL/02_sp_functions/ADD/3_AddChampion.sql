CREATE PROCEDURE [dbo].[AddChampion]

@name VARCHAR(25),
@gender VARCHAR(6),
@description VARCHAR(50),
@species VARCHAR(30),
@region_name VARCHAR(50),
@splashArt VARCHAR(350),	
@quote VARCHAR(200),	
@releaseDate DATE,

@P_name				VARCHAR(50) = NULL,
@P_description		VARCHAR(MAX) = NULL,

@Q_name				VARCHAR(50) = NULL,
@Q_description		VARCHAR(MAX) = NULL,

@W_name				VARCHAR(50) = NULL,
@W_description		VARCHAR(MAX) = NULL,

@E_name				VARCHAR(50) = NULL,
@E_description		VARCHAR(MAX) = NULL,

@R_name				VARCHAR(50) = NULL,
@R_description		VARCHAR(MAX) = NULL,

@stories_title      VARCHAR(70) = NULL,

@universe_name      VARCHAR(25) = NULL

AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION
    INSERT INTO Champion VALUES (@name, @gender, @description, @species,@region_name,@splashArt,@quote,@releaseDate)

    IF @P_name IS NOT NULL AND @Q_name IS NOT NULL AND @W_name IS NOT NULL AND @E_name IS NOT NULL AND @R_name IS NOT NULL
        BEGIN
            INSERT INTO Abilities VALUES (@name, @P_name, @P_description, @Q_name, @Q_description, @W_name, @W_description, @E_name, @E_description, @R_name, @R_description)
        END

    IF @stories_title IS NOT NULL
        BEGIN
            EXEC dbo.AddParticipates @name = @name, @stories_title = @stories_title
        END
    
    IF @universe_name IS NOT NULL
        BEGIN
            EXEC dbo.AddExistsOn @name = @name, @universe_name = @universe_name
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