using Gym_Management_System.services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gym_Management_System.pages.admin
{
    public partial class WorkoutManegement : Form
    {
        public WorkoutManegement()
        {
            InitializeComponent();

        try
            {
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();
                EnsureWorkoutTableExists(conn);
                //MessageBox.Show("Database connection successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
            }
        }

        // Ensure WeeklyWorkoutPlans table exists
        private void EnsureWorkoutTableExists(SqlConnection conn)
        {
            string checkTableQuery = @"
            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'WeeklyWorkoutPlans')
            BEGIN
                CREATE TABLE WeeklyWorkoutPlans (
                    PlanID INT IDENTITY(1,1) PRIMARY KEY,
                    PlayerID INT NOT NULL,
                    DayOfWeek NVARCHAR(50),
                    Workout NVARCHAR(255),
                    Reps NVARCHAR(50),
                    TrainerName NVARCHAR(100),
                    CONSTRAINT FK_Player_Workout FOREIGN KEY (PlayerID) REFERENCES players(id) ON DELETE CASCADE
                )
            END";

            SqlCommand cmd = new SqlCommand(checkTableQuery, conn);
            cmd.ExecuteNonQuery();
        }

        public Panel getWorkoutManagement()
        {
            return pnlWorkoutManegment;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string playerId = txtMemberId.Text.Trim();
            if (string.IsNullOrEmpty(playerId))
            {
                MessageBox.Show("Please enter Player ID");
                return;
            }

            if (!IsPlayerExists(playerId))
            {
                MessageBox.Show("Player not found.");
                return;
            }

            lblMessage.Text = "Player found!";
            LoadWorkoutTable(playerId);
        }

        private bool IsPlayerExists(string playerId)
        {
            try
            {
                SqlConnection con = DatabaseConnection.Instance.GetConnection();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM players WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", playerId);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
                return false;
            }
        }

        private void LoadWorkoutTable(string playerId)
        {
            dgvWorkoutTable.Rows.Clear();
            SqlConnection con = DatabaseConnection.Instance.GetConnection();

            EnsureWorkoutTableExists(con); // make sure table exists before query

            SqlCommand cmd = new SqlCommand("SELECT * FROM WeeklyWorkoutPlans WHERE PlayerID = @id", con);
            cmd.Parameters.AddWithValue("@id", playerId);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dgvWorkoutTable.Rows.Add(
                        reader["DayOfWeek"],
                        reader["Workout"],
                        reader["Reps"],
                        reader["TrainerName"]
                    );
                }
            }
            else
            {
                string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                foreach (string day in days)
                    dgvWorkoutTable.Rows.Add(day, "", "", "");
            }

            reader.Close();
        }

        private void btnAssignPlan_Click(object sender, EventArgs e)
        {
            string playerId = txtMemberId.Text.Trim();
            if (string.IsNullOrEmpty(playerId))
            {
                MessageBox.Show("Please enter a valid Player ID.");
                return;
            }

            SqlConnection con = DatabaseConnection.Instance.GetConnection();
            EnsureWorkoutTableExists(con);

            try
            {
                // Delete existing plans for the player
                SqlCommand deleteCmd = new SqlCommand("DELETE FROM WeeklyWorkoutPlans WHERE PlayerID = @id", con);
                deleteCmd.Parameters.AddWithValue("@id", playerId);
                deleteCmd.ExecuteNonQuery();

                // Insert new rows
                foreach (DataGridViewRow row in dgvWorkoutTable.Rows)
                {
                    if (row.IsNewRow) continue;

                    SqlCommand insertCmd = new SqlCommand(@"
                    INSERT INTO WeeklyWorkoutPlans (PlayerID, DayOfWeek, Workout, Reps, TrainerName)
                    VALUES (@p, @d, @w, @r, @t)", con);

                    insertCmd.Parameters.AddWithValue("@p", playerId);
                    insertCmd.Parameters.AddWithValue("@d", row.Cells[0].Value ?? "");
                    insertCmd.Parameters.AddWithValue("@w", row.Cells[1].Value ?? "");
                    insertCmd.Parameters.AddWithValue("@r", row.Cells[2].Value ?? "");
                    insertCmd.Parameters.AddWithValue("@t", row.Cells[3].Value ?? "");

                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Workout plan assigned successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning plan: " + ex.Message);
            }
        }

        private void btnUpdatePlan_Click(object sender, EventArgs e)
        {
            string playerId = txtMemberId.Text.Trim();
            if (string.IsNullOrEmpty(playerId))
            {
                MessageBox.Show("Please enter a valid Player ID.");
                return;
            }

            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            EnsureWorkoutTableExists(conn);

            try
            {
                SqlCommand deleteCmd = new SqlCommand("DELETE FROM WeeklyWorkoutPlans WHERE PlayerID = @PlayerID", conn);
                deleteCmd.Parameters.AddWithValue("@PlayerID", playerId);
                deleteCmd.ExecuteNonQuery();

                foreach (DataGridViewRow row in dgvWorkoutTable.Rows)
                {
                    if (row.IsNewRow) continue;

                    SqlCommand insertCmd = new SqlCommand(@"
                    INSERT INTO WeeklyWorkoutPlans (PlayerID, DayOfWeek, Workout, Reps, TrainerName)
                    VALUES (@PlayerID, @DayOfWeek, @Workout, @Reps, @TrainerName)", conn);

                    insertCmd.Parameters.AddWithValue("@PlayerID", playerId);
                    insertCmd.Parameters.AddWithValue("@DayOfWeek", row.Cells[0].Value ?? "");
                    insertCmd.Parameters.AddWithValue("@Workout", row.Cells[1].Value ?? "");
                    insertCmd.Parameters.AddWithValue("@Reps", row.Cells[2].Value ?? "");
                    insertCmd.Parameters.AddWithValue("@TrainerName", row.Cells[3].Value ?? "");
                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Workout plan updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating plan: " + ex.Message);
            }
        }

        private void btnDeletePlan_Click(object sender, EventArgs e)
        {
            string playerId = txtMemberId.Text.Trim();
            if (string.IsNullOrEmpty(playerId))
            {
                MessageBox.Show("Please enter a valid Player ID.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this player's workout plan?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            EnsureWorkoutTableExists(conn);

            try
            {
                SqlCommand deleteCmd = new SqlCommand("DELETE FROM WeeklyWorkoutPlans WHERE PlayerID = @PlayerID", conn);
                deleteCmd.Parameters.AddWithValue("@PlayerID", playerId);
                int rowsAffected = deleteCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Workout plan deleted successfully.");
                    dgvWorkoutTable.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("No plan found for this player.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting plan: " + ex.Message);
            }
        }

        private void dgvWorkoutTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void pnlWorkoutManegment_Paint(object sender, PaintEventArgs e) { }
    }


}
