CREATE TABLE [dbo].[eleve]
(
	[eleve_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [classe_ID] INT NOT NULL, 
    [user_ID] INT NOT NULL,
    FOREIGN KEY (classe_ID) REFERENCES classe(class_ID),
    FOREIGN KEY (user_ID) REFERENCES [User](user_ID),


)
