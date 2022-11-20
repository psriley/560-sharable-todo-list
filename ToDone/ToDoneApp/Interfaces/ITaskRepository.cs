using System;
using System.Collections.Generic;
using System.Text;
using ToDoneApp.Models;

namespace ToDoneApp.Interfaces
{
    public interface ITaskRepository
    {
        Task CreateTask(int CreatedByID, int ClaimedByID, string Title, string Description, DateTimeOffset DueDate, int PrivacyLevel, bool IsClaimable);

        bool ClaimTask(int TaskID, int UserID);

        IReadOnlyList<Task> FetchUserTasks(int UserID);

        IReadOnlyList<Task> FetchTasks();

        bool CompleteTask(int TaskID, int UserID);

        bool DeleteTask(int TaskID, int UserID);
    }
}
