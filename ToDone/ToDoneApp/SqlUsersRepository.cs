using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoneApp.DataDelegates;
using ToDoneApp.Models;

namespace ToDoneApp
{
    public class SqlUsersRepository : IUsersRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlUsersRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Users CreateUser(string displayName, string passwordHash, string firstName, string lastName, bool isAdmin)
        {
            if (string.IsNullOrEmpty(displayName)) throw new ArgumentException($"The parameter {nameof(displayName)} cannot be null or empty");
            if (string.IsNullOrWhiteSpace(passwordHash)) throw new ArgumentException($"The parameter {nameof(passwordHash)} cannot be null or have white space");
            if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException($"The parameter {nameof(firstName)} cannot be null or empty");
            if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException($"The parameter {nameof(lastName)} cannot be null or empty");

            var d = new CreateUserDataDelegate(displayName, passwordHash, firstName, lastName, isAdmin);
            return executor.ExecuteNonQuery(d);
        }

        public Users GetUser(string displayName)
        {
            if (string.IsNullOrEmpty(displayName)) throw new ArgumentException($"The parameter {nameof(displayName)} cannot be null or empty");

            var d = new GetUserDataDelegate(displayName);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Users> FetchUsersFriends(int UserID)
        {
            if (UserID < 1) throw new ArgumentException($"The parameter {nameof(UserID)} cannot be less than 1");

            var d = new FetchUsersFriendsDataDelegate(UserID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Users> FetchGroupsUsers(string displayName)
        {
            if (string.IsNullOrEmpty(displayName)) throw new ArgumentException($"The parameter {nameof(displayName)} cannot be null or empty");

            var d = new FetchGroupsUsersDataDelegate(displayName);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Groups> FetchUsersGroups(int UserID)
        {
            if (UserID < 1) throw new ArgumentException($"The parameter {nameof(UserID)} cannot be less than 1");

            var d = new FetchUsersGroupsDataDelegate(UserID);
            return executor.ExecuteReader(d);
        }
    }
}
