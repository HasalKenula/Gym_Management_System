using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Management_System.services;
using static System.Net.Mime.MediaTypeNames;

namespace Gym_Management_System.pages.admin
{
    public partial class AttendanceManegement : Form
    {
        public AttendanceManegement()
        {
            InitializeComponent();
            SetupTableHeaders();
            CreateAttendanceTableIfNotExists();
            LoadAttendenceData();
        }

        public Panel getAttendaceManagement()
        {
            return pnlAttendanceManage;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        

        private void SetupTableHeaders()
        {
            string[] columnNames = { "Attendance ID", "Member ID", "Member_type", "Date", "Check-in Time", "Check-out Time", "Status" };

            tableLayoutPanel1.ColumnCount = columnNames.Length;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.Controls.Clear();

            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            // 🔹 Fix header height
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F)); // fixed height (35px)

            for (int i = 0; i < columnNames.Length; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnNames.Length));
            }

            for (int col = 0; col < columnNames.Length; col++)
            {
                Label lbl = new Label();
                lbl.Text = columnNames[col];
                lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.ForeColor = Color.White;
                lbl.BackColor = Color.FromArgb(45, 85, 155);
                lbl.Margin = new Padding(0);
                lbl.Padding = new Padding(0);

                tableLayoutPanel1.Controls.Add(lbl, col, 0);
            }
        }




        private void CreateAttendanceTableIfNotExists()
        {
            DatabaseConnection.Instance.GetConnection();

            string createTableQuery = @"
                            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='attendence' AND xtype='U')
                            BEGIN
                                CREATE TABLE attendence (
                                    attendance_id INT PRIMARY KEY,
                                    member_id INT,
                                    member_type VARCHAR(100),
                                    date DATE,
                                    check_in_time DATETIME,
                                    check_out_time DATETIME,
                                    status VARCHAR(100),
                                   
                                )
                            END";

            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            {
                try
                {

                    using (SqlCommand cmd = new SqlCommand(createTableQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Table creation failed: " + ex.Message);
                }
            }
        }


        private void LoadAttendenceData()
        {


            string query = "SELECT attendance_id, member_id, member_type, date, check_in_time, check_out_time, status FROM attendence";

            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            {
                try
                {


                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();


                    tableLayoutPanel1.RowCount = 1;


                    for (int i = tableLayoutPanel1.Controls.Count - 1; i >= 0; i--)
                    {
                        Control c = tableLayoutPanel1.Controls[i];

                        if (tableLayoutPanel1.GetRow(c) != 0)
                            tableLayoutPanel1.Controls.Remove(c);
                    }

                    int row = 1;

                    while (reader.Read())
                    {

                        tableLayoutPanel1.RowCount = row + 1;
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));


                        for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                        {
                            Label lbl = new Label();
                            lbl.Dock = DockStyle.Fill;
                            lbl.TextAlign = ContentAlignment.MiddleCenter;
                            lbl.AutoSize = true;

                            switch (col)
                            {
                                case 0: lbl.Text = reader["attendance_id"].ToString(); break;
                                case 1: lbl.Text = reader["member_id"].ToString(); break;
                                case 2: lbl.Text = reader["member_type"].ToString(); break;                             
                                case 3:
                                    DateTime dt = reader.GetDateTime(reader.GetOrdinal("date"));
                                    lbl.Text = dt.ToShortDateString();
                                    break;
                                case 4:
                                    DateTime dt1 = reader.GetDateTime(reader.GetOrdinal("check_in_time"));
                                    lbl.Text = dt1.ToString("HH:mm:ss");
                                    break;
                                case 5:
                                    DateTime dt2 = reader.GetDateTime(reader.GetOrdinal("check_out_time"));
                                    lbl.Text = dt2.ToString("HH:mm:ss");
                                    break;
                                case 6: lbl.Text = reader["status"].ToString(); break;
                            }
                            lbl.Tag = row;


                            lbl.Click += RowLabel_Click;

                            tableLayoutPanel1.Controls.Add(lbl, col, row);
                        }

                        row++;
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void submit_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            {
                try
                {



                    string query = @"INSERT INTO attendence 
                                (attendance_id, member_id, member_type, date, check_in_time, check_out_time, status)
                                VALUES (@attendance_id, @member_id, @member_type, @date, @check_in_time, @check_out_time, @status)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@attendance_id", int.Parse(textId.Text));
                        cmd.Parameters.AddWithValue("@member_id", int.Parse(textMemberId.Text));
                        cmd.Parameters.AddWithValue("@member_type", comboMemberType.Text);
                        cmd.Parameters.AddWithValue("@date", DateTime.Parse(textDate.Text));
                        cmd.Parameters.AddWithValue("@check_in_time", DateTime.Parse(textInDate.Text));
                        cmd.Parameters.AddWithValue("@check_out_time", DateTime.Parse(textOutDate.Text));
                        cmd.Parameters.AddWithValue("@status", comboStatus.Text);
                        


                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Attendance added successfully!");
                            LoadAttendenceData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DatabaseConnection.Instance.GetConnection();

            {
                try
                {


                   

                    string query = @"UPDATE attendence SET 
                                member_id = @member_id,
                                member_type = @member_type,
                                date = @date,                            
                                check_in_time = @check_in_time,
                                check_out_time = @check_out_time,
                                status = @status
                                WHERE attendance_id = @attendance_id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@attendance_id", int.Parse(textId.Text));
                        cmd.Parameters.AddWithValue("@member_id", int.Parse(textMemberId.Text));
                        cmd.Parameters.AddWithValue("@member_type", comboMemberType.Text);
                        cmd.Parameters.AddWithValue("@date", DateTime.Parse(textDate.Text));
                        cmd.Parameters.AddWithValue("@check_in_time", DateTime.Parse(textInDate.Text));
                        cmd.Parameters.AddWithValue("@check_out_time", DateTime.Parse(textOutDate.Text));
                        cmd.Parameters.AddWithValue("@status", comboStatus.Text);


                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("attendance updated successfully!");
                            LoadAttendenceData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update data.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }
        }

        private void RowLabel_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel == null) return;

            int row = (int)clickedLabel.Tag;


            string attendance_id = "";
            string member_id = "";
            string member_type = "";
            string date = "";
            string check_in_time = "";
            string check_out_time = "";
            string status = "";

            for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    if (tableLayoutPanel1.GetRow(c) == row && tableLayoutPanel1.GetColumn(c) == col && c is Label)
                    {
                        string value = c.Text;
                        switch (col)
                        {
                            case 0: attendance_id = value; break;
                            case 1: member_id = value; break;
                            case 2: member_type = value; break;
                            case 3: date = value; break;
                            case 4: check_in_time = value; break;
                            case 5: check_out_time = value; break;
                            case 6: status = value; break;
                        }
                    }
                }
            }


            textId.Text = attendance_id;
            textMemberId.Text = member_id;
            comboMemberType.Text = member_type;
            textDate.Text = date;
            textInDate.Text = check_in_time;
            textOutDate.Text = check_out_time;
            comboStatus.Text = status;


        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textId.Text))
            {
                MessageBox.Show("Please select a attendance to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this attendance?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            {
                try
                {

                    string query = "DELETE FROM attendence WHERE attendance_id = @attendance_id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@attendance_id", int.Parse(textId.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("attendence deleted successfully!");

                            // Clear fields
                            textId.Clear();
                            textMemberId.Clear();
                            comboMemberType.SelectedIndex = -1;
                            textDate.Clear();
                            textInDate.Clear();
                            textOutDate.Clear();
                            comboStatus.SelectedIndex = -1;
                            textDate.Clear();
                          

                            LoadAttendenceData(); // Refresh the table layout
                        }
                        else
                        {
                            MessageBox.Show("attendence not found or could not be deleted.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
