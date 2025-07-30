namespace Gym_Management_System.pages.user
{
    partial class UserSide
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
            this.splitpnlUser = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitpnlUser)).BeginInit();
            this.splitpnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitpnlUser
            // 
            this.splitpnlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitpnlUser.Location = new System.Drawing.Point(0, 0);
            this.splitpnlUser.Name = "splitpnlUser";
            this.splitpnlUser.Size = new System.Drawing.Size(1312, 742);
            this.splitpnlUser.SplitterDistance = 301;
            this.splitpnlUser.TabIndex = 0;
            // 
            // UserSide
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 742);
            this.Controls.Add(this.splitpnlUser);
            this.Name = "UserSide";
            this.Text = "UserSide";
            ((System.ComponentModel.ISupportInitialize)(this.splitpnlUser)).EndInit();
            this.splitpnlUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitpnlUser;
    }
}