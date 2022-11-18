using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoneApp.Models;
using ToDoneApp.DataDelegates;

namespace ToDoneApp
{
    internal class SqlFriendsRepository : IFriendsRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlFriendsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public bool AddFriend(int UserID, int FriendID)
        {
            if (UserID < 1) throw new ArgumentException($"The Parameter {nameof(UserID)} can not be less than 1");
            if (FriendID < 1) throw new ArgumentException($"The Parameter {nameof(FriendID)} can not be less than 1");

            var d = new AddFriendDataDelegate(UserID, FriendID);
            return executor.ExecuteNonQuery(d);
        }

        public bool RemoveFriend(int UserID, int FriendID)
        {
            if (UserID < 1) throw new ArgumentException($"The Parameter {nameof(UserID)} can not be less than 1");
            if (FriendID < 1) throw new ArgumentException($"The Parameter {nameof(FriendID)} can not be less than 1");

            var d = new RemoveFriendDataDelegate(UserID, FriendID);
            return executor.ExecuteNonQuery(d);
        }
    }
}
