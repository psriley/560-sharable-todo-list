CREATE OR ALTER PROCEDURE ToDone.GetUser
	@DisplayName NVarChar(32)
AS
SELECT *
FROM ToDone.Users U
Where U.DisplayName = @DisplayName
GO