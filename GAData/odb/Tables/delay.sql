CREATE TABLE [dbo].[delay]
(
	[delay_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [dateheure] DATETIME NOT NULL, 
    [tempsretard] TIME NOT NULL,
    prof_ID int FOREIGN KEY REFERENCES former([former_ID]) NOT NULL,
    eleve_ID int FOREIGN KEY REFERENCES student([student_ID]) NOT NULL
)
