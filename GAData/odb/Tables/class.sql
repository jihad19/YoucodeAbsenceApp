CREATE TABLE [dbo].[class]
(
	[class_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [former_ID] INT NOT NULL, 
    [promo_ID] INT NOT NULL, 
    [specialty_ID] int NOT NULL,
    [class_name] NVARCHAR(50) NOT NULL
    FOREIGN KEY (former_ID) REFERENCES former(former_ID),
    FOREIGN KEY (promo_ID) REFERENCES promo(promo_ID),
    FOREIGN KEY (specialty_ID) REFERENCES specialty(specialty_ID)
)
