using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoneApp.Models;
using System.Data.SqlClient;
using System.Data;

namespace ToDoneApp.DataDelegates
{
    internal class CreateTaskDataDelegate : NonQueryDataDelegate<Task>
    {
        public readonly int CreatedByID;
        public readonly int ClaimedByID;
        public readonly string Title;
        public readonly string Description;
        public readonly DateTimeOffset? DueDate;
        public readonly int PrivacyLevel;
        public readonly bool IsClaimable;

        public CreateTaskDataDelegate(int CreatedById, int ClaimedByID, string Title, string Description, DateTimeOffset? DueDate, int PrivacyLevel, bool IsClaimable)
            : base("ToDone.CreateTask")
        {
            this.CreatedByID = CreatedById;
            this.ClaimedByID = ClaimedByID;
            this.Title = Title;
            this.Description = Description;
            this.DueDate = DueDate;
            this.PrivacyLevel = PrivacyLevel;
            this.IsClaimable = IsClaimable;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("CreatedByID", CreatedByID);
            command.Parameters.AddWithValue("ClaimedByID", ClaimedByID);
            command.Parameters.AddWithValue("Title", Title);
            command.Parameters.AddWithValue("Description", Description);
            command.Parameters.AddWithValue("DueDate", DueDate);
            command.Parameters.AddWithValue("PrivacyLevel", PrivacyLevel);
            command.Parameters.AddWithValue("IsClaimable", IsClaimable);

            var p = command.Parameters.Add("TaskID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Task Translate(SqlCommand command)
        {
            return new Task((int)command.Parameters["TaskID"].Value, CreatedByID, ClaimedByID, Title, Description, DueDate, null, PrivacyLevel, IsClaimable, true);
        }
    }
}
