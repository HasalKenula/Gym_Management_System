namespace Gym_Management_System.pages.user.dashboard.components
{
    partial class Announcements
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
            this.pnlAnnouncement = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlAnnouncement
            // 
            this.pnlAnnouncement.AutoScroll = true;
            this.pnlAnnouncement.Location = new System.Drawing.Point(40, 25);
            this.pnlAnnouncement.Name = "pnlAnnouncement";
            this.pnlAnnouncement.Size = new System.Drawing.Size(694, 381);
            this.pnlAnnouncement.TabIndex = 0;
            // 
            // Announcements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAnnouncement);
            this.Name = "Announcements";
            this.Text = "Announcements";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAnnouncement;
    }
}