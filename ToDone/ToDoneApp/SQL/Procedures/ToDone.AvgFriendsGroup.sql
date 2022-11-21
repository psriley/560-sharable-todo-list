CREATE OR ALTER PROCEDURE ToDone.AvgFriendsGroup
@GroupID INT
AS
SELECT (CAST((SELECT COUNT(*)
FROM ToDone.FriendsUser F
INNER JOIN ToDone.Users U ON (F.User1 = U.UserID OR F.User2 = U.UserID)
INNER JOIN ToDone.GroupUser GU ON (F.User1 = GU.UserID AND GU.GroupID = @GroupID)
OR (F.User2 = GU.UserID AND GU.GroupID = @GroupID))/2 AS FLOAT)
/
CAST(
(SELECT COUNT(*)
FROM ToDone.GroupUser GU
WHERE GU.GroupID = @GroupID) AS FLOAT)) AS Friends
GO