namespace Gym_Management_System.pages.user
{
    partial class Progress
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUserProgress = new System.Windows.Forms.Panel();
            this.pnlUserProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Progress";
            // 
            // pnlUserProgress
            // 
            this.pnlUserProgress.Controls.Add(this.label1);
            this.pnlUserProgress.Location = new System.Drawing.Point(-1, -3);
            this.pnlUserProgress.Name = "pnlUserProgress";
            this.pnlUserProgress.Size = new System.Drawing.Size(1482, 873);
            this.pnlUserProgress.TabIndex = 1;
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 873);
            this.Controls.Add(this.pnlUserProgress);
            this.Name = "Progress";
            this.Text = "MyStats";
            this.pnlUserProgress.ResumeLayout(false);
            this.pnlUserProgress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUserProgress;
    }
}