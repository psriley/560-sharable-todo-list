using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToDoneApp
{
    public partial class TaskSearchResults : UserControl
    {
        public TaskSearchResults(IReadOnlyList<Models.Task> tasks, Models.Users user, string connectionString)
        {
            InitializeComponent();
            foreach(Models.Task task in tasks)
            {
                uxBox.Controls.Add(new TaskControl(task, connectionString, user));
            }
        }
    }
}
