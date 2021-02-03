CREATE TABLE [dbo].[Admin]
(
	[admin_ID] INT NOT NULL PRIMARY KEY, 
	[user_ID] INT NOT NULL , 
	FOREIGN KEY (user_ID) REFERENCES [User](user_ID),

)
