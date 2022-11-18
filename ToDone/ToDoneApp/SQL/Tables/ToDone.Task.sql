IF OBJECT_ID(N'ToDone.Task') IS NULL
BEGIN
Create Table ToDone.Task
(
	TaskID Int Identity(1, 1) Primary Key,
	CreatedByID Int Foreign Key References ToDone.Users(UserID),
	ClaimedByID Int Default 0,
	Title NVarChar(64) Not Null,
	[Description] NVarChar(1024) Not Null,
	DueDate DateTimeOffset,
	CompletedOn DateTimeOffset,
	PrivacyLevel Int Foreign Key References ToDone.PrivacyLevel(PrivacyID),
	IsClaimable Bit Not Null Default 0,
	IsActive Bit Not Null Default 1
);
End;
