CREATE OR ALTER PROCEDURE ToDone.FetchUserTasks
	@UserID INT
AS

SELECT *
FROM ToDone.Task T
WHERE CreatedByID = @UserID OR ClaimedByID = @UserID

GO