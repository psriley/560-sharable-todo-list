using System;
using System.Collections.Generic;
using System.Text;
using ToDoneApp.Models;

namespace ToDoneApp.Interfaces
{
    public interface ITaskCommentRepository
    {
        bool CreateTaskComment(int TaskID, string Comment);

        List<TaskComment> FetchTaskComments(int TaskID);
    }
}
