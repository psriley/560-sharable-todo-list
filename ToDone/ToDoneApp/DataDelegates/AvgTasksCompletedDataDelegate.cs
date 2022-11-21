using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ToDoneApp.DataDelegates
{
    internal class AvgTasksCompletedDataDelegate : DataReaderDelegate<double>
    {
        public AvgTasksCompletedDataDelegate() :
            base("ToDone.AvgTasksCompleted")
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
