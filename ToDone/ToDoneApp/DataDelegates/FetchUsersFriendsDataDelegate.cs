using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using ToDoneApp.DataDelegates;
using ToDoneApp.Models;

namespace ToDoneApp.DataDelegates
{
    internal class FetchUsersFriendsDataDelegate : DataReaderDelegate<IReadOnlyList<Users>>
    {
        private readonly int UserID;

        public FetchUsersFriendsDataDelegate(int UserID)
            : base("ToDone.FetchUsersFriends")
        {
            this.UserID = UserID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", UserID);
        }

        public override IReadOnlyList<Users> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<Users> friends = new List<Users>();
            while (reader.Read())
            {
                friends.Add(new Users(
                    reader.GetInt32("UserID"),
                    reader.GetString("DisplayName"),
                    "0",
                    reader.GetString("FirstName"),
                    reader.GetString("LastName"),
                    reader.GetValue<bool>("IsAdmin")));
            }

            return friends;
        }
    }
}
