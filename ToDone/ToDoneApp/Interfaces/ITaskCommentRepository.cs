using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoneApp.Interfaces
{
    public interface ITaskCommentRepository
    {
        bool CreateTaskComment(int TaskID, string Comment);
    }
}
