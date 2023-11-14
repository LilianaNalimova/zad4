CREATE PROCEDURE [dbo].[IvanovGetStudentById]
	(@stId int = 5)
AS
	SELECT *
FROM StudentList WHERE Id = @stId
