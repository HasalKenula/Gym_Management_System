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
using Gym_Management_System.services;

namespace Gym_Management_System.pages.admin
{
    public partial class Players_Add : Form
    {
        public Players_Add()
        {
            InitializeComponent();
            CreateTrainerTableIfNotExists();
            SetupTableHeaders();
           
        }

        private void SetupTableHeaders()
        {

            string[] columnNames = { "ID", "Username", "Full Name", "Email", "Contact", "Joining Date" };

            tableLayoutPanel1.ColumnCount = columnNames.Length;
            tableLayoutPanel1.RowCount = 1;


            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.Controls.Clear();


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
                lbl.BackColor = Color.LightGray;

                tableLayoutPanel1.Controls.Add(lbl, col, 0);
            }
        }

        private void CreateTrainerTableIfNotExists()
        {
            DatabaseConnection.Instance.GetConnection();

            string createTableQuery = @"
                            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='players' AND xtype='U')
                            BEGIN
                                CREATE TABLE players (
                                    id INT PRIMARY KEY,
                                    username VARCHAR(50),
                                    fullname VARCHAR(100),
                                    email VARCHAR(100),
                                    contact VARCHAR(20),
                                    joining_date DATE,
                                    photo VARBINARY(MAX)
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
    }
}
