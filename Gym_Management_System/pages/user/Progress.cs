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
using Gym_Management_System.model;
using Gym_Management_System.services;

namespace Gym_Management_System.pages.user
{
    public partial class Progress : Form
    {
        private readonly User _currentUser;
        public Progress(User user)
        {
            InitializeComponent();
            _currentUser = user;

            // Null check added as a safeguard, though the caller should ensure user is not null
            if (_currentUser != null)
            {
                lblTitle.Text = $"Progress of {_currentUser.Name}";
                loadChart1Data();
                loadChart2Data();
            }
            else
            {
                lblTitle.Text = "User Progress";
            }
        }

        public Panel getUserProgress()
        {
            return pnlUserProgress;
        }

        public double getWeight(string userId)
        {
            double weight = 0.0;
            SqlConnection conn = null;

            try
            {
                conn = DatabaseConnection.Instance.GetConnection();

                string query = "SELECT weight FROM users WHERE userid = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        weight = Convert.ToDouble(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve user weight: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }

            return weight;
        }

        public double getHeight(string userId)
        {
            double height = 0.0;
            SqlConnection conn = null;

            try
            {
                conn = DatabaseConnection.Instance.GetConnection();

                string query = "SELECT height FROM users WHERE userid = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        height = Convert.ToDouble(result);
                    }
                }
            }
            catch (Exception ex)
            {
                // Changed the error message to be specific to height
                MessageBox.Show("Failed to retrieve user height: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }

            return height;
        }

        public void loadChart1Data()
        {
            // Ensure the chart control is available before trying to use it
            if (chart1 == null) return;

            // Use the User Id from the current user object
            string currentUserId = _currentUser?.Id;
            if (string.IsNullOrEmpty(currentUserId)) return;

            double height = getHeight(currentUserId);


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
            chart1.Titles.Add("Height");
            chart1.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

            // Create series
            Series series = new Series("Measurements");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.SteelBlue;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Arial", 10, FontStyle.Bold);
            series.LabelForeColor = Color.White;

            // Track the number of points added
            int pointsAdded = 0;

            // Add data points
            // Note: Keeping the check for height > 0. If height can be 0 and should be charted, remove the if condition.
            if (height > 0)
            {
                series.Points.AddXY("Height", height);
                pointsAdded++;

                // Customize points colors
                // Since this chart only shows Height, we only need to check for the first point (index 0)
                series.Points[0].Color = Color.FromArgb(65, 105, 225); // Royal Blue
            }

            // Removed the redundant check for pointsAdded >= 2 since only one point is added.

            chart1.Series.Add(series);

            // Refresh chart
            chart1.Invalidate();
        }

        public void loadChart2Data()
        {
            // Ensure the chart control is available before trying to use it
            if (chart2 == null) return; // 🛑 Changed from chart1 to chart2

            // Use the User Id from the current user object
            string currentUserId = _currentUser?.Id;
            if (string.IsNullOrEmpty(currentUserId)) return;

            double weight = getWeight(currentUserId);


            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            chart2.Titles.Clear();

            // Add ChartArea with proper styling
            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.BackColor = Color.Transparent;
            chart2.ChartAreas.Add(chartArea); // 🛑 Changed from chart1 to chart2

            // Add title
            chart2.Titles.Add("Weight"); // 🛑 Changed from chart1 to chart2
            chart2.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

            // Create series
            Series series = new Series("Measurements");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.SteelBlue;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Arial", 10, FontStyle.Bold);
            series.LabelForeColor = Color.White;

            // Track the number of points added
            int pointsAdded = 0;

            // Add data points and check if the value is meaningful before adding
            if (weight > 0)
            {
                series.Points.AddXY("Weight", weight);
                pointsAdded++;
            }


            // Customize points colors - CHECKING THE COUNT FOR SAFE ACCESS
            if (pointsAdded >= 1)
            {
                series.Points[0].Color = Color.FromArgb(34, 139, 34); // Changed to Forest Green for Weight
            }
            // Removed the check for pointsAdded >= 2 as only one point is being added here.


            chart2.Series.Add(series); // 🛑 Changed from chart1 to chart2

            // Refresh chart
            chart2.Invalidate(); // 🛑 Changed from chart1 to chart2
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}