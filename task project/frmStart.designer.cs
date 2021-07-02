
namespace task_project
{
    partial class frmStart
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
            this.components = new System.ComponentModel.Container();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Wide Latin", 44F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(7, 52);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1376, 73);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Task Management  System";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnStart.Location = new System.Drawing.Point(266, 218);
            this.btnStart.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(753, 214);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Let Us Start  !!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 57F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Tahoma", 35F);
            this.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.Name = "frmStart";
            this.Text = "Start";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}