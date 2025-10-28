using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Gym_Management_System.model;
using Gym_Management_System.pages.admin;
using Gym_Management_System.pages.user;
using Gym_Management_System.services;

namespace Gym_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetRoundedButton(btnSignin, 40);
            SetRoundedButton(btnSignup, 30);
            btnSignin.FlatStyle = FlatStyle.Flat;
            btnSignin.FlatAppearance.BorderSize = 0;
            btnSignin.BackColor = Color.DodgerBlue;
            btnSignin.ForeColor = Color.White;

            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.FlatAppearance.BorderSize = 0;
            btnSignup.BackColor = Color.DodgerBlue;
            btnSignup.ForeColor = Color.White;
        }


        private void SetRoundedButton(Button button, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = button.ClientRectangle;
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            button.Region = new Region(path);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Register regForm = new Register())
            {
                regForm.ShowDialog();
            }
            this.Hide();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            //login credentials checking here
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string query = "SELECT * FROM users WHERE username = @username AND password = @password;";
            string connString = DatabaseConnection.Instance.GetConnection().ConnectionString;

            using (SqlConnection connection = new SqlConnection(connString) )
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //user found
                                string dbUsername = reader["username"].ToString();
                                string dbPassword = reader["password"].ToString();
                                //string dbRole = reader["role"].ToString().Trim();
                                //string dbEmail = reader["email"].ToString();
                                //string dbUserId = reader["userid"].ToString();
                                //string dbName = reader["name"].ToString();
                                //string dbAge = reader["age"].ToString();
                                //string dbHeight = reader["height"].ToString();
                                //string dbWeight = reader["weight"].ToString();
                                //string dbContact = reader["contact"].ToString();
                                //string dbGender = reader["gender"].ToString();
                                //string dbBloodGrp = reader["bloodgrp"].ToString();
                                //string dbTrainer = reader["trainer"].ToString();

                                //byte[] photoBytes = null;
                                //if (reader["photo"] != DBNull.Value)
                                //{
                                //    photoBytes = (byte[])reader["photo"];
                                //}
//----------------------------------------------------------------------------------------
                                object GetValue(string columnName) => reader[columnName];

                                string dbRole = GetValue("role").ToString().Trim();

                                //int age = 0;
                                //if (GetValue("age") is int dbAgeInt) age = dbAgeInt;
                                //else int.TryParse(GetValue("age").ToString(), out age);

                                //double height = 0.0;
                                //if (GetValue("height") is double dbHeightDouble) height = dbHeightDouble;
                                //else double.TryParse(GetValue("height").ToString(), out height);

                                //double weight = 0.0;
                                //if (GetValue("weight") is double dbWeightDouble) weight = dbWeightDouble;
                                //else double.TryParse(GetValue("weight").ToString(), out weight);

                                //byte[] photoBytes = GetValue("photo") as byte[];


                                var _loggedInUser = new User
                                {
                                    Username = GetValue("username").ToString(),
                                    Email = GetValue("email").ToString(),
                                    //Name = GetValue("name").ToString(),
                                    //Phone = GetValue("contact").ToString(),
                                    //Trainer = GetValue("trainer").ToString(),
                                    //BloodGrp = GetValue("bloodgrp").ToString(),
                                    //Gender = GetValue("gender").ToString(),
                                    //Id = GetValue("userid").ToString(),
                                    //Age = age,
                                    //Height = height,
                                    //Weight = weight,
                                    //Photo = photoBytes,
                                };
                                //----------------------------------------------------------------------------------------------
                                //Console.WriteLine(dbRole);
                                if (dbPassword == password)
                                {
                                    MessageBox.Show("Login Success");
                                    //show window based on role


                                    if (string.Equals(dbRole, "user", StringComparison.OrdinalIgnoreCase))
                                    {
                                        UserSide userSide = new UserSide(_loggedInUser);
                                        userSide.Show();
                                        this.Hide();
                                    }
                                    else if (string.Equals(dbRole, "admin", StringComparison.OrdinalIgnoreCase))
                                    {
                                        AdminSide adminSide = new AdminSide();
                                        adminSide.Show();
                                        this.Hide();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Password");
                                    txtPassword.Text = "";
                                    return;
                                }
                            }
                            else
                            {
                                //user not found
                                MessageBox.Show("User not found !");
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                } 
            }
        }
    }
}
