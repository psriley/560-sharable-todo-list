using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToDoneApp.Models;
using ToDoneApp.SQLRepos;

namespace ToDoneApp
{
    public partial class UserResultComponent : UserControl
    {
        private MainForm form;
        private Users user;
        private readonly Users friend;
        private readonly Users caller;
        private readonly string connectionString;
        public UserResultComponent(Users u, Users c, string connectionString)
        {
            this.friend = u;
            this.caller = c;
            this.connectionString = connectionString;
            InitializeComponent();
            uxDisplayName.Text = u.DisplayName;
        }

        private void uxAddFriend_Click(object sender, EventArgs e)
        {
            IReadOnlyList<Users> friends = new SqlUsersRepository(connectionString).FetchUsersFriends(caller.UserID);
            List<int> ids = new List<int>();
            foreach(Users u in friends)
            {
                ids.Add(u.UserID);
            }
            if (!(ids.Contains(friend.UserID)))
            {
                new SqlFriendsRepository(connectionString).AddFriend(caller.UserID, friend.UserID);
                this.Parent.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("You are already friends with this user!");
            }
        }

        private void uxPublicTasks_Click(object sender, EventArgs e)
        {
            form = (MainForm)this.Parent.Parent.Parent.Parent;
            form.MainBoxControls.Clear();
            user = form.user;
            IReadOnlyList<Task> tasks = new SqlTaskRepository(connectionString).FetchUserTasks(friend.UserID);
            foreach (Task task in tasks)
            {
                if (task.PrivacyLevel == 3)
                {
                    form.MainBoxControls.Add(new TaskControl(task, connectionString, user));
                }
            }
        }
    }
}
