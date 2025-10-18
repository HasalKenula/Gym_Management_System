namespace Gym_Management_System.pages.user
{
    partial class UserMainMenu
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
            this.pnlUserMainMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUserDashboard = new System.Windows.Forms.Button();
            this.btnUserProgress = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlUserMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserMainMenu
            // 
            this.pnlUserMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserMainMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlUserMainMenu.Controls.Add(this.btnUserDashboard);
            this.pnlUserMainMenu.Controls.Add(this.btnUserProgress);
            this.pnlUserMainMenu.Controls.Add(this.btnUserProfile);
            this.pnlUserMainMenu.Controls.Add(this.btnLogout);
            this.pnlUserMainMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlUserMainMenu.Location = new System.Drawing.Point(-3, -1);
            this.pnlUserMainMenu.Name = "pnlUserMainMenu";
            this.pnlUserMainMenu.Padding = new System.Windows.Forms.Padding(40, 100, 20, 100);
            this.pnlUserMainMenu.Size = new System.Drawing.Size(290, 461);
            this.pnlUserMainMenu.TabIndex = 1;
            this.pnlUserMainMenu.WrapContents = false;
            // 
            // btnUserDashboard
            // 
            this.btnUserDashboard.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDashboard.Location = new System.Drawing.Point(43, 103);
            this.btnUserDashboard.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnUserDashboard.Name = "btnUserDashboard";
            this.btnUserDashboard.Size = new System.Drawing.Size(350, 40);
            this.btnUserDashboard.TabIndex = 0;
            this.btnUserDashboard.Text = "Dashboard";
            this.btnUserDashboard.UseVisualStyleBackColor = true;
            this.btnUserDashboard.Click += new System.EventHandler(this.btnUserDashboard_Click);
            // 
            // btnUserProgress
            // 
            this.btnUserProgress.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.btnUserProgress.Location = new System.Drawing.Point(43, 171);
            this.btnUserProgress.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnUserProgress.Name = "btnUserProgress";
            this.btnUserProgress.Size = new System.Drawing.Size(350, 40);
            this.btnUserProgress.TabIndex = 1;
            this.btnUserProgress.Text = "Progress";
            this.btnUserProgress.UseVisualStyleBackColor = true;
            this.btnUserProgress.Click += new System.EventHandler(this.btnUserProgress_Click);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.btnUserProfile.Location = new System.Drawing.Point(43, 239);
            this.btnUserProfile.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(350, 40);
            this.btnUserProfile.TabIndex = 2;
            this.btnUserProfile.Text = "Profile";
            this.btnUserProfile.UseVisualStyleBackColor = true;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Poppins", 10.2F);
            this.btnLogout.Location = new System.Drawing.Point(43, 307);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(350, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // UserMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.pnlUserMainMenu);
            this.Name = "UserMainMenu";
            this.Text = "UserMainMenu";
            this.pnlUserMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlUserMainMenu;
        private System.Windows.Forms.Button btnUserDashboard;
        private System.Windows.Forms.Button btnUserProgress;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Button btnLogout;
    }
}