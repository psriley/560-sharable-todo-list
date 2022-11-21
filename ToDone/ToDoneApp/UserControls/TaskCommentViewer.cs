using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToDoneApp.UserControls
{
    public partial class TaskCommentViewer : UserControl
    {
        public TaskCommentViewer(string comment)
        {
            InitializeComponent();
            uxComment.Text = comment;
        }
    }
}
