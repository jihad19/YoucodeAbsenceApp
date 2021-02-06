CREATE PROCEDURE [dbo].[spStudent_GetTodayAbsence]
	@class_name nvarchar(50)
AS
BEGIN
	    SELECT top 6 t1.FullName, t1.email, t1.[status] , t3.abs_ID, t3.abs_datetime, t4.justification_name 
		FROM dbo.[User] t1 
			inner join [student] t2 
				on t2.[user_ID] = t1.[user_ID] 
			inner join [absence] t3 
				on t2.student_ID = t3.student_ID 
			inner join [justification] t4 
				on t4.justification_ID = t3.justification_ID 
			inner join [class] t5 
			on t5.class_ID = t2.class_ID
		WHERE t5.class_name = @class_name
END

