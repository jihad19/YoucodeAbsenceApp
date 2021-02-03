CREATE TABLE [dbo].[User]
(
	[user_ID] INT NOT NULL PRIMARY KEY, 
    [email] NVARCHAR(50) NOT NULL,  
    [FullName] NVARCHAR(50) NOT NULL,  
    [phone] NVARCHAR(50) NOT NULL, 
    [photo-profile] IMAGE NOT NULL, 
    [role_ID] INT NOT NULL, 
    FOREIGN KEY (role_ID) REFERENCES Matiere(matiere_ID),
)
