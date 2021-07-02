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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void FillEmployeesList()
        {
            foreach (Employee Emp in Program.SystemEmployees)
            {
                ListViewItem item = new ListViewItem(Emp.Name);
                item.SubItems.Add(Emp.Salary.ToString());
                item.SubItems.Add(Emp.Phone);

                lstViwEmployees.Items.Add(item);
            }
        }
        private void txtEmpName_Enter(object sender, EventArgs e)
        {
            if (txtEmpName.Text == "Employee Name")
            {
                txtEmpName.Text = "";
                txtEmpName.ForeColor = Color.Black;
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (txtEmpName.Text == "")
            {
                txtEmpName.Text = "Employee Name";
                txtEmpName.ForeColor = Color.Silver;
            }
        }
        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstViwEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViwEmployees.SelectedItems.Count == 0)
                return;

            txtEmpName.Text = lstViwEmployees.SelectedItems[0].SubItems[0].Text.ToString();
            txtEmpSalary.Text = lstViwEmployees.SelectedItems[0].SubItems[1].Text.ToString();
            txtEmpPhone.Text = lstViwEmployees.SelectedItems[0].SubItems[2].Text.ToString();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            Employee Emp = new Employee();
            Emp.Name = txtEmpName.Text;
            Emp.Salary = Convert.ToInt32(txtEmpSalary.Text);
            Emp.Phone = txtEmpPhone.Text;
            ListViewItem item = new ListViewItem(Emp.Name);
            item.SubItems.Add(txtEmpSalary.Text);
            item.SubItems.Add(txtEmpPhone.Text);
            lstViwEmployees.Items.Add(item);
            Program.SystemEmployees.Add(Emp);
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string EmployeeName = lstViwEmployees.SelectedItems[0].SubItems[0].Text;
            Employee temp = null;
            for (int i = 0; i < Program.SystemEmployees.Count && temp == null; i++) 
            {
                if (Program.SystemEmployees[i].Name == EmployeeName)
                {
                    temp = Program.SystemEmployees[i];
                    Program.SystemEmployees.RemoveAt(i);
                }
            }
            bool Deleted = false;
            for (int i = 0; i < lstViwEmployees.Items.Count&&!Deleted; i++)
            {
                if (lstViwEmployees.Items[i].Selected)
                {
                    txtEmpName.Text = string.Empty;
                    txtEmpSalary.Text = string.Empty;
                    txtEmpPhone.Text = string.Empty;
                    lstViwEmployees.Items[i].Remove();
                    Deleted = true;
                }
            }
        }

        private void btnUpdateEmpolyee_Click(object sender, EventArgs e)
        {
            string EmpNameBeforeUpdate = lstViwEmployees.SelectedItems[0].SubItems[0].Text;
            lstViwEmployees.SelectedItems[0].SubItems[0].Text = txtEmpName.Text;
            lstViwEmployees.SelectedItems[0].SubItems[1].Text = txtEmpSalary.Text;
            lstViwEmployees.SelectedItems[0].SubItems[2].Text = txtEmpPhone.Text;
            
            /*******************/

            Employee temp = null;
            string EmpName = txtEmpName.Text;
            for(int i = 0; i < Program.SystemEmployees.Count && temp == null; i++)
            {
                if (Program.SystemEmployees[i].Name == EmpNameBeforeUpdate)
                {
                    temp = Program.SystemEmployees[i];
                    Program.SystemEmployees.RemoveAt(i);
                }
            }
            temp.Name = txtEmpName.Text;
            temp.Phone = txtEmpPhone.Text;
            temp.Salary = Convert.ToInt32(txtEmpSalary.Text);
            Program.SystemEmployees.Add(temp);
            txtEmpName.Text = string.Empty;
            txtEmpSalary.Text = string.Empty;
            txtEmpPhone.Text = string.Empty;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
