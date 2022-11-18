using DataAccess;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;
using ToDoneApp.DataDelegates;
using ToDoneApp.Models;

namespace ToDoneApp.DataDelegates
{
    internal class CreateTaskCommentDataDelegate : NonQueryDataDelegate<bool>
    {
        private readonly int taskID;
        private readonly string comment;

        public CreateTaskCommentDataDelegate(int taskID, string comment) : base("ToDone.CreateTaskComment")
        {
            this.taskID = taskID;
            this.comment = comment;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("TaskID", taskID);
            command.Parameters.AddWithValue("Comment", comment);

            var p = command.Parameters.Add("CommentID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override bool Translate(SqlCommand command)
        {
            return true;
        }
    }
}