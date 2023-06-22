CREATE PROCEDURE [dbo].[UpdateChampion]

@name VARCHAR(25),
@gender VARCHAR(6),
@description VARCHAR(50),
@species VARCHAR(30),
@region_name VARCHAR(50),
@splashArt VARCHAR(350),	
@quote VARCHAR(200),	
@releaseDate DATE,

@P_name				VARCHAR(50),
@P_description		VARCHAR(MAX),

@Q_name				VARCHAR(50),
@Q_description		VARCHAR(MAX),

@W_name				VARCHAR(50),
@W_description		VARCHAR(MAX),

@E_name				VARCHAR(50),
@E_description		VARCHAR(MAX),

@R_name				VARCHAR(50),
@R_description		VARCHAR(MAX),

@stories_title      VARCHAR(70),

@universe_name      VARCHAR(25)

AS
BEGIN
BEGIN TRY
BEGIN TRANSACTION

    --Check if the champion exists
    IF EXISTS (SELECT * FROM Champion WITH (INDEX(idx_Champion_Name)) WHERE name = @name)
        BEGIN
            UPDATE Champion
            SET 
                gender = @gender,
                description = @description,
                species = @species,
                region_name = @region_name,
                splashArt = @splashArt,
                quote = @quote,
                releaseDate = @releaseDate
            WHERE name = @name;
       

            UPDATE Abilities
            SET P_name = @P_name,
                P_description = @P_description,
                Q_name = @Q_name,
                Q_description = @Q_description,
                W_name = @W_name,
                W_description = @W_description,
                E_name = @E_name,
                E_description = @E_description,
                R_name = @R_name,
                R_description = @R_description
            WHERE champion_name = @name;
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