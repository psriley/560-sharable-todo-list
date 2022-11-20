using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ToDoneApp.SQLRepos;

namespace ToDoneApp
{
    public partial class CreateGroupControl : UserControl
    {
        string connectionString;
        public CreateGroupControl(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
            uxTitle.MaxLength = 64;
            uxDescription.MaxLength = 1024;
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void uxCreateGroup_Click(object sender, EventArgs e)
        {
            new SqlGroupsRepository(connectionString).CreateGroup(uxTitle.Text, uxDescription.Text);
            ((MainForm)this.Parent.Parent).MainForm_Load(this, e);
        }
    }
}
