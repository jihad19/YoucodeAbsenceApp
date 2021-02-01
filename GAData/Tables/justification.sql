CREATE TABLE [dbo].[justification]
(
	[justification_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [justification_name] NCHAR(50) NOT NULL, 
    [secretaire_ID] INT NOT NULL
)
