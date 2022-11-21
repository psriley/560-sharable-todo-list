using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;
using ToDoneApp.DataDelegates;
using ToDoneApp.Interfaces;
using ToDoneApp.Models;

namespace ToDoneApp.SQLRepos
{
    internal class SqlTaskCommentRepository : ITaskCommentRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlTaskCommentRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public bool CreateTaskComment(int TaskID, string Comment)
        {
            if (TaskID < 1) throw new ArgumentException($"The Parameter {nameof(TaskID)} can not be less than 1");
            if (string.IsNullOrEmpty(Comment)) throw new ArgumentException($"The Parameter {nameof(Comment)} can not be null or empty");

            var d = new CreateTaskCommentDataDelegate(TaskID, Comment);
            return executor.ExecuteNonQuery(d);
        }

        public List<TaskComment> FetchTaskComments(int TaskID)
        {
            if (TaskID < 1) throw new ArgumentException($"The Parameter {nameof(TaskID)} can not be less than 1");

            var d = new FetchTaskCommentsDataDelegate(TaskID);
            return executor.ExecuteReader(d);
        }
    }
}
