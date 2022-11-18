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
    internal class RemoveFriendDataDelegate : NonQueryDataDelegate<bool>
    {
        public readonly int UserID;
        public readonly int FriendID;

        public RemoveFriendDataDelegate(int UserID, int FriendID) :
            base("ToDone.RemoveFriend")
        {
            this.UserID = UserID;
            this.FriendID = FriendID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("User1", UserID);
            command.Parameters.AddWithValue("User2", FriendID);
        }


        public override bool Translate(SqlCommand command)
        {
            return true;
        }
    }
}
