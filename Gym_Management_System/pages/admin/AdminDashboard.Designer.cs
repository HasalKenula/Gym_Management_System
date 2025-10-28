namespace Gym_Management_System.pages.admin
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlAdminDashboard = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.chartSpecialization = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAdminDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpecialization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdminDashboard
            // 
            this.pnlAdminDashboard.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlAdminDashboard.Controls.Add(this.label3);
            this.pnlAdminDashboard.Controls.Add(this.label2);
            this.pnlAdminDashboard.Controls.Add(this.chartSpecialization);
            this.pnlAdminDashboard.Controls.Add(this.label1);
            this.pnlAdminDashboard.Controls.Add(this.chart1);
            this.pnlAdminDashboard.Location = new System.Drawing.Point(12, 12);
            this.pnlAdminDashboard.Name = "pnlAdminDashboard";
            this.pnlAdminDashboard.Size = new System.Drawing.Size(1469, 865);
            this.pnlAdminDashboard.TabIndex = 0;
            this.pnlAdminDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdminDashboard_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(199, 669);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trainers Specialization ==>";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chartSpecialization
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSpecialization.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSpecialization.Legends.Add(legend1);
            this.chartSpecialization.Location = new System.Drawing.Point(808, 438);
            this.chartSpecialization.Name = "chartSpecialization";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSpecialization.Series.Add(series1);
            this.chartSpecialization.Size = new System.Drawing.Size(625, 411);
            this.chartSpecialization.TabIndex = 2;
            this.chartSpecialization.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(883, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "<== Trainers and Players Amount";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(28, 83);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(625, 411);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(681, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Analization";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 873);
            this.Controls.Add(this.pnlAdminDashboard);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.pnlAdminDashboard.ResumeLayout(false);
            this.pnlAdminDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpecialization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdminDashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpecialization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}