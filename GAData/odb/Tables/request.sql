CREATE TABLE [dbo].[request]
(
	[request_Id] INT NOT NULL PRIMARY KEY, 
    [justification_id] INT FOREIGN KEY REFERENCES justification([justification_ID]) NOT null, 
    [abs_ID] INT NOT NULL, 
    [status] BIT NULL DEFAULT null 
)
