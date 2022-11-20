namespace ToDoneApp
{
    partial class TaskSearchResults
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
            this.uxBox = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // uxBox
            // 
            this.uxBox.Location = new System.Drawing.Point(0, 0);
            this.uxBox.Name = "uxBox";
            this.uxBox.Size = new System.Drawing.Size(645, 533);
            this.uxBox.TabIndex = 0;
            // 
            // TaskSearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxBox);
            this.Name = "TaskSearchResults";
            this.Size = new System.Drawing.Size(645, 533);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel uxBox;
    }
}
