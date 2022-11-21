using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ToDoneApp.DataDelegates
{
    internal class PercentCompletedDataDelegate : DataReaderDelegate<double>
    {
        public PercentCompletedDataDelegate() :
            base("ToDone.PercentCompleted")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override double Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read()) return 0;

            return reader.GetValue<double>("Completed");
        }
    }
}
