namespace Gym_Management_System.pages.admin
{
    partial class AdminMainMenu
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
            this.pnlAdminMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdminDashboard = new System.Windows.Forms.Button();
            this.btnMemManage = new System.Windows.Forms.Button();
            this.btnTrainerManage = new System.Windows.Forms.Button();
            this.btnAttendanceManage = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlAdminMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdminMenu
            // 
            this.pnlAdminMenu.Controls.Add(this.flowLayoutPanel1);
            this.pnlAdminMenu.Location = new System.Drawing.Point(-5, -2);
            this.pnlAdminMenu.Name = "pnlAdminMenu";
            this.pnlAdminMenu.Size = new System.Drawing.Size(370, 455);
            this.pnlAdminMenu.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAdminDashboard);
            this.flowLayoutPanel1.Controls.Add(this.btnMemManage);
            this.flowLayoutPanel1.Controls.Add(this.btnTrainerManage);
            this.flowLayoutPanel1.Controls.Add(this.btnAttendanceManage);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(367, 452);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAdminDashboard
            // 
            this.btnAdminDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnAdminDashboard.Name = "btnAdminDashboard";
            this.btnAdminDashboard.Size = new System.Drawing.Size(361, 54);
            this.btnAdminDashboard.TabIndex = 0;
            this.btnAdminDashboard.Text = "Dashboard";
            this.btnAdminDashboard.UseVisualStyleBackColor = true;
            this.btnAdminDashboard.Click += new System.EventHandler(this.btnAdminDashboard_Click);
            // 
            // btnMemManage
            // 
            this.btnMemManage.Location = new System.Drawing.Point(3, 63);
            this.btnMemManage.Name = "btnMemManage";
            this.btnMemManage.Size = new System.Drawing.Size(361, 54);
            this.btnMemManage.TabIndex = 1;
            this.btnMemManage.Text = "Member Management";
            this.btnMemManage.UseVisualStyleBackColor = true;
            this.btnMemManage.Click += new System.EventHandler(this.btnMemManage_Click);
            // 
            // btnTrainerManage
            // 
            this.btnTrainerManage.Location = new System.Drawing.Point(3, 123);
            this.btnTrainerManage.Name = "btnTrainerManage";
            this.btnTrainerManage.Size = new System.Drawing.Size(361, 54);
            this.btnTrainerManage.TabIndex = 2;
            this.btnTrainerManage.Text = "Trainer Management";
            this.btnTrainerManage.UseVisualStyleBackColor = true;
            this.btnTrainerManage.Click += new System.EventHandler(this.btnTrainerManage_Click);
            // 
            // btnAttendanceManage
            // 
            this.btnAttendanceManage.Location = new System.Drawing.Point(3, 183);
            this.btnAttendanceManage.Name = "btnAttendanceManage";
            this.btnAttendanceManage.Size = new System.Drawing.Size(361, 54);
            this.btnAttendanceManage.TabIndex = 3;
            this.btnAttendanceManage.Text = "Attendance Management";
            this.btnAttendanceManage.UseVisualStyleBackColor = true;
            this.btnAttendanceManage.Click += new System.EventHandler(this.btnAttendanceManage_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(3, 243);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(361, 54);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.pnlAdminMenu);
            this.Name = "AdminMainMenu";
            this.Text = "AdminMainMenu";
            this.pnlAdminMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdminMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAdminDashboard;
        private System.Windows.Forms.Button btnMemManage;
        private System.Windows.Forms.Button btnTrainerManage;
        private System.Windows.Forms.Button btnAttendanceManage;
        private System.Windows.Forms.Button btnLogout;
    }
}