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
    public partial class GroupSearchResults : UserControl
    {
        public GroupSearchResults(IReadOnlyList<Groups> groups, Users user, string connectionString)
        {
            InitializeComponent();
            foreach(Groups group in groups)
            {
                uxResultsBox.Controls.Add(new GroupResultsComponent(group, user, connectionString));
            }
        }
    }
}
