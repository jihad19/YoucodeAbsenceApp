CREATE PROCEDURE [dbo].[CreateSpeciality]
	@SpecialityName nvarchar(50)
	
AS
begin
	Insert into [dbo].specialty (specialty_name) VALUES (@SpecialityName)
end