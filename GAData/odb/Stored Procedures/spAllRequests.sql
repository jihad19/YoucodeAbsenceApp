CREATE PROCEDURE [dbo].[spAllRequests]

AS
begin
	SELECT u.fullName, s.[student_ID], a.abs_datetime,j.justification_ID,  r.[status], n.reason_name
	From absence a 
	INNER JOIN request r on r.abs_ID = a.abs_ID
	INNER JOIN justification j on j.justification_ID = r.justification_id
	INNER JOIN reason n on n.reason_Id = j.reason_ID
	INNER JOIN [student] s on s.[user_ID] = a.abs_ID
	INNER JOIN [User] u on u.[user_ID] = s.[user_ID]
end

