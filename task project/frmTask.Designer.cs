namespace task_project
{
    partial class frmTask
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
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.dtePckrTaskDeadline = new System.Windows.Forms.DateTimePicker();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rchTxtTaskDescription = new System.Windows.Forms.RichTextBox();
            this.lstViwTasks = new System.Windows.Forms.ListView();
            this.coltaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDeadLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIsArchived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbTeams = new System.Windows.Forms.ComboBox();
            this.cmbTeamCategories = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grBxAssignToEmployees = new System.Windows.Forms.GroupBox();
            this.btnOkEmployeeAssigned = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chckLstBxSystemEmployees = new System.Windows.Forms.CheckedListBox();
            this.chckLstBxTaskEmployees = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEmpToTask = new System.Windows.Forms.Button();
            this.btnEmpFromTask = new System.Windows.Forms.Button();
            this.btnAssignEmployees = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.rBtnNotArchived = new System.Windows.Forms.RadioButton();
            this.rBtnArchived = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grBxTaskStatus = new System.Windows.Forms.GroupBox();
            this.rBtnStsDone = new System.Windows.Forms.RadioButton();
            this.rBtnStsRunning = new System.Windows.Forms.RadioButton();
            this.rBtnStsNotAssigned = new System.Windows.Forms.RadioButton();
            this.cmbTaskFiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grBxAssignToEmployees.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grBxTaskStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTaskName
            // 
            this.txtTaskName.ForeColor = System.Drawing.Color.LightGray;
            this.txtTaskName.Location = new System.Drawing.Point(49, 99);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(321, 27);
            this.txtTaskName.TabIndex = 3;
            this.txtTaskName.Text = "Task Name";
            this.txtTaskName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTaskName.TextChanged += new System.EventHandler(this.TxtTaskName_TextChanged);
            // 
            // dtePckrTaskDeadline
            // 
            this.dtePckrTaskDeadline.CalendarForeColor = System.Drawing.Color.DarkCyan;
            this.dtePckrTaskDeadline.Location = new System.Drawing.Point(147, 223);
            this.dtePckrTaskDeadline.Margin = new System.Windows.Forms.Padding(4);
            this.dtePckrTaskDeadline.Name = "dtePckrTaskDeadline";
            this.dtePckrTaskDeadline.Size = new System.Drawing.Size(217, 27);
            this.dtePckrTaskDeadline.TabIndex = 4;
            this.dtePckrTaskDeadline.ValueChanged += new System.EventHandler(this.DtePckrTaskDeadline_ValueChanged);
            // 
            // btnAddTask
            // 
            this.btnAddTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddTask.Location = new System.Drawing.Point(600, 573);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(179, 34);
            this.btnAddTask.TabIndex = 14;
            this.btnAddTask.Text = "Add New Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUpdateTask.Location = new System.Drawing.Point(806, 573);
            this.btnUpdateTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(179, 34);
            this.btnUpdateTask.TabIndex = 15;
            this.btnUpdateTask.Text = "Update Task";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDeleteTask.Location = new System.Drawing.Point(1014, 573);
            this.btnDeleteTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(179, 34);
            this.btnDeleteTask.TabIndex = 16;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.Button6_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 40);
            this.label3.TabIndex = 13;
            this.label3.Text = " TASK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "DeadLine :";
            // 
            // rchTxtTaskDescription
            // 
            this.rchTxtTaskDescription.ForeColor = System.Drawing.Color.LightGray;
            this.rchTxtTaskDescription.Location = new System.Drawing.Point(49, 142);
            this.rchTxtTaskDescription.Margin = new System.Windows.Forms.Padding(4);
            this.rchTxtTaskDescription.Name = "rchTxtTaskDescription";
            this.rchTxtTaskDescription.Size = new System.Drawing.Size(321, 73);
            this.rchTxtTaskDescription.TabIndex = 20;
            this.rchTxtTaskDescription.Text = "Task Description";
            this.rchTxtTaskDescription.TextChanged += new System.EventHandler(this.RchTxtTaskDescription_TextChanged);
            // 
            // lstViwTasks
            // 
            this.lstViwTasks.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstViwTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coltaskName,
            this.colDescription,
            this.colDeadLine,
            this.colStatus,
            this.colIsArchived});
            this.lstViwTasks.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstViwTasks.FullRowSelect = true;
            this.lstViwTasks.GridLines = true;
            this.lstViwTasks.HideSelection = false;
            this.lstViwTasks.Location = new System.Drawing.Point(762, 142);
            this.lstViwTasks.Margin = new System.Windows.Forms.Padding(4);
            this.lstViwTasks.Name = "lstViwTasks";
            this.lstViwTasks.Size = new System.Drawing.Size(557, 346);
            this.lstViwTasks.TabIndex = 21;
            this.lstViwTasks.UseCompatibleStateImageBehavior = false;
            this.lstViwTasks.View = System.Windows.Forms.View.Details;
            this.lstViwTasks.SelectedIndexChanged += new System.EventHandler(this.LstViwTasks_SelectedIndexChanged_1);
            // 
            // coltaskName
            // 
            this.coltaskName.Text = "taskName";
            this.coltaskName.Width = 113;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 113;
            // 
            // colDeadLine
            // 
            this.colDeadLine.Text = "DeadLine";
            this.colDeadLine.Width = 106;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 98;
            // 
            // colIsArchived
            // 
            this.colIsArchived.Text = "IsArchived";
            this.colIsArchived.Width = 153;
            // 
            // cmbTeams
            // 
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(871, 100);
            this.cmbTeams.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(147, 27);
            this.cmbTeams.TabIndex = 22;
            this.cmbTeams.SelectedIndexChanged += new System.EventHandler(this.CmbTeams_SelectedIndexChanged);
            // 
            // cmbTeamCategories
            // 
            this.cmbTeamCategories.FormattingEnabled = true;
            this.cmbTeamCategories.Location = new System.Drawing.Point(1172, 103);
            this.cmbTeamCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTeamCategories.Name = "cmbTeamCategories";
            this.cmbTeamCategories.Size = new System.Drawing.Size(147, 27);
            this.cmbTeamCategories.TabIndex = 23;
            this.cmbTeamCategories.SelectedIndexChanged += new System.EventHandler(this.CmbTeamCategories_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1053, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Category :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(793, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Team :";
            // 
            // grBxAssignToEmployees
            // 
            this.grBxAssignToEmployees.Controls.Add(this.btnOkEmployeeAssigned);
            this.grBxAssignToEmployees.Controls.Add(this.label9);
            this.grBxAssignToEmployees.Controls.Add(this.label4);
            this.grBxAssignToEmployees.Controls.Add(this.chckLstBxSystemEmployees);
            this.grBxAssignToEmployees.Controls.Add(this.chckLstBxTaskEmployees);
            this.grBxAssignToEmployees.Controls.Add(this.label2);
            this.grBxAssignToEmployees.Controls.Add(this.label10);
            this.grBxAssignToEmployees.Controls.Add(this.btnEmpToTask);
            this.grBxAssignToEmployees.Controls.Add(this.btnEmpFromTask);
            this.grBxAssignToEmployees.ForeColor = System.Drawing.Color.White;
            this.grBxAssignToEmployees.Location = new System.Drawing.Point(47, 427);
            this.grBxAssignToEmployees.Name = "grBxAssignToEmployees";
            this.grBxAssignToEmployees.Size = new System.Drawing.Size(399, 214);
            this.grBxAssignToEmployees.TabIndex = 50;
            this.grBxAssignToEmployees.TabStop = false;
            this.grBxAssignToEmployees.Text = "Assign to Employees";
            this.grBxAssignToEmployees.Visible = false;
            // 
            // btnOkEmployeeAssigned
            // 
            this.btnOkEmployeeAssigned.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOkEmployeeAssigned.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnOkEmployeeAssigned.Location = new System.Drawing.Point(156, 182);
            this.btnOkEmployeeAssigned.Margin = new System.Windows.Forms.Padding(4);
            this.btnOkEmployeeAssigned.Name = "btnOkEmployeeAssigned";
            this.btnOkEmployeeAssigned.Size = new System.Drawing.Size(69, 25);
            this.btnOkEmployeeAssigned.TabIndex = 63;
            this.btnOkEmployeeAssigned.Text = "OK";
            this.btnOkEmployeeAssigned.UseVisualStyleBackColor = false;
            this.btnOkEmployeeAssigned.Click += new System.EventHandler(this.BtnOkEmployeeAssigned_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "System Employees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Task Employees";
            // 
            // chckLstBxSystemEmployees
            // 
            this.chckLstBxSystemEmployees.ForeColor = System.Drawing.Color.DarkCyan;
            this.chckLstBxSystemEmployees.FormattingEnabled = true;
            this.chckLstBxSystemEmployees.Location = new System.Drawing.Point(265, 57);
            this.chckLstBxSystemEmployees.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.chckLstBxSystemEmployees.Name = "chckLstBxSystemEmployees";
            this.chckLstBxSystemEmployees.Size = new System.Drawing.Size(116, 136);
            this.chckLstBxSystemEmployees.TabIndex = 15;
            this.chckLstBxSystemEmployees.SelectedIndexChanged += new System.EventHandler(this.ChckLstBxSystemEmployees_SelectedIndexChanged);
            // 
            // chckLstBxTaskEmployees
            // 
            this.chckLstBxTaskEmployees.ForeColor = System.Drawing.Color.DarkCyan;
            this.chckLstBxTaskEmployees.FormattingEnabled = true;
            this.chckLstBxTaskEmployees.Location = new System.Drawing.Point(10, 57);
            this.chckLstBxTaskEmployees.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.chckLstBxTaskEmployees.Name = "chckLstBxTaskEmployees";
            this.chckLstBxTaskEmployees.Size = new System.Drawing.Size(111, 136);
            this.chckLstBxTaskEmployees.TabIndex = 14;
            this.chckLstBxTaskEmployees.SelectedIndexChanged += new System.EventHandler(this.ChckLstBxTaskEmployees_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, -70);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "System Employees";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-4, -70);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Task Employees";
            // 
            // btnEmpToTask
            // 
            this.btnEmpToTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnEmpToTask.Location = new System.Drawing.Point(124, 103);
            this.btnEmpToTask.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEmpToTask.Name = "btnEmpToTask";
            this.btnEmpToTask.Size = new System.Drawing.Size(86, 28);
            this.btnEmpToTask.TabIndex = 12;
            this.btnEmpToTask.Text = "<-";
            this.btnEmpToTask.UseVisualStyleBackColor = true;
            this.btnEmpToTask.Click += new System.EventHandler(this.BtnEmpToTask_Click);
            // 
            // btnEmpFromTask
            // 
            this.btnEmpFromTask.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnEmpFromTask.Location = new System.Drawing.Point(176, 134);
            this.btnEmpFromTask.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEmpFromTask.Name = "btnEmpFromTask";
            this.btnEmpFromTask.Size = new System.Drawing.Size(86, 29);
            this.btnEmpFromTask.TabIndex = 11;
            this.btnEmpFromTask.Text = "->";
            this.btnEmpFromTask.UseVisualStyleBackColor = true;
            this.btnEmpFromTask.Click += new System.EventHandler(this.BtnEmpFromTask_Click);
            // 
            // btnAssignEmployees
            // 
            this.btnAssignEmployees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignEmployees.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAssignEmployees.Location = new System.Drawing.Point(49, 432);
            this.btnAssignEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssignEmployees.Name = "btnAssignEmployees";
            this.btnAssignEmployees.Size = new System.Drawing.Size(344, 37);
            this.btnAssignEmployees.TabIndex = 51;
            this.btnAssignEmployees.Text = "Assign to Employees";
            this.btnAssignEmployees.UseVisualStyleBackColor = true;
            this.btnAssignEmployees.Click += new System.EventHandler(this.BtnAssignEmployees_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFile.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAddFile.Location = new System.Drawing.Point(277, 392);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(116, 28);
            this.btnAddFile.TabIndex = 18;
            this.btnAddFile.Text = "Add a File ";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
            // 
            // rBtnNotArchived
            // 
            this.rBtnNotArchived.AutoSize = true;
            this.rBtnNotArchived.Location = new System.Drawing.Point(20, 55);
            this.rBtnNotArchived.Name = "rBtnNotArchived";
            this.rBtnNotArchived.Size = new System.Drawing.Size(49, 23);
            this.rBtnNotArchived.TabIndex = 54;
            this.rBtnNotArchived.Text = "No";
            this.rBtnNotArchived.UseVisualStyleBackColor = true;
            this.rBtnNotArchived.CheckedChanged += new System.EventHandler(this.RBtnNotArchived_CheckedChanged);
            // 
            // rBtnArchived
            // 
            this.rBtnArchived.AutoSize = true;
            this.rBtnArchived.Checked = true;
            this.rBtnArchived.Location = new System.Drawing.Point(20, 26);
            this.rBtnArchived.Name = "rBtnArchived";
            this.rBtnArchived.Size = new System.Drawing.Size(56, 23);
            this.rBtnArchived.TabIndex = 53;
            this.rBtnArchived.TabStop = true;
            this.rBtnArchived.Text = "Yes";
            this.rBtnArchived.UseVisualStyleBackColor = true;
            this.rBtnArchived.CheckedChanged += new System.EventHandler(this.RBtnArchived_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnArchived);
            this.groupBox2.Controls.Add(this.rBtnNotArchived);
            this.groupBox2.Location = new System.Drawing.Point(272, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 119);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Archive it ?";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // grBxTaskStatus
            // 
            this.grBxTaskStatus.Controls.Add(this.rBtnStsDone);
            this.grBxTaskStatus.Controls.Add(this.rBtnStsRunning);
            this.grBxTaskStatus.Controls.Add(this.rBtnStsNotAssigned);
            this.grBxTaskStatus.Location = new System.Drawing.Point(49, 261);
            this.grBxTaskStatus.Name = "grBxTaskStatus";
            this.grBxTaskStatus.Size = new System.Drawing.Size(200, 119);
            this.grBxTaskStatus.TabIndex = 58;
            this.grBxTaskStatus.TabStop = false;
            this.grBxTaskStatus.Text = "TaskStatus :";
            // 
            // rBtnStsDone
            // 
            this.rBtnStsDone.AutoSize = true;
            this.rBtnStsDone.Location = new System.Drawing.Point(20, 88);
            this.rBtnStsDone.Name = "rBtnStsDone";
            this.rBtnStsDone.Size = new System.Drawing.Size(69, 23);
            this.rBtnStsDone.TabIndex = 29;
            this.rBtnStsDone.Text = "Done";
            this.rBtnStsDone.UseVisualStyleBackColor = true;
            this.rBtnStsDone.CheckedChanged += new System.EventHandler(this.RBtnStsDone_CheckedChanged);
            // 
            // rBtnStsRunning
            // 
            this.rBtnStsRunning.AutoSize = true;
            this.rBtnStsRunning.Location = new System.Drawing.Point(20, 58);
            this.rBtnStsRunning.Name = "rBtnStsRunning";
            this.rBtnStsRunning.Size = new System.Drawing.Size(94, 23);
            this.rBtnStsRunning.TabIndex = 28;
            this.rBtnStsRunning.Text = "Running";
            this.rBtnStsRunning.UseVisualStyleBackColor = true;
            this.rBtnStsRunning.CheckedChanged += new System.EventHandler(this.RBtnStsRunning_CheckedChanged);
            // 
            // rBtnStsNotAssigned
            // 
            this.rBtnStsNotAssigned.AutoSize = true;
            this.rBtnStsNotAssigned.Checked = true;
            this.rBtnStsNotAssigned.Location = new System.Drawing.Point(20, 29);
            this.rBtnStsNotAssigned.Name = "rBtnStsNotAssigned";
            this.rBtnStsNotAssigned.Size = new System.Drawing.Size(129, 23);
            this.rBtnStsNotAssigned.TabIndex = 27;
            this.rBtnStsNotAssigned.TabStop = true;
            this.rBtnStsNotAssigned.Text = "NotAssigned";
            this.rBtnStsNotAssigned.UseVisualStyleBackColor = true;
            this.rBtnStsNotAssigned.CheckedChanged += new System.EventHandler(this.RBtnStsNotAssigned_CheckedChanged);
            // 
            // cmbTaskFiles
            // 
            this.cmbTaskFiles.FormattingEnabled = true;
            this.cmbTaskFiles.Location = new System.Drawing.Point(147, 393);
            this.cmbTaskFiles.Name = "cmbTaskFiles";
            this.cmbTaskFiles.Size = new System.Drawing.Size(115, 27);
            this.cmbTaskFiles.TabIndex = 59;
            this.cmbTaskFiles.SelectedIndexChanged += new System.EventHandler(this.CmbTaskFiles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Task Files :";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(400, 383);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(47, 47);
            this.webBrowser1.TabIndex = 60;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1_DocumentCompleted);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNext.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnNext.Location = new System.Drawing.Point(1199, 622);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(179, 68);
            this.btnNext.TabIndex = 61;
            this.btnNext.Text = "SubTask ->";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(-1, 622);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 68);
            this.button1.TabIndex = 62;
            this.button1.Text = "<- Category";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 687);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTaskFiles);
            this.Controls.Add(this.grBxTaskStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAssignEmployees);
            this.Controls.Add(this.grBxAssignToEmployees);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTeamCategories);
            this.Controls.Add(this.cmbTeams);
            this.Controls.Add(this.lstViwTasks);
            this.Controls.Add(this.rchTxtTaskDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.dtePckrTaskDeadline);
            this.Controls.Add(this.txtTaskName);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTask";
            this.Text = "TASK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grBxAssignToEmployees.ResumeLayout(false);
            this.grBxAssignToEmployees.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grBxTaskStatus.ResumeLayout(false);
            this.grBxTaskStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.DateTimePicker dtePckrTaskDeadline;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rchTxtTaskDescription;
        private System.Windows.Forms.ListView lstViwTasks;
        private System.Windows.Forms.ComboBox cmbTeams;
        private System.Windows.Forms.ComboBox cmbTeamCategories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grBxAssignToEmployees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chckLstBxSystemEmployees;
        private System.Windows.Forms.CheckedListBox chckLstBxTaskEmployees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEmpToTask;
        private System.Windows.Forms.Button btnEmpFromTask;
        private System.Windows.Forms.Button btnAssignEmployees;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.RadioButton rBtnNotArchived;
        private System.Windows.Forms.RadioButton rBtnArchived;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grBxTaskStatus;
        private System.Windows.Forms.RadioButton rBtnStsDone;
        private System.Windows.Forms.RadioButton rBtnStsRunning;
        private System.Windows.Forms.RadioButton rBtnStsNotAssigned;
        private System.Windows.Forms.ColumnHeader coltaskName;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colDeadLine;
        private System.Windows.Forms.ColumnHeader colStatus;
        public System.Windows.Forms.ColumnHeader colIsArchived;
        private System.Windows.Forms.ComboBox cmbTaskFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnOkEmployeeAssigned;
        private System.Windows.Forms.Button button1;
    }
}

