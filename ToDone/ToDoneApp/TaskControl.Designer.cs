namespace ToDoneApp
{
    partial class TaskControl
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
            this.uxTitle = new System.Windows.Forms.Label();
            this.uxComplete = new System.Windows.Forms.Button();
            this.uxComment = new System.Windows.Forms.Button();
            this.uxDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTitle
            // 
            this.uxTitle.AutoSize = true;
            this.uxTitle.Location = new System.Drawing.Point(3, 7);
            this.uxTitle.Name = "uxTitle";
            this.uxTitle.Size = new System.Drawing.Size(0, 15);
            this.uxTitle.TabIndex = 0;
            // 
            // uxComplete
            // 
            this.uxComplete.Location = new System.Drawing.Point(350, 3);
            this.uxComplete.Name = "uxComplete";
            this.uxComplete.Size = new System.Drawing.Size(93, 23);
            this.uxComplete.TabIndex = 1;
            this.uxComplete.Text = "Complete Task";
            this.uxComplete.UseVisualStyleBackColor = true;
            this.uxComplete.Click += new System.EventHandler(this.uxComplete_Click);
            // 
            // uxComment
            // 
            this.uxComment.Location = new System.Drawing.Point(449, 3);
            this.uxComment.Name = "uxComment";
            this.uxComment.Size = new System.Drawing.Size(113, 23);
            this.uxComment.TabIndex = 2;
            this.uxComment.Text = "Create Comment";
            this.uxComment.UseVisualStyleBackColor = true;
            this.uxComment.Click += new System.EventHandler(this.uxComment_Click);
            // 
            // uxDelete
            // 
            this.uxDelete.Location = new System.Drawing.Point(567, 3);
            this.uxDelete.Name = "uxDelete";
            this.uxDelete.Size = new System.Drawing.Size(75, 23);
            this.uxDelete.TabIndex = 3;
            this.uxDelete.Text = "Delete Task";
            this.uxDelete.UseVisualStyleBackColor = true;
            this.uxDelete.Click += new System.EventHandler(this.uxDelete_Click);
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxDelete);
            this.Controls.Add(this.uxComment);
            this.Controls.Add(this.uxComplete);
            this.Controls.Add(this.uxTitle);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(645, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxTitle;
        private System.Windows.Forms.Button uxComplete;
        private System.Windows.Forms.Button uxComment;
        private System.Windows.Forms.Button uxDelete;
    }
}
