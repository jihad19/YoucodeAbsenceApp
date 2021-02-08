CREATE TABLE [dbo].[former]
(
	[former_ID] INT NOT NULL PRIMARY KEY IDENTITY, 


	[user_ID] nvarchar(128) FOREIGN KEY REFERENCES [User]([user_ID]) NOT NULL


)
