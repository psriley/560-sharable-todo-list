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
        private readonly string displayName;

        public FetchGroupsUsersDataDelegate(string displayName)
            : base("ToDone.FetchUsersFriends")
        {
            this.displayName = displayName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("DisplayName", displayName);
        }


        public override IReadOnlyList<Users> Translate(SqlCommand command, IDataRowReader reader)
        {
            var gUsers = new List<Users>();

            while (reader.Read())
            {
                gUsers.Add(new Users(
                    reader.GetInt32("UserID"),
                    displayName,
                    reader.GetString("PasswordHash"),
                    reader.GetString("FirstName"),
                    reader.GetString("LastName"),
                    reader.GetValue<bool>("IsAdmin")));
            }

            return gUsers;
        }
    }
}