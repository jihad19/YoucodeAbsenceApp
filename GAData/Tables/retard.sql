CREATE TABLE [dbo].[retard]
(
	[retard_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [dateheure] DATETIME NULL, 
    [tempsretard] TIME NULL,
    prof_ID int FOREIGN KEY REFERENCES professeur(prof_ID),
    eleve_ID int FOREIGN KEY REFERENCES eleve(eleve_ID)
)
