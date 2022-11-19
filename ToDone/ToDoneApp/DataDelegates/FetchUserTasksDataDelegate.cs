using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ToDoneApp.Models;

namespace ToDoneApp.DataDelegates
{
    internal class FetchUserTaskDataDelegate : DataReaderDelegate<IReadOnlyList<ToDoneApp.Models.Task>>
    {
        public readonly int UserID;

        public FetchUserTaskDataDelegate(int UserID)
            : base("ToDone.FetchUserTasks")
        {
            this.UserID = UserID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", UserID);
        }

        public override IReadOnlyList<Task> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<Task> tasks = new List<Task>();
            DateTimeOffset? completed;
            while (reader.Read())
            {
                try
                {
                    completed = reader.GetDateTimeOffset("CompletedOn");
                }
                catch
                {
                    completed = null;
                }
                tasks.Add(new Task(
                    reader.GetInt32("TaskID"),
                    reader.GetInt32("CreatedByID"),
                    reader.GetInt32("ClaimedByID"),
                    reader.GetString("Title"),
                    reader.GetString("Description"),
                    reader.GetDateTimeOffset("DueDate"),
                    completed,
                    reader.GetInt32("PrivacyLevel"),
                    reader.GetValue<bool>("IsClaimable"),
                    reader.GetValue<bool>("IsActive")));
            }
            return tasks;
        }
    }
}
