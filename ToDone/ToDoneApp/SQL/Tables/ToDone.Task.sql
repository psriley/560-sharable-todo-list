IF OBJECT_ID(N'ToDone.Task') IS NULL
BEGIN
Create Table ToDone.Task
(
	TaskID Int Identity(1, 1) Primary Key,
	UserID Int Foreign Key References ToDone.Users(UserID),
	Title NVarChar(64) Not Null,
	[Description] NVarChar(256) Not Null,
	DueDate Date,
	CompletedOn DateTimeOffset,
	PrivacyLevel Int Foreign Key References ToDone.PrivacyLevel(PrivacyID),
	Claimable Bit
);
End;
