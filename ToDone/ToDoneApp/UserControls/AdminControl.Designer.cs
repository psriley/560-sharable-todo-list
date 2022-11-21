namespace ToDoneApp
{
    partial class AdminControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxRunAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxPercentComplete = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxUserCompletedInput = new System.Windows.Forms.TextBox();
            this.uxUserCompletedOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.uxCompletionHour = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxAvgTasksDBWide = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uxAvgGroupInput = new System.Windows.Forms.TextBox();
            this.uxAvgGroup = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uxFriendsGroupInput = new System.Windows.Forms.TextBox();
            this.uxFriendsGroup = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uxFriends = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxRunAdmin
            // 
            this.uxRunAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uxRunAdmin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxRunAdmin.Location = new System.Drawing.Point(494, 449);
            this.uxRunAdmin.Name = "uxRunAdmin";
            this.uxRunAdmin.Size = new System.Drawing.Size(148, 81);
            this.uxRunAdmin.TabIndex = 1;
            this.uxRunAdmin.Text = "Run All";
            this.uxRunAdmin.UseVisualStyleBackColor = true;
            this.uxRunAdmin.Click += new System.EventHandler(this.uxRunAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Percent of tasks completed for all users:";
            // 
            // uxPercentComplete
            // 
            this.uxPercentComplete.AutoSize = true;
            this.uxPercentComplete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxPercentComplete.Location = new System.Drawing.Point(311, 90);
            this.uxPercentComplete.Name = "uxPercentComplete";
            this.uxPercentComplete.Size = new System.Drawing.Size(0, 21);
            this.uxPercentComplete.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Percent of tasks completed for user with ID =         :";
            // 
            // uxUserCompletedInput
            // 
            this.uxUserCompletedInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUserCompletedInput.Location = new System.Drawing.Point(338, 120);
            this.uxUserCompletedInput.Name = "uxUserCompletedInput";
            this.uxUserCompletedInput.Size = new System.Drawing.Size(32, 29);
            this.uxUserCompletedInput.TabIndex = 9;
            // 
            // uxUserCompletedOutput
            // 
            this.uxUserCompletedOutput.AutoSize = true;
            this.uxUserCompletedOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUserCompletedOutput.Location = new System.Drawing.Point(376, 128);
            this.uxUserCompletedOutput.Name = "uxUserCompletedOutput";
            this.uxUserCompletedOutput.Size = new System.Drawing.Size(67, 21);
            this.uxUserCompletedOutput.TabIndex = 10;
            this.uxUserCompletedOutput.Text = "No User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(265, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Admin Page";
            // 
            // uxBack
            // 
            this.uxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uxBack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxBack.Location = new System.Drawing.Point(3, 449);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(148, 81);
            this.uxBack.TabIndex = 12;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Most popular task completion hour:";
            // 
            // uxCompletionHour
            // 
            this.uxCompletionHour.AutoSize = true;
            this.uxCompletionHour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCompletionHour.Location = new System.Drawing.Point(285, 167);
            this.uxCompletionHour.Name = "uxCompletionHour";
            this.uxCompletionHour.Size = new System.Drawing.Size(0, 21);
            this.uxCompletionHour.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Average number of tasks completed for all users:";
            // 
            // uxAvgTasksDBWide
            // 
            this.uxAvgTasksDBWide.AutoSize = true;
            this.uxAvgTasksDBWide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAvgTasksDBWide.Location = new System.Drawing.Point(376, 206);
            this.uxAvgTasksDBWide.Name = "uxAvgTasksDBWide";
            this.uxAvgTasksDBWide.Size = new System.Drawing.Size(0, 21);
            this.uxAvgTasksDBWide.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(549, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Average number of tasks completed for all members of group with ID =          :";
            // 
            // uxAvgGroupInput
            // 
            this.uxAvgGroupInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAvgGroupInput.Location = new System.Drawing.Point(523, 237);
            this.uxAvgGroupInput.Name = "uxAvgGroupInput";
            this.uxAvgGroupInput.Size = new System.Drawing.Size(36, 29);
            this.uxAvgGroupInput.TabIndex = 18;
            // 
            // uxAvgGroup
            // 
            this.uxAvgGroup.AutoSize = true;
            this.uxAvgGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAvgGroup.Location = new System.Drawing.Point(565, 245);
            this.uxAvgGroup.Name = "uxAvgGroup";
            this.uxAvgGroup.Size = new System.Drawing.Size(79, 21);
            this.uxAvgGroup.TabIndex = 19;
            this.uxAvgGroup.Text = "No Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(22, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(485, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Average number of friends for all members of group with ID =          :";
            // 
            // uxFriendsGroupInput
            // 
            this.uxFriendsGroupInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFriendsGroupInput.Location = new System.Drawing.Point(459, 326);
            this.uxFriendsGroupInput.Name = "uxFriendsGroupInput";
            this.uxFriendsGroupInput.Size = new System.Drawing.Size(36, 29);
            this.uxFriendsGroupInput.TabIndex = 21;
            // 
            // uxFriendsGroup
            // 
            this.uxFriendsGroup.AutoSize = true;
            this.uxFriendsGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFriendsGroup.Location = new System.Drawing.Point(501, 334);
            this.uxFriendsGroup.Name = "uxFriendsGroup";
            this.uxFriendsGroup.Size = new System.Drawing.Size(79, 21);
            this.uxFriendsGroup.TabIndex = 22;
            this.uxFriendsGroup.Text = "No Group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(22, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Average number of friends for all users:";
            // 
            // uxFriends
            // 
            this.uxFriends.AutoSize = true;
            this.uxFriends.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFriends.Location = new System.Drawing.Point(306, 289);
            this.uxFriends.Name = "uxFriends";
            this.uxFriends.Size = new System.Drawing.Size(0, 21);
            this.uxFriends.TabIndex = 24;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxFriends);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uxFriendsGroup);
            this.Controls.Add(this.uxFriendsGroupInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uxAvgGroup);
            this.Controls.Add(this.uxAvgGroupInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uxAvgTasksDBWide);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxCompletionHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxUserCompletedOutput);
            this.Controls.Add(this.uxUserCompletedInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxPercentComplete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxRunAdmin);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(645, 533);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxRunAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxPercentComplete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxUserCompletedInput;
        private System.Windows.Forms.Label uxUserCompletedOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label uxCompletionHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label uxAvgTasksDBWide;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uxAvgGroupInput;
        private System.Windows.Forms.Label uxAvgGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uxFriendsGroupInput;
        private System.Windows.Forms.Label uxFriendsGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label uxFriends;
    }
}
