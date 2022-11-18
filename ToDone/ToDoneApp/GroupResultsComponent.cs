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
    public partial class GroupResultsComponent : UserControl
    {
        public GroupResultsComponent(Groups g, Users user, string connectionString)
        {
            InitializeComponent();
            uxDisplay.Text = g.Title;
        }
    }
}
