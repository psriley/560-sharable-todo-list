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
            this.SuspendLayout();
            // 
            // uxDisplayName
            // 
            this.uxDisplayName.AutoSize = true;
            this.uxDisplayName.Location = new System.Drawing.Point(3, 7);
            this.uxDisplayName.Name = "uxDisplayName";
            this.uxDisplayName.Size = new System.Drawing.Size(80, 15);
            this.uxDisplayName.TabIndex = 0;
            this.uxDisplayName.Text = "Display Name";
            // 
            // uxAddFriend
            // 
            this.uxAddFriend.Location = new System.Drawing.Point(174, 3);
            this.uxAddFriend.Name = "uxAddFriend";
            this.uxAddFriend.Size = new System.Drawing.Size(462, 23);
            this.uxAddFriend.TabIndex = 1;
            this.uxAddFriend.Text = "Add Friend";
            this.uxAddFriend.UseVisualStyleBackColor = true;
            this.uxAddFriend.Click += new System.EventHandler(this.uxAddFriend_Click);
            // 
            // UserResultComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxAddFriend);
            this.Controls.Add(this.uxDisplayName);
            this.Name = "UserResultComponent";
            this.Size = new System.Drawing.Size(639, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxDisplayName;
        private System.Windows.Forms.Button uxAddFriend;
    }
}
