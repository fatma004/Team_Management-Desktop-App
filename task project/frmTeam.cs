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
    public partial class frmTeam : Form
    {
        Team myTeam;
        frmCategory fr;
        bool isAdmin;
        public frmTeam(bool IsAdmin)
        {
            InitializeComponent();
            FillListViewTeams();
            myTeam = new Team();
            isAdmin = IsAdmin;
            if (!isAdmin) pnlAdmin.Visible=false;

        }

        private void change(object sender, EventArgs e)
        {

            myTeam = fr.myTeam;
            //MessageBox.Show(fr.myTeam.Name);
            for (int i = 0; i < lstViwTeams.Items.Count; i++)
            {
                if (lstViwTeams.Items[i].SubItems[0].Text.ToString() == myTeam.Name)
                {
                    lstViwTeams.Items[i].Selected = true;

                }
                else
                {
                    lstViwTeams.Items[i].Selected = false;
                }
            }
        }

        private void ClearCheckBoxs()
        {
            if (chckLstBxSystemEmps.Items.Count > 0)
            {
                chckLstBxSystemEmps.Items.Clear();
            }
            if (chckLstBxTeamEmps.Items.Count > 0)
            {
                chckLstBxTeamEmps.Items.Clear();
            }
        }
        private void txtTeamName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTeamName_Enter_1(object sender, EventArgs e)
        {
            if (txtTeamName.Text == "Name")
            {
                txtTeamName.Text = "";
                txtTeamName.ForeColor = Color.Black;
            }
        }

        private void txtTeamName_Leave_1(object sender, EventArgs e)
        {
            if (txtTeamName.Text == "")
            {
                txtTeamName.Text = "Name";
                txtTeamName.ForeColor = Color.Silver;
            }
        }

        private void txtTeamDesc_Enter(object sender, EventArgs e)
        {
            if (txtTeamDesc.Text == "Description")
            {
                txtTeamDesc.Text = "";
                txtTeamDesc.ForeColor = Color.Black;
            }
        }

        private void txtTeamDesc_Leave(object sender, EventArgs e)
        {
            if (txtTeamDesc.Text == "")
            {
                txtTeamDesc.Text = "Description";
                txtTeamDesc.ForeColor = Color.Silver;
            }
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            ClearCheckBoxs();
            Team team = new Team(txtTeamName.Text, txtTeamDesc.Text);
            Program.Teams.Add(team);
            ListViewItem item = new ListViewItem(txtTeamName.Text);
            item.SubItems.Add(txtTeamDesc.Text);
            lstViwTeams.Items.Add(item);
        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
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
            for (int i = 0; i < lstViwTeams.Items.Count && !Deleted; i++)
            {
                if (lstViwTeams.Items[i].Selected)
                {
                    txtTeamName.Text = string.Empty;
                    txtTeamDesc.Text = string.Empty;
                    lstViwTeams.Items[i].Remove();
                    Deleted = true;
                }
            }
        }

        private void frmTeam_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {
            lstViwTeams.SelectedItems[0].SubItems[0].Text = myTeam.Name;
            lstViwTeams.SelectedItems[0].SubItems[1].Text = myTeam.Description;
            if (grBxAddEmpToTeam.Visible)
            {
                UpdateEmpsListOfTeam();
            }
        }
        private void DisplayEmpsTeamAndEmpsSystemInCheckBoxs()
        {
            for (int i = 0; i < Program.SystemEmployees.Count; i++)
            {
                Employee E = Program.SystemEmployees[i];
                bool found = false;
                for (int j = 0; j < myTeam.TeamEmployees.Count && !found; j++)
                {
                    if (myTeam.TeamEmployees[j].Name == E.Name)
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    chckLstBxSystemEmps.Items.Add(Program.SystemEmployees[i].Name);
                }
            }
            chckLstBxTeamEmps.Items.AddRange(myTeam.TeamEmployees.ToArray());
        }
        private void FillListViewTeams()
        {
            for (int i = 0; i < Program.Teams.Count; i++)
            {
                ListViewItem item = new ListViewItem(Program.Teams[i].Name);
                item.SubItems.Add(Program.Teams[i].Description);
                lstViwTeams.Items.Add(item);
            }
        }

        private void lstViwTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (lstViwTeams.SelectedItems.Count == 0) return;
            myTeam = null;
            string selectedIteamName= lstViwTeams.SelectedItems[0].SubItems[0].Text.ToString();
            for (int i = 0; i < Program.Teams.Count && myTeam == null; i++) 
            {
                if(Program.Teams[i].Name== selectedIteamName)
                {
                    myTeam = Program.Teams[i];
                }
            }
            ClearCheckBoxs();
            txtTeamName.Text = myTeam.Name;
            txtTeamDesc.Text = myTeam.Description;
            if (grBxAddEmpToTeam.Visible)
            {
                DisplayEmpsTeamAndEmpsSystemInCheckBoxs();
            }

        }

        private void UpdateEmpsListOfTeam()
        {
           myTeam.TeamEmployees.Clear();
            for(int i = 0; i < chckLstBxTeamEmps.Items.Count; i++)
            {
                string EmpName= chckLstBxTeamEmps.Items[i].ToString();
                bool Added = false;
                for (int j = 0; j < Program.SystemEmployees.Count && !Added; j++) 
                {
                    if (Program.SystemEmployees[j].Name == EmpName)
                    {
                        myTeam.TeamEmployees.Add(Program.SystemEmployees[j]);
                        Added=true;
                    }
                }
            }
        }

        private void btnAddEmpsToTeam_Click(object sender, EventArgs e)
        {
            ClearCheckBoxs();
            grBxAddEmpToTeam.Visible = true;
            DisplayEmpsTeamAndEmpsSystemInCheckBoxs();
            
        }

        private void btnAddTempToTeam_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chckLstBxSystemEmps.Items.Count; i++)
            {
                if (chckLstBxSystemEmps.GetItemChecked(i))
                {
                    string EmpName = chckLstBxSystemEmps.Items[i].ToString();
                    chckLstBxTeamEmps.Items.Add(EmpName);
                    chckLstBxSystemEmps.Items.Remove(chckLstBxSystemEmps.Items[i]);
                    i--;
                }
            }
        }

        private void btnDelteEmpFromTeam_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chckLstBxTeamEmps.Items.Count; i++)
            {
                if (chckLstBxTeamEmps.GetItemChecked(i))
                {
                    string EmpName = chckLstBxTeamEmps.Items[i].ToString();
                    chckLstBxSystemEmps.Items.Add(EmpName);
                    chckLstBxTeamEmps.Items.Remove(chckLstBxTeamEmps.Items[i]);
                    i--;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ClearCheckBoxs();
            grBxAddEmpToTeam.Visible = false;
        }


        private void frmTeam_Load(object sender, EventArgs e)
        {

        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            fr = new frmCategory(isAdmin,myTeam);
            fr.CategoryEvt += change;
            fr.ShowDialog();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ChckLstBxSystemEmps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
   


