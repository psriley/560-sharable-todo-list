CREATE OR ALTER PROCEDURE ToDone.PercentCompleted
AS
DECLARE @CompletedCount FLOAT = (
SELECT COUNT(*)
FROM ToDone.Task T
WHERE T.CompletedOn < T.DueDate
), 
@TotalTasks FLOAT = (
SELECT COUNT(*)
FROM ToDone.Task T
)
SELECT (@CompletedCount/@TotalTasks*100) AS Completed
GO