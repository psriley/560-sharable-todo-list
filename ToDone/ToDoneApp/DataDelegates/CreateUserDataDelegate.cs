using System;
using DataAccess;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ToDoneApp.Models;
using System.Data.SqlClient;

namespace ToDoneApp.DataDelegates
{
    internal class CreateUserDataDelegate : NonQueryDataDelegate<Users>
    {
        public readonly string displayName;
        public readonly string passwordHash;
        public readonly string firstName;
        public readonly string lastName;
        public readonly bool isAdmin;

        public CreateUserDataDelegate(string displayName, string passwordHash, string firstName, string lastName, bool isAdmin)
            : base("ToDone.CreateUser")
        {
            this.displayName = displayName;
            this.passwordHash = passwordHash;
            this.firstName = firstName;
            this.lastName = lastName;
            this.isAdmin = isAdmin;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("DisplayName", displayName);
            command.Parameters.AddWithValue("PasswordHash", passwordHash);
            command.Parameters.AddWithValue("FirstName", firstName);
            command.Parameters.AddWithValue("LastName", lastName);
            command.Parameters.AddWithValue("IsAdmin", isAdmin);

            var p = command.Parameters.Add("UserID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Users Translate(SqlCommand command)
        {
            return new Users((int)command.Parameters["UserID"].Value, displayName, passwordHash, firstName, lastName, isAdmin);
        }
    }
}
