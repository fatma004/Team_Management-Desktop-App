
namespace task_project
{
    partial class frmCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.lstviwCategory = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDeleteCategory.Location = new System.Drawing.Point(529, 309);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(159, 31);
            this.btnDeleteCategory.TabIndex = 5;
            this.btnDeleteCategory.Text = "Delete Category";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.AccessibleName = "";
            this.btnUpdateCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateCategory.Location = new System.Drawing.Point(346, 310);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(177, 30);
            this.btnUpdateCategory.TabIndex = 6;
            this.btnUpdateCategory.Text = "Update Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnNext.Location = new System.Drawing.Point(688, 364);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(123, 61);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Task ->";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cmbTitle
            // 
            this.cmbTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(103, 90);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(176, 21);
            this.cmbTitle.TabIndex = 10;
            this.cmbTitle.SelectedIndexChanged += new System.EventHandler(this.cmbTitle_SelectedIndexChanged);
            // 
            // lstviwCategory
            // 
            this.lstviwCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Description});
            this.lstviwCategory.FullRowSelect = true;
            this.lstviwCategory.GridLines = true;
            this.lstviwCategory.HideSelection = false;
            this.lstviwCategory.Location = new System.Drawing.Point(555, 117);
            this.lstviwCategory.MultiSelect = false;
            this.lstviwCategory.Name = "lstviwCategory";
            this.lstviwCategory.Size = new System.Drawing.Size(184, 172);
            this.lstviwCategory.TabIndex = 16;
            this.lstviwCategory.UseCompatibleStateImageBehavior = false;
            this.lstviwCategory.View = System.Windows.Forms.View.Details;
            this.lstviwCategory.SelectedIndexChanged += new System.EventHandler(this.lstviwCategory_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 76;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Title :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Team :";
            // 
            // cmbTeam
            // 
            this.cmbTeam.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(75, 11);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(120, 21);
            this.cmbTeam.TabIndex = 19;
            this.cmbTeam.SelectedIndexChanged += new System.EventHandler(this.cmbTeam_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDescription.Location = new System.Drawing.Point(43, 133);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(243, 106);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.Text = "Description Of Category";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(176, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add Category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBack.Location = new System.Drawing.Point(-7, 364);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 59);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "<- Team";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.label3);
            this.pnlAdmin.Controls.Add(this.cmbTeam);
            this.pnlAdmin.Location = new System.Drawing.Point(555, 76);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(200, 35);
            this.pnlAdmin.TabIndex = 23;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(803, 418);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstviwCategory);
            this.Controls.Add(this.cmbTitle);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Name = "frmCategory";
            this.Tag = "";
            this.Text = "Add Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.ListView lstviwCategory;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlAdmin;
    }
}

