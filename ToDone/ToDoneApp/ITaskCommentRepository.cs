using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoneApp
{
    public interface ITaskCommentRepository
    {
        bool CreateTaskComment(int TaskID, string Comment);
    }
}
