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
            this.uxGroupName.Location = new System.Drawing.Point(6, 7);
            this.uxGroupName.Name = "uxGroupName";
            this.uxGroupName.Size = new System.Drawing.Size(75, 15);
            this.uxGroupName.TabIndex = 0;
            this.uxGroupName.Text = "Group Name";
            // 
            // uxTasks
            // 
            this.uxTasks.Location = new System.Drawing.Point(106, 2);
            this.uxTasks.Name = "uxTasks";
            this.uxTasks.Size = new System.Drawing.Size(43, 23);
            this.uxTasks.TabIndex = 1;
            this.uxTasks.Text = "Tasks";
            this.uxTasks.UseVisualStyleBackColor = true;
            // 
            // uxMembers
            // 
            this.uxMembers.Location = new System.Drawing.Point(155, 2);
            this.uxMembers.Name = "uxMembers";
            this.uxMembers.Size = new System.Drawing.Size(67, 23);
            this.uxMembers.TabIndex = 2;
            this.uxMembers.Text = "Members";
            this.uxMembers.UseVisualStyleBackColor = true;
            // 
            // uxLeaveGroup
            // 
            this.uxLeaveGroup.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.uxLeaveGroup.Location = new System.Drawing.Point(228, 3);
            this.uxLeaveGroup.Name = "uxLeaveGroup";
            this.uxLeaveGroup.Size = new System.Drawing.Size(25, 23);
            this.uxLeaveGroup.TabIndex = 3;
            this.uxLeaveGroup.Text = "-";
            this.uxLeaveGroup.UseVisualStyleBackColor = false;
            // 
            // GroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxLeaveGroup);
            this.Controls.Add(this.uxMembers);
            this.Controls.Add(this.uxTasks);
            this.Controls.Add(this.uxGroupName);
            this.Name = "GroupControl";
            this.Size = new System.Drawing.Size(264, 28);
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
