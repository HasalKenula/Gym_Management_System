using System;
using System.Windows.Forms;

namespace Gym_Management_System.model
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        //private void AdminDashboard_Load(object sender, EventArgs e)
        //{
        //    lblAdminName.Text = "Welcome, Admin!";
        //}

        private void btnMembers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Members section clicked.");
        }

        private void btnTrainers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trainers section clicked.");
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payments section clicked.");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports section clicked.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
