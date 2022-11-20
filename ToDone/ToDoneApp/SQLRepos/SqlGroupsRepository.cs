using DataAccess;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using ToDoneApp.DataDelegates;
using ToDoneApp.Interfaces;
using ToDoneApp.Models;

namespace ToDoneApp.SQLRepos
{
    internal class SqlGroupsRepository : IGroupsRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlGroupsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Groups CreateGroup(string Title, string Description)
        {
            if (string.IsNullOrEmpty(Title)) throw new ArgumentException($"The parameter {nameof(Title)} cannot be null or empty");
            if (string.IsNullOrEmpty(Description)) throw new ArgumentException($"The parameter {nameof(Description)} cannot be null or empty");

            var d = new CreateGroupDataDelegate(Title, Description);
            return executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<Groups> FetchGroups()
        {
            var d = new FetchGroupsDataDelegate();
            return executor.ExecuteReader(d);
        }

        public Groups GetGroup(int GroupID)
        {
            if (GroupID < 0) throw new ArgumentException($" The Parameter {nameof(GroupID)} can not be less than 0");

            var d = new GetGroupDataDelegate(GroupID);
            return executor.ExecuteReader(d);
        }
    }
}