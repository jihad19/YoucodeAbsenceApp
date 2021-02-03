CREATE TABLE [dbo].[absence]
(
	[abs_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [abs_datetime] DATETIME NOT NULL, 
    [report] TEXT NOT NULL, 
    [Image] IMAGE NOT NULL,
    former_ID int FOREIGN KEY REFERENCES former([former_ID]) NOT NULL,
    student_ID int FOREIGN KEY REFERENCES student([student_ID]) NOT NULL,
    justification_ID int FOREIGN KEY REFERENCES justification(justification_ID) NOT NULL
)
