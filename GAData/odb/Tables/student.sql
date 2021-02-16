CREATE TABLE [dbo].[student]
(
	[student_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [class_ID] INT NOT NULL, 
<<<<<<< Updated upstream
    [user_ID] nvarchar(128) NOT NULL,
=======
    [user_ID] NVARCHAR(128) NOT NULL,
>>>>>>> Stashed changes
    FOREIGN KEY (class_ID) REFERENCES class(class_ID),
    FOREIGN KEY (user_ID) REFERENCES [User](user_ID),
)
