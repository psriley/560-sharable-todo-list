using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoneApp.DataDelegates;
using ToDoneApp.Interfaces;
using ToDoneApp.Models;

namespace ToDoneApp.SQLRepos
{
    internal class SqlTaskRepository : ITaskRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlTaskRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public bool ClaimTask(int TaskID, int UserID)
        {
            if (TaskID < 1) throw new ArgumentOutOfRangeException($"The Parameter {nameof(TaskID)} can not be less than 1");
            if (UserID < 1) throw new ArgumentOutOfRangeException($"The Parameter {nameof(UserID)} can not be less than 1");

            var d = new ClaimTaskDataDelegate(TaskID, UserID);
            return executor.ExecuteNonQuery(d);
        }

        public bool CompleteTask(int TaskID, int UserID)
        {
            if (TaskID < 1) throw new ArgumentOutOfRangeException($"The Parameter {nameof(TaskID)} can not be less than 1");
            if (UserID < 1) throw new ArgumentOutOfRangeException($"The Parameter {nameof(UserID)} can not be less than 1");

            var d = new CompleteTaskDataDelegate(TaskID, UserID);
            return executor.ExecuteNonQuery(d);
        }

        public Models.Task CreateTask(int CreatedByID, int ClaimedByID, string Title, string Description, DateTimeOffset DueDate, int PrivacyLevel, bool IsClaimable)
        {
            if (string.IsNullOrEmpty(Title)) throw new ArgumentException($"The Parameter {nameof(Title)} can not be null or empty");
            if (string.IsNullOrEmpty(Description)) throw new ArgumentException($"The Parameter {nameof(Description)} can not be null or empty");
            if (PrivacyLevel < 0 | PrivacyLevel > 3) throw new ArgumentException($"The Parameter {nameof(PrivacyLevel)} must be one of the 4 choices provided");


            var d = new CreateTaskDataDelegate(CreatedByID, ClaimedByID, Title, Description, DueDate, PrivacyLevel, IsClaimable);
            return executor.ExecuteNonQuery(d);
        }

        public bool DeleteTask(int TaskID, int UserID)
        {
            if (TaskID < 1) throw new ArgumentOutOfRangeException($"The Parameter {nameof(TaskID)} can not be less than 1");
            if (UserID < 1) throw new ArgumentOutOfRangeException($"The Parameter {nameof(UserID)} can not be less than 1");

            var d = new DeleteTaskDataDelegate(TaskID, UserID);
            return executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<Models.Task> FetchTasks()
        {
            var d = new FetchTasksDataDelegate();
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Models.Task> FetchUserTasks(int UserID)
        {
            if (UserID < 1) throw new ArgumentOutOfRangeException($"The Parameter {nameof(UserID)} can not be less than 1");

            var d = new FetchUserTaskDataDelegate(UserID);
            return executor.ExecuteReader(d);
        }
    }
}
