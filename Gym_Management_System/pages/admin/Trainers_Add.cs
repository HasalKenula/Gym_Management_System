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
    public partial class Trainers_Add : Form
    {
        public Trainers_Add()
        {
            InitializeComponent();
            CreateTrainerTableIfNotExists();
            SetupTableHeaders();
            LoadTrainerData();
        }

        public Panel getTrainersAddPanel()
        {
            return pnlTrainerAdd;
        }


        private void SetupTableHeaders()
        {
            string[] columnNames = { "ID", "Username", "Full Name", "Email", "Contact", "Specialization", "Joining Date" };

            tableLayoutPanel1.ColumnCount = columnNames.Length;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.Controls.Clear();

            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            //  Fix header height
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

        private void CreateTrainerTableIfNotExists()
        {
            DatabaseConnection.Instance.GetConnection();

            string createTableQuery = @"
                            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='trainers' AND xtype='U')
                            BEGIN
                                CREATE TABLE trainers (
                                    id INT PRIMARY KEY,
                                    username VARCHAR(50),
                                    fullname VARCHAR(100),
                                    email VARCHAR(100),
                                    contact VARCHAR(20),
                                    specialization VARCHAR(100),
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

        private void pictureUploadBox_Click(object sender, EventArgs e)
        {

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

                    string query = @"INSERT INTO trainers 
                                (id, username, fullname, email, contact, specialization, joining_date, photo)
                                VALUES (@id, @username, @fullname, @email, @contact, @specialization, @joining_date, @photo)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(textId.Text));
                        cmd.Parameters.AddWithValue("@username", textUsername.Text);
                        cmd.Parameters.AddWithValue("@fullname", textFullname.Text);
                        cmd.Parameters.AddWithValue("@email", textEmail.Text);
                        cmd.Parameters.AddWithValue("@contact", textContact.Text);
                        cmd.Parameters.AddWithValue("@specialization", combospecialization.Text);
                        cmd.Parameters.AddWithValue("@joining_date", DateTime.Parse(textDate.Text)); // use DateTimePicker ideally
                        SqlParameter photoParam = new SqlParameter("@photo", SqlDbType.VarBinary, -1);
                        photoParam.Value = (object)photoBytes ?? DBNull.Value;
                        cmd.Parameters.Add(photoParam);


                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Trainer added successfully!");
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

        private void LoadTrainerData()
        {
             

            string query = "SELECT id, username, fullname, email, contact, specialization, joining_date FROM trainers";

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
                                case 0: lbl.Text = reader["id"].ToString(); break;
                                case 1: lbl.Text = reader["username"].ToString(); break;
                                case 2: lbl.Text = reader["fullname"].ToString(); break;
                                case 3: lbl.Text = reader["email"].ToString(); break;
                                case 4: lbl.Text = reader["contact"].ToString(); break;
                                case 5: lbl.Text = reader["specialization"].ToString(); break;
                                case 6:
                                    DateTime dt = reader.GetDateTime(reader.GetOrdinal("joining_date"));
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

                    string query = @"UPDATE trainers SET 
                                username = @username,
                                fullname = @fullname,
                                email = @email,
                                contact = @contact,
                                specialization = @specialization,
                                joining_date = @joining_date,
                                photo = @photo
                                WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(textId.Text));
                        cmd.Parameters.AddWithValue("@username", textUsername.Text);
                        cmd.Parameters.AddWithValue("@fullname", textFullname.Text);
                        cmd.Parameters.AddWithValue("@email", textEmail.Text);
                        cmd.Parameters.AddWithValue("@contact", textContact.Text);
                        cmd.Parameters.AddWithValue("@specialization", combospecialization.Text);
                        cmd.Parameters.AddWithValue("@joining_date", DateTime.Parse(textDate.Text)); // ideally use DateTimePicker
                        SqlParameter photoParam = new SqlParameter("@photo", SqlDbType.VarBinary, -1);
                        photoParam.Value = (object)photoBytes ?? DBNull.Value;
                        cmd.Parameters.Add(photoParam);


                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Trainer updated successfully!");
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
            string specialization = "";
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
                            case 5: specialization = value; break;
                            case 6: joiningDate = value; break;
                        }
                    }
                }
            }

            
            textId.Text = id;
            textUsername.Text = username;
            textFullname.Text = fullname;
            textEmail.Text = email;
            textContact.Text = contact;
            combospecialization.Text = specialization;
            textDate.Text = joiningDate;

            
            try
            {
                SqlConnection conn = DatabaseConnection.Instance.GetConnection();
                {
                    
                    string query = "SELECT photo FROM trainers WHERE id = @id";
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

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textId.Text))
            {
                MessageBox.Show("Please select a trainer to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this trainer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            SqlConnection conn = DatabaseConnection.Instance.GetConnection();
            {
                try
                {
                    
                    string query = "DELETE FROM trainers WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(textId.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Trainer deleted successfully!");

                            // Clear fields
                            textId.Clear();
                            textUsername.Clear();
                            textFullname.Clear();
                            textEmail.Clear();
                            textContact.Clear();
                            combospecialization.SelectedIndex = -1;
                            textDate.Clear();
                            pictureUploadBox.Image = null;
                            textImageUpload.Clear();

                            LoadTrainerData(); // Refresh the table layout
                        }
                        else
                        {
                            MessageBox.Show("Trainer not found or could not be deleted.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
