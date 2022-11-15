namespace ToDoneApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainBoxUX = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FriendsBoxUX = new System.Windows.Forms.GroupBox();
            this.GroupBoxUX = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainBoxUX
            // 
            this.MainBoxUX.Location = new System.Drawing.Point(12, 35);
            this.MainBoxUX.Name = "MainBoxUX";
            this.MainBoxUX.Size = new System.Drawing.Size(645, 606);
            this.MainBoxUX.TabIndex = 0;
            this.MainBoxUX.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(893, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // FriendsBoxUX
            // 
            this.FriendsBoxUX.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FriendsBoxUX.Location = new System.Drawing.Point(663, 35);
            this.FriendsBoxUX.Name = "FriendsBoxUX";
            this.FriendsBoxUX.Size = new System.Drawing.Size(268, 295);
            this.FriendsBoxUX.TabIndex = 4;
            this.FriendsBoxUX.TabStop = false;
            this.FriendsBoxUX.Text = "Friends";
            // 
            // GroupBoxUX
            // 
            this.GroupBoxUX.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxUX.Location = new System.Drawing.Point(663, 346);
            this.GroupBoxUX.Name = "GroupBoxUX";
            this.GroupBoxUX.Size = new System.Drawing.Size(268, 295);
            this.GroupBoxUX.TabIndex = 5;
            this.GroupBoxUX.TabStop = false;
            this.GroupBoxUX.Text = "Groups";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 653);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GroupBoxUX);
            this.Controls.Add(this.FriendsBoxUX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MainBoxUX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MainBoxUX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox FriendsBoxUX;
        private System.Windows.Forms.GroupBox GroupBoxUX;
        private System.Windows.Forms.Button button2;
    }
}
