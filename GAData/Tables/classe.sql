CREATE TABLE [dbo].[classe]
(
	[class_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [prof_ID] INT NOT NULL, 
    [section_ID] INT NOT NULL, 
    [matiere_ID] INT NOT NULL, 
    [classe_name] NCHAR(50) NOT NULL
)
