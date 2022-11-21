CREATE OR ALTER PROCEDURE ToDone.PopularHourUser
@UserID INT
AS
SELECT TOP(1) DATEPART(HOUR,T.CompletedOn) AS HourCompleted, COUNT(T.CompletedOn) AS HourCount
FROM ToDone.Task T
WHERE T.CompletedOn <> '1900-01-01 00:00:00' AND T.CreatedByID = @UserID
GROUP BY (DATEPART(HOUR, T.CompletedOn))
ORDER BY HourCount DESC
GO