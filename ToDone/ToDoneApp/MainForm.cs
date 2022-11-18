using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoneApp
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            LoadFormLabels();
            ShowAdminButton();
        }

        public bool isAdmin { get; set; } = false;
        public string displayName { get; set; } = "Christian";

        private void LoadFormLabels()
        {
            uxDisplayNameLabel.Text = displayName;
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
        }
    }
}
