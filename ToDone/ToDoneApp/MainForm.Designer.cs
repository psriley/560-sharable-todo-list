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
            this.uxFriendsBox = new System.Windows.Forms.GroupBox();
            this.uxGroupBox = new System.Windows.Forms.GroupBox();
            this.uxMyTasksButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uxAddTask = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.uxAdminButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // uxMainBox
            // 
            this.uxMainBox.Location = new System.Drawing.Point(17, 131);
            this.uxMainBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxMainBox.Name = "uxMainBox";
            this.uxMainBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxMainBox.Size = new System.Drawing.Size(921, 889);
            this.uxMainBox.TabIndex = 0;
            this.uxMainBox.TabStop = false;
            this.uxMainBox.Text = "Title";
            // 
            // uxLogOutButton
            // 
            this.uxLogOutButton.Location = new System.Drawing.Point(716, 14);
            this.uxLogOutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxLogOutButton.Name = "uxLogOutButton";
            this.uxLogOutButton.Size = new System.Drawing.Size(107, 38);
            this.uxLogOutButton.TabIndex = 1;
            this.uxLogOutButton.Text = "Log Out";
            this.uxLogOutButton.UseVisualStyleBackColor = true;
            // 
            // uxDisplayNameLabel
            // 
            this.uxDisplayNameLabel.AutoSize = true;
            this.uxDisplayNameLabel.Location = new System.Drawing.Point(17, 20);
            this.uxDisplayNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxDisplayNameLabel.Name = "uxDisplayNameLabel";
            this.uxDisplayNameLabel.Size = new System.Drawing.Size(122, 25);
            this.uxDisplayNameLabel.TabIndex = 2;
            this.uxDisplayNameLabel.Text = "Display Name";
            // 
            // uxClock
            // 
            this.uxClock.Location = new System.Drawing.Point(1130, 21);
            this.uxClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxClock.Name = "uxClock";
            this.uxClock.Size = new System.Drawing.Size(200, 25);
            this.uxClock.TabIndex = 3;
            this.uxClock.Text = "Clock";
            this.uxClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uxFriendsBox
            // 
            this.uxFriendsBox.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFriendsBox.Location = new System.Drawing.Point(947, 58);
            this.uxFriendsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxFriendsBox.Name = "uxFriendsBox";
            this.uxFriendsBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxFriendsBox.Size = new System.Drawing.Size(383, 451);
            this.uxFriendsBox.TabIndex = 4;
            this.uxFriendsBox.TabStop = false;
            this.uxFriendsBox.Text = "Friends";
            // 
            // uxGroupBox
            // 
            this.uxGroupBox.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxGroupBox.Location = new System.Drawing.Point(947, 577);
            this.uxGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxGroupBox.Name = "uxGroupBox";
            this.uxGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxGroupBox.Size = new System.Drawing.Size(383, 443);
            this.uxGroupBox.TabIndex = 5;
            this.uxGroupBox.TabStop = false;
            this.uxGroupBox.Text = "Groups";
            // 
            // uxMyTasksButton
            // 
            this.uxMyTasksButton.Location = new System.Drawing.Point(831, 14);
            this.uxMyTasksButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxMyTasksButton.Name = "uxMyTasksButton";
            this.uxMyTasksButton.Size = new System.Drawing.Size(107, 38);
            this.uxMyTasksButton.TabIndex = 6;
            this.uxMyTasksButton.Text = "My Tasks";
            this.uxMyTasksButton.UseVisualStyleBackColor = true;
            this.uxMyTasksButton.Click += new System.EventHandler(this.uxMyTasksButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(947, 1030);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add Group";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1165, 1030);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 38);
            this.button4.TabIndex = 8;
            this.button4.Text = "Remove Group";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(628, 31);
            this.textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 25;
            this.comboBox1.Location = new System.Drawing.Point(651, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 33);
            this.comboBox1.TabIndex = 10;
            // 
            // uxAddTask
            // 
            this.uxAddTask.Location = new System.Drawing.Point(17, 1028);
            this.uxAddTask.Name = "uxAddTask";
            this.uxAddTask.Size = new System.Drawing.Size(112, 34);
            this.uxAddTask.TabIndex = 11;
            this.uxAddTask.Text = "Add Task";
            this.uxAddTask.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(946, 519);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 38);
            this.button6.TabIndex = 12;
            this.button6.Text = "Add Friend";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1165, 519);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 38);
            this.button7.TabIndex = 13;
            this.button7.Text = "Remove Friend";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // uxAdminButton
            // 
            this.uxAdminButton.Location = new System.Drawing.Point(947, 14);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 1088);
            this.Controls.Add(this.uxAdminButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.uxAddTask);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.uxMyTasksButton);
            this.Controls.Add(this.uxGroupBox);
            this.Controls.Add(this.uxFriendsBox);
            this.Controls.Add(this.uxClock);
            this.Controls.Add(this.uxDisplayNameLabel);
            this.Controls.Add(this.uxLogOutButton);
            this.Controls.Add(this.uxMainBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox uxMainBox;
        private System.Windows.Forms.Button uxLogOutButton;
        private System.Windows.Forms.Label uxDisplayNameLabel;
        private System.Windows.Forms.Label uxClock;
        private System.Windows.Forms.GroupBox uxFriendsBox;
        private System.Windows.Forms.GroupBox uxGroupBox;
        private System.Windows.Forms.Button uxMyTasksButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button uxAddTask;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button uxAdminButton;
        private System.Windows.Forms.Timer timer1;
    }
}
