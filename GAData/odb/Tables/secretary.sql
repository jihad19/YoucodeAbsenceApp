CREATE TABLE [dbo].[secretary]
(
	[secretary_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
<<<<<<< Updated upstream
    [user_ID] NVARCHAR(128) FOREIGN KEY REFERENCES [User]([user_ID]) NOT NULL
=======
    [user_ID] NVARCHAR(128) FOREIGN KEY REFERENCES [User](user_ID) NOT NULL,
>>>>>>> Stashed changes
)
