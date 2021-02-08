CREATE PROCEDURE [dbo].[spFormer]
	
AS
begin
	SELECT f.former_ID, u.fullName,p.promo_year,s.specialty_name
	FROM former f 
	INNER JOIN class c on c.former_ID = f.former_ID
	INNER JOIN promo p on p.promo_ID = c.promo_ID
	INNER JOIN specialty s on s.specialty_ID = c.specialty_ID
	INNER JOIN [User] u on u.[user_ID] = f.[user_ID]
end
