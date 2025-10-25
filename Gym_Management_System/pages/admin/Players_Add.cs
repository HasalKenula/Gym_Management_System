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

namespace Gym_Management_System.pages.admin
{
    public partial class Players_Add : Form
    {
        public Players_Add()
        {
            InitializeComponent();
            CreateTrainerTableIfNotExists();
            SetupTableHeaders();
            LoadTrainerData();

        }

        public Panel getPlayersAddPanel()
        {
            return pnlPlayersAdd;
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
                            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='users' AND xtype='U')
                            BEGIN
                                CREATE TABLE users (
                                    userid INT IDENTITY(1,1) PRIMARY KEY,
                                    username VARCHAR(50),
                                    password VARCHAR(255),
                                    name VARCHAR(50),
                                    role VARCHAR(50),
                                    age int,
                                    email VARCHAR(100),
                                    contact VARCHAR(50),
                                    height decimal(5,2),
                                    weight decimal(5,2),
                                    trainer varchar(50),
                                    bloodgrp varchar(50),
                                    gender varchar(50),
                                    photo VARBINARY(MAX),
                                    joindate DATE
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


      

        private void LoadTrainerData()
        {


            string query = "SELECT userid, username, name, email, contact, joindate FROM users";

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
                                case 0: lbl.Text = reader["userid"].ToString(); break;
                                case 1: lbl.Text = reader["username"].ToString(); break;
                                case 2: lbl.Text = reader["name"].ToString(); break;
                                case 3: lbl.Text = reader["email"].ToString(); break;
                                case 4: lbl.Text = reader["contact"].ToString(); break;

                                case 5:
                                    DateTime dt = reader.GetDateTime(reader.GetOrdinal("joindate"));
                                    lbl.Text = dt.ToShortDateString();
                                    break;
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


        private void RowLabel_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel == null) return;

            int row = (int)clickedLabel.Tag;


            string id = "";
            string username = "";
            string fullname = "";
            string email = "";
            string contact = "";

            string joiningDate = "";

            for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    if (tableLayoutPanel1.GetRow(c) == row && tableLayoutPanel1.GetColumn(c) == col && c is Label)
                    {
                        string value = c.Text;
                        switch (col)
                        {
                            case 0: id = value; break;
                            case 1: username = value; break;
                            case 2: fullname = value; break;
                            case 3: email = value; break;
                            case 4: contact = value; break;

                            case 5: joiningDate = value; break;
                        }
                    }
                }
            }


            textId.Text = id;
            textUsername.Text = username;
            textFullname.Text = fullname;
            textEmail.Text = email;
            textContact.Text = contact;

            textDate.Text = joiningDate;


            try
            {
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();
                {

                    string query = "SELECT photo FROM users WHERE userid = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(id));

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            byte[] photoBytes = (byte[])result;
                            if (photoBytes.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(photoBytes))
                                {
                                    pictureUploadBox.Image = Image.FromStream(ms);
                                    pictureUploadBox.SizeMode = PictureBoxSizeMode.StretchImage; // optional
                                }
                            }
                            else
                            {
                                pictureUploadBox.Image = null; // Clear if empty byte array
                            }
                        }
                        else
                        {
                            pictureUploadBox.Image = null; // No image in DB
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load image: " + ex.Message);
            }
        }

        private void buttonBrowse_Click_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textImageUpload.Text = ofd.FileName;
                pictureUploadBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            {
                try
                {


                    byte[] photoBytes = null;
                    if (pictureUploadBox.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureUploadBox.Image.Save(ms, pictureUploadBox.Image.RawFormat);
                            photoBytes = ms.ToArray();
                        }
                    }

                    string query = @"INSERT INTO users 
                                ( username, name, email, contact, joindate, photo)
                                VALUES (@username, @name, @email, @contact, @joindate, @photo)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", textUsername.Text);
                        cmd.Parameters.AddWithValue("@name", textFullname.Text);
                        cmd.Parameters.AddWithValue("@email", textEmail.Text);
                        cmd.Parameters.AddWithValue("@contact", textContact.Text);   
                        cmd.Parameters.AddWithValue("@joindate", DateTime.Parse(textDate.Text)); // use DateTimePicker ideally
                        SqlParameter photoParam = new SqlParameter("@photo", SqlDbType.VarBinary, -1);
                        photoParam.Value = (object)photoBytes ?? DBNull.Value;
                        cmd.Parameters.Add(photoParam);


                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Player added successfully!");
                            LoadTrainerData();
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

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DatabaseConnection.Instance.GetConnection();

            {
                try
                {


                    byte[] photoBytes = null;
                    if (pictureUploadBox.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureUploadBox.Image.Save(ms, pictureUploadBox.Image.RawFormat);
                            photoBytes = ms.ToArray();
                        }
                    }

                    string query = @"UPDATE users SET 
                                username = @username,
                                name = @name,
                                email = @email,
                                contact = @contact,                         
                                joindate = @joindate,
                                photo = @photo
                                WHERE userid = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(textId.Text));
                        cmd.Parameters.AddWithValue("@username", textUsername.Text);
                        cmd.Parameters.AddWithValue("@name", textFullname.Text);
                        cmd.Parameters.AddWithValue("@email", textEmail.Text);
                        cmd.Parameters.AddWithValue("@contact", textContact.Text);
                        cmd.Parameters.AddWithValue("@joindate", DateTime.Parse(textDate.Text)); // ideally use DateTimePicker
                        SqlParameter photoParam = new SqlParameter("@photo", SqlDbType.VarBinary, -1);
                        photoParam.Value = (object)photoBytes ?? DBNull.Value;
                        cmd.Parameters.Add(photoParam);


                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Player updated successfully!");
                            LoadTrainerData();
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

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textId.Text))
            {
                MessageBox.Show("Please select a player to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this players?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            {
                try
                {

                    string query = "DELETE FROM users WHERE userid = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(textId.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Player deleted successfully!");

                            // Clear fields
                            textId.Clear();
                            textUsername.Clear();
                            textFullname.Clear();
                            textEmail.Clear();
                            textContact.Clear();                           
                            textDate.Clear();
                            pictureUploadBox.Image = null;
                            textImageUpload.Clear();

                            LoadTrainerData(); // Refresh the table layout
                        }
                        else
                        {
                            MessageBox.Show("Player not found or could not be deleted.");
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
