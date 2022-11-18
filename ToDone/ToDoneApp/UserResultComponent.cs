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
        public UserResultComponent(Users u, Users c, string connectionString)
        {
            InitializeComponent();
            uxDisplayName.Text = u.DisplayName;
        }

        private void uxAddFriend_Click(object sender, EventArgs e)
        {

        }
    }
}
