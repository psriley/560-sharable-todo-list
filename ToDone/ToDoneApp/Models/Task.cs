using System;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace ToDoneApp.Models
{
    public class Task
    {
        public int TaskID { get; }
        public int CreatedByID { get; }
        public int ClaimedByID { get; }
        public string Title { get; }
        public string Description { get; }
        public DateTimeOffset? DueDate { get; }
        public DateTimeOffset? CompletedOn { get; }
        public int PrivacyLevel { get; }
        public bool IsClaimable { get; }
        public bool IsActive { get; }

        public Task(int taskID, int createdByID, int claimedByID, string title, string description, DateTimeOffset? dueDate, DateTimeOffset? completedOn, int privacyLevel, bool isClaimable, bool isActive)
        {
            TaskID = taskID;
            CreatedByID = createdByID;
            ClaimedByID = claimedByID;
            Title = title;
            Description = description;
            DueDate = dueDate;
            CompletedOn = completedOn;
            PrivacyLevel = privacyLevel;
            IsClaimable = isClaimable;
            IsActive = isActive;
        }
    }

}
