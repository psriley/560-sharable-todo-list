namespace ToDoneApp
{
    partial class UserResultComponent
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
            this.uxDisplayName = new System.Windows.Forms.Label();
            this.uxAddFriend = new System.Windows.Forms.Button();
            this.uxPublicTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxDisplayName
            // 
            this.uxDisplayName.AutoSize = true;
            this.uxDisplayName.Location = new System.Drawing.Point(4, 12);
            this.uxDisplayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxDisplayName.Name = "uxDisplayName";
            this.uxDisplayName.Size = new System.Drawing.Size(122, 25);
            this.uxDisplayName.TabIndex = 0;
            this.uxDisplayName.Text = "Display Name";
            // 
            // uxAddFriend
            // 
            this.uxAddFriend.Location = new System.Drawing.Point(550, 5);
            this.uxAddFriend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxAddFriend.Name = "uxAddFriend";
            this.uxAddFriend.Size = new System.Drawing.Size(359, 38);
            this.uxAddFriend.TabIndex = 1;
            this.uxAddFriend.Text = "Add Friend";
            this.uxAddFriend.UseVisualStyleBackColor = true;
            this.uxAddFriend.Click += new System.EventHandler(this.uxAddFriend_Click);
            // 
            // uxPublicTasks
            // 
            this.uxPublicTasks.Location = new System.Drawing.Point(183, 5);
            this.uxPublicTasks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxPublicTasks.Name = "uxPublicTasks";
            this.uxPublicTasks.Size = new System.Drawing.Size(359, 38);
            this.uxPublicTasks.TabIndex = 2;
            this.uxPublicTasks.Text = "View Public Tasks";
            this.uxPublicTasks.UseVisualStyleBackColor = true;
            this.uxPublicTasks.Click += new System.EventHandler(this.uxPublicTasks_Click);
            // 
            // UserResultComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxPublicTasks);
            this.Controls.Add(this.uxAddFriend);
            this.Controls.Add(this.uxDisplayName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserResultComponent";
            this.Size = new System.Drawing.Size(913, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxDisplayName;
        private System.Windows.Forms.Button uxAddFriend;
        private System.Windows.Forms.Button uxPublicTasks;
    }
}
