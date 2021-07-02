namespace task_project
{
    partial class frmEmployee
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
            this.grBxSystemEmployees = new System.Windows.Forms.GroupBox();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.txtEmpSalary = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmpolyee = new System.Windows.Forms.Button();
            this.lstViwEmployees = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grBxSystemEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBxSystemEmployees
            // 
            this.grBxSystemEmployees.Controls.Add(this.txtEmpPhone);
            this.grBxSystemEmployees.Controls.Add(this.txtEmpSalary);
            this.grBxSystemEmployees.Controls.Add(this.txtEmpName);
            this.grBxSystemEmployees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBxSystemEmployees.ForeColor = System.Drawing.Color.White;
            this.grBxSystemEmployees.Location = new System.Drawing.Point(30, 133);
            this.grBxSystemEmployees.Name = "grBxSystemEmployees";
            this.grBxSystemEmployees.Size = new System.Drawing.Size(241, 235);
            this.grBxSystemEmployees.TabIndex = 20;
            this.grBxSystemEmployees.TabStop = false;
            this.grBxSystemEmployees.Text = "Employee Info";
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.AllowDrop = true;
            this.txtEmpPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpPhone.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmpPhone.Location = new System.Drawing.Point(19, 145);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(162, 27);
            this.txtEmpPhone.TabIndex = 13;
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.AllowDrop = true;
            this.txtEmpSalary.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSalary.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmpSalary.Location = new System.Drawing.Point(19, 99);
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.Size = new System.Drawing.Size(162, 27);
            this.txtEmpSalary.TabIndex = 12;
            // 
            // txtEmpName
            // 
            this.txtEmpName.AllowDrop = true;
            this.txtEmpName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtEmpName.Location = new System.Drawing.Point(19, 56);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(162, 27);
            this.txtEmpName.TabIndex = 11;
            this.txtEmpName.TextChanged += new System.EventHandler(this.txtEmpName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 40);
            this.label3.TabIndex = 19;
            this.label3.Text = "Emplyee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(309, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "System Employees :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.ForeColor = System.Drawing.Color.DarkCyan;
            this.AddEmployee.Location = new System.Drawing.Point(79, 429);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(142, 39);
            this.AddEmployee.TabIndex = 16;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(427, 429);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(165, 39);
            this.btnDeleteEmployee.TabIndex = 15;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnUpdateEmpolyee
            // 
            this.btnUpdateEmpolyee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmpolyee.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateEmpolyee.Location = new System.Drawing.Point(240, 429);
            this.btnUpdateEmpolyee.Name = "btnUpdateEmpolyee";
            this.btnUpdateEmpolyee.Size = new System.Drawing.Size(166, 39);
            this.btnUpdateEmpolyee.TabIndex = 14;
            this.btnUpdateEmpolyee.Text = " Update Employee";
            this.btnUpdateEmpolyee.UseVisualStyleBackColor = true;
            this.btnUpdateEmpolyee.Click += new System.EventHandler(this.btnUpdateEmpolyee_Click);
            // 
            // lstViwEmployees
            // 
            this.lstViwEmployees.AllowDrop = true;
            this.lstViwEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstViwEmployees.FullRowSelect = true;
            this.lstViwEmployees.HideSelection = false;
            this.lstViwEmployees.Location = new System.Drawing.Point(312, 133);
            this.lstViwEmployees.MultiSelect = false;
            this.lstViwEmployees.Name = "lstViwEmployees";
            this.lstViwEmployees.Size = new System.Drawing.Size(365, 235);
            this.lstViwEmployees.TabIndex = 13;
            this.lstViwEmployees.UseCompatibleStateImageBehavior = false;
            this.lstViwEmployees.View = System.Windows.Forms.View.Details;
            this.lstViwEmployees.SelectedIndexChanged += new System.EventHandler(this.lstViwEmployees_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Salary";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone";
            this.columnHeader3.Width = 120;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(689, 497);
            this.Controls.Add(this.grBxSystemEmployees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnUpdateEmpolyee);
            this.Controls.Add(this.lstViwEmployees);
            this.Name = "frmEmployee";
            this.Text = "Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.grBxSystemEmployees.ResumeLayout(false);
            this.grBxSystemEmployees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBxSystemEmployees;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.TextBox txtEmpSalary;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmpolyee;
        private System.Windows.Forms.ListView lstViwEmployees;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}