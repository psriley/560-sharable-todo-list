IF OBJECT_ID(N'ToDone.Groups') IS NULL
BEGIN
Create Table ToDone.Groups
(
	GroupID Int Identity(1,1) Primary Key,
	Title NVarChar(64) Unique Not Null,
	[Description] NVarChar(256) Not Null	
);
End;
