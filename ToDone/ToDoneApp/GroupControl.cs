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
    public partial class GroupControl : UserControl
    {
        public GroupControl(Groups g, string connectionString)
        {
            InitializeComponent();
            uxGroupName.Text = g.Title;
        }
    }
}
