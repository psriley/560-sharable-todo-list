using System;
using DataAccess;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ToDoneApp.Models;
using System.Data.SqlClient;
using ToDoneApp.DataDelegates;

namespace ToDoneApp
{
    internal class SqlGroupUserRepository : IGroupUserRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlGroupUserRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public int JoinGroup(int UserID, int GroupID)
        {
            if (UserID < 1) throw new ArgumentException($"The parameter {nameof(UserID)} cannot be less than 1");
            if (GroupID < 1) throw new ArgumentException($"The parameter {nameof(GroupID)} cannot be less than 1");

            var d = new JoinGroupDataDelegate(UserID, GroupID);
            return executor.ExecuteNonQuery(d);
        }

        public int LeaveGroup(int UserID, int GroupID)
        {
            if (UserID < 1) throw new ArgumentException($"The parameter {nameof(UserID)} cannot be less than 1");
            if (GroupID < 1) throw new ArgumentException($"The parameter {nameof(GroupID)} cannot be less than 1");

            var d = new LeaveGroupDataDelegate(UserID, GroupID);
            return executor.ExecuteNonQuery(d);
        }
    }
}
