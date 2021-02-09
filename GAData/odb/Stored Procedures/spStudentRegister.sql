CREATE PROCEDURE [dbo].spStudentRegister
	@user_ID nvarchar(128),
	@email nvarchar(50),
	@fullName nvarchar(50),
	@class_ID int 
AS
begin
	insert into [User] ([user_ID], [email],[fullName]) VALUES (@user_ID,@email,@fullName);
	insert into [student] ([user_ID],[class_ID]) VALUES (@user_ID,@class_ID)
end