CREATE PROCEDURE [dbo].[spAddUser]
	@user_ID nvarchar(128),
	@email nvarchar(50),
	@fullName nvarchar(50),
	@phone nvarchar(50),
	@profile_picture image,
	@status bit
AS
begin
	insert into [User]([user_ID], email, fullName, phone, profile_picture)
	values(@user_ID, @email, @fullName, @phone, @profile_picture)
end
