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
            this.FriendNameUX = new System.Windows.Forms.Label();
            this.FriendTaskButtonUX = new System.Windows.Forms.Button();
            this.FriendFriendsButtonUX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FriendNameUX
            // 
            this.FriendNameUX.AutoSize = true;
            this.FriendNameUX.Location = new System.Drawing.Point(6, 7);
            this.FriendNameUX.Name = "FriendNameUX";
            this.FriendNameUX.Size = new System.Drawing.Size(121, 15);
            this.FriendNameUX.TabIndex = 0;
            this.FriendNameUX.Text = "Friends Display Name";
            // 
            // FriendTaskButtonUX
            // 
            this.FriendTaskButtonUX.Location = new System.Drawing.Point(133, 2);
            this.FriendTaskButtonUX.Name = "FriendTaskButtonUX";
            this.FriendTaskButtonUX.Size = new System.Drawing.Size(48, 23);
            this.FriendTaskButtonUX.TabIndex = 1;
            this.FriendTaskButtonUX.Text = "Tasks";
            this.FriendTaskButtonUX.UseVisualStyleBackColor = true;
            // 
            // FriendFriendsButtonUX
            // 
            this.FriendFriendsButtonUX.Location = new System.Drawing.Point(187, 2);
            this.FriendFriendsButtonUX.Name = "FriendFriendsButtonUX";
            this.FriendFriendsButtonUX.Size = new System.Drawing.Size(54, 23);
            this.FriendFriendsButtonUX.TabIndex = 2;
            this.FriendFriendsButtonUX.Text = "Friends";
            this.FriendFriendsButtonUX.UseVisualStyleBackColor = true;
            // 
            // FriendControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FriendFriendsButtonUX);
            this.Controls.Add(this.FriendTaskButtonUX);
            this.Controls.Add(this.FriendNameUX);
            this.Name = "FriendControll";
            this.Size = new System.Drawing.Size(246, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FriendNameUX;
        private System.Windows.Forms.Button FriendTaskButtonUX;
        private System.Windows.Forms.Button FriendFriendsButtonUX;
    }
}
