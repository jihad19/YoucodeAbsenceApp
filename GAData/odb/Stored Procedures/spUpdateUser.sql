CREATE PROCEDURE [dbo].[spUpdateUser]
	@email nvarchar(50),
	@fullname nvarchar(50),
	@status bit,
	@user_ID nvarchar(128)
AS
BEGIN
	Update [User] 
	set [User].email = @email,
		[User].fullName = @fullname,
		[User].[status] =@status
		WHERE [User].[user_ID] = @user_ID
END
