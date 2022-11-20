using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToDoneApp
{
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();
        }

        private void uxBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Clear();
        }

        private void uxRunAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
