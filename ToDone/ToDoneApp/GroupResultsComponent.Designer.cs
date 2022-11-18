namespace ToDoneApp
{
    partial class GroupResultsComponent
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
            this.uxDisplay = new System.Windows.Forms.Label();
            this.uxJoinGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxDisplay
            // 
            this.uxDisplay.AutoSize = true;
            this.uxDisplay.Location = new System.Drawing.Point(3, 7);
            this.uxDisplay.Name = "uxDisplay";
            this.uxDisplay.Size = new System.Drawing.Size(38, 15);
            this.uxDisplay.TabIndex = 0;
            this.uxDisplay.Text = "label1";
            // 
            // uxJoinGroup
            // 
            this.uxJoinGroup.Location = new System.Drawing.Point(120, 4);
            this.uxJoinGroup.Name = "uxJoinGroup";
            this.uxJoinGroup.Size = new System.Drawing.Size(522, 23);
            this.uxJoinGroup.TabIndex = 1;
            this.uxJoinGroup.Text = "Join Group";
            this.uxJoinGroup.UseVisualStyleBackColor = true;
            // 
            // GroupResultsComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxJoinGroup);
            this.Controls.Add(this.uxDisplay);
            this.Name = "GroupResultsComponent";
            this.Size = new System.Drawing.Size(645, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxDisplay;
        private System.Windows.Forms.Button uxJoinGroup;
    }
}
