CREATE PROCEDURE dbo.IvanovGetStudentById
	(@stId int = 5)
AS
select * from StudentList where Id = @stId