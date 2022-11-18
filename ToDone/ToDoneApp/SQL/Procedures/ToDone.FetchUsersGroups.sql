CREATE OR ALTER PROCEDURE ToDone.FetchUsersGroups
	@UserID INT
AS
SELECT G.GroupID, G.Title, G.[Description]
FROM ToDone.Groups G
INNER JOIN ToDone.GroupUser GU ON GU.UserID = @UserID
GO