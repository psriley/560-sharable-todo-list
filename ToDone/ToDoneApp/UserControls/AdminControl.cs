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
    public partial class AdminControl : UserControl
    {
        private readonly string connectionString;
        public AdminControl(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void uxBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Clear();
        }

        private void uxRunAdmin_Click(object sender, EventArgs e)
        {
            double percCompleted = new SqlAdminRepository(connectionString).PercentCompleted();
            if(percCompleted != 0)
            {
                uxPercentComplete.Text = $"{Math.Round(percCompleted, 0).ToString()}%";
            }
            else{ uxPercentComplete.Text = "ERROR!"; }
            int UserID = 0;
            if(uxUserCompletedInput.Text != "") UserID = Convert.ToInt32(uxUserCompletedInput.Text);
            if(UserID > 0)
            {
                uxUserCompletedOutput.Text = $"{(new SqlAdminRepository(connectionString).PercentCompletedUser(UserID)).ToString()}%";
            }

            List<int> results = new SqlAdminRepository(connectionString).PopularHour();
            if (results[0] >= 0 && results[1] >= 0)
            {
                uxCompletionHour.Text = $"Hour:{results[0]} Number of Tasks: {results[1]}";
            }

            double tasksCompleted = new SqlAdminRepository(connectionString).AvgTasksCompleted();
            if(tasksCompleted >= 0)
            {
                uxAvgTasksDBWide.Text = $"{tasksCompleted}";
            }

            int GroupID = 0;
            if (uxAvgGroupInput.Text != "") GroupID = Convert.ToInt32(uxAvgGroupInput.Text);
            if(GroupID > 0)
            {
                uxAvgGroup.Text = $"{new SqlAdminRepository(connectionString).AvgTasksCompletedGroup(GroupID)}";
            }

            uxFriends.Text = $"{new SqlAdminRepository(connectionString).AvgFriends()}";

            GroupID = 0;
            if (uxFriendsGroupInput.Text != "") GroupID = Convert.ToInt32(uxFriendsGroupInput.Text);
            if(GroupID > 0)
            {
                uxFriendsGroup.Text = $"{new SqlAdminRepository(connectionString).AvgFriendsGroup(GroupID)}";
            }
        }
    }
}
