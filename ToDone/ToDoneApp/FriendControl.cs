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
        public FriendControl(Users u, string connectionString)
        {
            InitializeComponent();
            uxFriendName.Text = u.DisplayName;
        }
    }
}
