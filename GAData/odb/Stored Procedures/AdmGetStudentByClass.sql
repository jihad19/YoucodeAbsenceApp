CREATE PROCEDURE [dbo].[spGetStudentByClass]
	@Class_ID int	
AS
begin
	SELECT u.fullName, u.email, u.[status]
	from student s
	INNER JOIN [User] u on u.[user_ID] = s.[user_ID]
	WHERE s.class_ID = @Class_ID
end
