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
using Gym_Management_System.model;
using Gym_Management_System.services;

namespace Gym_Management_System.pages.user
{
    public partial class Profile : Form
    {
        private readonly User _currentUser;
        public Profile(User user)
        {
            InitializeComponent();
            _currentUser = user;
            txtUserId.Text = _currentUser.Id;
            txtUsername.Text = _currentUser.Username;
            txtEmail.Text = _currentUser.Email;
            txtName.Text = _currentUser.Name;
            txtHeight.Text = _currentUser.Height.ToString();
            txtWeight.Text = _currentUser.Weight.ToString();
            txtAge.Text = _currentUser.Age.ToString();
            txtTrainer.Text = _currentUser.Trainer;
            cmbBldGrp.Text = _currentUser.BloodGrp;
            cmbGender.Text = _currentUser.Gender;
        }

        public Panel getUserProfile()
        {
            return pnlUserProfile;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Visible = true;

            txtName.Enabled = true;
            txtUsername.Enabled = true;
            txtEmail.Enabled = true;
            txtContactNo.Enabled = true;
            txtAge.Enabled = true;
            txtHeight.Enabled = true;
            txtWeight.Enabled = true;
            txtTrainer.Enabled = true;
            cmbBldGrp.Enabled = true;
            cmbGender.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnEdit.Enabled = true;

            txtName.Enabled = false;
            txtUsername.Enabled = false;
            txtEmail.Enabled = false;
            txtContactNo.Enabled = false;
            txtAge.Enabled = false;
            txtHeight.Enabled = false;
            txtWeight.Enabled = false;
            txtTrainer.Enabled = false;
            cmbBldGrp.Enabled = false;
            cmbGender.Enabled = false;


            string name = txtName.Text;
            string phoneNo = txtContactNo.Text;
            string age = txtAge.Text;
            string weight = txtWeight.Text;
            string height = txtHeight.Text;
            string bloodGrp = cmbBldGrp.Text;
            string gender = cmbGender.Text;
            string trainer = txtTrainer.Text;
            

            string query = "UPDATE users SET name=@name, contact=@contact, age=@age, weight=@weight, height=@height, bloodgrp=@bloodgrp, gender=@gender, trainer=@trainer WHERE username=@username;";

            string connectionString = DatabaseConnection.Instance.GetConnection().ConnectionString;

            using(SqlConnection connection =  new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@contact", phoneNo);
                        command.Parameters.AddWithValue("@age", age);
                        command.Parameters.AddWithValue("@weight", weight);
                        command.Parameters.AddWithValue("@height", height);
                        command.Parameters.AddWithValue("@bloodgrp", bloodGrp);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@trainer", trainer);
                        command.Parameters.AddWithValue("@username", _currentUser.Username);

                        int result = command.ExecuteNonQuery();
                        if (result <= 0)
                        {
                            MessageBox.Show("Error Occured.");
                        }
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
