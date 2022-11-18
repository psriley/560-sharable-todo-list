CREATE OR ALTER PROCEDURE ToDone.CreateTask
	@CreatedByID INT,
	@ClaimedByID INT,
	@Title NVarChar(64),
	@Description NVarChar(256),
	@DueDate DateTimeOffset = '3000-01-01',
	@PrivacyLevel Int,
	@IsClaimable Bit = 0,
	@TaskID INT OUTPUT
AS
INSERT ToDone.Task(CreatedByID, ClaimedByID, Title, [Description], DueDate, PrivacyLevel, IsClaimable)
VALUES(@CreatedByID, @ClaimedByID, @Title, @Description, @DueDate, @PrivacyLevel, @IsClaimable);
SET @TaskID = SCOPE_IDENTITY();
GO