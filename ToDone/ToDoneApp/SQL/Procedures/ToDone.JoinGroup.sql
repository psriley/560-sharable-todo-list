CREATE OR ALTER PROCEDURE ToDone.JoinGroup
	@UserID INT,
	@GroupID INT
AS
INSERT ToDone.GroupUser (UserID, GroupID)
VALUES (@UserID, @GroupID)
GO