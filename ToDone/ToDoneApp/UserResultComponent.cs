using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToDoneApp.Models;

namespace ToDoneApp
{
    public partial class UserResultComponent : UserControl
    {
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
                var x = (this.Parent.Parent.Parent.Parent).Name;
                this.Parent.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("You are already frields with this user!");
            }
        }
    }
}
