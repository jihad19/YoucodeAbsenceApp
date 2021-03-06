﻿CREATE PROCEDURE [dbo].[spStudent_GetStudentRequest]
	@User_ID nvarchar(128)
AS
BEGIN
	    SELECT top 3 t1.FullName, t4.jus_datetime, t3.justification_ID, t4.[jus_type] 
		FROM dbo.[User] t1 
			inner join [student] t2 on t2.[user_ID] = t1.[user_ID] 
			inner join [absence] t3 on t2.student_ID = t3.student_ID 
			inner join [justification] t4 on t4.justification_ID = t3.justification_ID
		WHERE @User_ID = t1.[user_ID]
		ORDER by t3.abs_ID DESC
END
