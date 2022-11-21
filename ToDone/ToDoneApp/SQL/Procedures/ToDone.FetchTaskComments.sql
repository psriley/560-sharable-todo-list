CREATE OR ALTER PROCEDURE ToDone.FetchTaskComments 
	@TaskID INT
AS 
SELECT *
FROM ToDone.TaskComment T
WHERE T.TaskID = @TaskID
GO