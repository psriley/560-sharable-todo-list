﻿namespace ToDoneApp
{
    partial class UserSearchResults
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
            this.uxResultsBox = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // uxResultsBox
            // 
            this.uxResultsBox.Location = new System.Drawing.Point(3, 3);
            this.uxResultsBox.Name = "uxResultsBox";
            this.uxResultsBox.Size = new System.Drawing.Size(639, 527);
            this.uxResultsBox.TabIndex = 0;
            // 
            // UserSearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxResultsBox);
            this.Name = "UserSearchResults";
            this.Size = new System.Drawing.Size(645, 533);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel uxResultsBox;
    }
}
