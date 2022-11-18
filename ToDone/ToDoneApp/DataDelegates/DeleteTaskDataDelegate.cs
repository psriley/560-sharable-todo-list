using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ToDoneApp.DataDelegates
{
    internal class DeleteTaskDataDelegate : NonQueryDataDelegate<bool>
    {
        public readonly int TaskID;
        public readonly int UserID;

        public DeleteTaskDataDelegate(int TaskID, int UserID)
            : base("ToDone.DeleteTask")
        {
            this.TaskID = TaskID;
            this.UserID = UserID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("TaskID", TaskID);
            command.Parameters.AddWithValue("UserID", UserID);
        }

        public override bool Translate(SqlCommand command)
        {
            return true;
        }
    }
}
