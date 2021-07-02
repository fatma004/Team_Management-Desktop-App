using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;    
using System.Windows.Forms;

namespace task_project
{
    partial class frmCategory : Form
    {
        public Category myCategory;
       // CategoryData mycategoryData;
        public  Team myTeam;
        public event EventHandler CategoryEvt;
        frmTask f;
        bool isAdmin;
        
        public frmCategory(bool IsAdmin,Team tt)
        {
            InitializeComponent();
            myTeam = tt;
            myCategory = new Category();
            isAdmin = IsAdmin;
            //mycategoryData = new CategoryData();
            cmbTitle.DataSource = Enum.GetValues(typeof(CategoryTitle));
            
            foreach (Team t in Program.Teams)
                cmbTeam.Items.Add(t.Name);
            cmbTeam.SelectedItem = myTeam.Name;
            fill_listview();
            if (!isAdmin)
            {
                pnlAdmin.Visible = false;
                
            }
        }
        private void fill_listview()
        {
            lstviwCategory.Items.Clear();
            foreach (Category c in myTeam.TeamCategories)
            {
                ListViewItem it = new ListViewItem(c.Title.ToString());
                it.SubItems.Add(c.Description);


                lstviwCategory.Items.Add(it);
            }
        }
        private void AddItem()
        {
            Category cat = new Category(myCategory.Title, myCategory.Description);
            myTeam.TeamCategories.Add(cat);
            fill_listview();
        }

        public void change(object t, EventArgs e)
        {
            myCategory = f.myCategory;
            myTeam = f.myTeam;
            txtDescription.Text = myCategory.Title.ToString();
            cmbTitle.SelectedItem = myCategory.Title.ToString();
            cmbTeam.SelectedItem = myTeam.Name;
            this.TopMost = true;


        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }
  
        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            AddItem();
            txtDescription.Text = string.Empty;
            cmbTitle.SelectedIndex = -1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            f = new frmTask(isAdmin,myTeam,myCategory);
            f.TaskEvt += change;
            f.Show();
            this.TopMost = false;
            f.TopMost = true;

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myTeam.TeamCategories.Count; i++)
                if (myCategory.ID == myTeam.TeamCategories[i].ID)
                    myTeam.TeamCategories.RemoveAt(i);

            fill_listview();


            txtDescription.Text = string.Empty;
            cmbTitle.SelectedIndex = -1;
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text == "Description Of Category")
            {
                txtDescription.Text = "";
                txtDescription.ForeColor = Color.Black;
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                txtDescription.Text = "Description Of Category";
                txtDescription.ForeColor = Color.Silver;
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myTeam.TeamCategories.Count; i++)
                if (myCategory.ID == myTeam.TeamCategories[i].ID)
                    myTeam.TeamCategories[i] = myCategory;
            fill_listview();
        }

        private void lstviwCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstviwCategory.Items[lstviwCategory.FocusedItem.Index].SubItems.Count > 0)
                    foreach (Category c in myTeam.TeamCategories)
                    {
                        if (c.Title.ToString() == lstviwCategory.Items[lstviwCategory.FocusedItem.Index].SubItems[0].Text)
                            myCategory = new Category(c);
                    }
            }
            catch { }
            cmbTitle.Text = myCategory.Title.ToString();
            txtDescription.Text = myCategory.Description;
        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (cmbTitle.SelectedItem != null)
                myCategory.Title = (CategoryTitle)cmbTitle.SelectedItem;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            myCategory.Description = txtDescription.Text;
        }

        private void cmbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Team t in Program.Teams)
                if (t.Name == cmbTeam.SelectedItem.ToString())
                    myTeam = t;
            fill_listview();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddItem();
            txtDescription.Text = string.Empty;
            cmbTitle.SelectedIndex = -1;
        }

        

        private void Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            CategoryEvt(this, new EventArgs());
        }
    }
}
