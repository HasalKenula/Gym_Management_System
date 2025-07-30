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
            this.pnlUserMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserMainMenu
            // 
            this.pnlUserMainMenu.Controls.Add(this.btnUserDashboard);
            this.pnlUserMainMenu.Controls.Add(this.btnUserProgress);
            this.pnlUserMainMenu.Controls.Add(this.btnUserProfile);
            this.pnlUserMainMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlUserMainMenu.Location = new System.Drawing.Point(-3, -1);
            this.pnlUserMainMenu.Name = "pnlUserMainMenu";
            this.pnlUserMainMenu.Size = new System.Drawing.Size(295, 461);
            this.pnlUserMainMenu.TabIndex = 1;
            // 
            // btnUserDashboard
            // 
            this.btnUserDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnUserDashboard.Name = "btnUserDashboard";
            this.btnUserDashboard.Size = new System.Drawing.Size(96, 23);
            this.btnUserDashboard.TabIndex = 0;
            this.btnUserDashboard.Text = "Dashboard";
            this.btnUserDashboard.UseVisualStyleBackColor = true;
            this.btnUserDashboard.Click += new System.EventHandler(this.btnUserDashboard_Click);
            // 
            // btnUserProgress
            // 
            this.btnUserProgress.Location = new System.Drawing.Point(3, 32);
            this.btnUserProgress.Name = "btnUserProgress";
            this.btnUserProgress.Size = new System.Drawing.Size(75, 23);
            this.btnUserProgress.TabIndex = 1;
            this.btnUserProgress.Text = "Progress";
            this.btnUserProgress.UseVisualStyleBackColor = true;
            this.btnUserProgress.Click += new System.EventHandler(this.btnUserProgress_Click);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Location = new System.Drawing.Point(3, 61);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(75, 23);
            this.btnUserProfile.TabIndex = 2;
            this.btnUserProfile.Text = "Profile";
            this.btnUserProfile.UseVisualStyleBackColor = true;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
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
    }
}