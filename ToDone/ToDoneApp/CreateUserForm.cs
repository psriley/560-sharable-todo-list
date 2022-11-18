using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccess;
using ToDoneApp.Models;
using System.Data.SqlClient;
using ToDoneApp.DataDelegates;
using System.Security.Cryptography;

namespace ToDoneApp
{
    public partial class CreateUserForm : Form
    {
        private readonly string connectionString;
        public CreateUserForm(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
            uxDisplayName.MaxLength = 32;
            uxPassword.MaxLength = 32;
            uxFirstName.MaxLength = 32;
            uxLastName.MaxLength = 32;
        }

        private void onBackClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onSignUpClick(object sender, EventArgs e)
        {
            string pTextPW = uxPassword.Text;
            byte[] newPassBytes;
            string newPass = "";
            using( SHA256 myHash = SHA256.Create())
            {
                newPassBytes = myHash.ComputeHash(Encoding.UTF8.GetBytes(pTextPW));
            }
            foreach(byte b in newPassBytes)
            {
                newPass += b;
            }
            new SqlUsersRepository(connectionString).CreateUser(uxDisplayName.Text, newPass, uxFirstName.Text, uxLastName.Text, false);
            this.Close();
        }

    }
}
