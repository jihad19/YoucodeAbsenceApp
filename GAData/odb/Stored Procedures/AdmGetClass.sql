CREATE PROCEDURE [dbo].[spGetClass]
	
AS
begin
	SELECT c.class_ID,c.class_name,p.promo_year,s.specialty_name,u.fullName
	FROM class c 
	INNER JOIN [promo] p on p.promo_ID = c.[promo_ID]
	INNER JOIN [specialty] s on s.specialty_ID = c.[specialty_ID]
	INNER JOIN [former] f on f.[former_ID] = c.[former_ID]
	INNER JOIN [User] u on u.[user_ID] = f.[user_ID]
end
