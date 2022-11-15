CREATE OR ALTER PROCEDURE ToDone.CreateGroup
	@Title NVarChar(64),
	@Description NVarChar(256),	
	@GroupID INT OUTPUT
AS

INSERT ToDone.Groups(Title, [Description])
VALUES(@Title, @Description)

SET @GroupID = SCOPE_IDENTITY();
GO