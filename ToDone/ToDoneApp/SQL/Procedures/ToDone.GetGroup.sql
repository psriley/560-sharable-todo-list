CREATE OR ALTER PROCEDURE ToDone.GetGroup
	@GroupID INT
AS 
SELECT *
FROM ToDone.Groups G
WHERE G.GroupID = @GroupID
GO