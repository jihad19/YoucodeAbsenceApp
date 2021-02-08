CREATE TABLE [dbo].[absence]
(
	[abs_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [abs_datetime] DATETIME NOT NULL DEFAULT getutcdate(), 
    former_ID int FOREIGN KEY REFERENCES former([former_ID]) NOT NULL,
    student_ID int FOREIGN KEY REFERENCES student([student_ID]) NOT NULL
)
