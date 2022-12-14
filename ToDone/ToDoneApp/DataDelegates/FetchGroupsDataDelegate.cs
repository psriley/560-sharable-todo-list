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
    internal class FetchGroupsDataDelegate : DataReaderDelegate<IReadOnlyList<Groups>>
    {
        public FetchGroupsDataDelegate()
            : base("ToDone.FetchGroups")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<Groups> Translate(SqlCommand command, IDataRowReader reader)
        {
            var allGroups = new List<Groups>();

            while (reader.Read())
            {
                allGroups.Add(new Groups(
                    reader.GetInt32("GroupID"),
                    reader.GetString("Title"),
                    reader.GetString("Description")));
            }

            return allGroups;
        }
    }
}
