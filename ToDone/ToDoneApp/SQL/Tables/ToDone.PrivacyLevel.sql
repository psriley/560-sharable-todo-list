IF OBJECT_ID(N'ToDone.PrivacyLevel') IS NULL
BEGIN
Create Table ToDone.PrivacyLevel
(
	PrivacyID Int Primary Key,
	PrivacyType NVarChar(32) Not Null
);
End;
