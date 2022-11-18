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
    public partial class LogInForm : Form
    {
        private readonly string connectionString;
        public LogInForm(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
            uxDisplayName.MaxLength = 32;
            uxPassword.MaxLength = 32;
        }

        private void onSignUpClick(object sender, EventArgs e)
        {
            CreateUserForm c = new CreateUserForm(connectionString);
            this.Hide();
            c.ShowDialog();
            this.Show();
        }

        private void onLogInClick(object sender, EventArgs e)
        {
            string pTextPW = uxPassword.Text;
            byte[] newPassBytes;
            string newPass = "";
            using (SHA256 myHash = SHA256.Create())
            {
                newPassBytes = myHash.ComputeHash(Encoding.UTF8.GetBytes(pTextPW));
            }
            foreach (byte b in newPassBytes)
            {
                newPass += b;
            }
            Users user = new SqlUsersRepository(connectionString).GetUser(uxDisplayName.Text);
            if(user != null)
            {
                if (user.PasswordHash == newPass.Substring(0,32))
                {
                    MainForm main = new MainForm(connectionString, user);
                    this.Hide();
                    main.ShowDialog();
                    uxDisplayName.Text = "";
                    uxPassword.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Display Name or Password Incorrect");
                }
            }
            else
            {
                MessageBox.Show("Display Name or Password Incorrect");
            }
        }
    }
}
