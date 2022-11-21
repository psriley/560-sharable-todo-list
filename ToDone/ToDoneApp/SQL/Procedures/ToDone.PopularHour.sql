﻿CREATE OR ALTER PROCEDURE ToDone.PopularHour
AS
SELECT TOP(1) DATEPART(HOUR,T.CompletedOn) AS HourNumber, COUNT(T.CompletedOn) AS HourCount
FROM ToDone.Task T
WHERE T.CompletedOn <> '1900-01-01 00:00:00'
GROUP BY (DATEPART(HOUR, T.CompletedOn))
ORDER BY HourCount DESC
GO