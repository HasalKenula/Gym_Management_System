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
        public AdminDashboard()
        {
            InitializeComponent();
            LoadDashboardChart();

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

        //private void LoadDashboardChart()
        //{
        //    int trainerCount = GetTrainerCount();
        //    int memberCount = GetMemberCount();

        //    chart1.Series.Clear();

        //    Series series = chart1.Series.Add("Gym Stats");
        //    series.ChartType = SeriesChartType.Column; // or Pie, Bar, etc.

        //    series.Points.AddXY("Trainers", trainerCount);
        //    series.Points.AddXY("players", memberCount);

        //    series.IsValueShownAsLabel = true;

        //    chart1.Invalidate();
        //}

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
                chart1.Titles.Add("Gym Statistics");
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

                // Show data in message box for debugging
                //MessageBox.Show($"Chart Data:\nTrainers: {trainerCount}\nMembers: {memberCount}",
                //               "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "SELECT COUNT(*) FROM players";

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


    }
}
