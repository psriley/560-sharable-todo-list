CREATE OR ALTER PROCEDURE ToDone.AvgTasksCompletedGroup
@GroupID INT
AS
SELECT  (CAST((
SELECT COUNT(*)
FROM ToDone.Task T
INNER JOIN ToDone.GroupUser GU ON T.CreatedByID = GU.UserID AND GU.GroupID = @GroupID
WHERE T.CompletedOn <> '1900-01-01 00:00:00') AS FLOAT)
/
CAST((SELECT COUNT(*)
FROM ToDone.Users U
INNER JOIN ToDone.GroupUser GU ON U.UserID = GU.UserID AND GU.GroupID = @GroupID)AS FLOAT))AS Tasks
GO