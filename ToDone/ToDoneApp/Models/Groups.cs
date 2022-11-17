using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoneApp.Models
{
    public class Groups
    {
        public int GroupID { get; }
        public string Title { get; }
        public string Description { get; }

        public Groups(int groupID, string title, string description)
        {
            GroupID = groupID;
            Title = title;
            Description = description;
        }
    }
}
