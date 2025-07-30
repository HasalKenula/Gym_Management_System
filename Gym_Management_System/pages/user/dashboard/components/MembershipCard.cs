using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System.pages.user.dashboard.components
{
    public partial class MembershipCard : Form
    {
        public MembershipCard()
        {
            InitializeComponent();
        }

        public Panel getMembershipCrd()
        {
            return pnlMembershipCrd;
        }
    }
}
