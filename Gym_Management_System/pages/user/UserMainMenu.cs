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
    public partial class UserMainMenu : Form
    {
        private UserSide userSide;
        UserDashboard userDashboard = new UserDashboard();
        Profile userProfile = new Profile();
        Progress userProgress = new Progress();

        public UserMainMenu(UserSide userSideInstance)
        {
            InitializeComponent();
            userSide = userSideInstance;
        }

        public Panel getMainMenu()
        {
            return pnlUserMainMenu;
        }

        private void btnUserDashboard_Click(object sender, EventArgs e)
        {
            Panel embedUserDashboard = userDashboard.getUserDashboard();
            userSide.getContentPanel().Controls.Clear();
            userSide.getContentPanel().Controls.Add(embedUserDashboard);
            embedUserDashboard.Dock = DockStyle.Fill;
        }

        private void btnUserProgress_Click(object sender, EventArgs e)
        {
            Panel embedUserProgress = userProgress.getUserProgress();
            userSide.getContentPanel().Controls.Clear();
            userSide.getContentPanel().Controls.Add(embedUserProgress);
            embedUserProgress.Dock = DockStyle.Fill;
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            Panel embedUserProfile = userProfile.getUserProfile();
            userSide.getContentPanel().Controls.Clear();
            userSide.getContentPanel().Controls.Add(embedUserProfile);
            embedUserProfile.Dock = DockStyle.Fill;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
