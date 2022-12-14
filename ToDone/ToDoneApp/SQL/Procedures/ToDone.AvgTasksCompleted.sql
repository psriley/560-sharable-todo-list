CREATE OR ALTER PROCEDURE ToDone.AvgTasksCompleted
AS
SELECT (CAST((
SELECT COUNT(*)
FROM ToDone.Task T
WHERE T.CompletedOn <> '1900-01-01 00:00:00') AS FLOAT)
/
CAST((SELECT COUNT(*)
FROM ToDone.Users)AS FLOAT)) AS Completed
GO