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
    public partial class TaskControl : UserControl
    {
        private readonly string connectionString;
        private readonly ToDoneApp.Models.Task task;
        private readonly Users user;
        public TaskControl(ToDoneApp.Models.Task task, string connectionString, Users user)
        {
            InitializeComponent();
            this.user = user;
            this.task = task;
            this.connectionString = connectionString;
            uxTitle.Text = task.Title;
            if(task.CompletedOn != null)
            {
                uxCompleted.Text = ($"Completed:{task.CompletedOn.ToString().Substring(0,19)}");
            }
        }

        private void uxComplete_Click(object sender, EventArgs e)
        {
            if(user.UserID == task.CreatedByID)
            {
                new SqlTaskRepository(connectionString).CompleteTask(task.TaskID, task.CreatedByID);
            }
            else
            {
                MessageBox.Show("You must be the creator of a task to mark it as complete");
            }
        }

        private void uxDelete_Click(object sender, EventArgs e)
        {
            if (user.UserID == task.CreatedByID)
            {
                new SqlTaskRepository(connectionString).DeleteTask(task.TaskID, task.CreatedByID);
            }
            else
            {
                MessageBox.Show("You must be the creator of a task to delete it");
            }
        }

        private void uxComment_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Parent.Controls)
            {
                if (c != this)
                {
                    this.Parent.Controls.Remove(c);
                }
            }
            this.Parent.Controls.Add(new TaskCommentControl(task, connectionString));
            this.Parent.Controls.Remove(this);
        }
    }
}
