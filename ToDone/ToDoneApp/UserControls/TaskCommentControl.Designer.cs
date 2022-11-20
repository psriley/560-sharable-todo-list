namespace ToDoneApp
{
    partial class TaskCommentControl
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
            this.uxDescription = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uxPostComment = new System.Windows.Forms.Button();
            this.uxComment = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxTitle
            // 
            this.uxTitle.AutoSize = true;
            this.uxTitle.Location = new System.Drawing.Point(290, 9);
            this.uxTitle.Name = "uxTitle";
            this.uxTitle.Size = new System.Drawing.Size(38, 15);
            this.uxTitle.TabIndex = 0;
            this.uxTitle.Text = "label1";
            // 
            // uxDescription
            // 
            this.uxDescription.Location = new System.Drawing.Point(15, 43);
            this.uxDescription.Name = "uxDescription";
            this.uxDescription.ReadOnly = true;
            this.uxDescription.Size = new System.Drawing.Size(616, 122);
            this.uxDescription.TabIndex = 1;
            this.uxDescription.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uxPostComment
            // 
            this.uxPostComment.Location = new System.Drawing.Point(483, 452);
            this.uxPostComment.Name = "uxPostComment";
            this.uxPostComment.Size = new System.Drawing.Size(148, 63);
            this.uxPostComment.TabIndex = 3;
            this.uxPostComment.Text = "Post Comment";
            this.uxPostComment.UseVisualStyleBackColor = true;
            this.uxPostComment.Click += new System.EventHandler(this.uxPostComment_Click);
            // 
            // uxComment
            // 
            this.uxComment.Location = new System.Drawing.Point(15, 260);
            this.uxComment.Name = "uxComment";
            this.uxComment.Size = new System.Drawing.Size(616, 129);
            this.uxComment.TabIndex = 4;
            this.uxComment.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Comment:";
            // 
            // TaskCommentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxComment);
            this.Controls.Add(this.uxPostComment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxDescription);
            this.Controls.Add(this.uxTitle);
            this.Name = "TaskCommentControl";
            this.Size = new System.Drawing.Size(645, 533);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxTitle;
        private System.Windows.Forms.RichTextBox uxDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button uxPostComment;
        private System.Windows.Forms.RichTextBox uxComment;
        private System.Windows.Forms.Label label1;
    }
}
