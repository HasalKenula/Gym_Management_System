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
using BCrypt.Net;


namespace Gym_Management_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            CreateUserTableIfNotExists();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter your name")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Login login = new Login())
            {
                login.ShowDialog();
            }
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //register code here
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confPassword = txtConfPass.Text;
            string email = txtEmail.Text;
            string role = cmbRole.Text;

            if (username == "" ||  password == "" ||  confPassword == "" || email == "" || role == "")
            {
                MessageBox.Show("empty");
            }
            else
            {
                if(email.Contains("@"))
                {
                    if (password == confPassword)
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                        MessageBox.Show("ok");
                        SqlConnection connection = DatabaseConnection.Instance.GetConnection();
                        string query = "INSERT INTO users (username, password, email, role) VALUES (@username, @hashedPassword, @email, @role);";

                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@role", role);

                                int result = cmd.ExecuteNonQuery();
                                if(result > 0)
                                {
                                    MessageBox.Show("Registered Success");
                                }
                                connection.Close();
                            }
                        }catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match !");
                    }
                }
                else
                {
                    MessageBox.Show("Not valid email");
                }


            }

        }

        private void CreateUserTableIfNotExists()
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
    }
}
