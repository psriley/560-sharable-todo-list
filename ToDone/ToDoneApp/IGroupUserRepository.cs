using System;
using DataAccess;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ToDoneApp.Models;
using System.Data.SqlClient;

namespace ToDoneApp
{
    public interface IGroupUserRepository
    {
        int JoinGroup(int UserID, int GroupID);

        int LeaveGroup(int UserID, int GroupID);
    }
}
