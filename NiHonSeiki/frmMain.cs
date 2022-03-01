using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NiHonSeiki
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            frmReceive f = new frmReceive();
            f.Show();
        }

        private void btnReceiveVender_Click(object sender, EventArgs e)
        {
            frmReceiveVender f = new frmReceiveVender();
            f.Show();
        }

        private void btnSendVender_Click(object sender, EventArgs e)
        {
            frmSendVender f = new frmSendVender("Send to Vender");
            f.Show();
        }
    }
}