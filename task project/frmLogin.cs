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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
           
        }

     

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        User newUser;
        bool isAdmin;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User newUser = new User(txtUserName.Text,txtPassword.Text);
            foreach (User u in Program.SystemUsers)
                if (newUser.Name == u.Name && newUser.Password == u.Password)
                { newUser = u;
                    isAdmin = u.isAdmin;
                }
                    
            ////not working although debug is good
            if (Program.SystemUsers.Contains(newUser))
            {
                pnlMenu.Visible = true;
                pnlLogin.Visible = false;
                
            }
            else
            {
                MessageBox.Show("UserName or Password is wrong!!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmTeam frm = new frmTeam(isAdmin);
            frm.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
