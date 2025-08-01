namespace Gym_Management_System.pages.admin
{
    partial class AdminSide
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
            this.splitContAdmin = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContAdmin)).BeginInit();
            this.splitContAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContAdmin
            // 
            this.splitContAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContAdmin.Location = new System.Drawing.Point(0, 0);
            this.splitContAdmin.Name = "splitContAdmin";
            this.splitContAdmin.Size = new System.Drawing.Size(1272, 534);
            this.splitContAdmin.SplitterDistance = 281;
            this.splitContAdmin.TabIndex = 0;
            // 
            // AdminSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 534);
            this.Controls.Add(this.splitContAdmin);
            this.Name = "AdminSide";
            this.Text = "AdminSide";
            ((System.ComponentModel.ISupportInitialize)(this.splitContAdmin)).EndInit();
            this.splitContAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContAdmin;
    }
}