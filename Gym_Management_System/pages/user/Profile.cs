using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System.pages.user
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
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
        }
    }
}
