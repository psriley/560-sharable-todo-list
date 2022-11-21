using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ToDoneApp.DataDelegates
{
    internal class AvgFriendsGroupDataDelegate : DataReaderDelegate<double>
    {
        private readonly int GroupID;
        public AvgFriendsGroupDataDelegate(int GroupID) :
            base("ToDone.AvgFriendsGroup")
        {
            this.GroupID = GroupID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GroupID", GroupID);
        }

        public override double Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read()) return 0;

            return reader.GetValue<double>("Friends");
        }
    }
}
