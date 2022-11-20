using System;
using System.Collections.Generic;
using System.Text;
using ToDoneApp.Models;

namespace ToDoneApp.Interfaces
{
    public interface IUsersRepository
    {
        Users CreateUser(string DisplayName, string Password, string FirstName, string LastName, bool IsAdmin);

        Users GetUser(string DisplayName);

        IReadOnlyList<Users> FetchUsersFriends(int UserID);

        IReadOnlyList<Users> FetchGroupsUsers(int GroupID);

        IReadOnlyList<Groups> FetchUsersGroups(int UserID);

        IReadOnlyList<Users> FetchUsers();

    }
}
