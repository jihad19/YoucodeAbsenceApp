CREATE TABLE [dbo].[justification]
(
	[justification_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [justification_name] NCHAR(50) NOT NULL,
    secretary_ID int FOREIGN KEY REFERENCES secretary([secretary_ID]) NOT NULL,
)
