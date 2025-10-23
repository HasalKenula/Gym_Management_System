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
    public partial class UserMainMenu : Form
    {
        private readonly User _currentUser;
        private UserSide userSide;
        UserDashboard userDashboard;
        Profile userProfile;
        Progress userProgress;

        public UserMainMenu(UserSide userSideInstance, User user)
        {
            InitializeComponent();
            userSide = userSideInstance;
            _currentUser = user;

            userDashboard = new UserDashboard(_currentUser);
            userProfile = new Profile(_currentUser);
            userProgress = new Progress(_currentUser);
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
            userSide.Close();
        }
    }
}
