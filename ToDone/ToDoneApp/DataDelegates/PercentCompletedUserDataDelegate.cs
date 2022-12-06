using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ToDoneApp.DataDelegates
{
    internal class PercentCompletedUserDataDelegate : DataReaderDelegate<double>
    {
        private readonly int UserID;
        public PercentCompletedUserDataDelegate(int UserID) :
            base("ToDone.PercentCompletedUser")
        {
            this.UserID = UserID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", UserID);
        }

        public override double Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read()) return 0;

            return reader.GetValue<double>("Completed");
        }
    }
}
