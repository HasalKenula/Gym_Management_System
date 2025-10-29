using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Management_System.model;

namespace Gym_Management_System.pages.user
{
    public partial class Progress : Form
    {
        private readonly User _currentUser;
        public Progress(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        public Panel getUserProgress() {
            return pnlUserProgress;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
