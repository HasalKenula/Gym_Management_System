using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System.pages.admin
{
    public partial class AdminSide : Form
    {
        public AdminSide()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            AdminMainMenu adminMainMenu = new AdminMainMenu(this);
            AdminDashboard adminDashboard = new AdminDashboard();
            Panel embedAdminMenu = adminMainMenu.getAdminMenuPanel();
            Panel embedAdminDashboard = adminDashboard.getAdminDashboard();
            splitContAdmin.Panel1.Controls.Add(embedAdminMenu);
            splitContAdmin.Panel2.Controls.Add(embedAdminDashboard);
            embedAdminDashboard.Dock = DockStyle.Fill;
            embedAdminMenu.Dock = DockStyle.Fill;
        }

        public Panel getAdminContentPanel()
        {
            return splitContAdmin.Panel2;
        }
    }
}
