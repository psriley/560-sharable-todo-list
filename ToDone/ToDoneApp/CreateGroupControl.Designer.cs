
namespace ToDoneApp
{
    partial class CreateGroupControl
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxDescription = new System.Windows.Forms.RichTextBox();
            this.uxTitle = new System.Windows.Forms.TextBox();
            this.uxCreateGroup = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(138, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(582, 120);
            this.label5.TabIndex = 18;
            this.label5.Text = "Create Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Title:";
            // 
            // uxDescription
            // 
            this.uxDescription.Location = new System.Drawing.Point(49, 282);
            this.uxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxDescription.Name = "uxDescription";
            this.uxDescription.Size = new System.Drawing.Size(731, 232);
            this.uxDescription.TabIndex = 15;
            this.uxDescription.Text = "";
            // 
            // uxTitle
            // 
            this.uxTitle.Location = new System.Drawing.Point(103, 194);
            this.uxTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxTitle.Name = "uxTitle";
            this.uxTitle.Size = new System.Drawing.Size(677, 31);
            this.uxTitle.TabIndex = 14;
            // 
            // uxCreateGroup
            // 
            this.uxCreateGroup.Location = new System.Drawing.Point(440, 665);
            this.uxCreateGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxCreateGroup.Name = "uxCreateGroup";
            this.uxCreateGroup.Size = new System.Drawing.Size(340, 197);
            this.uxCreateGroup.TabIndex = 20;
            this.uxCreateGroup.Text = "Create Group";
            this.uxCreateGroup.UseVisualStyleBackColor = true;
            this.uxCreateGroup.Click += new System.EventHandler(this.uxCreateGroup_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(47, 665);
            this.uxCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(336, 197);
            this.uxCancel.TabIndex = 19;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // CreateGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxCreateGroup);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDescription);
            this.Controls.Add(this.uxTitle);
            this.Name = "CreateGroupControl";
            this.Size = new System.Drawing.Size(841, 912);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox uxDescription;
        private System.Windows.Forms.TextBox uxTitle;
        private System.Windows.Forms.Button uxCreateGroup;
        private System.Windows.Forms.Button uxCancel;
    }
}
