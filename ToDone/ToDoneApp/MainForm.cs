using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoneApp.Models;

namespace ToDoneApp
{
    public partial class MainForm : Form
    {
        private readonly string connectionString;
        private readonly Users user;
        public MainForm(string connectionString, Users user)
        {
            this.connectionString = connectionString;
            this.user = user;
            InitializeComponent();
            LoadFormLabels();
            ShowAdminButton();
        }

        public bool isAdmin { get; set; } = false;
        public string displayName { get; set; }

        private void LoadFormLabels()
        {
            uxDisplayNameLabel.Text = user.DisplayName;
        }

        private void ShowAdminButton()
        {
            // if isAdmin is true, button is not visible
            uxAdminButton.Visible = isAdmin ? true : false;
        }

        private void uxMyTasksButton_Click(object sender, EventArgs e)
        {
            uxMainBox.Text = uxMyTasksButton.Text;
            // Display all of the users tasks in main box
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            uxClock.Text = datetime.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            IReadOnlyList<Users> friends = new SqlUsersRepository(connectionString).FetchUsersFriends(user.UserID);
            foreach(Users u in friends)
            {
                uxFriendsBox.Controls.Add(new FriendControl(u));
            }
        }

        private void uxAddTask_Click(object sender, EventArgs e)
        {
            CreateTaskControl cTask = new CreateTaskControl();
            uxMainBox.Controls.Add(cTask);
        }

        private void uxLogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
