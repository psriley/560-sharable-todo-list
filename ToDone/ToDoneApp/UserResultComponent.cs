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
            new SqlFriendsRepository(connectionString).AddFriend(caller.UserID, friend.UserID);
            ((MainForm)this.Parent).MainForm_Load(this, e);
            this.Parent.Controls.Remove(this);
        }
    }
}
