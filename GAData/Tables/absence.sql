CREATE TABLE [dbo].[absence]
(
	[abs_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [dateheure] DATETIME NULL, 
    [rapport] VARCHAR(50) NULL, 
    [Image] IMAGE NULL,
    prof_ID int FOREIGN KEY REFERENCES Professeur(prof_ID),
    eleve_ID int FOREIGN KEY REFERENCES eleve(eleve_ID),
    justification_ID int FOREIGN KEY REFERENCES justification(justification_ID)
)
