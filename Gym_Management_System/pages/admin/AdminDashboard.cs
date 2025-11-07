using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Gym_Management_System.services;

namespace Gym_Management_System.pages.admin
{
    public partial class AdminDashboard : Form
    {
        private Timer dashboardTimer = new Timer();

        private void DashboardTimer_Tick(object sender, EventArgs e)
        {
            LoadDashboardChart();
            LoadTrainerSpecializationChart();
        }
        public AdminDashboard()
        {
            InitializeComponent();
            LoadDashboardChart();
            LoadTrainerSpecializationChart();
            dashboardTimer.Interval = 2000; // 10,000 ms = 10 seconds
            dashboardTimer.Tick += DashboardTimer_Tick;
            dashboardTimer.Start();
        }

        public Panel getAdminDashboard()
        {
            return pnlAdminDashboard;
        }

        private void pnlAdminDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardChart();
        }



        private void LoadDashboardChart()
        {
            try
            {
                int trainerCount = GetTrainerCount();
                int memberCount = GetMemberCount();

                // Debug: Check if data is being retrieved
                Console.WriteLine($"Trainers: {trainerCount}, Members: {memberCount}");

                chart1.Series.Clear();
                chart1.ChartAreas.Clear();
                chart1.Titles.Clear();

                // Add ChartArea with proper styling
                ChartArea chartArea = new ChartArea("MainArea");
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisY.MajorGrid.Enabled = false;
                chartArea.BackColor = Color.Transparent;
                chart1.ChartAreas.Add(chartArea);

                // Add title
                chart1.Titles.Add("Trainers and Players amount");
                chart1.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

                // Create series
                Series series = new Series("Counts");
                series.ChartType = SeriesChartType.Column;
                series.Color = Color.SteelBlue;
                series.IsValueShownAsLabel = true;
                series.Font = new Font("Arial", 10, FontStyle.Bold);
                series.LabelForeColor = Color.White;

                // Add data points
                series.Points.AddXY("Trainers", trainerCount);
                series.Points.AddXY("Members", memberCount);

                // Customize points colors
                if (series.Points.Count > 0)
                {
                    series.Points[0].Color = Color.FromArgb(65, 105, 225); // Royal Blue
                    series.Points[1].Color = Color.FromArgb(34, 139, 34);  // Forest Green
                }

                chart1.Series.Add(series);

                // Refresh chart
                chart1.Invalidate();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading chart: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetTrainerCount()
        {
            int count = 0;
            SqlConnection conn = null;

            try
            {
                conn = DatabaseConnection.Instance.GetConnection();
                string query = "SELECT COUNT(*) FROM trainers";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    count = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get trainer count: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }

            return count;
        }

        private int GetMemberCount()
        {
            int count = 0;
            SqlConnection conn = null;

            try
            {
                conn = DatabaseConnection.Instance.GetConnection();
                string query = "SELECT COUNT(*) FROM users";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    count = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get players count: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }

            return count;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void LoadTrainerSpecializationChart()
        {
            try
            {
                // Clear previous data
                chartSpecialization.Series.Clear();
                chartSpecialization.ChartAreas.Clear();
                chartSpecialization.Titles.Clear();
                chartSpecialization.Legends.Clear();

                // Add ChartArea
                ChartArea chartArea = new ChartArea("SpecializationArea")
                {
                    BackColor = Color.Transparent
                };
                chartSpecialization.ChartAreas.Add(chartArea);

                // Add Title
                chartSpecialization.Titles.Add("Trainer Specializations");
                chartSpecialization.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

                // Add Legend
                Legend legend = new Legend("SpecializationLegend")
                {
                    Docking = Docking.Bottom,
                    Alignment = StringAlignment.Center
                };
                chartSpecialization.Legends.Add(legend);

                // Create Series and assign legend name
                Series series = new Series("Specialization")
                {
                    ChartType = SeriesChartType.Pie,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    IsValueShownAsLabel = true,
                    LabelForeColor = Color.White,
                    Legend = "SpecializationLegend" // Must match the legend added above
                };

                // Fetch data from database
                SqlConnection conn = null;
                try
                {
                    conn = DatabaseConnection.Instance.GetConnection();
                    string query = "SELECT specialization, COUNT(*) AS count FROM trainers GROUP BY specialization";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string specialization = reader["specialization"].ToString();
                            int count = Convert.ToInt32(reader["count"]);
                            series.Points.AddXY(specialization, count);
                        }
                    }
                }
                finally
                {
                    conn?.Close();
                }

                // Assign colors to points
                for (int i = 0; i < series.Points.Count; i++)
                {
                    var point = series.Points[i];
                    switch (point.AxisLabel)
                    {
                        case "Strength":
                            point.Color = Color.FromArgb(70, 130, 180); // Steel Blue
                            break;
                        case "Cardio":
                            point.Color = Color.FromArgb(255, 99, 71);  // Tomato
                            break;
                        case "Weight Loss":
                            point.Color = Color.FromArgb(60, 179, 113); // Medium Sea Green
                            break;
                        default:
                            point.Color = Color.Gray;
                            break;
                    }
                }

                // Add series to chart
                chartSpecialization.Series.Add(series);

                // Refresh chart
                chartSpecialization.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading specialization chart: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
