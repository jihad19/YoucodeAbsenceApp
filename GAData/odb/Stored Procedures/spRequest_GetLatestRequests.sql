CREATE PROCEDURE [dbo].[spRequest_GetLatestRequests]
AS
BEGIN
	SELECT top 3 t1.fullName , t3.abs_datetime, t4.justification_name 
	FROM dbo.[User] t1 
		inner join [student] t2 
			on t2.[user_ID] = t1.[user_ID] 
		inner join [absence] t3 
			on t2.student_ID = t3.student_ID 
		inner join [justification] t4 
			on t4.justification_ID = t3.justification_ID 
	ORDER by t3.abs_ID DESC
END
