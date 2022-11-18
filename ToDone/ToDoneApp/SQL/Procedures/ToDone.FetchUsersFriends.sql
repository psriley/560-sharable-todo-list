CREATE OR ALTER PROCEDURE ToDone.FetchUsersFriends
	@UserID INT
AS
SELECT U.UserID, U.DisplayName, U.FirstName, U.LastName, U.IsAdmin
FROM ToDone.Users U
INNER JOIN ToDone.FriendsUser F ON (F.User1 = @UserID AND F.User2 = U.UserID) OR (F.User2 = @UserID AND F.User1 = U.UserID)
GO