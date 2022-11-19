using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;
using ToDoneApp.DataDelegates;
using ToDoneApp.Models;

namespace ToDoneApp.DataDelegates
{
    internal class AddFriendDataDelegate : NonQueryDataDelegate<bool>
    {
        public readonly int UserID;
        public readonly int FriendID;

        public AddFriendDataDelegate(int UserID, int FriendID):
            base("ToDone.AddFriend")
        {
            this.UserID = UserID;
            this.FriendID = FriendID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", UserID);
            command.Parameters.AddWithValue("FriendID", FriendID);
        }


        public override bool Translate(SqlCommand command)
        {
            return true;
        }
    }
}
