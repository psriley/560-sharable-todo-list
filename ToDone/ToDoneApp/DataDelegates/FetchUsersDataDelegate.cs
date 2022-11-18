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
    internal class FetchUsersDataDelegate : DataReaderDelegate<IReadOnlyList<Users>>
    {
        public FetchUsersDataDelegate()
            : base("ToDone.FetchUsers")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<Users> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<Users> users = new List<Users>();
            while (reader.Read())
            {
                users.Add(new Users(
                    reader.GetInt32("UserID"),
                    reader.GetString("DisplayName"),
                    reader.GetString("PasswordHash"),
                    reader.GetString("FirstName"),
                    reader.GetString("LastName"),
                    reader.GetValue<bool>("IsAdmin")));
            }
            return users;
        }
    }
}
