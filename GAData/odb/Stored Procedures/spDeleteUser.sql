CREATE PROCEDURE [dbo].[spDeleteUser]
	@user_ID nvarchar(128)
AS
BEGIN
	Update [User] 
	set [User].[status] = NULL
	WHERE [User].[user_ID] = @user_ID
END
