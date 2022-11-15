IF OBJECT_ID(N'ToDone.FriendsUser') IS NULL
BEGIN
Create Table ToDone.FriendsUser
(
	User1 Int Foreign Key References ToDone.Users(UserID),
	User2 Int Foreign Key References ToDone.Users(UserID)

	Primary Key
	(
		User1,
		User2
	)
);
End;
