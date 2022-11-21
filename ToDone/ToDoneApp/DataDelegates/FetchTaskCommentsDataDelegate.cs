﻿using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;
using ToDoneApp.DataDelegates;
using ToDoneApp.Interfaces;
using ToDoneApp.Models;

namespace ToDoneApp.DataDelegates
{
    internal class FetchTaskCommentsDataDelegate : DataReaderDelegate<List<TaskComment>>
    {
        private readonly int TaskID;

        public FetchTaskCommentsDataDelegate(int TaskID)
            : base("ToDone.FetchTaskComments")
        {
            this.TaskID = TaskID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("TaskID", TaskID);
        }

        public override List<TaskComment> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<TaskComment> comments = new List<TaskComment>();

            while (reader.Read())
            {
                comments.Add(new TaskComment(
                    reader.GetInt32("CommentID"),
                    reader.GetInt32("TaskID"),
                    reader.GetString("Comment")));
            }

            return comments;
        }
    }
}
