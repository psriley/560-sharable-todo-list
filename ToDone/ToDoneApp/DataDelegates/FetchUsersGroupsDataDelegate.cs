using System;
using DataAccess;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ToDoneApp.Models;
using System.Data.SqlClient;

namespace ToDoneApp.DataDelegates
{
    internal class FetchUsersGroupsDataDelegate : DataReaderDelegate<IReadOnlyList<Groups>>
    {
        public readonly int UserID;

        public FetchUsersGroupsDataDelegate(int UserID)
            : base("ToDone.FetchUsersGroups")
        {
            this.UserID = UserID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("UserID", UserID);
        }

        public override IReadOnlyList<Groups> Translate(SqlCommand command, IDataRowReader reader)
        {
            var allGroups = new List<Groups>();

            while (reader.Read())
            {
                allGroups.Add(new Groups(
                    reader.GetInt32("GroupID"),
                    reader.GetString("Title"),
                    reader.GetString("Description")));
            }

            return allGroups;
        }
    }
}

