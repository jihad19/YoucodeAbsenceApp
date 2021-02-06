CREATE PROCEDURE [dbo].[spCreateSpeciality]
	@SpecialityName nvarchar(50)
	
AS
begin
	Insert into [dbo].specialty (specialty_name) VALUES (@SpecialityName)
end