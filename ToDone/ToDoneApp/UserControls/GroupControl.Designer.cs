namespace ToDoneApp
{
    partial class GroupControl
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
            this.uxGroupName = new System.Windows.Forms.Label();
            this.uxTasks = new System.Windows.Forms.Button();
            this.uxMembers = new System.Windows.Forms.Button();
            this.uxLeaveGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxGroupName
            // 
            this.uxGroupName.AutoSize = true;
            this.uxGroupName.Location = new System.Drawing.Point(9, 12);
            this.uxGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxGroupName.Name = "uxGroupName";
            this.uxGroupName.Size = new System.Drawing.Size(114, 25);
            this.uxGroupName.TabIndex = 0;
            this.uxGroupName.Text = "Group Name";
            // 
            // uxTasks
            // 
            this.uxTasks.Location = new System.Drawing.Point(151, 3);
            this.uxTasks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxTasks.Name = "uxTasks";
            this.uxTasks.Size = new System.Drawing.Size(61, 38);
            this.uxTasks.TabIndex = 1;
            this.uxTasks.Text = "Tasks";
            this.uxTasks.UseVisualStyleBackColor = true;
            this.uxTasks.Click += new System.EventHandler(this.uxTasks_Click);
            // 
            // uxMembers
            // 
            this.uxMembers.Location = new System.Drawing.Point(221, 3);
            this.uxMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxMembers.Name = "uxMembers";
            this.uxMembers.Size = new System.Drawing.Size(96, 38);
            this.uxMembers.TabIndex = 2;
            this.uxMembers.Text = "Members";
            this.uxMembers.UseVisualStyleBackColor = true;
            this.uxMembers.Click += new System.EventHandler(this.uxMembers_Click);
            // 
            // uxLeaveGroup
            // 
            this.uxLeaveGroup.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.uxLeaveGroup.Location = new System.Drawing.Point(326, 5);
            this.uxLeaveGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxLeaveGroup.Name = "uxLeaveGroup";
            this.uxLeaveGroup.Size = new System.Drawing.Size(36, 38);
            this.uxLeaveGroup.TabIndex = 3;
            this.uxLeaveGroup.Text = "-";
            this.uxLeaveGroup.UseVisualStyleBackColor = false;
            this.uxLeaveGroup.Click += new System.EventHandler(this.uxLeaveGroup_Click);
            // 
            // GroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxLeaveGroup);
            this.Controls.Add(this.uxMembers);
            this.Controls.Add(this.uxTasks);
            this.Controls.Add(this.uxGroupName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GroupControl";
            this.Size = new System.Drawing.Size(377, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxGroupName;
        private System.Windows.Forms.Button uxTasks;
        private System.Windows.Forms.Button uxMembers;
        private System.Windows.Forms.Button uxLeaveGroup;
    }
}
