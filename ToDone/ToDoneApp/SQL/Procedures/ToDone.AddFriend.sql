CREATE OR ALTER PROCEDURE ToDone.AddFriend
	@UserID INT,
	@FriendDisplayName NVarChar(32)
AS
INSERT ToDone.FriendsUser(User1, User2)
VALUES(@UserID, (SELECT U.UserID FROM ToDone.Users U Where U.DisplayName = @FriendDisplayName))
GO