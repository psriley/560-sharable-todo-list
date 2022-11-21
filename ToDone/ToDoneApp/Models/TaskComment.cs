using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoneApp.Models
{
    public class TaskComment
    {
        public int CommentID { get; }
        public int TaskID { get; }
        public string Comment { get; }

        public TaskComment(int CommentID, int TaskID, string Comment)
        {
            this.CommentID = CommentID;
            this.TaskID = TaskID;
            this.Comment = Comment;
        }
    }
}
