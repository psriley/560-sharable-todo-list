using System;
using DataAccess;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ToDoneApp.Models;
using System.Data.SqlClient;
using ToDoneApp.DataDelegates;

namespace ToDoneApp.Interfaces
{
    public interface IFriendsRepository
    {
        bool AddFriend(int UserID, int FriendID);

        bool RemoveFriend(int UserID, int FriendID);
    }
}
