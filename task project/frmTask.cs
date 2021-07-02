using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace task_project
{
    partial class frmTask : Form
    {
       
        public Team myTeam;
        public Category myCategory;
        public Task myTask;
        public bool isAdmin;
        public event EventHandler TaskEvt;
        frmSubTask f ;

        public frmTask(bool IsAdmin,Team t,Category c)
        {
            InitializeComponent();
            myTask = new Task();
            myTeam = t;
            myCategory = c;
            FillCmbTeams();
            cmbTeams.SelectedItem = myTeam.Name;
            FillCmbCategories();
            cmbTeamCategories.SelectedItem = myCategory.Title.ToString();
            FillTaskView();
            isAdmin = IsAdmin;
            if (!isAdmin) cmbTeams.Visible = false;
          
        }
     
        private void FillChckLstBxTaskEmployees()
        {
            chckLstBxTaskEmployees.Items.Clear();
            foreach (Employee e in myTask.Employees)
                chckLstBxTaskEmployees.Items.Add(e.Name);
        }
        private void FillChckLstBxSystemEmployees()
        {
            chckLstBxSystemEmployees.Items.Clear();
            foreach (Employee e in Program.SystemEmployees)
                chckLstBxSystemEmployees.Items.Add(e.Name);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myCategory.CategoryTasks.Count; i++)
                if (myTask.ID == myCategory.CategoryTasks[i].ID)
                    myCategory.CategoryTasks[i] =new Task( myTask);
            myTask = null;
            FillTaskView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myCategory.CategoryTasks.Count; i++)
                if (myTask.ID == myCategory.CategoryTasks[i].ID)
                    myCategory.CategoryTasks.RemoveAt(i);
            FillTaskView();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAssignEmployees_Click(object sender, EventArgs e)
        {
            FillChckLstBxTaskEmployees();
            FillChckLstBxSystemEmployees();
            grBxAssignToEmployees.Visible = true;
            btnAssignEmployees.Visible = false;
        }

        private void FillCmbFiles()
        {
            cmbTaskFiles.Items.Clear();
            foreach(string s in myTask.FilesPathes)
            cmbTaskFiles.Items.Add(Path.GetFileName(s));
        }
        private void BtnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            FD.Filter = "PDF|*.pdf";//|JPG|*.jpg|PNG|*.png";
            if (FD.ShowDialog() == DialogResult.OK)
                myTask.FilesPathes.Add(FD.FileName); //path stored with name  "C:/hhhh/hhhh/hhhh/n.png"
            FillCmbFiles();                                         
        }
        private void FillCmbTeams()
        {
            cmbTeams.Items.Clear();
            foreach (Team t in Program.Teams)
                cmbTeams.Items.Add(t.Name);
        }
        private void FillCmbCategories()
        {
            cmbTeamCategories.Items.Clear();
            foreach (Team t in Program.Teams)
            {
                if (t.Name == cmbTeams.SelectedItem as string)
                    myTeam = t;
            }
           
            foreach (Category c in myTeam.TeamCategories)
            {
                string cName = Enum.GetName(typeof(CategoryTitle),c.Title);
                cmbTeamCategories.Items.Add(cName);
            }
        }
        public void FillTaskView()
        {
                    lstViwTasks.Items.Clear();
                    foreach (Task tt in myCategory.CategoryTasks)
                    {
                        ListViewItem it = new ListViewItem(tt.Name);
                        it.SubItems.Add(tt.Description);
                        it.SubItems.Add(tt.DeadLine.Date.ToString());
                        it.SubItems.Add(tt.Status.ToString());
                        it.SubItems.Add(tt.IsArchived.ToString());
                       
                        lstViwTasks.Items.Add(it);
                    }
                
            
        }
            private void LstViwTasks_SelectedIndexChanged(object sender, EventArgs e)
            {
                 
            }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            
            Task n=new Task(myTask.Name, myTask.Description, myTask.SubTasks, myTask.Employees, myTask.DeadLine, myTask.Status, myTask.FilesPathes, myTask.IsArchived);

            myCategory.CategoryTasks.Add(n);
            FillTaskView();
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

        private void CmbTeamCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Category c in myTeam.TeamCategories)
            {
                string cName = Enum.GetName(typeof(CategoryTitle), c.Title);
                if (cName == cmbTeamCategories.SelectedItem as string)
                    myCategory = c;
            }
            FillTaskView();
        }

        private void CmbTaskFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri(myTask.FilesPathes[cmbTaskFiles.SelectedIndex]));

        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void BtnEmpFromTask_Click(object sender, EventArgs e)
        {
            int myCount = chckLstBxTaskEmployees.CheckedItems.Count;
            for (int c = myCount - 1; c >= 0; c--)
            {
                string s = chckLstBxTaskEmployees.CheckedItems[c] as string;
                chckLstBxSystemEmployees.Items.Add(s);
                chckLstBxTaskEmployees.Items.Remove(s);
                for (int i=0;i<myTask.Employees.Count;i++)
                    if (myTask.Employees[i].Name == s) myTask.Employees.RemoveAt(i);
            }
        }

        private void BtnEmpToTask_Click(object sender, EventArgs e)
        {
            int myCount = chckLstBxSystemEmployees.CheckedItems.Count;
            for (int c = myCount - 1; c >= 0; c--)
            {
                string s = chckLstBxSystemEmployees.CheckedItems[c] as string;
                chckLstBxTaskEmployees.Items.Add(s);
                chckLstBxSystemEmployees.Items.Remove(s);
                for (int i = 0; i < Program.SystemEmployees.Count; i++)
                {
                    if (Program.SystemEmployees[i].Name == s && !myTask.Employees.Contains(Program.SystemEmployees[i]))
                            myTask.Employees.Add(Program.SystemEmployees[i]);
                }
            }
        }

        private void RBtnArchived_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnArchived.Checked) myTask.IsArchived = true;
        }

        private void RBtnNotArchived_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnNotArchived.Checked) myTask.IsArchived = false;
        }

        private void RBtnStsNotAssigned_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnStsNotAssigned.Checked)
                myTask.Status = Status.NotAssigned;
        }

        private void RBtnStsRunning_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnStsRunning.Checked)
                myTask.Status = Status.Running;
        }

        private void RBtnStsDone_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnStsDone.Checked)
                myTask.Status = Status.Done;
        }

        private void LstViwTasks_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstViwTasks.SelectedItems.Count > 0)
            {
                foreach (Task t in myCategory.CategoryTasks)
                    if (t.Name == lstViwTasks.Items[lstViwTasks.FocusedItem.Index].SubItems[0].Text)
                        myTask = new Task(t);
            }

            txtTaskName.Text = myTask.Name;
            rchTxtTaskDescription.Text = myTask.Description;
            dtePckrTaskDeadline.Text = myTask.DeadLine.Date.ToString();
            switch (Enum.GetName(typeof(Status), myTask.Status)){
                case "NotAssigned":
                    rBtnStsNotAssigned.Checked = true;
                    break;
                case "Running":
                    rBtnStsRunning.Checked = true;
                    break;
                case "Done":
                    rBtnStsDone.Checked = true;
                    break;

            }
            switch( myTask.IsArchived)
            {
                case true:
                    rBtnArchived.Checked = true;
                    break;
                case false:
                    rBtnNotArchived.Checked = true;
                    break;
            }
            FillCmbFiles();
            FillChckLstBxSystemEmployees();
            FillChckLstBxTaskEmployees();

          
        }
        public void change(object t, EventArgs e)
        {
            myTeam = f.myTeam;
            cmbTeams.SelectedItem = myTeam.Name;
            myCategory = f.myCategory;
            cmbTeamCategories.SelectedItem = myCategory.Title.ToString();
            myTask = f.myTask;
            try
            {
                for (int i = 0; i < lstViwTasks.Items.Count; i++)
                {
                    if (lstViwTasks.Items[i].SubItems[0].Text == myTask.Name)
                    {
                        lstViwTasks.Items[i].Selected = true;
                        lstViwTasks.Focus();

                    }
                    else
                    {
                        lstViwTasks.Items[i].Selected = false;
                    }
                }
            }
            catch{ }
            this.TopMost = true;
        }
        private void LnkLblAddSubTask_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            f = new frmSubTask(isAdmin,myTeam, myCategory, myTask);
            f.SubTaskEvt += change;
            f.Show();
            this.TopMost = false;
            f.TopMost = true;
        }

        private void TxtTaskName_TextChanged(object sender, EventArgs e)
        {
            myTask.Name = txtTaskName.Text;
        }

        private void RchTxtTaskDescription_TextChanged(object sender, EventArgs e)
        {
            myTask.Description = rchTxtTaskDescription.Text;
        }

        private void DtePckrTaskDeadline_ValueChanged(object sender, EventArgs e)
        {
            myTask.DeadLine = dtePckrTaskDeadline.Value ;
        }

        private void ChckLstBxTaskEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            f = new frmSubTask(isAdmin,myTeam, myCategory, myTask);
            f.SubTaskEvt += change;
            f.Show();
            this.TopMost = false;
            f.TopMost = true;
        }

        private void BtnOkEmployeeAssigned_Click(object sender, EventArgs e)
        {
            grBxAssignToEmployees.Visible = false;
            btnAssignEmployees.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TaskEvt(this, new EventArgs());

        }

        private void ChckLstBxSystemEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
