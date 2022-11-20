namespace ToDoneApp
{
    partial class FriendControl
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
            this.uxFriendName = new System.Windows.Forms.Label();
            this.FriendTaskButtonUX = new System.Windows.Forms.Button();
            this.FriendFriendsButtonUX = new System.Windows.Forms.Button();
            this.uxRemoveFriend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxFriendName
            // 
            this.uxFriendName.AutoSize = true;
            this.uxFriendName.Location = new System.Drawing.Point(0, 10);
            this.uxFriendName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxFriendName.Name = "uxFriendName";
            this.uxFriendName.Size = new System.Drawing.Size(184, 25);
            this.uxFriendName.TabIndex = 0;
            this.uxFriendName.Text = "Friends Display Name";
            // 
            // FriendTaskButtonUX
            // 
            this.FriendTaskButtonUX.Location = new System.Drawing.Point(169, 3);
            this.FriendTaskButtonUX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FriendTaskButtonUX.Name = "FriendTaskButtonUX";
            this.FriendTaskButtonUX.Size = new System.Drawing.Size(69, 38);
            this.FriendTaskButtonUX.TabIndex = 1;
            this.FriendTaskButtonUX.Text = "Tasks";
            this.FriendTaskButtonUX.UseVisualStyleBackColor = true;
            this.FriendTaskButtonUX.Click += new System.EventHandler(this.FriendTaskButtonUX_Click);
            // 
            // FriendFriendsButtonUX
            // 
            this.FriendFriendsButtonUX.Location = new System.Drawing.Point(246, 3);
            this.FriendFriendsButtonUX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FriendFriendsButtonUX.Name = "FriendFriendsButtonUX";
            this.FriendFriendsButtonUX.Size = new System.Drawing.Size(77, 38);
            this.FriendFriendsButtonUX.TabIndex = 2;
            this.FriendFriendsButtonUX.Text = "Friends";
            this.FriendFriendsButtonUX.UseVisualStyleBackColor = true;
            this.FriendFriendsButtonUX.Click += new System.EventHandler(this.FriendFriendsButtonUX_Click);
            // 
            // uxRemoveFriend
            // 
            this.uxRemoveFriend.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.uxRemoveFriend.Location = new System.Drawing.Point(331, 3);
            this.uxRemoveFriend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxRemoveFriend.Name = "uxRemoveFriend";
            this.uxRemoveFriend.Size = new System.Drawing.Size(40, 38);
            this.uxRemoveFriend.TabIndex = 3;
            this.uxRemoveFriend.Text = "-";
            this.uxRemoveFriend.UseVisualStyleBackColor = false;
            this.uxRemoveFriend.Click += new System.EventHandler(this.uxRemoveFriend_Click);
            // 
            // FriendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxRemoveFriend);
            this.Controls.Add(this.FriendFriendsButtonUX);
            this.Controls.Add(this.FriendTaskButtonUX);
            this.Controls.Add(this.uxFriendName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FriendControl";
            this.Size = new System.Drawing.Size(377, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxFriendName;
        private System.Windows.Forms.Button FriendTaskButtonUX;
        private System.Windows.Forms.Button FriendFriendsButtonUX;
        private System.Windows.Forms.Button uxRemoveFriend;
    }
}
