CREATE OR ALTER PROCEDURE ToDone.PercentCompletedUser
@UserID INT
AS
SELECT (
CAST((SELECT COUNT(*)
FROM ToDone.Task T
WHERE T.CompletedOn < T.DueDate AND T.CreatedByID = @UserID) AS FLOAT)
/
CAST((SELECT COUNT(*)
FROM ToDone.Task T
WHERE T.CreatedByID = @UserID) AS FLOAT)*100) AS Completed
GO
