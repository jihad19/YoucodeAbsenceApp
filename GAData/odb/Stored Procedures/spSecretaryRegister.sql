CREATE PROCEDURE [dbo].spSecretaryRegister
	@user_ID nvarchar(128),
	@email nvarchar(50),
	@fullName nvarchar(50)
AS
begin
	insert into [User] ([user_ID], [email],[fullName]) VALUES (@user_ID,@email,@fullName);
	insert into [secretary] ([user_ID]) VALUES (@user_ID)
end