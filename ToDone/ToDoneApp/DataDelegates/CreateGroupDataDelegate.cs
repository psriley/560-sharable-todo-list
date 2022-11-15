using System;
using DataAccess;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ToDoneApp.Models;
using System.Data.SqlClient;

namespace ToDoneApp.DataDelegates
{
    internal class CreateGroupDataDelegate : NonQueryDataDelegate<Groups>
    {
        public readonly string Title;
        public readonly string Description;

        public CreateGroupDataDelegate(string Title, string Description)
            : base("ToDone.CreateGroup")
        {
            this.Title = Title;
            this.Description = Description;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Title", Title);
            command.Parameters.AddWithValue("Description", Description);

            var p = command.Parameters.Add("GroupID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Groups Translate(SqlCommand command)
        {
            return new Groups((int)command.Parameters["GroupID"].Value, Title, Description);
        }
    }
}
