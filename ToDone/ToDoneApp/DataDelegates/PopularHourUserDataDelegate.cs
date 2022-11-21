using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ToDoneApp.DataDelegates
{
    internal class PopularHourUserDataDelegate : DataReaderDelegate<List<int>>
    {
        private readonly int UserID;
        public PopularHourUserDataDelegate(int UserID) :
            base("ToDone.PercentCompleted")
        {
            this.UserID = UserID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", UserID);
        }

        public override List<int> Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read()) return null;

            List<int> result = new List<int>();
            result.Add(reader.GetInt32("Hour"));
            result.Add(reader.GetInt32("HourCount"));

            return result;
        }
    }
}
