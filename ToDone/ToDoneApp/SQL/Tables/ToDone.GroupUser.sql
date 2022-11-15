IF OBJECT_ID(N'ToDone.GroupUser') IS NULL
BEGIN
Create Table ToDone.GroupUser
(
	UserID Int Foreign Key References ToDone.Users(UserID),
	GroupID Int Foreign Key References ToDone.Groups(GroupID)

	Primary Key(
		UserID,
		GroupID
	)
);
End;
