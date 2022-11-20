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
using ToDoneApp.SQLRepos;

namespace ToDoneApp
{
    public partial class MainForm : Form
    {
        private readonly string connectionString;
        public readonly Users user;
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
            timer1.Start();
            uxDisplayNameLabel.Text = user.DisplayName;
            uxSearchParam.Items.Add("User");
            uxSearchParam.Items.Add("Task");
            uxSearchParam.Items.Add("Group");
        }

        private void ShowAdminButton()
        {
            // if isAdmin is true, button is not visible
            uxAdminButton.Visible = user.IsAdmin ? true : false;
        }

        private void uxMyTasksButton_Click(object sender, EventArgs e)
        {
            uxMainBox.Text = uxMyTasksButton.Text;
            MainForm_Load(this, e);
            uxSearchBox.Text = "";
            uxSearchParam.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            uxClock.Text = datetime.ToString();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            uxFriendsBox.Controls.Clear();
            uxGroupsBox.Controls.Clear();
            uxMainBox.Controls.Clear();
            IReadOnlyList<Users> friends = new SqlUsersRepository(connectionString).FetchUsersFriends(user.UserID);
            foreach(Users u in friends)
            {
                uxFriendsBox.Controls.Add(new FriendControl(u, connectionString));
            }
            IReadOnlyList<Groups> groups = new SqlUsersRepository(connectionString).FetchUsersGroups(user.UserID);
            foreach(Groups g in groups)
            {
                uxGroupsBox.Controls.Add(new GroupControl(g, connectionString));
            }
            IReadOnlyList<ToDoneApp.Models.Task> tasks = new SqlTaskRepository(connectionString).FetchUserTasks(user.UserID);
            foreach(ToDoneApp.Models.Task t in tasks)
            {
                uxMainBox.Controls.Add(new TaskControl(t, connectionString, user));
            }
        }

        private void uxAddTask_Click(object sender, EventArgs e)
        {
            uxMainBox.Controls.Clear();
            CreateTaskControl cTask = new CreateTaskControl(user, connectionString);
            uxMainBox.Controls.Add(cTask);
        }

        private void uxLogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxSearch_Click(object sender, EventArgs e)
        {
            uxMainBox.Controls.Clear();
            switch (uxSearchParam.Text)
            {
                case "User":
                    try
                    {
                        IReadOnlyList<Users> users = new SqlUsersRepository(connectionString).FetchUsers();
                        List<Users> results = new List<Users>();
                        foreach(Users u in users)
                        {
                            if (u.DisplayName.ToLower().Contains(uxSearchBox.Text.ToLower()))
                            {
                                if(u.UserID != user.UserID)
                                {
                                    results.Add(u);
                                }
                            }
                        }
                        uxMainBox.Controls.Add(new UserSearchResults(results, user, connectionString));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("User not found! Please check spelling.");
                    }
                    break;
                case "Group":
                    try
                    {
                        IReadOnlyList<Groups> groups = new SqlGroupsRepository(connectionString).FetchGroups();
                        List<Groups> results = new List<Groups>();
                        foreach(Groups g in groups)
                        {
                            if (g.Title.ToLower().Contains(uxSearchBox.Text.ToLower()))
                            {
                                results.Add(g);
                            }
                        }
                        uxMainBox.Controls.Add(new GroupSearchResults(results, user, connectionString));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Group not found! Please check spelling.");
                    }
                    break;
                case "Task":
                    try
                    {
                        IReadOnlyList<Models.Task> tasks = new SqlTaskRepository(connectionString).FetchTasks();
                        List<Models.Task> results = new List<Models.Task>();
                        foreach (Models.Task task in tasks)
                        {
                            if (task.Title.ToLower().Contains(uxSearchBox.Text.ToLower()))
                            {
                                results.Add(task);
                            }
                        }
                        uxMainBox.Controls.Add(new TaskSearchResults(results, user, connectionString));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Task not found! Please check spelling.");
                    }
                    break;
                default:
                    MessageBox.Show("Please Select a Search Parameter!");
                    break;
            }
        }

        private void uxCreateGroup_Click(object sender, EventArgs e)
        {
            uxMainBox.Controls.Clear();
            CreateGroupControl cGroup = new CreateGroupControl(connectionString);
            uxMainBox.Controls.Add(cGroup);
        }

        public Control.ControlCollection MainBoxControls
        {
            get { return uxMainBox.Controls; }
        }

        private void uxAdminButton_Click(object sender, EventArgs e)
        {
            uxMainBox.Controls.Clear();
            uxMainBox.Controls.Add(new AdminControl());
        }
    }
}
