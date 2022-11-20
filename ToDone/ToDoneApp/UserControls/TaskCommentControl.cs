using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ToDoneApp.SQLRepos;

namespace ToDoneApp
{
    public partial class TaskCommentControl : UserControl
    {
        private readonly ToDoneApp.Models.Task task;
        private readonly string connectionString;
        public TaskCommentControl(ToDoneApp.Models.Task task, string connectionString)
        {
            this.connectionString = connectionString;
            this.task = task;
            InitializeComponent();
            uxTitle.Text = task.Title;
            uxDescription.Text = task.Description;
        }

        private void uxPostComment_Click(object sender, EventArgs e)
        {
            new SqlTaskCommentRepository(connectionString).CreateTaskComment(task.TaskID, uxComment.Text);
            this.Parent.Controls.Remove(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
