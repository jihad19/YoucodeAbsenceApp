CREATE TABLE [dbo].[User]
(
	[user_ID] NVARCHAR(128) NOT NULL PRIMARY KEY, 
    [email] NVARCHAR(50) NOT NULL,  
    [fullName] NVARCHAR(128) NOT NULL,  
    [phone] NVARCHAR(50) NOT NULL, 
    [profile_picture] IMAGE NOT NULL, 
    [status] BIT NOT NULL DEFAULT 1
)
