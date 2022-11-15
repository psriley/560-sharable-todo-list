IF OBJECT_ID(N'ToDone.TaskComment') IS NULL
BEGIN
Create Table ToDone.TaskComment
(
	CommentID Int Identity(1,1) Primary Key,
	TaskID Int Foreign Key References ToDone.Task(TaskID),
	Comment NVarChar(256) Not Null
);
End;
