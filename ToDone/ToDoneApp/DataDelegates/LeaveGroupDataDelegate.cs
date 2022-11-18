using System;
using DataAccess;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ToDoneApp.Models;
using System.Data.SqlClient;

namespace ToDoneApp.DataDelegates
{
    internal class LeaveGroupDataDelegate : NonQueryDataDelegate<int>
    {
        public readonly int UserID;
        public readonly int GroupID;

        public LeaveGroupDataDelegate(int UserID, int GroupID)
            : base("ToDone.JoinGroup")
        {
            this.UserID = UserID;
            this.GroupID = GroupID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("UserID", UserID);
            command.Parameters.AddWithValue("GroupID", GroupID);
        }

        public override int Translate(SqlCommand command)
        {
            return GroupID;
        }
    }
}
