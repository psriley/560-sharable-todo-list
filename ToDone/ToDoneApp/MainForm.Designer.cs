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
            this.uxMainBox = new System.Windows.Forms.GroupBox();
            this.uxLogOutButton = new System.Windows.Forms.Button();
            this.uxDisplayNameLabel = new System.Windows.Forms.Label();
            this.uxClock = new System.Windows.Forms.Label();
            this.uxMyTasksButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uxAddTask = new System.Windows.Forms.Button();
            this.uxAdminButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uxFriendsBox = new System.Windows.Forms.FlowLayoutPanel();
            this.Friends = new System.Windows.Forms.Label();
            this.uxGroupsBox = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxMainBox
            // 
            this.uxMainBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uxMainBox.Location = new System.Drawing.Point(12, 79);
            this.uxMainBox.Name = "uxMainBox";
            this.uxMainBox.Size = new System.Drawing.Size(645, 533);
            this.uxMainBox.TabIndex = 0;
            this.uxMainBox.TabStop = false;
            // 
            // uxLogOutButton
            // 
            this.uxLogOutButton.Location = new System.Drawing.Point(501, 8);
            this.uxLogOutButton.Name = "uxLogOutButton";
            this.uxLogOutButton.Size = new System.Drawing.Size(75, 23);
            this.uxLogOutButton.TabIndex = 1;
            this.uxLogOutButton.Text = "Log Out";
            this.uxLogOutButton.UseVisualStyleBackColor = true;
            this.uxLogOutButton.Click += new System.EventHandler(this.uxLogOutButton_Click);
            // 
            // uxDisplayNameLabel
            // 
            this.uxDisplayNameLabel.AutoSize = true;
            this.uxDisplayNameLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxDisplayNameLabel.Location = new System.Drawing.Point(12, -3);
            this.uxDisplayNameLabel.Name = "uxDisplayNameLabel";
            this.uxDisplayNameLabel.Size = new System.Drawing.Size(201, 41);
            this.uxDisplayNameLabel.TabIndex = 2;
            this.uxDisplayNameLabel.Text = "Display Name";
            // 
            // uxClock
            // 
            this.uxClock.Location = new System.Drawing.Point(791, 13);
            this.uxClock.Name = "uxClock";
            this.uxClock.Size = new System.Drawing.Size(140, 15);
            this.uxClock.TabIndex = 3;
            this.uxClock.Text = "Clock";
            this.uxClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uxMyTasksButton
            // 
            this.uxMyTasksButton.Location = new System.Drawing.Point(582, 8);
            this.uxMyTasksButton.Name = "uxMyTasksButton";
            this.uxMyTasksButton.Size = new System.Drawing.Size(75, 23);
            this.uxMyTasksButton.TabIndex = 6;
            this.uxMyTasksButton.Text = "Home";
            this.uxMyTasksButton.UseVisualStyleBackColor = true;
            this.uxMyTasksButton.Click += new System.EventHandler(this.uxMyTasksButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(441, 23);
            this.textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 15;
            this.comboBox1.Location = new System.Drawing.Point(456, 40);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // uxAddTask
            // 
            this.uxAddTask.Location = new System.Drawing.Point(11, 621);
            this.uxAddTask.Margin = new System.Windows.Forms.Padding(2);
            this.uxAddTask.Name = "uxAddTask";
            this.uxAddTask.Size = new System.Drawing.Size(78, 20);
            this.uxAddTask.TabIndex = 11;
            this.uxAddTask.Text = "Add Task";
            this.uxAddTask.UseVisualStyleBackColor = true;
            this.uxAddTask.Click += new System.EventHandler(this.uxAddTask_Click);
            // 
            // uxAdminButton
            // 
            this.uxAdminButton.Location = new System.Drawing.Point(663, 8);
            this.uxAdminButton.Name = "uxAdminButton";
            this.uxAdminButton.Size = new System.Drawing.Size(116, 23);
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
            this.uxFriendsBox.Location = new System.Drawing.Point(663, 79);
            this.uxFriendsBox.Name = "uxFriendsBox";
            this.uxFriendsBox.Size = new System.Drawing.Size(269, 252);
            this.uxFriendsBox.TabIndex = 15;
            // 
            // Friends
            // 
            this.Friends.AutoSize = true;
            this.Friends.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Friends.Location = new System.Drawing.Point(663, 43);
            this.Friends.Name = "Friends";
            this.Friends.Size = new System.Drawing.Size(81, 20);
            this.Friends.TabIndex = 16;
            this.Friends.Text = "Friends:";
            // 
            // uxGroupsBox
            // 
            this.uxGroupsBox.Location = new System.Drawing.Point(663, 357);
            this.uxGroupsBox.Name = "uxGroupsBox";
            this.uxGroupsBox.Size = new System.Drawing.Size(269, 255);
            this.uxGroupsBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(662, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Groups:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxGroupsBox);
            this.Controls.Add(this.Friends);
            this.Controls.Add(this.uxFriendsBox);
            this.Controls.Add(this.uxAdminButton);
            this.Controls.Add(this.uxAddTask);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uxMyTasksButton);
            this.Controls.Add(this.uxClock);
            this.Controls.Add(this.uxDisplayNameLabel);
            this.Controls.Add(this.uxLogOutButton);
            this.Controls.Add(this.uxMainBox);
            this.Name = "MainForm";
            this.Text = "To Done ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox uxMainBox;
        private System.Windows.Forms.Button uxLogOutButton;
        private System.Windows.Forms.Label uxDisplayNameLabel;
        private System.Windows.Forms.Label uxClock;
        private System.Windows.Forms.Button uxMyTasksButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button uxAddTask;
        private System.Windows.Forms.Button uxAdminButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel uxFriendsBox;
        private System.Windows.Forms.Label Friends;
        private System.Windows.Forms.FlowLayoutPanel uxGroupsBox;
        private System.Windows.Forms.Label label1;
    }
}
