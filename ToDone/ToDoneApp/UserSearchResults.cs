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
    public partial class UserSearchResults : UserControl
    {
        public UserSearchResults(IReadOnlyList<Users> users, Users u, string connectionString)
        {
            InitializeComponent();
            foreach(Users user in users)
            {
                uxResultsBox.Controls.Add(new UserResultComponent(user, u, connectionString));
            }
        }
    }
}
