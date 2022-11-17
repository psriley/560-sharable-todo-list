CREATE OR ALTER PROCEDURE ToDone.FetchUsersFriends
	@DisplayName NVarChar(32)
AS
SELECT *
FROM ToDone.Users US
WHERE US.UserID =
(SELECT 
CASE WHEN F.User1 = U.UserID Then F.User2 ELSE F.User1 END
FROM ToDone.Users U
INNER JOIN ToDone.FriendsUser F on U.UserID = F.User1 OR U.UserId = F.User2
WHERE U.DisplayName = @DisplayName)
GO