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
using Gym_Management_System.pages.user.dashboard.components;

namespace Gym_Management_System.pages.user
{
    public partial class UserDashboard : Form
    {
        private readonly User _currentUser;

        MembershipCard membershipCard;

        public UserDashboard(User user)
        {
            InitializeComponent();
            _currentUser = user;
            lblGreeting.Text = $"Hello, {_currentUser.Username}";
            membershipCard = new MembershipCard(_currentUser);
            tbleLayoutUserDashboard.Controls.Add(membershipCard.getMembershipCrd(), 0, 0);
        }

        public Panel getUserDashboard() {
            return pnlUserDashboard;
        }
    }
}
