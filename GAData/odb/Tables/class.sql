CREATE TABLE [dbo].[class]
(
	[class_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [former_ID] INT NOT NULL, 
    [section_ID] INT NOT NULL, 
    [specialty_ID] int NOT NULL,
    [class_name] NVARCHAR(50) NOT NULL
    FOREIGN KEY (former_ID) REFERENCES former(former_ID),
    FOREIGN KEY (section_ID) REFERENCES section(section_ID),
    FOREIGN KEY (specialty_ID) REFERENCES specialty(specialty_ID)
)
