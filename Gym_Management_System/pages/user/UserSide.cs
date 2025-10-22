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
    public partial class UserSide : Form
    {
        private readonly User _currentUser;
        public UserSide(User user)
        {
            InitializeComponent();
            _currentUser = user;
            this.WindowState = FormWindowState.Maximized;
            UserMainMenu userMainMenu = new UserMainMenu(this, _currentUser);
            UserDashboard userDashboard = new UserDashboard(_currentUser);
            Panel embedDashboard = userDashboard.getUserDashboard();
            Panel embedUserMenu = userMainMenu.getMainMenu();
            splitpnlUser.Panel1.Controls.Add(embedUserMenu);
            splitpnlUser.Panel2.Controls.Add(embedDashboard);
            embedUserMenu.Dock = DockStyle.Fill;
            embedDashboard.Dock = DockStyle.Fill;
        }

        public User CurrentUser
        {
            get { return _currentUser; }
        }

        public Panel getContentPanel()
        {
            return splitpnlUser.Panel2;
        }
    }
}
