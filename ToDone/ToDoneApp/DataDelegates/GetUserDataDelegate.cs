using System;
using DataAccess;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ToDoneApp.Models;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ToDoneApp.DataDelegates
{
    internal class GetUserDataDelegate : DataReaderDelegate<Users>
    {
        private readonly string displayName;

        public GetUserDataDelegate(string displayName)
            : base("ToDone.GetUser")
        {
            this.displayName = displayName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("DisplayName", displayName);
        }

        public override Users Translate(SqlCommand command, IDataRowReader reader)
        {
            if(!reader.Read()) return null;
                

            return new Users(
                reader.GetInt32("UserID"), 
                displayName, 
                reader.GetString("PasswordHash"), 
                reader.GetString("FirstName"), 
                reader.GetString("LastName"), 
                reader.GetValue<bool>("IsAdmin"));
        }
    }
}
