CREATE OR ALTER PROCEDURE ToDone.CompleteTask
	@TaskID INT,
	@UserID INT
AS
IF ((SELECT CreatedByID FROM ToDone.Task WHERE TaskID = @TaskID) = @UserID)
UPDATE ToDone.Task
SET CompletedOn = SYSDATETIMEOFFSET()
WHERE TaskID = @TaskID
GO