using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ToDoneApp.DataDelegates
{
    internal class PopularHourDataDelegate : DataReaderDelegate<List<int>>
    {
        public PopularHourDataDelegate() :
            base("ToDone.PopularHour")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override List<int> Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read()) return null;

            List<int> result = new List<int>();
            result.Add(reader.GetInt32("HourNumber"));
            result.Add(reader.GetInt32("HourCount"));

            return result;
        }
    }
}
