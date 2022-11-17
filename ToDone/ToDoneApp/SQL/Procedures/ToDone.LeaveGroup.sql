CREATE OR ALTER PROCEDURE ToDone.LeaveGroup
	@UserID INT,
	@GroupID INT
AS
DELETE 
FROM ToDone.GroupUser
WHERE UserID = @UserID AND GroupID = @GroupID
GO