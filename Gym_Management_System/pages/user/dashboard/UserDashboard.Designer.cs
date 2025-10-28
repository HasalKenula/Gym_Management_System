namespace Gym_Management_System.pages.user
{
    partial class UserDashboard
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.pnlUserDashboard = new System.Windows.Forms.Panel();
            this.tbleLayoutUserDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.pnlUserDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(59, 35);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(248, 36);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Good Morning ,";
            // 
            // pnlUserDashboard
            // 
            this.pnlUserDashboard.Controls.Add(this.tbleLayoutUserDashboard);
            this.pnlUserDashboard.Controls.Add(this.lblGreeting);
            this.pnlUserDashboard.Location = new System.Drawing.Point(-3, -1);
            this.pnlUserDashboard.Name = "pnlUserDashboard";
            this.pnlUserDashboard.Size = new System.Drawing.Size(1200, 627);
            this.pnlUserDashboard.TabIndex = 3;
            // 
            // tbleLayoutUserDashboard
            // 
            this.tbleLayoutUserDashboard.AutoSize = true;
            this.tbleLayoutUserDashboard.ColumnCount = 3;
            this.tbleLayoutUserDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.0493F));
            this.tbleLayoutUserDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.9507F));
            this.tbleLayoutUserDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tbleLayoutUserDashboard.Location = new System.Drawing.Point(65, 118);
            this.tbleLayoutUserDashboard.Name = "tbleLayoutUserDashboard";
            this.tbleLayoutUserDashboard.RowCount = 2;
            this.tbleLayoutUserDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.8961F));
            this.tbleLayoutUserDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.1039F));
            this.tbleLayoutUserDashboard.Size = new System.Drawing.Size(1021, 509);
            this.tbleLayoutUserDashboard.TabIndex = 2;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 628);
            this.Controls.Add(this.pnlUserDashboard);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.pnlUserDashboard.ResumeLayout(false);
            this.pnlUserDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Panel pnlUserDashboard;
        private System.Windows.Forms.TableLayoutPanel tbleLayoutUserDashboard;
    }
}