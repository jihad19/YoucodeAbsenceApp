CREATE PROCEDURE [dbo].[spSelectClasse]
	@class_ID int,
	@former_ID int,
	@promo_ID int,
	@specialty_ID int,
	@class_name nvarchar(50)
AS
begin
	SELECT @class_ID, @former_ID, @promo_ID, @specialty_ID, @class_name
end
