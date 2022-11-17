CREATE OR ALTER PROCEDURE ToDone.DeleteTask
	@TaskID INT,
	@UserID INT
AS
IF (((SELECT CreatedByID FROM ToDone.Task WHERE TaskID = @TaskID) = @UserID) OR (SELECT U.IsAdmin FROM ToDone.Users U WHERE UserID = @UserID) = 1)
UPDATE ToDone.Task
SET IsActive = 0
WHERE TaskID = @TaskID
GO