using System;
using DataAccess;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ToDoneApp.Models;
using System.Data.SqlClient;
namespace ToDoneApp.DataDelegates
{
    internal class GetGroupDataDelegate : DataReaderDelegate<Groups>
    {
        private readonly int GroupID;

        public GetGroupDataDelegate(int GroupID)
            : base("ToDone.GetGroup")
        {
            this.GroupID = GroupID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GroupID", GroupID);
        }

        public override Groups Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException($"Group with ID:{GroupID} not found");

            return new Groups(
                GroupID, 
                reader.GetString("Title"), 
                reader.GetString("Description"));

        }
    }
}