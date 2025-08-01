namespace Gym_Management_System.pages.admin
{
    partial class AttendanceManegement
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
            this.pnlAttendanceManage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlAttendanceManage
            // 
            this.pnlAttendanceManage.Location = new System.Drawing.Point(-2, -1);
            this.pnlAttendanceManage.Name = "pnlAttendanceManage";
            this.pnlAttendanceManage.Size = new System.Drawing.Size(805, 450);
            this.pnlAttendanceManage.TabIndex = 0;
            // 
            // AttendanceManegement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAttendanceManage);
            this.Name = "AttendanceManegement";
            this.Text = "AttendanceManegement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAttendanceManage;
    }
}