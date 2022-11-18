CREATE OR ALTER PROCEDURE ToDone.CreateUser
	@DisplayName NVARCHAR(32),
	@PasswordHash NVarChar(32),
	@FirstName NVarChar(32),
	@LastName NVarChar(32),
	@IsAdmin BIT,
	@UserID INT OUTPUT
AS

INSERT ToDone.Users(DisplayName, PasswordHash, FirstName, LastName, IsAdmin)
VALUES(@DisplayName, @PasswordHash, @FirstName, @LastName, @IsAdmin)

SET @UserID = SCOPE_IDENTITY();
GO