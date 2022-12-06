using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoneApp.DataDelegates;
using ToDoneApp.Interfaces;

namespace ToDoneApp.SQLRepos
{
    internal class SqlAdminRepository : IAdminRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlAdminRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public double AvgFriends()
        {

            var d = new AvgFriendsDataDelegate();
            return executor.ExecuteReader(d);
        }

        public double AvgFriendsGroup(int GroupID)
        {
            if (GroupID < 1) throw new ArgumentException($"The Parameter {nameof(GroupID)} can not be less than 1");

            var d = new AvgFriendsGroupDataDelegate(GroupID);
            return executor.ExecuteReader(d);
        }

        public double AvgTasksCompleted()
        {

            var d = new AvgTasksCompletedDataDelegate();
            return executor.ExecuteReader(d);
        }

        public double AvgTasksCompletedGroup(int GroupID)
        {
            if (GroupID < 1) throw new ArgumentException($"The Parameter {nameof(GroupID)} can not be less than 1");

            var d = new AvgTasksGroupDataDelegate(GroupID);
            return executor.ExecuteReader(d);
        }

        public double PercentCompleted()
        {
            var d = new PercentCompletedDataDelegate();
            return executor.ExecuteReader(d);
        }

        public double PercentCompletedUser(int UserID)
        {
            if (UserID < 1) throw new ArgumentException($"The Parameter {nameof(UserID)} can not be less than 1");

            var d = new PercentCompletedUserDataDelegate(UserID);
            return executor.ExecuteReader(d);
        }

        public List<int> PopularHour()
        {
            var d = new PopularHourDataDelegate();
            return executor.ExecuteReader(d);
        }

        public List<int> PopularHourUser(int UserID)
        {
            if (UserID < 1) throw new ArgumentException($"The Parameter {nameof(UserID)} can not be less than 1");

            var d = new PopularHourUserDataDelegate(UserID);
            return executor.ExecuteReader(d);
        }
    }
}
