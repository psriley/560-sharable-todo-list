using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ToDoneApp.Models;
using ToDoneApp.SQLRepos;

namespace ToDoneApp
{
    public partial class GroupResultsComponent : UserControl
    {
        private readonly Groups g;
        private readonly Users u;
        private readonly string connectionString;
        public GroupResultsComponent(Groups group, Users user, string connectionString)
        {
            this.g = group;
            this.u = user;
            this.connectionString = connectionString;
            InitializeComponent();
            uxDisplay.Text = group.Title;
            uxDescription.Text = group.Description;
        }

        private void uxJoinGroup_Click(object sender, EventArgs e)
        {
            IReadOnlyList<Groups> groups = new SqlUsersRepository(connectionString).FetchUsersGroups(u.UserID);
            List<int> ids = new List<int>();
            foreach (Groups group in groups)
            {
                ids.Add(group.GroupID);
            }
            if (!(ids.Contains(g.GroupID)))
            {
                new SqlGroupUserRepository(connectionString).JoinGroup(u.UserID, g.GroupID);
                var x = (this.Parent.Parent.Parent.Parent).Name;
                this.Parent.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("You are already in this group!");
            }
        }
    }
}
