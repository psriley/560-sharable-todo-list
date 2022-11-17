CREATE OR ALTER PROCEDURE ToDone.CreateTask
	@CreatedByID INT,
	@Title NVarChar(64),
	@Description NVarChar(256),
	@DueDate Date = '3000-01-01',
	@PrivacyLevel Int,
	@IsClaimable Bit = 0,
	@TaskID INT OUTPUT
AS
INSERT ToDone.Task(CreatedByID, Title, [Description], DueDate, PrivacyLevel, IsClaimable)
VALUES(@CreatedByID, @Title, @Description, @DueDate, @PrivacyLevel, @IsClaimable);
SET @TaskID = SCOPE_IDENTITY();
GO