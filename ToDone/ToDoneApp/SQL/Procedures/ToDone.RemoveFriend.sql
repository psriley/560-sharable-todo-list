CREATE OR ALTER PROCEDURE ToDone.RemoveFriend
	@UserID INT,
	@FriendID INT
AS
DELETE 
FROM ToDone.FriendsUser
WHERE ((User1 = @UserID AND User2 = @FriendID) OR (User2 = @UserID AND User1 = @FriendID))
GO