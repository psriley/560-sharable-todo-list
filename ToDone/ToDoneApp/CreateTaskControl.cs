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
    public partial class CreateTaskControl : UserControl
    {
        string connectionString;
        Users u;
        public CreateTaskControl(Users user, string connectionString)
        {
            this.connectionString = connectionString;
            this.u = user;
            InitializeComponent();
            uxDueDate.Visible = false;
            uxDueDateLabel.Visible = false;
            uxTitle.MaxLength = 64;
            uxDescription.MaxLength = 1024;
            uxPrivacy.Items.Add("Creator and Claimer");
            uxPrivacy.Items.Add("Creator, Claimer, and Friends");
            uxPrivacy.Items.Add("Creator, Claimer, Friends, and Groups");
            uxPrivacy.Items.Add("Public");
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void uxHasDue_Changed(object sender, EventArgs e)
        {
            uxDueDate.Visible = uxHasDueDate.Checked;
            uxDueDateLabel.Visible = uxHasDueDate.Checked;
        }

        private void uxMakeTask_Click(object sender, EventArgs e)
        {
            new SqlTaskRepository(connectionString).CreateTask(u.UserID, 0, uxTitle.Text, uxDescription.Text, uxDueDate.Value, uxPrivacy.SelectedIndex+1, uxClaimable.Checked);
            ((MainForm)this.Parent.Parent).MainForm_Load(this, e);
            this.Parent.Controls.Remove(this);
        }
    }
}
