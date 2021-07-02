using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_project
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }
        int counter = 0;
        int len = 0;
        string txt;
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter > len)
            {
                counter = 0;
                lblWelcome.Text = "";
            }

            else
            {

                lblWelcome.Text = txt.Substring(0, counter);

                if (lblWelcome.ForeColor == Color.Black)
                    lblWelcome.ForeColor = Color.White;
                else
                    lblWelcome.ForeColor = Color.Black;
            }
        }

    
        private void frmStart_Load(object sender, EventArgs e)
        {
            txt = lblWelcome.Text;
            len = txt.Length;
            lblWelcome.Text = "";
            timer1.Start();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}
