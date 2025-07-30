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
    public partial class UserSide : Form
    {
        public UserSide()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            UserMainMenu userMainMenu = new UserMainMenu(this);
            UserDashboard userDashboard = new UserDashboard();
            Panel embedDashboard = userDashboard.getUserDashboard();
            Panel embedUserMenu = userMainMenu.getMainMenu();
            splitpnlUser.Panel1.Controls.Add(embedUserMenu);
            splitpnlUser.Panel2.Controls.Add(embedDashboard);
            embedUserMenu.Dock = DockStyle.Fill;
            embedDashboard.Dock = DockStyle.Fill;
            
        }

        public Panel getContentPanel()
        {
            return splitpnlUser.Panel2;
        }
    }
}
