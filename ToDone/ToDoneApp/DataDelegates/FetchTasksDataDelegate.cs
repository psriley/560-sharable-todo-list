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
    internal class FetchTasksDataDelegate : DataReaderDelegate<IReadOnlyList<Task>>
    {
        public FetchTasksDataDelegate() :
            base("ToDone.FetchTasks")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
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