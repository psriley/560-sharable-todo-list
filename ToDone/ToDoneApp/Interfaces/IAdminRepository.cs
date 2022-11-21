using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoneApp.Interfaces
{
    internal interface IAdminRepository
    {
        double PercentCompleted();

        int PercentCompletedUser(int UserID);

        List<int> PopularHour();

        List<int> PopularHourUser(int UserID);

        double AvgTasksCompleted();

        double AvgTasksCompletedGroup(int GroupID);

        double AvgFriends();

        double AvgFriendsGroup(int GroupID);
    }
}
