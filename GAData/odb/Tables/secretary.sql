CREATE TABLE [dbo].[secretary]
(
	[secretary_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [user_ID] int FOREIGN KEY REFERENCES [User]([user_ID]) NOT NULL
)
