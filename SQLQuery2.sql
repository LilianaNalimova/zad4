USE [Students]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[IvanovGetStudentById]
		@stId = 3

SELECT	@return_value as 'Return Value'

GO
