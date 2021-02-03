CREATE TABLE [dbo].[Admin]
(
	[admin_ID] INT NOT NULL PRIMARY KEY, 
	[user_ID] int FOREIGN KEY REFERENCES [User]([user_ID]) NOT NULL
)
