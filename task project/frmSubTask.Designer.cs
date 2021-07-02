namespace task_project
{
    partial class frmSubTask
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lstViwSubTasks = new System.Windows.Forms.ListView();
            this.ColSTaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSTaskDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSTaskDeadLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSTaskStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rchTxtSubTaskDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtePckrSubTaskDeadLine = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtSubTaskName = new System.Windows.Forms.TextBox();
            this.btnDeleteSubTask = new System.Windows.Forms.Button();
            this.btnUpdateSubTask = new System.Windows.Forms.Button();
            this.btnAddSubTask = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rBtnDoneSubTask = new System.Windows.Forms.RadioButton();
            this.rBtnRunningSubTask = new System.Windows.Forms.RadioButton();
            this.rBtnNotAssignedSubTask = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.btnBackToTask = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.cmbTeams = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTasks = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1935, 146);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(242, 27);
            this.comboBox2.TabIndex = 39;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1433, 142);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 27);
            this.comboBox1.TabIndex = 38;
            // 
            // lstViwSubTasks
            // 
            this.lstViwSubTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColSTaskName,
            this.ColSTaskDesc,
            this.ColSTaskDeadLine,
            this.ColSTaskStatus});
            this.lstViwSubTasks.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstViwSubTasks.FullRowSelect = true;
            this.lstViwSubTasks.HideSelection = false;
            this.lstViwSubTasks.Location = new System.Drawing.Point(827, 159);
            this.lstViwSubTasks.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lstViwSubTasks.Name = "lstViwSubTasks";
            this.lstViwSubTasks.Size = new System.Drawing.Size(478, 394);
            this.lstViwSubTasks.TabIndex = 37;
            this.lstViwSubTasks.UseCompatibleStateImageBehavior = false;
            this.lstViwSubTasks.View = System.Windows.Forms.View.Details;
            this.lstViwSubTasks.SelectedIndexChanged += new System.EventHandler(this.ListView2_SelectedIndexChanged);
            // 
            // ColSTaskName
            // 
            this.ColSTaskName.Text = "Name";
            this.ColSTaskName.Width = 84;
            // 
            // ColSTaskDesc
            // 
            this.ColSTaskDesc.Text = "Description";
            this.ColSTaskDesc.Width = 122;
            // 
            // ColSTaskDeadLine
            // 
            this.ColSTaskDeadLine.Text = "DeadLine";
            this.ColSTaskDeadLine.Width = 164;
            // 
            // ColSTaskStatus
            // 
            this.ColSTaskStatus.Text = "Status";
            this.ColSTaskStatus.Width = 212;
            // 
            // rchTxtSubTaskDescription
            // 
            this.rchTxtSubTaskDescription.ForeColor = System.Drawing.Color.LightGray;
            this.rchTxtSubTaskDescription.Location = new System.Drawing.Point(46, 171);
            this.rchTxtSubTaskDescription.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rchTxtSubTaskDescription.Name = "rchTxtSubTaskDescription";
            this.rchTxtSubTaskDescription.Size = new System.Drawing.Size(532, 138);
            this.rchTxtSubTaskDescription.TabIndex = 36;
            this.rchTxtSubTaskDescription.Text = "SubTask Description";
            this.rchTxtSubTaskDescription.TextChanged += new System.EventHandler(this.RchTxtSubTaskDescription_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "DeadLine :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 40);
            this.label3.TabIndex = 27;
            this.label3.Text = " SubTASK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1737, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Category :";
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.DarkCyan;
            this.button6.Location = new System.Drawing.Point(1935, 776);
            this.button6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(298, 50);
            this.button6.TabIndex = 30;
            this.button6.Text = "Delete Task";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.DarkCyan;
            this.button5.Location = new System.Drawing.Point(1592, 776);
            this.button5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(298, 50);
            this.button5.TabIndex = 29;
            this.button5.Text = "Update Task";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.DarkCyan;
            this.button4.Location = new System.Drawing.Point(1252, 776);
            this.button4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(298, 50);
            this.button4.TabIndex = 28;
            this.button4.Text = "Add New Task";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dtePckrSubTaskDeadLine
            // 
            this.dtePckrSubTaskDeadLine.CalendarForeColor = System.Drawing.Color.DarkCyan;
            this.dtePckrSubTaskDeadLine.Location = new System.Drawing.Point(225, 321);
            this.dtePckrSubTaskDeadLine.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dtePckrSubTaskDeadLine.Name = "dtePckrSubTaskDeadLine";
            this.dtePckrSubTaskDeadLine.Size = new System.Drawing.Size(359, 27);
            this.dtePckrSubTaskDeadLine.TabIndex = 25;
            this.dtePckrSubTaskDeadLine.ValueChanged += new System.EventHandler(this.DtePckrSubTaskDeadLine_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSubTaskName
            // 
            this.txtSubTaskName.ForeColor = System.Drawing.Color.LightGray;
            this.txtSubTaskName.Location = new System.Drawing.Point(46, 120);
            this.txtSubTaskName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtSubTaskName.Name = "txtSubTaskName";
            this.txtSubTaskName.Size = new System.Drawing.Size(532, 27);
            this.txtSubTaskName.TabIndex = 24;
            this.txtSubTaskName.Text = "SubTask Name";
            this.txtSubTaskName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubTaskName.TextChanged += new System.EventHandler(this.TxtSubTaskName_TextChanged);
            // 
            // btnDeleteSubTask
            // 
            this.btnDeleteSubTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDeleteSubTask.Location = new System.Drawing.Point(931, 614);
            this.btnDeleteSubTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSubTask.Name = "btnDeleteSubTask";
            this.btnDeleteSubTask.Size = new System.Drawing.Size(179, 34);
            this.btnDeleteSubTask.TabIndex = 44;
            this.btnDeleteSubTask.Text = "Delete SubTask";
            this.btnDeleteSubTask.UseVisualStyleBackColor = true;
            this.btnDeleteSubTask.Click += new System.EventHandler(this.BtnDeleteSubTask_Click);
            // 
            // btnUpdateSubTask
            // 
            this.btnUpdateSubTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateSubTask.Location = new System.Drawing.Point(731, 614);
            this.btnUpdateSubTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateSubTask.Name = "btnUpdateSubTask";
            this.btnUpdateSubTask.Size = new System.Drawing.Size(179, 34);
            this.btnUpdateSubTask.TabIndex = 43;
            this.btnUpdateSubTask.Text = "Update SubTask";
            this.btnUpdateSubTask.UseVisualStyleBackColor = true;
            this.btnUpdateSubTask.Click += new System.EventHandler(this.Button9_Click);
            // 
            // btnAddSubTask
            // 
            this.btnAddSubTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddSubTask.Location = new System.Drawing.Point(528, 614);
            this.btnAddSubTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSubTask.Name = "btnAddSubTask";
            this.btnAddSubTask.Size = new System.Drawing.Size(179, 34);
            this.btnAddSubTask.TabIndex = 42;
            this.btnAddSubTask.Text = "Add New SubTask";
            this.btnAddSubTask.UseVisualStyleBackColor = true;
            this.btnAddSubTask.Click += new System.EventHandler(this.BtnAddSubTask_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 19);
            this.label8.TabIndex = 48;
            this.label8.Text = "SubTaskStatus :";
            // 
            // rBtnDoneSubTask
            // 
            this.rBtnDoneSubTask.AutoSize = true;
            this.rBtnDoneSubTask.Location = new System.Drawing.Point(197, 542);
            this.rBtnDoneSubTask.Name = "rBtnDoneSubTask";
            this.rBtnDoneSubTask.Size = new System.Drawing.Size(69, 23);
            this.rBtnDoneSubTask.TabIndex = 47;
            this.rBtnDoneSubTask.Text = "Done";
            this.rBtnDoneSubTask.UseVisualStyleBackColor = true;
            this.rBtnDoneSubTask.CheckedChanged += new System.EventHandler(this.RBtnDoneSubTask_CheckedChanged);
            // 
            // rBtnRunningSubTask
            // 
            this.rBtnRunningSubTask.AutoSize = true;
            this.rBtnRunningSubTask.Location = new System.Drawing.Point(197, 512);
            this.rBtnRunningSubTask.Name = "rBtnRunningSubTask";
            this.rBtnRunningSubTask.Size = new System.Drawing.Size(94, 23);
            this.rBtnRunningSubTask.TabIndex = 46;
            this.rBtnRunningSubTask.Text = "Running";
            this.rBtnRunningSubTask.UseVisualStyleBackColor = true;
            this.rBtnRunningSubTask.CheckedChanged += new System.EventHandler(this.RBtnRunningSubTask_CheckedChanged);
            // 
            // rBtnNotAssignedSubTask
            // 
            this.rBtnNotAssignedSubTask.AutoSize = true;
            this.rBtnNotAssignedSubTask.Checked = true;
            this.rBtnNotAssignedSubTask.Location = new System.Drawing.Point(197, 483);
            this.rBtnNotAssignedSubTask.Name = "rBtnNotAssignedSubTask";
            this.rBtnNotAssignedSubTask.Size = new System.Drawing.Size(129, 23);
            this.rBtnNotAssignedSubTask.TabIndex = 45;
            this.rBtnNotAssignedSubTask.TabStop = true;
            this.rBtnNotAssignedSubTask.Text = "NotAssigned";
            this.rBtnNotAssignedSubTask.UseVisualStyleBackColor = true;
            this.rBtnNotAssignedSubTask.CheckedChanged += new System.EventHandler(this.RBtnNotAssignedSubTask_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Assign To  :";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(225, 382);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(359, 27);
            this.cmbEmployees.TabIndex = 49;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.CmbEmployees_SelectedIndexChanged);
            // 
            // btnBackToTask
            // 
            this.btnBackToTask.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBackToTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBackToTask.Location = new System.Drawing.Point(-2, 682);
            this.btnBackToTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackToTask.Name = "btnBackToTask";
            this.btnBackToTask.Size = new System.Drawing.Size(140, 75);
            this.btnBackToTask.TabIndex = 55;
            this.btnBackToTask.Text = " <- Task";
            this.btnBackToTask.UseVisualStyleBackColor = false;
            this.btnBackToTask.Click += new System.EventHandler(this.BtnBackToTask_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.cmbTeams);
            this.pnlAdmin.Controls.Add(this.label4);
            this.pnlAdmin.Controls.Add(this.cmbCategories);
            this.pnlAdmin.Controls.Add(this.label2);
            this.pnlAdmin.Controls.Add(this.cmbTasks);
            this.pnlAdmin.Controls.Add(this.label7);
            this.pnlAdmin.Location = new System.Drawing.Point(799, 80);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(559, 70);
            this.pnlAdmin.TabIndex = 56;
            // 
            // cmbTeams
            // 
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(102, 37);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(80, 27);
            this.cmbTeams.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 59;
            this.label4.Text = "Team :";
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(283, 37);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(75, 27);
            this.cmbCategories.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(192, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Category :";
            // 
            // cmbTasks
            // 
            this.cmbTasks.FormattingEnabled = true;
            this.cmbTasks.Location = new System.Drawing.Point(425, 37);
            this.cmbTasks.Name = "cmbTasks";
            this.cmbTasks.Size = new System.Drawing.Size(81, 27);
            this.cmbTasks.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(368, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 55;
            this.label7.Text = "Task :";
            // 
            // frmSubTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.btnBackToTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rBtnDoneSubTask);
            this.Controls.Add(this.rBtnRunningSubTask);
            this.Controls.Add(this.rBtnNotAssignedSubTask);
            this.Controls.Add(this.btnDeleteSubTask);
            this.Controls.Add(this.btnUpdateSubTask);
            this.Controls.Add(this.btnAddSubTask);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lstViwSubTasks);
            this.Controls.Add(this.rchTxtSubTaskDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dtePckrSubTaskDeadLine);
            this.Controls.Add(this.txtSubTaskName);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmSubTask";
            this.Text = "SubTask";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SubTask_Load);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView lstViwSubTasks;
        private System.Windows.Forms.RichTextBox rchTxtSubTaskDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dtePckrSubTaskDeadLine;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtSubTaskName;
        private System.Windows.Forms.Button btnDeleteSubTask;
        private System.Windows.Forms.Button btnUpdateSubTask;
        private System.Windows.Forms.Button btnAddSubTask;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rBtnDoneSubTask;
        private System.Windows.Forms.RadioButton rBtnRunningSubTask;
        private System.Windows.Forms.RadioButton rBtnNotAssignedSubTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.ColumnHeader ColSTaskName;
        private System.Windows.Forms.ColumnHeader ColSTaskDesc;
        private System.Windows.Forms.ColumnHeader ColSTaskDeadLine;
        private System.Windows.Forms.ColumnHeader ColSTaskStatus;
        private System.Windows.Forms.Button btnBackToTask;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.ComboBox cmbTeams;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTasks;
        private System.Windows.Forms.Label label7;
    }
}