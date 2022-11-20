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
    public partial class GroupControl : UserControl
    {
        private MainForm form;
        private Users user;
        private readonly Groups group;
        private readonly string connectionString;
        public GroupControl(Groups g, string connectionString)
        {
            this.group = g;
            this.connectionString = connectionString;
            InitializeComponent();
            uxGroupName.Text = g.Title;
        }

        private void uxLeaveGroup_Click(object sender, EventArgs e)
        {
            form = (MainForm)this.Parent.Parent;
            user = form.user;
            IReadOnlyList<Groups> groups = new SqlUsersRepository(connectionString).FetchUsersGroups(user.UserID);
            List<int> ids = new List<int>();
            foreach (Groups group in groups)
            {
                ids.Add(group.GroupID);
            }
            if ((ids.Contains(group.GroupID)))
            {
                new SqlGroupUserRepository(connectionString).LeaveGroup(user.UserID, group.GroupID);
                this.Parent.Parent.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("You can't leave a group you aren't in!");
            }
        }

        private void uxMembers_Click(object sender, EventArgs e)
        {
            form = (MainForm)this.Parent.Parent;
            form.MainBoxControls.Clear();
            user = form.user;
            IReadOnlyList<Users> users = new SqlUsersRepository(connectionString).FetchGroupsUsers(group.GroupID);
            foreach (Users u in users)
            {
                if(u.UserID != user.UserID)
                {
                    form.MainBoxControls.Add(new UserResultComponent(u, user, connectionString));
                }
            }
        }
    }
}
