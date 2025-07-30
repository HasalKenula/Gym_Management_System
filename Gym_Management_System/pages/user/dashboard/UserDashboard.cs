using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Management_System.pages.user.dashboard.components;

namespace Gym_Management_System.pages.user
{
    public partial class UserDashboard : Form
    {
        MembershipCard membershipCard = new MembershipCard();

        public UserDashboard()
        {
            InitializeComponent();
            tbleLayoutUserDashboard.Controls.Add(membershipCard.getMembershipCrd(), 0, 0);
        }

        public Panel getUserDashboard() {
            return pnlUserDashboard;
        }
    }
}
