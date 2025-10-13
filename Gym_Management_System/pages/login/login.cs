using System;
using System.Drawing;
using System.Windows.Forms;

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
            this.Show();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            //login credentials checking here
            string username = txtUsername.Text;
            string password = txtPassword.Text;

        }
    }
}
