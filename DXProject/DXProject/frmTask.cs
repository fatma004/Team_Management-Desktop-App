using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXProject
{
    public partial class frmTask : DevExpress.XtraEditors.XtraForm
    {
        int counter = 0;
        int len = 0;
        string txt;
        Category myCategory;
        Team myTeam;
        Employee myEmployee;
        Task myTask;
        SubTask mySubTask;
        bool IsAdmin = false;
        public frmTask()
        {
            InitializeComponent();
            myCategory = new Category();
            myTeam = new Team();
            myEmployee = new Employee();
            myTask = new Task();
            mySubTask = new SubTask();
            cmbTitle.DataSource = Enum.GetValues(typeof(CategoryTitle));
        }
        private void adminPanelVisible()
        {
            if(!IsAdmin)
            {
                lblSystemTeam.Visible = false;
                lalTeamCategory.Visible = false;
                lstviwTeams.Visible = false;
                btnDeleteTeam.Visible = false;
                btnDeleteTeam.Visible = false;
                cmbTeam.Visible = false;
                label7.Visible = false;
                lblTeamTask.Visible = false;
                cmbTeamTask.Visible = false;
                label13.Visible = false;
                label12.Visible = false;
                lblCategoryTask.Visible = false;
                cmbCategoryTask.Visible = false;
                label11.Visible = false;
                lblTeamSubTask.Visible = false;
                cmbTeamSubTask.Visible = false;
                lblCategorySubTask.Visible = false;
                cmbCategorySubTask.Visible = false;
                lablTaskSubTask.Visible = false;
                cmbTaskSubTask.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
            }
        }
        private void frmTask_Load(object sender, EventArgs e)
        {
            navpageTask.PageVisible = false;
            navpageSubTask.PageVisible = false;
            navpageCategory.PageVisible = false;
            txt = lblWelcome.Text;
            len = txt.Length;
            lblWelcome.Text = "";
            timer1.Start();

        }
        /*Start Welcome*/
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lblWelcome.Visible = false;
            btnStart.Visible = false;
            panel1.Visible = true;
        }
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
        /*End Welcome*/

        /*Start Login*/
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            User newUser = new User(txtUserName.Text, txtPassword.Text);
            foreach (User u in Program.SystemUsers)
                if (newUser.Name == u.Name && newUser.Password == u.Password)
                    newUser = u;
            ////not working although debug is good
            if (Program.SystemUsers.Contains(newUser))
            {
                navpanMenu.Visible = true;
                lblNote.Visible = true;
                panel1.Visible = false;
                IsAdmin = newUser.isAdmin;
                adminPanelVisible();
            }
            else
            {
                MessageBox.Show("UserName or Password is wrong!!");
            }
        }
        /*End Login*/

        /*Start Move Between Pages*/
        private void navigationPane1_Click(object sender, EventArgs e)
        {
            lblNote.Visible = false;
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            changeDataOfCategory();
            navpageCategory.PageVisible = true;
            navpanMenu.SelectedPage = navpageCategory;
            fill_cmbTeam();
            cmbTeam.SelectedItem = myTeam.Name;
        }
        private void btnBackToEmpolyeePage_Click(object sender, EventArgs e)
        {
            navpageCategory.PageVisible = false;
        }
        private void btnGoToTaskPage_Click(object sender, EventArgs e)
        {
            changeDataOfTask();
            navpageTask.PageVisible = true;
            navpanMenu.SelectedPage = navpageTask;
            fill_cmbCategoryTask();
            fill_cmbTeamTask();
            cmbTeamTask.SelectedItem = myTeam.Name;
            cmbCategoryTask.SelectedItem = myCategory.Title.ToString();
        }
        private void btnBactToTeamPage_Click(object sender, EventArgs e)
        {
            navpageCategory.PageVisible = false;
            navpageTask.PageVisible = false;
            navpageSubTask.PageVisible = false;
            navpanMenu.SelectedPage = navpageTeam;
        }
        private void changeDataOfSubTask()
        {
            cmbTeamSubTask.SelectedItem = myTeam.Name;
            cmbCategorySubTask.SelectedItem = myCategory.Title.ToString();
            cmbTaskSubTask.SelectedItem = myTask.Name;
            for (int i = 0; i < lstviwSubTask.Items.Count; i++)
            {
                if (lstviwSubTask.Items[i].SubItems[0].Text == mySubTask.Name)
                {
                    lstviwSubTask.Items[i].Selected = true;
                    lstviwSubTask.Focus();
                }
                else
                {
                    lstviwSubTask.Items[i].Selected = false;
                }
            }
        }
        private void btnGoToSubTaskPage_Click(object sender, EventArgs e)
        {
            changeDataOfSubTask();
            navpageSubTask.PageVisible = true;
            navpanMenu.SelectedPage = navpageSubTask;
            fill_cmbTaskSubTask();
            fill_cmbCategorySubTask();
            fill_cmbTeamSubTask();
            fill_cmbAssginTo();
            cmbTeamSubTask.SelectedItem = myTeam.Name;
            cmbCategorySubTask.SelectedItem = myCategory.Title.ToString();
            cmbTaskSubTask.SelectedItem = myTask.Name;
        }
        private void btnBackToCategoryPage_Click(object sender, EventArgs e)
        {
            navpageTask.PageVisible = false;
            navpageSubTask.PageVisible = false;
            navpanMenu.SelectedPage = navpageCategory;
        }
        private void btnBackToTaskPage_Click(object sender, EventArgs e)
        {
            fill_lstviwTask();
            navpageSubTask.PageVisible = false;
            navpanMenu.SelectedPage = navpageTask;
        }
        /*End Move Between Pages*/

        /*Start Placeholder*/
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text == "")
            {
                txtEmployeeName.Text = "Employee Name";
                txtEmployeeName.ForeColor = Color.Silver;
            }
        }
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text == "Employee Name")
            {
                txtEmployeeName.Text = "";
                txtEmployeeName.ForeColor = Color.Black;
            }
        }
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Phone";
                txtPhone.ForeColor = Color.Silver;
            }
        }
        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Phone")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.Black;
            }
        }
        private void txtSalary_Leave(object sender, EventArgs e)
        {
            if (txtSalary.Text == "")
            {
                txtSalary.Text = "Salary";
                txtSalary.ForeColor = Color.Silver;
            }
        }
        private void txtSalary_Enter(object sender, EventArgs e)
        {
            if (txtSalary.Text == "Salary")
            {
                txtSalary.Text = "";
                txtSalary.ForeColor = Color.Black;
            }
        }
        private void txtDescriptionOfTeam_Leave(object sender, EventArgs e)
        {
            if (txtTeamDescription.Text == "")
            {
                txtTeamDescription.Text = "Team Description";
                txtTeamDescription.ForeColor = Color.Silver;
            }
        }
        private void txtDescriptionOfTeam_Enter(object sender, EventArgs e)
        {
            if (txtTeamDescription.Text == "Team Description")
            {
                txtTeamDescription.Text = "";
                txtTeamDescription.ForeColor = Color.Black;
            }
        }
        private void txtNameOfTeam_Leave(object sender, EventArgs e)
        {
            if (txtTeamName.Text == "")
            {
                txtTeamName.Text = "Team Name";
                txtTeamName.ForeColor = Color.Silver;
            }
        }
        private void txtNameOfTeam_Enter(object sender, EventArgs e)
        {
            if (txtTeamName.Text == "Team Name")
            {
                txtTeamName.Text = "";
                txtTeamName.ForeColor = Color.Black;
            }
        }
        private void txtTaskName_Leave(object sender, EventArgs e)
        {
            if (txtTaskName.Text == "")
            {
                txtTaskName.Text = "Task Name";
                txtTaskName.ForeColor = Color.Silver;
            }
        }
        private void txtTaskName_Enter(object sender, EventArgs e)
        {
            if (txtTaskName.Text == "Task Name")
            {
                txtTaskName.Text = "";
                txtTaskName.ForeColor = Color.Black;
            }
        }
        private void rchtxtTaskDescription_Leave(object sender, EventArgs e)
        {
            if (rchtxtTaskDescription.Text == "")
            {
                rchtxtTaskDescription.Text = "           Task Description";
                rchtxtTaskDescription.ForeColor = Color.Silver;
            }
        }
        private void rchtxtTaskDescription_Enter(object sender, EventArgs e)
        {
            if (rchtxtTaskDescription.Text == "           Task Description")
            {
                rchtxtTaskDescription.Text = "";
                rchtxtTaskDescription.ForeColor = Color.Black;
            }
        }
        private void rchtxtDescription_Leave(object sender, EventArgs e)
        {
            if (rchtxtDescription.Text == "")
            {
                rchtxtDescription.Text = "                 Category  Description";
                rchtxtDescription.ForeColor = Color.Silver;
            }
        }
        private void rchtxtDescription_Enter(object sender, EventArgs e)
        {
            if (rchtxtDescription.Text == "                 Category  Description")
            {
                rchtxtDescription.Text = "";
                rchtxtDescription.ForeColor = Color.Black;
            }
        }
        private void txtSubTaskName_Enter(object sender, EventArgs e)
        {
            if (txtSubTaskName.Text == "Sub Task Name")
            {
                txtSubTaskName.Text = "";
                txtSubTaskName.ForeColor = Color.Black;
            }
        }
        private void txtSubTaskName_Leave(object sender, EventArgs e)
        {
            if (txtSubTaskName.Text == "")
            {
                txtSubTaskName.Text = "Sub Task Name";
                txtSubTaskName.ForeColor = Color.Silver;
            }
        }
        private void rchtxtSubTaskDescription_Enter_1(object sender, EventArgs e)
        {
            if (rchtxtSubTaskDescription.Text == "SubTask  Description")
            {
                rchtxtSubTaskDescription.Text = "";
                rchtxtSubTaskDescription.ForeColor = Color.Black;
            }
        }
        private void rchtxtSubTaskDescription_Leave(object sender, EventArgs e)
        {
            if (rchtxtSubTaskDescription.Text == "")
            {
                rchtxtSubTaskDescription.Text = "SubTask  Description";
                rchtxtSubTaskDescription.ForeColor = Color.Silver;
            }
        }
        /*End Placeholder*/

        /*Start Employee*/
        private void fill_listviewEmployee()
        {
            lstviwEmployees.Items.Clear();
            foreach (Employee Emp in Program.systemEmployees)
            {
                ListViewItem item = new ListViewItem(Emp.Name);
                item.SubItems.Add(Emp.Salary.ToString());
                item.SubItems.Add(Emp.Phone);
                lstviwEmployees.Items.Add(item);
            }
        }
        private void lstviwEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstviwEmployees.SelectedItems.Count == 0)
                return;
            txtName_Enter(this, new EventArgs());
            txtPhone_Enter(this, new EventArgs());
            txtSalary_Enter(this, new EventArgs());
            txtEmployeeName.Text = lstviwEmployees.SelectedItems[0].SubItems[0].Text.ToString();
            txtPhone.Text = lstviwEmployees.SelectedItems[0].SubItems[2].Text.ToString();
            txtSalary.Text = lstviwEmployees.SelectedItems[0].SubItems[1].Text.ToString();
        }
        private void checkValidEmployee()
        {
            int parsedValue;
            if (int.TryParse(txtEmployeeName.Text, out parsedValue))
            {
                MessageBox.Show("This Filed Start With Char !");
                txtEmployeeName.ForeColor = Color.Red;
                return;
            }
            else if(!int.TryParse(txtPhone.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                txtPhone.ForeColor = Color.Red;
                return;
            }
            else if(!int.TryParse(txtSalary.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                txtSalary.ForeColor = Color.Red;
                return;
            }
            else 
            {
                myEmployee = new Employee();
                myEmployee.Name = txtEmployeeName.Text;
                myEmployee.Salary = Convert.ToInt32(txtSalary.Text);
                myEmployee.Phone = txtPhone.Text;
                if (Program.systemEmployees.Any(E => E.Name == myEmployee.Name))
                {
                    MessageBox.Show("this employee there is !!");
                }
                else
                {
                    Program.systemEmployees.Add(myEmployee);
                }
                fill_listviewEmployee();
                txtEmployeeName.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtSalary.Text = string.Empty;
                txtName_Leave(this, new EventArgs());
                txtPhone_Leave(this, new EventArgs());
                txtSalary_Leave(this, new EventArgs());
            }
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtEmployeeName.Text)|| txtEmployeeName.Text=="Employee Name" || String.IsNullOrEmpty(txtPhone.Text) || txtPhone.Text == "Phone" || String.IsNullOrEmpty(txtSalary.Text) || txtSalary.Text == "Salary")
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else 
            {
                checkValidEmployee();
            }
        }
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmployeeName.Text) || txtEmployeeName.Text == "Employee Name" || String.IsNullOrEmpty(txtPhone.Text) || txtPhone.Text == "Phone" || String.IsNullOrEmpty(txtSalary.Text) || txtSalary.Text == "Salary")
            {
                MessageBox.Show("Please Enter your data , * is required data !");

            }
            else
            {
                string EmployeeName = lstviwEmployees.SelectedItems[0].SubItems[0].Text;
                Employee temp = null;
                for (int i = 0; i < Program.systemEmployees.Count && temp == null; i++)
                {
                    if (Program.systemEmployees[i].Name == EmployeeName)
                    {
                        temp = Program.systemEmployees[i];
                        Program.systemEmployees.RemoveAt(i);
                    }
                }
                bool Deleted = false;
                for (int i = 0; i < lstviwEmployees.Items.Count && !Deleted; i++)
                {
                    if (lstviwEmployees.Items[i].Selected)
                    {
                        txtEmployeeName.Text = string.Empty;
                        txtSalary.Text = string.Empty;
                        txtPhone.Text = string.Empty;
                        lstviwEmployees.Items[i].Remove();
                        Deleted = true;
                    }
                }
                txtName_Leave(this, new EventArgs());
                txtPhone_Leave(this, new EventArgs());
                txtSalary_Leave(this, new EventArgs());
            }    
        }
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmployeeName.Text) || txtEmployeeName.Text == "Employee Name" || String.IsNullOrEmpty(txtPhone.Text) || txtPhone.Text == "Phone" || String.IsNullOrEmpty(txtSalary.Text) || txtSalary.Text == "Salary")
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else
            {
                string EmpNameBeforeUpdate = lstviwEmployees.SelectedItems[0].SubItems[0].Text;
                lstviwEmployees.SelectedItems[0].SubItems[0].Text = txtEmployeeName.Text;
                lstviwEmployees.SelectedItems[0].SubItems[2].Text = txtPhone.Text;
                lstviwEmployees.SelectedItems[0].SubItems[1].Text = txtSalary.Text;
                Employee temp = null;
                for (int i = 0; i < Program.systemEmployees.Count && temp == null; i++)
                {
                    if (Program.systemEmployees[i].Name == EmpNameBeforeUpdate)
                    {
                        temp = Program.systemEmployees[i];
                        Program.systemEmployees.RemoveAt(i);
                    }
                }
                temp.Name = txtEmployeeName.Text;
                temp.Phone = txtPhone.Text;
                temp.Salary = Convert.ToInt32(txtSalary.Text);
                Program.systemEmployees.Add(temp);
                txtEmployeeName.Text = string.Empty;
                txtSalary.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtName_Leave(this, new EventArgs());
                txtPhone_Leave(this, new EventArgs());
                txtSalary_Leave(this, new EventArgs());
            }
        }
        /*End Employee*/

        /*Start Team*/
        private void changeDataOfCategory()
        {
            for (int i = 0; i < lstviwTeams.Items.Count; i++)
            {
                if (lstviwTeams.Items[i].SubItems[0].Text.ToString() == myTeam.Name)
                {
                    lstviwTeams.Items[i].Selected = true;
                }
                else
                {
                    lstviwTeams.Items[i].Selected = false;
                }
            }
        }
        private void fill_listviewTeams()
        {
            lstviwTeams.Items.Clear();
            for (int i = 0; i < Program.Teams.Count; i++)
            {
                ListViewItem item = new ListViewItem(Program.Teams[i].Name);
                item.SubItems.Add(Program.Teams[i].Description);
                lstviwTeams.Items.Add(item);
            }
        }
        private void ClearCheckBoxs()
        {
            if (chcklstbxSystemEmployees.Items.Count > 0)
            {
                chcklstbxSystemEmployees.Items.Clear();
            }
            if (chcklstbxTeamEmplyees.Items.Count > 0)
            {
                chcklstbxTeamEmplyees.Items.Clear();
            }
        }
        private void btnAssginToTeams_Click(object sender, EventArgs e)
        {
            ClearCheckBoxs();
            grbxAssginEmployeeToTeam.Visible = true;
            DisplayEmployeeTeamAndEmployeeSystemInCheckBoxs();
        }
        private void checkValidTeam()
        {
            int parsedValue;
            if (int.TryParse(txtTeamName.Text, out parsedValue))
            {
                MessageBox.Show("This Filed Start With Char !");
                txtTeamName.ForeColor = Color.Red;
                return;
            }
            else if (int.TryParse(txtTeamDescription.Text, out parsedValue))
            {
                MessageBox.Show("This Filed Start With Char !");
                txtTeamDescription.ForeColor = Color.Red;
                return;
            }
            else
            {
                ClearCheckBoxs();
                myTeam = new Team(txtTeamName.Text, txtTeamDescription.Text);
                Program.Teams.Add(myTeam);
                fill_listviewTeams();
                txtTeamName.Text = string.Empty;
                txtTeamDescription.Text = string.Empty;
                txtNameOfTeam_Leave(this, new EventArgs());
                txtDescriptionOfTeam_Leave(this, new EventArgs());
            }
        }
        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTeamName.Text) || txtTeamName.Text == "Team Name" || String.IsNullOrEmpty(txtTeamDescription.Text) || txtPhone.Text == "Team Description")
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else
            {
                checkValidTeam();
            }
        }
        private void DisplayEmployeeTeamAndEmployeeSystemInCheckBoxs()
        {
            for (int i = 0; i < Program.systemEmployees.Count; i++)
            {
                Employee E = Program.systemEmployees[i];
                if (!myTeam.TeamEmployees.Any(Emp => Emp.Name == E.Name))
                {
                    chcklstbxSystemEmployees.Items.Add(Program.systemEmployees[i]);
                }
            }
            chcklstbxTeamEmplyees.Items.AddRange(myTeam.TeamEmployees.ToArray());
        }
        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTeamName.Text) || txtTeamName.Text == "Team Name" || String.IsNullOrEmpty(txtTeamDescription.Text) || txtPhone.Text == "Team Description")
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else
            {
                ClearCheckBoxs();
                bool Deleted = false;
                for (int i = 0; i < Program.Teams.Count && !Deleted; i++)
                {
                    if (Program.Teams[i].Name == myTeam.Name)
                    {
                        Program.Teams.RemoveAt(i);
                        Deleted = true;
                    }
                }
                Deleted = false;
                for (int i = 0; i < lstviwTeams.Items.Count && !Deleted; i++)
                {
                    if (lstviwTeams.Items[i].Selected)
                    {
                        txtTeamName.Text = string.Empty;
                        txtTeamDescription.Text = string.Empty;
                        lstviwTeams.Items[i].Remove();
                        Deleted = true;
                    }
                }
                txtTeamName.Text = string.Empty;
                txtTeamDescription.Text = string.Empty;
                txtNameOfTeam_Leave(this, new EventArgs());
                txtDescriptionOfTeam_Leave(this, new EventArgs());
            }
        }
        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTeamName.Text) || txtTeamName.Text == "Team Name" || String.IsNullOrEmpty(txtTeamDescription.Text) || txtPhone.Text == "Team Description")
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else
            {
                myTeam.Name = txtTeamName.Text;
                myTeam.Description = txtTeamDescription.Text;
                lstviwTeams.SelectedItems[0].SubItems[0].Text = myTeam.Name;
                lstviwTeams.SelectedItems[0].SubItems[1].Text = myTeam.Description;
                if (grbxAssginEmployeeToTeam.Visible)
                {
                    UpdateEmpsListOfTeam();
                }
                txtTeamName.Text = string.Empty;
                txtTeamDescription.Text = string.Empty;
                txtNameOfTeam_Leave(this, new EventArgs());
                txtDescriptionOfTeam_Leave(this, new EventArgs());
            }
        }
        private void UpdateEmpsListOfTeam()
        {
            myTeam.TeamEmployees.Clear();
            for (int i = 0; i < chcklstbxTeamEmplyees.Items.Count; i++)
            {
                string EmpName = chcklstbxTeamEmplyees.Items[i].ToString();
                Employee Emp = Program.systemEmployees.Find(E => E.Name == EmpName);
                myTeam.TeamEmployees.Add(Emp);
            }
        }
        private void lstviwTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNameOfTeam_Enter(this, new EventArgs());
            txtDescriptionOfTeam_Enter(this, new EventArgs());
            if (lstviwTeams.SelectedItems.Count == 0)
                return;
            myTeam = null;
            string selectedIteamName = lstviwTeams.SelectedItems[0].SubItems[0].Text.ToString();
            for (int i = 0; i < Program.Teams.Count && myTeam == null; i++)
            {
                if (Program.Teams[i].Name == selectedIteamName)
                {
                    myTeam = Program.Teams[i];
                }
            }
            ClearCheckBoxs();
            txtTeamName.Text = myTeam.Name;
            txtTeamDescription.Text = myTeam.Description;
            if (grbxAssginEmployeeToTeam.Visible)
            {
                DisplayEmployeeTeamAndEmployeeSystemInCheckBoxs();
            }
        }
        private void btnGoToTeam_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chcklstbxSystemEmployees.Items.Count; i++)
            {
                if (chcklstbxSystemEmployees.GetItemChecked(i))
                {
                    string EmpName = chcklstbxSystemEmployees.Items[i].ToString();
                    chcklstbxTeamEmplyees.Items.Add(EmpName);
                    chcklstbxSystemEmployees.Items.Remove(chcklstbxSystemEmployees.Items[i]);
                    i--;
                }
            }
        }
        private void btnBackToEmployee_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chcklstbxTeamEmplyees.Items.Count; i++)
            {
                if (chcklstbxTeamEmplyees.GetItemChecked(i))
                {
                    string EmpName = chcklstbxTeamEmplyees.Items[i].ToString();
                    chcklstbxSystemEmployees.Items.Add(EmpName);
                    chcklstbxTeamEmplyees.Items.Remove(chcklstbxTeamEmplyees.Items[i]);
                    i--;
                }
            }
        }
        private void btnOkEmployeeToTeam_Click(object sender, EventArgs e)
        {
            ClearCheckBoxs();
            grbxAssginEmployeeToTeam.Visible = false;
        }
        /*End Team*/

        /*Start Category*/
       private void fill_cmbTeam()
        {
            cmbTeam.Items.Clear();
            foreach (Team t in Program.Teams)
            {
                if (!cmbTeam.Items.Contains(t.Name.ToString()))
                    cmbTeam.Items.Add(t.Name.ToString());
            }

        }
        private void changeDataOfTask()
        {           
            cmbTeamTask.SelectedItem = myTeam.Name;
            cmbCategoryTask.SelectedItem = myCategory.Title.ToString();
                for (int i = 0; i < lstviwTask.Items.Count; i++)
                {
                    if (lstviwTask.Items[i].SubItems[0].Text == myTask.Name)
                    {
                        lstviwTask.Items[i].Selected = true;
                        lstviwTask.Focus();
                    }
                    else
                    {
                        lstviwTask.Items[i].Selected = false;
                    }
                }
        }
        private void fill_listviewCategory()
        {
            lstviwCategory.Items.Clear();
            foreach (Category c in myTeam.TeamCategories)
            {
                ListViewItem it = new ListViewItem(c.Title.ToString());
                it.SubItems.Add(c.Description);
                lstviwCategory.Items.Add(it);
            }
        }
        private void AddCategory()
        {
            Category cat = new Category(myCategory.Title, myCategory.Description);
            myTeam.TeamCategories.Add(cat);
            fill_listviewCategory();
        }
        private void checkVaildCategory()
        {
            int parsedValue;
            if (int.TryParse(rchtxtDescription.Text, out parsedValue))
            {
                MessageBox.Show("This Filed Start With Char !");
                rchtxtDescription.ForeColor = Color.Red;
                return;
            }
            else
            {
                AddCategory();
                rchtxtDescription.Text = string.Empty;
                cmbTitle.SelectedIndex = -1;
                rchtxtDescription_Leave(this, new EventArgs());
            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if ((cmbTitle.SelectedIndex == -1) || (cmbTeam.SelectedIndex == -1) || rchtxtDescription.Text == "                 Category  Description" || String.IsNullOrEmpty(rchtxtDescription.Text))
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else
            {
                checkVaildCategory();
            }
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if ((cmbTitle.SelectedIndex == -1) || (cmbTeam.SelectedIndex == -1) || rchtxtDescription.Text == "                 Category  Description" || String.IsNullOrEmpty(rchtxtDescription.Text))
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else
            {
                for (int i = 0; i < myTeam.TeamCategories.Count; i++)
                    if (myCategory.ID == myTeam.TeamCategories[i].ID)
                        myTeam.TeamCategories.RemoveAt(i);
                fill_listviewCategory();
                rchtxtDescription.Text = string.Empty;
                cmbTitle.SelectedIndex = -1;
                rchtxtDescription_Leave(this, new EventArgs());
            }
        }
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if ((cmbTitle.SelectedIndex == -1) || (cmbTeam.SelectedIndex == -1) || rchtxtDescription.Text == "                 Category  Description" || String.IsNullOrEmpty(rchtxtDescription.Text))
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else
            {
                for (int i = 0; i < myTeam.TeamCategories.Count; i++)
                    if (myCategory.ID == myTeam.TeamCategories[i].ID)
                        myTeam.TeamCategories[i] = new Category(myCategory);
                fill_listviewCategory();
                rchtxtDescription.Text = string.Empty;
                cmbTitle.SelectedIndex = -1;
                rchtxtDescription_Leave(this, new EventArgs());
            }
        }
        private void lstviwCategory_SelectedIndexChanged(object sender, EventArgs e)
        { 
            foreach (Category c in myTeam.TeamCategories)
            {
                if (c.Title.ToString() == lstviwCategory.Items[lstviwCategory.FocusedItem.Index].SubItems[0].Text)
                    myCategory = new Category(c);
            }
            cmbTitle.Text = myCategory.Title.ToString();
            rchtxtDescription.Text = myCategory.Description;
        }
        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTitle.SelectedItem != null)
                myCategory.Title = (CategoryTitle)cmbTitle.SelectedItem;
        }
        private void rchtxtDescription_TextChanged(object sender, EventArgs e)
        {
            myCategory.Description = rchtxtDescription.Text;
        }
        private void cmbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Team t in Program.Teams)
                if (t.Name == cmbTeam.SelectedItem.ToString())
                    myTeam = t;
            fill_listviewCategory();
        }
        /*End Category*/

        /*Start Task*/
        private void txtTaskName_TextChanged(object sender, EventArgs e)
        {
            myTask.Name = txtTaskName.Text;
        }
        private void rchtxtTaskDescription_TextChanged(object sender, EventArgs e)
        {
            if (rchtxtTaskDescription.Text == string.Empty)
                return;
            myTask.Description = rchtxtTaskDescription.Text;
        }
        private void cmbCategoryTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Category c in myTeam.TeamCategories)
            {
                string cName = Enum.GetName(typeof(CategoryTitle), c.Title);
                if (cName == cmbCategoryTask.SelectedItem as string)
                    myCategory = c;
            }
            fill_lstviwTask();
        }
        private void cmbTeamTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Team t in Program.Teams)
            {
                if (t.Name == cmbTeamTask.SelectedItem as string)
                    myTeam = t;
            }
            lstviwTask.Items.Clear();
            cmbCategoryTask.SelectedIndex = -1;
            fill_cmbCategoryTask();
            fill_lstviwTask();
        }
        private void btnShowWithArchived_Click(object sender, EventArgs e)
        {
            fill_lstviwTask();
        }
        private void btnShowWithOutArchived_Click(object sender, EventArgs e)
        {
            lstviwTask.Items.Clear();
            foreach (Task tt in myCategory.CategoryTasks)
            {
                if (tt.IsArchived == false)
                {
                    ListViewItem it = new ListViewItem(tt.Name);
                    it.SubItems.Add(tt.Description);
                    it.SubItems.Add(tt.DeadLine.Date.ToString());
                    it.SubItems.Add(tt.Status.ToString());
                    it.SubItems.Add(tt.IsArchived.ToString());
                    lstviwTask.Items.Add(it);
                }
            }
        }
        private void fill_cmbTaskFiles()
        {
            cmbTaskFiles.Items.Clear();
            foreach (string s in myTask.FilesPathes)
               cmbTaskFiles.Items.Add(Path.GetFileName(s));
        }
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            cmbTaskFiles.Items.Clear();
            myTask.FilesPathes = null;
            OpenFileDialog FD = new OpenFileDialog();
            FD.Filter = "PDF|*.pdf";//|JPG|*.jpg|PNG|*.png";
            if (FD.ShowDialog() == DialogResult.OK)
                myTask.FilesPathes.Add(FD.FileName); //path stored with name  "C:/hhhh/hhhh/hhhh/n.png"
            fill_cmbTaskFiles();
        }
        private void cmbTaskFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri(myTask.FilesPathes[cmbTaskFiles.SelectedIndex]));
        }
        private void rdbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnYes.Checked) myTask.IsArchived = true;
        }
        private void rdbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnNo.Checked) myTask.IsArchived = false;
        }
        private void rdbtnNotAssginedTask_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnNotAssginedTask.Checked)
                myTask.Status = Status.NotAssigned;
        }
        private void rdbtnRunningTask_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnRunningTask.Checked)
                myTask.Status = Status.Running;
        }
        private void rdbtnDoneTask_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDoneTask.Checked)
                myTask.Status = Status.Done;
        }
        private void lstviwTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            rchtxtTaskDescription_Enter(this, new EventArgs());
            txtTaskName_Enter(this, new EventArgs());
            if (lstviwTask.SelectedItems.Count == 0)
                return;
            myTask = null;
            if (lstviwTask.SelectedItems.Count > 0)
            {
                foreach (Task t in myCategory.CategoryTasks)
                    if (t.Name == lstviwTask.Items[lstviwTask.FocusedItem.Index].SubItems[0].Text)
                        myTask =new Task(t);
            }
            ClearCheckBox();
            txtTaskName.Text = myTask.Name;
            rchtxtTaskDescription.Text = myTask.Description;
            dtDeadLineTask.Text = myTask.DeadLine.Date.ToString();
            switch (Enum.GetName(typeof(Status), myTask.Status))
            {
                case "NotAssigned":
                    rdbtnNotAssginedTask.Checked = true;
                    break;
                case "Running":
                    rdbtnRunningTask.Checked = true;
                    break;
                case "Done":
                    rdbtnDoneTask.Checked = true;
                    break;
            }
            switch (myTask.IsArchived)
            {
                case true:
                    rdbtnYes.Checked = true;
                    break;
                case false:
                    rdbtnNo.Checked = true;
                    break;
            }
            fill_cmbTaskFiles();
            DisplayEmployeeTaskAndEmployeeSystemInCheckBoxs();
        }
        private void ClearCheckBox()
        {
            if (chcklstbxTaskEmployee.Items.Count > 0)
            {
                chcklstbxTaskEmployee.Items.Clear();
            }
            if (chcklstbxTeamEmployee.Items.Count > 0)
            {
                chcklstbxTeamEmployee.Items.Clear();
            }
        }
        private void btnAssginToEmployees_Click(object sender, EventArgs e)
        {
            ClearCheckBox();
            grbxAssginToEmployee.Visible = true;
            DisplayEmployeeTaskAndEmployeeSystemInCheckBoxs();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chcklstbxTaskEmployee.Items.Count; i++)
            {
                if (chcklstbxTaskEmployee.GetItemChecked(i))
                {
                    string EmpName = chcklstbxTaskEmployee.Items[i].ToString();
                    chcklstbxTeamEmployee.Items.Add(EmpName);
                    chcklstbxTaskEmployee.Items.Remove(chcklstbxTaskEmployee.Items[i]);
                    i--;
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chcklstbxTeamEmployee.Items.Count; i++)
            {
                if (chcklstbxTeamEmployee.GetItemChecked(i))
                {
                    string EmpName = chcklstbxTeamEmployee.Items[i].ToString();
                    chcklstbxTaskEmployee.Items.Add(EmpName);
                    chcklstbxTeamEmployee.Items.Remove(chcklstbxTeamEmployee.Items[i]);
                    i--;
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ClearCheckBoxs();
            grbxAssginToEmployee.Visible = false;
        }
        private void DisplayEmployeeTaskAndEmployeeSystemInCheckBoxs()
        { 
            for (int i = 0; i < myTeam.TeamEmployees.Count; i++)
            {
                Employee e = myTeam.TeamEmployees[i];
                if (!myTask.Employees.Any(Emp => Emp.Name == e.Name))
                {
                    chcklstbxTeamEmployee.Items.Add(e);
                }
            }
           chcklstbxTaskEmployee.Items.AddRange(myTask.Employees.ToArray());
        }
        private void checkValidTask()
        {
            int parsedValue;
            if (int.TryParse(txtTaskName.Text, out parsedValue))
            {
                MessageBox.Show("This Filed Start With Char !");
                txtTaskName.ForeColor = Color.Red;
                return;
            }
            else if (int.TryParse(rchtxtTaskDescription.Text, out parsedValue))
            {
                MessageBox.Show("This Filed Start With Char !");
                rchtxtTaskDescription.ForeColor = Color.Red;
                return;
            }
            else
            {
                ClearCheckBox();
                Task n = new Task(myTask.Name, myTask.Description, myTask.SubTasks, myTask.Employees, myTask.DeadLine, myTask.Status, myTask.FilesPathes, myTask.IsArchived);
                myCategory.CategoryTasks.Add(n);
                cmbTaskFiles.Items.Clear();
                cmbTaskFiles.SelectedIndex = -1;
                fill_lstviwTask();
                rchtxtTaskDescription.Text = string.Empty;
                txtTaskName.Text = string.Empty;
                rdbtnNo.Checked = false;
                rdbtnYes.Checked = false;
                rdbtnNotAssginedTask.Checked = false;
                rdbtnRunningTask.Checked = false;
                rdbtnDoneTask.Checked = false;
                rchtxtTaskDescription_Leave(this, new EventArgs());
                txtTaskName_Leave(this, new EventArgs());
            }
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if ((cmbTeamTask.SelectedIndex == -1) || (cmbCategoryTask.SelectedIndex == -1) || rchtxtTaskDescription.Text == "           Task Description" || String.IsNullOrEmpty(rchtxtTaskDescription.Text)|| txtTaskName.Text == "Task Name" || String.IsNullOrEmpty(txtTaskName.Text))
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else
            {
                checkValidTask();
            }
        }
        private void UpdateEmpsListOfTask()
        {
            myTask.Employees.Clear();
            for (int i = 0; i < chcklstbxTaskEmployee.Items.Count; i++)
            {
                string EmpName = chcklstbxTaskEmployee.Items[i].ToString();
                bool Added = false;
                for (int j = 0; j < myTeam.TeamEmployees.Count && !Added; j++)
                {
                    if (myTeam.TeamEmployees[j].Name == EmpName)
                    {
                        myTask.Employees.Add(myTeam.TeamEmployees[j]);
                        Added = true;
                    }
                }
            }
        }
        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            if ((cmbTeamTask.SelectedIndex == -1) || (cmbCategoryTask.SelectedIndex == -1) || rchtxtTaskDescription.Text == "           Task Description" || String.IsNullOrEmpty(rchtxtTaskDescription.Text) || txtTaskName.Text == "Task Name" || String.IsNullOrEmpty(txtTaskName.Text))
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else
            {
                for (int i = 0; i < myCategory.CategoryTasks.Count; i++)
                    if (myTask.ID == myCategory.CategoryTasks[i].ID)
                        myCategory.CategoryTasks[i] = new Task(myTask);
                fill_lstviwTask();
                if (grbxAssginToEmployee.Visible)
                {
                    UpdateEmpsListOfTask();
                }
                rchtxtTaskDescription.Text = string.Empty;
                txtTaskName.Text = string.Empty;
                rdbtnNo.Checked = false;
                rdbtnYes.Checked = false;
                rdbtnNotAssginedTask.Checked = false;
                rdbtnRunningTask.Checked = false;
                rdbtnDoneTask.Checked = false;
                rchtxtTaskDescription_Leave(this, new EventArgs());
                txtTaskName_Leave(this, new EventArgs());
            }
        }
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if ((cmbTeamTask.SelectedIndex == -1) || (cmbCategoryTask.SelectedIndex == -1) || rchtxtTaskDescription.Text == "           Task Description" || String.IsNullOrEmpty(rchtxtTaskDescription.Text) || txtTaskName.Text == "Task Name" || String.IsNullOrEmpty(txtTaskName.Text))
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else
            {
                ClearCheckBox();
                for (int i = 0; i < myCategory.CategoryTasks.Count; i++)
                    if (myTask.ID == myCategory.CategoryTasks[i].ID)
                        myCategory.CategoryTasks.RemoveAt(i);
                fill_lstviwTask();
                rchtxtTaskDescription.Text = string.Empty;
                txtTaskName.Text = string.Empty;
                rdbtnNo.Checked = false;
                rdbtnYes.Checked = false;
                rdbtnNotAssginedTask.Checked = false;
                rdbtnRunningTask.Checked = false;
                rdbtnDoneTask.Checked = false;
                rchtxtTaskDescription_Leave(this, new EventArgs());
                txtTaskName_Leave(this, new EventArgs());
            }
        }
        public void fill_lstviwTask()
        {
            lstviwTask.Items.Clear();
            foreach (Task tt in myCategory.CategoryTasks)
            {
                ListViewItem it = new ListViewItem(tt.Name);
                it.SubItems.Add(tt.Description);
                it.SubItems.Add(tt.DeadLine.Date.ToString());
                it.SubItems.Add(tt.Status.ToString());
                it.SubItems.Add(tt.IsArchived.ToString());

                lstviwTask.Items.Add(it);
            }
        }
        private void fill_cmbCategoryTask()
        {
            cmbCategoryTask.Items.Clear();
            foreach (Category c in myTeam.TeamCategories)
            {
                if (!cmbCategoryTask.Items.Contains(c.Title.ToString()))
                    cmbCategoryTask.Items.Add(c.Title.ToString());
            }

        }
        private void fill_cmbTeamTask()
        {
            cmbTeamTask.Items.Clear();
            foreach (Team t in Program.Teams)
            {
                if (!cmbTeamTask.Items.Contains(t.Name.ToString()))
                    cmbTeamTask.Items.Add(t.Name.ToString());
            }
        }
        private void dtDeadLineTask_ValueChanged(object sender, EventArgs e)
        {
            myTask.DeadLine = dtDeadLineTask.Value;
        }
        /*End Task*/

        /*Start SubTask*/
        private void fill_cmbTeamSubTask()
        {
            cmbTeamSubTask.Items.Clear();
            foreach (Team t in Program.Teams)
            {
                if (!cmbTeamSubTask.Items.Contains(t.Name.ToString()))
                    cmbTeamSubTask.Items.Add(t.Name.ToString());
            }
        }
        private void fill_cmbCategorySubTask()
        {
            cmbCategorySubTask.Items.Clear();
            foreach (Category c in myTeam.TeamCategories)
            {
                if (!cmbCategorySubTask.Items.Contains(c.Title.ToString()))
                    cmbCategorySubTask.Items.Add(c.Title.ToString());
            }
        }
        private void fill_cmbTaskSubTask()
        {
            cmbTaskSubTask.Items.Clear();
            foreach (Task t in myCategory.CategoryTasks)
            {
                if (!cmbTaskSubTask.Items.Contains(t.Name.ToString()))
                    cmbTaskSubTask.Items.Add(t.Name.ToString());
            }
        }
        public void fill_cmbAssginTo()
        {
            cmbAssginTo.Items.Clear();
            foreach (Employee e in myTask.Employees)
                cmbAssginTo.Items.Add(e.Name);
        }
        public void fill_lstviwSubTask()
        {
            lstviwSubTask.Items.Clear();
            foreach (SubTask tt in myTask.SubTasks)
            {
                ListViewItem it = new ListViewItem(tt.Name);
                it.SubItems.Add(tt.Description);
                it.SubItems.Add(tt.DeadLine.Date.ToString());
                it.SubItems.Add(tt.Status.ToString());
                it.SubItems.Add(tt.Employee.Name);
                lstviwSubTask.Items.Add(it);
            }
        }
        private void lstviwSubTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (SubTask t in myTask.SubTasks)
                if (t.Name == lstviwSubTask.Items[lstviwSubTask.FocusedItem.Index].SubItems[0].Text)
                    mySubTask = new SubTask(t);
            txtSubTaskName.Text = mySubTask.Name;
            rchtxtSubTaskDescription.Text = mySubTask.Description;
            dtDeadLineSubTask.Text = mySubTask.DeadLine.Date.ToString();
            switch (Enum.GetName(typeof(Status), mySubTask.Status))
            {
                case "NotAssigned":
                    rdbtnNotAssignedSubTask.Checked = true;
                    break;
                case "Running":
                    rdbtnRunningSubTaskStatus.Checked = true;
                    break;
                case "Done":
                    rdbtnDoneSubTaskStatus.Checked = true;
                    break;
            }
            fill_cmbAssginTo();
        }
        private void txtSubTaskName_TextChanged(object sender, EventArgs e)
        {
            if (txtSubTaskName.Text == string.Empty)
                return;
            mySubTask.Name = txtSubTaskName.Text;
        }
        private void dtDeadLineSubTask_ValueChanged(object sender, EventArgs e)
        {
            mySubTask.DeadLine = dtDeadLineSubTask.Value;
        }
        private void cmbAssginTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySubTask.Employee = Program.systemEmployees.Find(emp => emp.Name == cmbAssginTo.SelectedItem.ToString());
        }
        private void rdbtnNotAssignedSubTask_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnNotAssignedSubTask.Checked)
                mySubTask.Status = Status.NotAssigned;
        }
        private void rdbtnRunningSubTaskStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnRunningSubTaskStatus.Checked)
                mySubTask.Status = Status.Running;
        }
        private void rdbtnDoneSubTaskStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDoneSubTaskStatus.Checked)
                mySubTask.Status = Status.Done;
        }
        private void cmbTaskSubTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Task t in myCategory.CategoryTasks)
            {
                if (t.Name == cmbTaskSubTask.SelectedItem as string)
                    myTask = t;
            }
            fill_cmbAssginTo();
            fill_lstviwSubTask();
        }
        private void cmbTeamSubTask_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            foreach (Team t in Program.Teams)
            {
                if (t.Name == cmbCategorySubTask.SelectedItem as string)
                    myTeam = t;
            }
            lstviwSubTask.Items.Clear();
            cmbCategorySubTask.SelectedIndex = -1;
            cmbTaskSubTask.SelectedIndex = -1;
            fill_cmbCategorySubTask();
        }
        private void cmbCategorySubTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Category c in myTeam.TeamCategories)
            {
                string cName = Enum.GetName(typeof(CategoryTitle), c.Title);
                if (cName == cmbCategorySubTask.SelectedItem as string)
                    myCategory = c;
            }
            lstviwSubTask.Items.Clear();
            cmbTaskSubTask.SelectedIndex = -1;
            fill_cmbTaskSubTask();
        }
        private void checkValidSubTask()
        {
            int parsedValue;
            if (int.TryParse(txtSubTaskName.Text, out parsedValue))
            {
                MessageBox.Show("This Filed Start With Char !");
                txtSubTaskName.ForeColor = Color.Red;
                return;
            }
            else if (int.TryParse(rchtxtSubTaskDescription.Text, out parsedValue))
            {
                MessageBox.Show("This Filed Start With Char !");
                rchtxtSubTaskDescription.ForeColor = Color.Red;
                return;
            }
            else
            {
                SubTask n = new SubTask(mySubTask.Name, mySubTask.Description, mySubTask.Employee, mySubTask.DeadLine, mySubTask.Status);
                myTask.SubTasks.Add(n);
                fill_lstviwSubTask();
            }
        }
        private void btnAddSubTask_Click(object sender, EventArgs e)
        {
            if ((cmbTeamSubTask.SelectedIndex == -1)|| (cmbAssginTo.SelectedIndex == -1) || (cmbCategorySubTask.SelectedIndex == -1)|| (cmbTaskSubTask.SelectedIndex == -1) || rchtxtSubTaskDescription.Text == "SubTask  Description" || String.IsNullOrEmpty(rchtxtSubTaskDescription.Text) || txtSubTaskName.Text == "SubTask Name" || String.IsNullOrEmpty(txtSubTaskName.Text))
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else
            {
                checkValidSubTask();
            }

        }
        private void btnUpdateSubTask_Click(object sender, EventArgs e)
        {
            if ((cmbTeamSubTask.SelectedIndex == -1) || (cmbAssginTo.SelectedIndex == -1) || (cmbCategorySubTask.SelectedIndex == -1) || (cmbTaskSubTask.SelectedIndex == -1) || rchtxtSubTaskDescription.Text == "SubTask  Description" || String.IsNullOrEmpty(rchtxtSubTaskDescription.Text) || txtSubTaskName.Text == "SubTask Name" || String.IsNullOrEmpty(txtSubTaskName.Text))
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else
            {
                for (int i = 0; i < myTask.SubTasks.Count; i++)
                    if (mySubTask.ID == myTask.SubTasks[i].ID)
                        myTask.SubTasks[i] = new SubTask(mySubTask);
                fill_lstviwSubTask();
                //check Task with subtask status
                    int counter = 0;
                    for (int j = 0; j <myTask.SubTasks.Count; j++)
                    { 
                        if (myTask.SubTasks[j].Status == Status.Done)
                        {
                            counter++;
                        }
                    }
                if (counter == myTask.SubTasks.Count)
                    myTask.Status = Status.Done;    
            }
        }
        private void btnDeleteSubTask_Click(object sender, EventArgs e)
        {
            if ((cmbTeamSubTask.SelectedIndex == -1) || (cmbAssginTo.SelectedIndex == -1) || (cmbCategorySubTask.SelectedIndex == -1) || (cmbTaskSubTask.SelectedIndex == -1) || rchtxtSubTaskDescription.Text == "SubTask  Description" || String.IsNullOrEmpty(rchtxtSubTaskDescription.Text) || txtSubTaskName.Text == "SubTask Name" || String.IsNullOrEmpty(txtSubTaskName.Text))
            {
                MessageBox.Show("Please Enter your data , * is required data !");
            }
            else
            {
                for (int i = 0; i < myTask.SubTasks.Count; i++)
                    if (mySubTask.ID == myTask.SubTasks[i].ID)
                        myTask.SubTasks.RemoveAt(i);
                fill_lstviwSubTask();
            }
        }
        private void rchtxtSubTaskDescription_TextChanged_2(object sender, EventArgs e)
        {
            if (rchtxtSubTaskDescription.Text == string.Empty)
                return;
            mySubTask.Description = rchtxtSubTaskDescription.Text;
        }

        private void lblTeamSubTask_Click(object sender, EventArgs e)
        {

        }
        /*End SubTask*/
    }
}
