CREATE OR ALTER PROCEDURE ToDone.CreateTaskComment
	@TaskID INT,
	@Comment NVarChar(256),
	@CommentID INT OUTPUT
AS
INSERT ToDone.TaskComment(TaskID, Comment)
VALUES(@TaskID, @Comment)

SET @CommentID = SCOPE_IDENTITY();
GO