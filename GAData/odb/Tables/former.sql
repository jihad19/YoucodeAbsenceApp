CREATE TABLE [dbo].[former]
(
	[former_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
	[user_ID] int FOREIGN KEY REFERENCES [User]([user_ID]) NOT NULL

)
