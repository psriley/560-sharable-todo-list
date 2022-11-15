using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoneApp.Models
{
    public class Users
    {
        public int UserID { get; }
        public string DisplayName { get; }
        public string PasswordHash { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public bool IsAdmin { get; }


        public Users(int userID, string displayName, string passwordHash, string firstName, string lastName, bool isAdmin)
        {
            UserID = userID;
            DisplayName = displayName;
            PasswordHash = passwordHash;
            FirstName = firstName;
            LastName = lastName;
            IsAdmin = isAdmin;
        }
    }
}
