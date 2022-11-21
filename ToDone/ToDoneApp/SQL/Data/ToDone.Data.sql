﻿If ((Select Count(*) From ToDone.PrivacyLevel)<> 4) 

Insert ToDone.PrivacyLevel(PrivacyID, PrivacyType)
Values
(0, N'Creator and Claimer'),
(1, N'Creator, Claimer, and Friends'),
(2, N'Creator, Claimer, Group and Friends'),
(3, N'Public');

Go


Declare @Password NVarChar = N'Password';
If((Select Count(*) From ToDone.Users)<> 2)

Insert ToDone.Users(DisplayName, PasswordHash, FirstName, LastName, IsAdmin)
Values
(N'Peyton Riley', N'55131205158113182224612143461222' , N'Peyton', N'Riley', 0)


If((Select Count(*) From ToDone.Users)<> 3)
Insert ToDone.Users(DisplayName, PasswordHash, FirstName, LastName, IsAdmin)
Values
(N'Christian Berard', N'15422818814502191452132205571328', N'Christian', N'Berard', 0)

If((Select Count(*) From ToDone.Users)<> 3)
Insert ToDone.Users(DisplayName, PasswordHash, FirstName, LastName, IsAdmin)
Values
(N'Admin', N'19319436176602171881231061342151', N'Admin', N'Admin', 1)
Go


If((Select Count(*) From ToDone.Task) <> 2)
Insert ToDone.Task(CreatedByID, Title, [Description], DueDate, CompletedOn, PrivacyLevel, IsClaimable)
Values
((Select U.UserID From ToDone.Users U Where U.DisplayName = N'Peyton Riley'), N'Peyton First Task!', N'This task is not claimable', '2022-11-19 23:00:00', '2022-11-19 22:00:00', 0, 0),
((Select U.UserID From ToDone.Users U Where U.DisplayName = N'Christian Berard'), N'Christian First Task!', N'This task is claimable', '2022-11-19 23:00:00', '2022-12-19 00:00:00', 1, 1)
Go


If((Select Count(*) From ToDone.TaskComment) <> 1)
Insert ToDone.TaskComment(TaskID, Comment)
Values
(1, N'Almost done with whatever Peyton task 1 is!')
Go


If((Select Count(*) From ToDone.Groups) <> 1)
Insert ToDone.Groups(Title, [Description])
Values
(N'New Group', N'This is where I would put a description of the group.... IF I HAD ONE')
Go 


IF((Select Count(*) From ToDone.FriendsUser) <> 1)
Insert ToDone.FriendsUser (User1, User2)
Values
((Select U.UserID From ToDone.Users U Where U.DisplayName = 'Peyton Riley'), (Select U.UserID From ToDone.Users U Where U.DisplayName = 'Christian Berard'))
Go


IF((Select Count(*) From ToDone.GroupUser) <> 2)
Insert ToDone.GroupUser(UserID, GroupID)
Values
((Select U.UserID From ToDone.Users U Where U.DisplayName = 'Admin'), (Select G.GroupID From ToDone.Groups G Where G.Title = N'New Group')),((Select U.UserID From ToDone.Users U Where U.DisplayName = 'Christian Berard'), (Select G.GroupID From ToDone.Groups G Where G.Title = N'New Group'))
Go
