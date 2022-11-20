namespace ToDoneApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uxLogOutButton = new System.Windows.Forms.Button();
            this.uxDisplayNameLabel = new System.Windows.Forms.Label();
            this.uxClock = new System.Windows.Forms.Label();
            this.uxMyTasksButton = new System.Windows.Forms.Button();
            this.uxSearchBox = new System.Windows.Forms.TextBox();
            this.uxSearchParam = new System.Windows.Forms.ComboBox();
            this.uxAddTask = new System.Windows.Forms.Button();
            this.uxAdminButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uxFriendsBox = new System.Windows.Forms.FlowLayoutPanel();
            this.Friends = new System.Windows.Forms.Label();
            this.uxGroupsBox = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSearch = new System.Windows.Forms.Button();
            this.uxMainBox = new System.Windows.Forms.FlowLayoutPanel();
            this.uxCreateGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLogOutButton
            // 
            this.uxLogOutButton.Location = new System.Drawing.Point(17, 1030);
            this.uxLogOutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxLogOutButton.Name = "uxLogOutButton";
            this.uxLogOutButton.Size = new System.Drawing.Size(107, 38);
            this.uxLogOutButton.TabIndex = 1;
            this.uxLogOutButton.Text = "Log Out";
            this.uxLogOutButton.UseVisualStyleBackColor = true;
            this.uxLogOutButton.Click += new System.EventHandler(this.uxLogOutButton_Click);
            // 
            // uxDisplayNameLabel
            // 
            this.uxDisplayNameLabel.AutoSize = true;
            this.uxDisplayNameLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxDisplayNameLabel.Location = new System.Drawing.Point(17, -5);
            this.uxDisplayNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxDisplayNameLabel.Name = "uxDisplayNameLabel";
            this.uxDisplayNameLabel.Size = new System.Drawing.Size(294, 60);
            this.uxDisplayNameLabel.TabIndex = 2;
            this.uxDisplayNameLabel.Text = "Display Name";
            // 
            // uxClock
            // 
            this.uxClock.Location = new System.Drawing.Point(1130, 22);
            this.uxClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxClock.Name = "uxClock";
            this.uxClock.Size = new System.Drawing.Size(200, 25);
            this.uxClock.TabIndex = 3;
            this.uxClock.Text = "Clock";
            this.uxClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uxMyTasksButton
            // 
            this.uxMyTasksButton.Location = new System.Drawing.Point(831, 13);
            this.uxMyTasksButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxMyTasksButton.Name = "uxMyTasksButton";
            this.uxMyTasksButton.Size = new System.Drawing.Size(107, 38);
            this.uxMyTasksButton.TabIndex = 6;
            this.uxMyTasksButton.Text = "Refresh";
            this.uxMyTasksButton.UseVisualStyleBackColor = true;
            this.uxMyTasksButton.Click += new System.EventHandler(this.uxMyTasksButton_Click);
            // 
            // uxSearchBox
            // 
            this.uxSearchBox.Location = new System.Drawing.Point(16, 75);
            this.uxSearchBox.Name = "uxSearchBox";
            this.uxSearchBox.Size = new System.Drawing.Size(523, 31);
            this.uxSearchBox.TabIndex = 9;
            // 
            // uxSearchParam
            // 
            this.uxSearchParam.FormattingEnabled = true;
            this.uxSearchParam.ItemHeight = 25;
            this.uxSearchParam.Location = new System.Drawing.Point(550, 75);
            this.uxSearchParam.Name = "uxSearchParam";
            this.uxSearchParam.Size = new System.Drawing.Size(273, 33);
            this.uxSearchParam.TabIndex = 10;
            // 
            // uxAddTask
            // 
            this.uxAddTask.Location = new System.Drawing.Point(573, 13);
            this.uxAddTask.Name = "uxAddTask";
            this.uxAddTask.Size = new System.Drawing.Size(111, 38);
            this.uxAddTask.TabIndex = 11;
            this.uxAddTask.Text = "Add Task";
            this.uxAddTask.UseVisualStyleBackColor = true;
            this.uxAddTask.Click += new System.EventHandler(this.uxAddTask_Click);
            // 
            // uxAdminButton
            // 
            this.uxAdminButton.Location = new System.Drawing.Point(947, 13);
            this.uxAdminButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxAdminButton.Name = "uxAdminButton";
            this.uxAdminButton.Size = new System.Drawing.Size(166, 38);
            this.uxAdminButton.TabIndex = 14;
            this.uxAdminButton.Text = "Admin Settings";
            this.uxAdminButton.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uxFriendsBox
            // 
            this.uxFriendsBox.Location = new System.Drawing.Point(947, 132);
            this.uxFriendsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxFriendsBox.Name = "uxFriendsBox";
            this.uxFriendsBox.Size = new System.Drawing.Size(384, 420);
            this.uxFriendsBox.TabIndex = 15;
            // 
            // Friends
            // 
            this.Friends.AutoSize = true;
            this.Friends.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Friends.Location = new System.Drawing.Point(947, 72);
            this.Friends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Friends.Name = "Friends";
            this.Friends.Size = new System.Drawing.Size(115, 30);
            this.Friends.TabIndex = 16;
            this.Friends.Text = "Friends:";
            // 
            // uxGroupsBox
            // 
            this.uxGroupsBox.Location = new System.Drawing.Point(947, 595);
            this.uxGroupsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxGroupsBox.Name = "uxGroupsBox";
            this.uxGroupsBox.Size = new System.Drawing.Size(384, 425);
            this.uxGroupsBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(946, 557);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Groups:";
            // 
            // uxSearch
            // 
            this.uxSearch.Location = new System.Drawing.Point(831, 75);
            this.uxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxSearch.Name = "uxSearch";
            this.uxSearch.Size = new System.Drawing.Size(107, 38);
            this.uxSearch.TabIndex = 19;
            this.uxSearch.Text = "Search";
            this.uxSearch.UseVisualStyleBackColor = true;
            this.uxSearch.Click += new System.EventHandler(this.uxSearch_Click);
            // 
            // uxMainBox
            // 
            this.uxMainBox.Location = new System.Drawing.Point(16, 132);
            this.uxMainBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxMainBox.Name = "uxMainBox";
            this.uxMainBox.Size = new System.Drawing.Size(921, 888);
            this.uxMainBox.TabIndex = 20;
            // 
            // uxCreateGroup
            // 
            this.uxCreateGroup.Location = new System.Drawing.Point(690, 13);
            this.uxCreateGroup.Name = "uxCreateGroup";
            this.uxCreateGroup.Size = new System.Drawing.Size(134, 38);
            this.uxCreateGroup.TabIndex = 21;
            this.uxCreateGroup.Text = "Create Group";
            this.uxCreateGroup.UseVisualStyleBackColor = true;
            this.uxCreateGroup.Click += new System.EventHandler(this.uxCreateGroup_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 1088);
            this.Controls.Add(this.uxCreateGroup);
            this.Controls.Add(this.uxMainBox);
            this.Controls.Add(this.uxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxGroupsBox);
            this.Controls.Add(this.Friends);
            this.Controls.Add(this.uxFriendsBox);
            this.Controls.Add(this.uxAdminButton);
            this.Controls.Add(this.uxAddTask);
            this.Controls.Add(this.uxSearchParam);
            this.Controls.Add(this.uxSearchBox);
            this.Controls.Add(this.uxMyTasksButton);
            this.Controls.Add(this.uxClock);
            this.Controls.Add(this.uxDisplayNameLabel);
            this.Controls.Add(this.uxLogOutButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "To Done ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uxLogOutButton;
        private System.Windows.Forms.Label uxDisplayNameLabel;
        private System.Windows.Forms.Label uxClock;
        private System.Windows.Forms.Button uxMyTasksButton;
        private System.Windows.Forms.TextBox uxSearchBox;
        private System.Windows.Forms.ComboBox uxSearchParam;
        private System.Windows.Forms.Button uxAddTask;
        private System.Windows.Forms.Button uxAdminButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel uxFriendsBox;
        private System.Windows.Forms.Label Friends;
        private System.Windows.Forms.FlowLayoutPanel uxGroupsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxSearch;
        private System.Windows.Forms.FlowLayoutPanel uxMainBox;
        private System.Windows.Forms.Button uxCreateGroup;
    }
}
