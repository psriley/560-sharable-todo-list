CREATE OR ALTER PROCEDURE ToDone.GetTask
	@UserID INT,
	@Title NVarChar(64)
AS
SELECT *
FROM ToDone.Task T
WHERE (T.CreatedByID = @UserID OR T.ClaimedByID = @UserID) AND T.Title = @Title
GO