CREATE OR ALTER PROCEDURE ToDone.FetchGroupsUsers
	@GroupID INT
AS
SELECT U.UserID, U.DisplayName, U.FirstName, U.LastName
FROM ToDone.GroupUser GU
INNER JOIN ToDone.Users U ON GU.UserID = U.UserID
WHERE @GroupID = GU.GroupID
GO