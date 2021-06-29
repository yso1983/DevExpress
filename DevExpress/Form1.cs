using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DevExpress
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    { 
        public Form1()
        {
            InitializeComponent();
            this.uiBtn_Show.Click += uiBtn_Show_Click;
        }

        private void uiBtn_Show_Click(object sender, EventArgs e)
        {
            frmProgressPanel frm = new frmProgressPanel();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }
    }
}
