using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using ToDoneApp.DataDelegates;
using ToDoneApp.Models;

namespace ToDoneApp.DataDelegates
{
    internal class FetchGroupsUsersDataDelegate : DataReaderDelegate<IReadOnlyList<Users>>
    {
        private readonly int GroupID;

        public FetchGroupsUsersDataDelegate(int GroupID)
            : base("ToDone.FetchGroupsUsers")
        {
            this.GroupID = GroupID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GroupID", GroupID);
        }


        public override IReadOnlyList<Users> Translate(SqlCommand command, IDataRowReader reader)
        {
            var gUsers = new List<Users>();

            while (reader.Read())
            {
                gUsers.Add(new Users(
                    reader.GetInt32("UserID"),
                    reader.GetString("DisplayName"),
                    null,
                    reader.GetString("FirstName"),
                    reader.GetString("LastName"),
                    false));
            }

            return gUsers;
        }
    }
}