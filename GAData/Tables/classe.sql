CREATE TABLE [dbo].[classe]
(
	[class_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [prof_ID] INT NOT NULL, 
    [section_ID] INT NOT NULL, 
    [matiere_ID] INT NOT NULL, 
    [classe_name] NCHAR(50) NOT NULL,
    FOREIGN KEY (prof_ID) REFERENCES Professeur(prof_ID),
    FOREIGN KEY (section_ID) REFERENCES Section(section_ID),
    FOREIGN KEY (matiere_ID) REFERENCES Matiere(matiere_ID),
)
