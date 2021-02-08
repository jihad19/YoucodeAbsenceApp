CREATE PROCEDURE [dbo].[spFormer]
	
AS
begin
	SELECT f.former_ID, u.fullName
	FROM former f 
	INNER JOIN [User] u on u.[user_ID] = f.[user_ID]
end
