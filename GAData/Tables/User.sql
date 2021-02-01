CREATE TABLE [dbo].[User]
(
	[user_ID] INT NOT NULL PRIMARY KEY, 
    [email] VARCHAR(50) NULL, 
    [mdb] VARCHAR(50) NULL, 
    [prenom] VARCHAR(50) NULL, 
    [nom] VARCHAR(50) NULL, 
    [phone] VARCHAR(50) NULL, 
    [photo-profile] IMAGE NULL, 
    role_ID int FOREIGN KEY REFERENCES Role(role_ID)


)
