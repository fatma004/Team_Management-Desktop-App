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
     partial class frmSubTask : Form
    {
        public Team myTeam;
        public Category myCategory;
        public Task myTask;
        SubTask mySubTask;
        bool isAdmin;
        public event EventHandler SubTaskEvt;


        public frmSubTask(bool IsAdmin,Team tm,Category ct,Task tsk)
        {
            InitializeComponent();   
            myTeam = tm;
            myCategory = ct;
            myTask = tsk;
            FillCmbTeams();
            FillCmbCategories();
            FillCmbTasks();
            cmbTeams.SelectedItem = myTeam.Name;
            cmbCategories.SelectedItem = myCategory.Title.ToString();
            cmbTasks.SelectedItem = myTask.Name;
            isAdmin = IsAdmin;
            if (!isAdmin) pnlAdmin.Visible = false;

        }
        private void FillCmbTeams()
        {
            cmbTeams.Items.Clear();
            foreach (Team t in Program.Teams)
                cmbTeams.Items.Add(t.Name);
        }
        private void FillCmbCategories()
        {
            cmbCategories.Items.Clear();
            foreach (Category c in myTeam.TeamCategories)
            {
                string cName = Enum.GetName(typeof(CategoryTitle), c.Title);
                cmbCategories.Items.Add(cName);
            }
        }
        private void FillCmbTasks()
        {
            cmbTasks.Items.Clear();
            
            foreach (Task t in myCategory.CategoryTasks)
            {
               
                cmbTasks.Items.Add(t.Name);
            }
        }
        public void FillCmbParentTaskEmployees()
        {
            cmbEmployees.Items.Clear();
            foreach (Employee e in myTask.Employees)
                cmbEmployees.Items.Add(e.Name);
        }
        public void FillSubTaskView()
        {
            lstViwSubTasks.Items.Clear();
            foreach (SubTask tt in myTask.SubTasks)
            {
                ListViewItem it = new ListViewItem(tt.Name);
                it.SubItems.Add(tt.Description);
                it.SubItems.Add(tt.DeadLine.Date.ToString());
                it.SubItems.Add(tt.Status.ToString());
               

                lstViwSubTasks.Items.Add(it);
            }


        }
        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (SubTask t in myTask.SubTasks)
                if (t.Name == lstViwSubTasks.Items[lstViwSubTasks.FocusedItem.Index].SubItems[0].Text)
                    mySubTask = new SubTask(t);

            txtSubTaskName.Text = mySubTask.Name;
            rchTxtSubTaskDescription.Text = mySubTask.Description;
            dtePckrSubTaskDeadLine.Text = mySubTask.DeadLine.Date.ToString();
            switch (Enum.GetName(typeof(Status), myTask.Status))
            {
                case "NotAssigned":
                    rBtnNotAssignedSubTask.Checked = true;
                    break;
                case "Running":
                    rBtnRunningSubTask.Checked = true;
                    break;
                case "Done":
                    rBtnDoneSubTask.Checked = true;
                    break;

            }
            FillCmbParentTaskEmployees();

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubTask_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        //update
        private void Button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myTask.SubTasks.Count; i++)
                if (mySubTask.ID == myTask.SubTasks[i].ID)
                    myTask.SubTasks[i] = mySubTask;
            FillSubTaskView();
        }

        private void TxtSubTaskName_TextChanged(object sender, EventArgs e)
        {
            mySubTask.Name = txtSubTaskName.Text;
        }

        private void BtnAddSubTask_Click(object sender, EventArgs e)
        {
            SubTask n = new SubTask(mySubTask.Name, mySubTask.Description, mySubTask.Employee, mySubTask.DeadLine, mySubTask.Status);

            
            myTask.SubTasks.Add(n);
            FillSubTaskView();

        }

        private void RchTxtSubTaskDescription_TextChanged(object sender, EventArgs e)
        {
            rchTxtSubTaskDescription.Text = mySubTask.Description;
        }

        private void DtePckrSubTaskDeadLine_ValueChanged(object sender, EventArgs e)
        {
            mySubTask.DeadLine = dtePckrSubTaskDeadLine.Value;
        }

        private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySubTask.Employee = cmbEmployees.SelectedItem as Employee;
        }

        private void RBtnNotAssignedSubTask_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnNotAssignedSubTask.Checked)
                mySubTask.Status = Status.NotAssigned;
        }

        private void RBtnRunningSubTask_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnRunningSubTask.Checked)
                mySubTask.Status = Status.Running;
        }

        private void RBtnDoneSubTask_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnDoneSubTask.Checked)
                mySubTask.Status = Status.Done;

        }

        private void CmbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Task t in myCategory.CategoryTasks)
            {
                
                if (t.Name == cmbTasks.SelectedItem as string)
                    myTask=t;
            }
            FillCmbParentTaskEmployees();
            FillSubTaskView();
        }

        private void BtnDeleteSubTask_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myTask.SubTasks.Count; i++)
                if (mySubTask.ID == myTask.SubTasks[i].ID)
                    myTask.SubTasks.RemoveAt(i);
        
            FillSubTaskView();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CmbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Team t in Program.Teams)
            {
                if (t.Name == cmbTeams.SelectedItem as string)
                    myTeam = t;
            }
          
            FillCmbCategories();
            
        }

        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Category c in myTeam.TeamCategories)
            {
                string cName = Enum.GetName(typeof(CategoryTitle), c.Title);
                if (cName == cmbCategories.SelectedItem as string)
                    myCategory = c;
            }
            FillCmbTasks();



        }

        private void BtnBackToTask_Click(object sender, EventArgs e)
        {
            
            SubTaskEvt(this, new EventArgs());
            this.Close();


        }
    }
}
