namespace task_project
{
    partial class frmTeam
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstViwTeams = new System.Windows.Forms.ListView();
            this.TeamName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.btnUpdateTeam = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.txtTeamDesc = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.btnAddEmpsToTeam = new System.Windows.Forms.Button();
            this.chckLstBxTeamEmps = new System.Windows.Forms.CheckedListBox();
            this.chckLstBxSystemEmps = new System.Windows.Forms.CheckedListBox();
            this.btnAddEmpToTeam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grBxAddEmpToTeam = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDelteEmpFromTeam = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.grBxAddEmpToTeam.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Team";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTeam.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDeleteTeam.Location = new System.Drawing.Point(215, 347);
            this.btnDeleteTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(129, 30);
            this.btnDeleteTeam.TabIndex = 18;
            this.btnDeleteTeam.Text = "Delete Team";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Team:";
            this.label1.Visible = false;
            // 
            // lstViwTeams
            // 
            this.lstViwTeams.AllowDrop = true;
            this.lstViwTeams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TeamName,
            this.TeamDescription});
            this.lstViwTeams.FullRowSelect = true;
            this.lstViwTeams.HideSelection = false;
            this.lstViwTeams.Location = new System.Drawing.Point(7, 53);
            this.lstViwTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstViwTeams.Name = "lstViwTeams";
            this.lstViwTeams.Size = new System.Drawing.Size(315, 262);
            this.lstViwTeams.TabIndex = 16;
            this.lstViwTeams.UseCompatibleStateImageBehavior = false;
            this.lstViwTeams.View = System.Windows.Forms.View.Details;
            this.lstViwTeams.SelectedIndexChanged += new System.EventHandler(this.lstViwTeams_SelectedIndexChanged);
            // 
            // TeamName
            // 
            this.TeamName.Text = "Name";
            this.TeamName.Width = 100;
            // 
            // TeamDescription
            // 
            this.TeamDescription.Text = "Description";
            this.TeamDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TeamDescription.Width = 200;
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Items.AddRange(new object[] {
            "Team1",
            "Team2",
            "Team3",
            "Team4",
            "Team5"});
            this.cmbTeam.Location = new System.Drawing.Point(163, 28);
            this.cmbTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(121, 21);
            this.cmbTeam.TabIndex = 15;
            this.cmbTeam.Visible = false;
            // 
            // btnUpdateTeam
            // 
            this.btnUpdateTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTeam.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateTeam.Location = new System.Drawing.Point(666, 433);
            this.btnUpdateTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateTeam.Name = "btnUpdateTeam";
            this.btnUpdateTeam.Size = new System.Drawing.Size(127, 30);
            this.btnUpdateTeam.TabIndex = 14;
            this.btnUpdateTeam.Text = "Update Team";
            this.btnUpdateTeam.UseVisualStyleBackColor = true;
            this.btnUpdateTeam.Click += new System.EventHandler(this.btnUpdateTeam_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddTeam.Location = new System.Drawing.Point(541, 433);
            this.btnAddTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(119, 30);
            this.btnAddTeam.TabIndex = 13;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // txtTeamDesc
            // 
            this.txtTeamDesc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamDesc.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTeamDesc.Location = new System.Drawing.Point(46, 145);
            this.txtTeamDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTeamDesc.Multiline = true;
            this.txtTeamDesc.Name = "txtTeamDesc";
            this.txtTeamDesc.Size = new System.Drawing.Size(234, 52);
            this.txtTeamDesc.TabIndex = 12;
            this.txtTeamDesc.Text = "Description";
            this.txtTeamDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTeamDesc.Enter += new System.EventHandler(this.txtTeamDesc_Enter);
            this.txtTeamDesc.Leave += new System.EventHandler(this.txtTeamDesc_Leave);
            // 
            // txtTeamName
            // 
            this.txtTeamName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTeamName.Location = new System.Drawing.Point(46, 102);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(234, 27);
            this.txtTeamName.TabIndex = 11;
            this.txtTeamName.Text = " Name";
            this.txtTeamName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTeamName.TextChanged += new System.EventHandler(this.txtTeamName_TextChanged);
            this.txtTeamName.Enter += new System.EventHandler(this.txtTeamName_Enter_1);
            this.txtTeamName.Leave += new System.EventHandler(this.txtTeamName_Leave_1);
            // 
            // btnAddEmpsToTeam
            // 
            this.btnAddEmpsToTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmpsToTeam.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddEmpsToTeam.Location = new System.Drawing.Point(46, 212);
            this.btnAddEmpsToTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmpsToTeam.Name = "btnAddEmpsToTeam";
            this.btnAddEmpsToTeam.Size = new System.Drawing.Size(234, 30);
            this.btnAddEmpsToTeam.TabIndex = 20;
            this.btnAddEmpsToTeam.Text = "Add Employees To Team";
            this.btnAddEmpsToTeam.UseVisualStyleBackColor = true;
            this.btnAddEmpsToTeam.Click += new System.EventHandler(this.btnAddEmpsToTeam_Click);
            // 
            // chckLstBxTeamEmps
            // 
            this.chckLstBxTeamEmps.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckLstBxTeamEmps.ForeColor = System.Drawing.Color.DarkCyan;
            this.chckLstBxTeamEmps.FormattingEnabled = true;
            this.chckLstBxTeamEmps.Location = new System.Drawing.Point(246, 72);
            this.chckLstBxTeamEmps.Name = "chckLstBxTeamEmps";
            this.chckLstBxTeamEmps.Size = new System.Drawing.Size(115, 158);
            this.chckLstBxTeamEmps.TabIndex = 22;
            // 
            // chckLstBxSystemEmps
            // 
            this.chckLstBxSystemEmps.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckLstBxSystemEmps.ForeColor = System.Drawing.Color.DarkCyan;
            this.chckLstBxSystemEmps.FormattingEnabled = true;
            this.chckLstBxSystemEmps.Location = new System.Drawing.Point(10, 72);
            this.chckLstBxSystemEmps.Name = "chckLstBxSystemEmps";
            this.chckLstBxSystemEmps.Size = new System.Drawing.Size(119, 158);
            this.chckLstBxSystemEmps.TabIndex = 23;
            this.chckLstBxSystemEmps.SelectedIndexChanged += new System.EventHandler(this.ChckLstBxSystemEmps_SelectedIndexChanged);
            // 
            // btnAddEmpToTeam
            // 
            this.btnAddEmpToTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmpToTeam.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddEmpToTeam.Location = new System.Drawing.Point(170, 123);
            this.btnAddEmpToTeam.Name = "btnAddEmpToTeam";
            this.btnAddEmpToTeam.Size = new System.Drawing.Size(70, 30);
            this.btnAddEmpToTeam.TabIndex = 24;
            this.btnAddEmpToTeam.Text = ">";
            this.btnAddEmpToTeam.UseVisualStyleBackColor = true;
            this.btnAddEmpToTeam.Click += new System.EventHandler(this.btnAddTempToTeam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(223, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Team Employees :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "System Employees :";
            // 
            // grBxAddEmpToTeam
            // 
            this.grBxAddEmpToTeam.Controls.Add(this.btnOk);
            this.grBxAddEmpToTeam.Controls.Add(this.btnDelteEmpFromTeam);
            this.grBxAddEmpToTeam.Controls.Add(this.chckLstBxTeamEmps);
            this.grBxAddEmpToTeam.Controls.Add(this.label4);
            this.grBxAddEmpToTeam.Controls.Add(this.label3);
            this.grBxAddEmpToTeam.Controls.Add(this.chckLstBxSystemEmps);
            this.grBxAddEmpToTeam.Controls.Add(this.btnAddEmpToTeam);
            this.grBxAddEmpToTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBxAddEmpToTeam.Location = new System.Drawing.Point(12, 260);
            this.grBxAddEmpToTeam.Name = "grBxAddEmpToTeam";
            this.grBxAddEmpToTeam.Size = new System.Drawing.Size(391, 285);
            this.grBxAddEmpToTeam.TabIndex = 27;
            this.grBxAddEmpToTeam.TabStop = false;
            this.grBxAddEmpToTeam.Text = "Add Employees To Team";
            this.grBxAddEmpToTeam.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Cornsilk;
            this.btnOk.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnOk.Location = new System.Drawing.Point(152, 250);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 29);
            this.btnOk.TabIndex = 28;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnDelteEmpFromTeam
            // 
            this.btnDelteEmpFromTeam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelteEmpFromTeam.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDelteEmpFromTeam.Location = new System.Drawing.Point(135, 159);
            this.btnDelteEmpFromTeam.Name = "btnDelteEmpFromTeam";
            this.btnDelteEmpFromTeam.Size = new System.Drawing.Size(78, 30);
            this.btnDelteEmpFromTeam.TabIndex = 27;
            this.btnDelteEmpFromTeam.Text = "<";
            this.btnDelteEmpFromTeam.UseVisualStyleBackColor = true;
            this.btnDelteEmpFromTeam.Click += new System.EventHandler(this.btnDelteEmpFromTeam_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(885, 501);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 65);
            this.button1.TabIndex = 29;
            this.button1.Text = "Category ->";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.label1);
            this.pnlAdmin.Controls.Add(this.cmbTeam);
            this.pnlAdmin.Controls.Add(this.lstViwTeams);
            this.pnlAdmin.Controls.Add(this.btnDeleteTeam);
            this.pnlAdmin.Location = new System.Drawing.Point(590, 49);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(347, 379);
            this.pnlAdmin.TabIndex = 30;
            // 
            // frmTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1009, 560);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grBxAddEmpToTeam);
            this.Controls.Add(this.btnAddEmpsToTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdateTeam);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.txtTeamDesc);
            this.Controls.Add(this.txtTeamName);
            this.Name = "frmTeam";
            this.Text = "Team";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTeam_Load);
            this.Click += new System.EventHandler(this.frmTeam_Click);
            this.grBxAddEmpToTeam.ResumeLayout(false);
            this.grBxAddEmpToTeam.PerformLayout();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstViwTeams;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.Button btnUpdateTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.TextBox txtTeamDesc;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Button btnAddEmpsToTeam;
        private System.Windows.Forms.CheckedListBox chckLstBxTeamEmps;
        private System.Windows.Forms.CheckedListBox chckLstBxSystemEmps;
        private System.Windows.Forms.Button btnAddEmpToTeam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grBxAddEmpToTeam;
        private System.Windows.Forms.ColumnHeader TeamName;
        private System.Windows.Forms.ColumnHeader TeamDescription;
        private System.Windows.Forms.Button btnDelteEmpFromTeam;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlAdmin;
    }
}

