CREATE PROCEDURE [dbo].[CreateClass]
	@Former_ID int,
	@promo_ID int,
	@speciality_ID int,
	@className nvarchar(50)
AS
BEGIN
	INSERT INTO [odb].[class]  (former_ID,section_ID,specialty_ID,class_name) 
	VALUES (@Former_ID,@promo_ID,@speciality_ID,@className)
END
