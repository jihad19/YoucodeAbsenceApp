CREATE PROCEDURE [dbo].[spAddClass]
	@Former_ID int,
	@promo_ID int,
	@speciality_ID int,
	@className nvarchar(50)
AS
BEGIN
	INSERT INTO class  (former_ID,promo_ID,specialty_ID,class_name) 
	VALUES (@Former_ID,@promo_ID,@speciality_ID,@className)
END
