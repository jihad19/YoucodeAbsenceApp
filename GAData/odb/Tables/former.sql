CREATE TABLE [dbo].[former]
(
	[former_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
<<<<<<< Updated upstream


	[user_ID] nvarchar(128) FOREIGN KEY REFERENCES [User]([user_ID]) NOT NULL

=======
	[user_ID] NVARCHAR(128) FOREIGN KEY REFERENCES [User]([user_ID]) NOT NULL
>>>>>>> Stashed changes

)
