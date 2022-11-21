CREATE OR ALTER PROCEDURE ToDone.PercentCompletedUser
@UserID INT
AS
SELECT (
(SELECT COUNT(*)
FROM ToDone.Task T
WHERE T.CompletedOn < T.DueDate AND T.CreatedByID = @UserID)
/
(SELECT COUNT(*)
FROM ToDone.Task T
WHERE T.CreatedByID = @UserID)*100) AS Completed
GO
