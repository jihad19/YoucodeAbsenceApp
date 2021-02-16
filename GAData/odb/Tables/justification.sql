CREATE TABLE [dbo].[justification]
(
	[justification_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [reason_ID] INT FOREIGN KEY REFERENCES reason([reason_ID]) NOT null, 
    [student_ID] INT NULL FOREIGN KEY REFERENCES student([student_ID]), 
    [raport] TEXT NULL, 
    [image] IMAGE NULL
)
