CREATE TABLE [dbo].[Professeur]
(
	[prof_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [user_ID] INT NOT NULL,
	FOREIGN KEY (user_ID) REFERENCES [User](user_ID),

)
