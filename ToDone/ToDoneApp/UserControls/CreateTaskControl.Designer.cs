namespace ToDoneApp
{
    partial class CreateTaskControl
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
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxMakeTask = new System.Windows.Forms.Button();
            this.uxTitle = new System.Windows.Forms.TextBox();
            this.uxDueDate = new System.Windows.Forms.DateTimePicker();
            this.uxPrivacy = new System.Windows.Forms.ComboBox();
            this.uxClaimable = new System.Windows.Forms.CheckBox();
            this.uxDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxDueDateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxHasDueDate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(40, 409);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(235, 118);
            this.uxCancel.TabIndex = 0;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxMakeTask
            // 
            this.uxMakeTask.Location = new System.Drawing.Point(315, 409);
            this.uxMakeTask.Name = "uxMakeTask";
            this.uxMakeTask.Size = new System.Drawing.Size(238, 118);
            this.uxMakeTask.TabIndex = 1;
            this.uxMakeTask.Text = "Make Task";
            this.uxMakeTask.UseVisualStyleBackColor = true;
            this.uxMakeTask.Click += new System.EventHandler(this.uxMakeTask_Click);
            // 
            // uxTitle
            // 
            this.uxTitle.Location = new System.Drawing.Point(78, 96);
            this.uxTitle.Name = "uxTitle";
            this.uxTitle.Size = new System.Drawing.Size(475, 23);
            this.uxTitle.TabIndex = 2;
            // 
            // uxDueDate
            // 
            this.uxDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxDueDate.Location = new System.Drawing.Point(104, 329);
            this.uxDueDate.Name = "uxDueDate";
            this.uxDueDate.Size = new System.Drawing.Size(449, 23);
            this.uxDueDate.TabIndex = 5;
            // 
            // uxPrivacy
            // 
            this.uxPrivacy.FormattingEnabled = true;
            this.uxPrivacy.Location = new System.Drawing.Point(124, 371);
            this.uxPrivacy.Name = "uxPrivacy";
            this.uxPrivacy.Size = new System.Drawing.Size(210, 23);
            this.uxPrivacy.TabIndex = 6;
            // 
            // uxClaimable
            // 
            this.uxClaimable.AutoSize = true;
            this.uxClaimable.Location = new System.Drawing.Point(378, 375);
            this.uxClaimable.Name = "uxClaimable";
            this.uxClaimable.Size = new System.Drawing.Size(79, 19);
            this.uxClaimable.TabIndex = 7;
            this.uxClaimable.Text = "Claimable";
            this.uxClaimable.UseVisualStyleBackColor = true;
            // 
            // uxDescription
            // 
            this.uxDescription.Location = new System.Drawing.Point(40, 149);
            this.uxDescription.Name = "uxDescription";
            this.uxDescription.Size = new System.Drawing.Size(513, 141);
            this.uxDescription.TabIndex = 8;
            this.uxDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Description:";
            // 
            // uxDueDateLabel
            // 
            this.uxDueDateLabel.AutoSize = true;
            this.uxDueDateLabel.Location = new System.Drawing.Point(40, 333);
            this.uxDueDateLabel.Name = "uxDueDateLabel";
            this.uxDueDateLabel.Size = new System.Drawing.Size(58, 15);
            this.uxDueDateLabel.TabIndex = 11;
            this.uxDueDateLabel.Text = "Due Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Privacy Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(125, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 81);
            this.label5.TabIndex = 13;
            this.label5.Text = "Create Task";
            // 
            // uxHasDueDate
            // 
            this.uxHasDueDate.AutoSize = true;
            this.uxHasDueDate.Location = new System.Drawing.Point(260, 304);
            this.uxHasDueDate.Name = "uxHasDueDate";
            this.uxHasDueDate.Size = new System.Drawing.Size(74, 19);
            this.uxHasDueDate.TabIndex = 14;
            this.uxHasDueDate.Text = "Due Date";
            this.uxHasDueDate.UseVisualStyleBackColor = true;
            this.uxHasDueDate.CheckedChanged += new System.EventHandler(this.uxHasDue_Changed);
            // 
            // CreateTaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxHasDueDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxDueDateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDescription);
            this.Controls.Add(this.uxClaimable);
            this.Controls.Add(this.uxPrivacy);
            this.Controls.Add(this.uxDueDate);
            this.Controls.Add(this.uxTitle);
            this.Controls.Add(this.uxMakeTask);
            this.Controls.Add(this.uxCancel);
            this.Name = "CreateTaskControl";
            this.Size = new System.Drawing.Size(589, 547);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxMakeTask;
        private System.Windows.Forms.TextBox uxTitle;
        private System.Windows.Forms.DateTimePicker uxDueDate;
        private System.Windows.Forms.ComboBox uxPrivacy;
        private System.Windows.Forms.CheckBox uxClaimable;
        private System.Windows.Forms.RichTextBox uxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uxDueDateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox uxHasDueDate;
    }
}
