IF OBJECT_ID(N'ToDone.Users') IS NULL
BEGIN
Create Table ToDone.Users
(
	UserID Int Identity(1, 1) Primary Key,
	DisplayName	NVarChar(32) Unique Not Null,
	PasswordHash NVarChar(32) Not Null,
	FirstName NVarChar(32) Not Null,
	LastName NVarChar(32) Not Null,
	IsAdmin Bit 

	Unique 
	(
		FirstName,
		LastName
	)
);
End;
