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
    internal class CreateTaskCommentDataDelegate : NonQueryDataDelegate<bool>
    {
        private readonly int taskID;
        private readonly string comment;

        public CreateTaskCommentDataDelegate(int taskID, string comment) : base("ToDone.CreateTaskComment")
        {
            this.taskID = taskID;
            this.comment = comment;
        }

        public override bool Translate(SqlCommand command)
        {
            return true;
        }
    }
}