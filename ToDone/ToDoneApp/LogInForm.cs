using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToDoneApp
{
    public partial class LogInForm : Form
    {
        private readonly string connectionString;
        public LogInForm(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
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

        }
    }
}
