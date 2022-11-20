using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ToDoneApp.Models;

namespace ToDoneApp
{
    public partial class FriendControl : UserControl
    {
        private MainForm form;
        private Users user;
        private readonly Users friend;
        private readonly string connectionString;
        public FriendControl(Users f, string connectionString)
        {
            this.friend = f;
            this.connectionString = connectionString;
            InitializeComponent();
            uxFriendName.Text = f.DisplayName;
        }

        private void uxRemoveFriend_Click(object sender, EventArgs e)
        {
            form = (MainForm)this.Parent.Parent;
            user = form.user;
            IReadOnlyList<Users> friends = new SqlUsersRepository(connectionString).FetchUsersFriends(user.UserID);
            List<int> ids = new List<int>();
            foreach (Users friend in friends)
            {
                ids.Add(friend.UserID);
            }
            if ((ids.Contains(friend.UserID)))
            {
                new SqlFriendsRepository(connectionString).RemoveFriend(user.UserID, friend.UserID);
                this.Parent.Parent.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("You can't remove a friend you aren't friends with!");
            }
        }

        private void FriendFriendsButtonUX_Click(object sender, EventArgs e)
        {
            form = (MainForm)this.Parent.Parent;
            form.MainBoxControls.Clear();
            user = form.user;
            IReadOnlyList<Users> users = new SqlUsersRepository(connectionString).FetchUsersFriends(friend.UserID);
            foreach (Users u in users)
            {
                if (u.UserID != user.UserID)
                {
                    form.MainBoxControls.Add(new UserResultComponent(u, user, connectionString));
                }
            }
        }
    }
}
