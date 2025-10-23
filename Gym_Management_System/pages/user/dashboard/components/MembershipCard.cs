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

namespace Gym_Management_System.pages.user.dashboard.components
{
    public partial class MembershipCard : Form
    {
        private readonly User _currentUser;
        public MembershipCard(User user)
        {
            InitializeComponent();
            _currentUser = user;
            showData(_currentUser);
        }

        public Panel getMembershipCrd()
        {
            return pnlMembershipCrd;
        }

        public void showData(User user) {
            lblMemberID.Text = user.Id;

        }
    }
}
