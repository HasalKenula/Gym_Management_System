namespace Gym_Management_System.pages.user.dashboard.components
{
    partial class MembershipCard
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
            this.pnlMembershipCrd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblMemberPlan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMemberStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlMembershipCrd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMembershipCrd
            // 
            this.pnlMembershipCrd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMembershipCrd.Controls.Add(this.lblExpDate);
            this.pnlMembershipCrd.Controls.Add(this.label7);
            this.pnlMembershipCrd.Controls.Add(this.lblMemberStatus);
            this.pnlMembershipCrd.Controls.Add(this.label5);
            this.pnlMembershipCrd.Controls.Add(this.lblMemberPlan);
            this.pnlMembershipCrd.Controls.Add(this.label3);
            this.pnlMembershipCrd.Controls.Add(this.lblMemberID);
            this.pnlMembershipCrd.Controls.Add(this.label1);
            this.pnlMembershipCrd.Location = new System.Drawing.Point(21, 12);
            this.pnlMembershipCrd.Name = "pnlMembershipCrd";
            this.pnlMembershipCrd.Size = new System.Drawing.Size(616, 334);
            this.pnlMembershipCrd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID: ";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(137, 43);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(61, 16);
            this.lblMemberID.TabIndex = 1;
            this.lblMemberID.Text = "GY13616";
            // 
            // lblMemberPlan
            // 
            this.lblMemberPlan.AutoSize = true;
            this.lblMemberPlan.Location = new System.Drawing.Point(137, 83);
            this.lblMemberPlan.Name = "lblMemberPlan";
            this.lblMemberPlan.Size = new System.Drawing.Size(36, 16);
            this.lblMemberPlan.TabIndex = 3;
            this.lblMemberPlan.Text = "Gold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Member Plan:";
            // 
            // lblMemberStatus
            // 
            this.lblMemberStatus.AutoSize = true;
            this.lblMemberStatus.Location = new System.Drawing.Point(137, 119);
            this.lblMemberStatus.Name = "lblMemberStatus";
            this.lblMemberStatus.Size = new System.Drawing.Size(44, 16);
            this.lblMemberStatus.TabIndex = 5;
            this.lblMemberStatus.Text = "Active";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Member Status:";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(137, 159);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(71, 16);
            this.lblExpDate.TabIndex = 7;
            this.lblExpDate.Text = "2025-10-12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Expire Date:";
            // 
            // MembershipCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMembershipCrd);
            this.Name = "MembershipCard";
            this.Text = "MembershipCard";
            this.pnlMembershipCrd.ResumeLayout(false);
            this.pnlMembershipCrd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMembershipCrd;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMemberPlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMemberStatus;
        private System.Windows.Forms.Label label5;
    }
}