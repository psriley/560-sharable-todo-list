using System;
using System.Collections.Generic;
using System.Text;
using ToDoneApp.Models;

namespace ToDoneApp
{
    public interface IUsersRepository
    {
        Users CreateUser(string DisplayName, string Password, string FirstName, string LastName, bool IsAdmin);

        Users GetUser(string DisplayName);        

        IReadOnlyList<Users> FetchUsersFriends(string DisplayName);

        IReadOnlyList<Users> FetchGroupsUsers(string DisplayName);

    }
}
