CREATE PROCEDURE [dbo].[spFrmGetStudents]
	@User_Id int
AS
begin 
	SELECT s.student_ID, a.fullName, c.class_name
	FROM [User] u 
	INNER JOIN former f on f.[user_ID] = u.[user_ID]
	inner join class c on c.former_ID = f.former_ID
	inner join student s on s.class_ID = c.class_ID
	inner join [User] a on a.[user_ID] = s.[user_ID]
	WHERE u.[user_ID] = @User_Id
end
