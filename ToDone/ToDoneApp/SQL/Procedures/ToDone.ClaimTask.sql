CREATE OR ALTER PROCEDURE ToDone.ClaimTask
	@TaskID INT,
	@ClaimedByID INT
AS
UPDATE ToDone.Task
SET ClaimedByID = @ClaimedByID,
PrivacyLevel = 1
WHERE TaskID = @TaskID
GO