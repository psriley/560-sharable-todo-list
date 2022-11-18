CREATE OR ALTER PROCEDURE ToDone.AddFriend
	@UserID INT,
	@FriendID INT
AS
INSERT ToDone.FriendsUser(User1, User2)
VALUES(@UserID, @FriendID)
GO