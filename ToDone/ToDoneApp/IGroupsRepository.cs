using System;
using System.Collections.Generic;
using System.Text;
using ToDoneApp.Models;

namespace ToDoneApp
{
    public interface IGroupsRepository
    {
        Groups CreateGroup(string Title, string Description);

        IReadOnlyList<Groups> FetchGroups();

        Groups GetGroup(int GroupID);
    }
}
