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
    public partial class AdminMainMenu : Form
    {
        private AdminSide adminSide;
        AdminDashboard adminDashboard = new AdminDashboard();
        Players_Add playersAdd = new Players_Add();
        Trainers_Add trainersAdd = new Trainers_Add();
        AttendanceManegement attendanceManegement = new AttendanceManegement();
        WorkoutManegement workoutManegement = new WorkoutManegement();

        public AdminMainMenu(AdminSide adminSideInstance)
        {
            InitializeComponent();
            adminSide = adminSideInstance;
        }

        public Panel getAdminMenuPanel()
        {
            return pnlAdminMenu;
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            Panel embedAdminDashboard = adminDashboard.getAdminDashboard();
            adminSide.getAdminContentPanel().Controls.Clear();
            adminSide.getAdminContentPanel().Controls.Add(embedAdminDashboard);
            embedAdminDashboard.Dock = DockStyle.Fill;
        }

        private void btnMemManage_Click(object sender, EventArgs e)
        {
            Panel embedPlayerAdd = playersAdd.getPlayersAddPanel();
            adminSide.getAdminContentPanel().Controls.Clear();
            adminSide.getAdminContentPanel().Controls.Add(embedPlayerAdd);
            embedPlayerAdd.Dock = DockStyle.Fill;
        }

        private void btnTrainerManage_Click(object sender, EventArgs e)
        {
            Panel embedTrainersAdd = trainersAdd.getTrainersAddPanel();
            adminSide.getAdminContentPanel().Controls.Clear();
            adminSide.getAdminContentPanel().Controls.Add(embedTrainersAdd);
            embedTrainersAdd.Dock = DockStyle.Fill;
        }

        private void btnAttendanceManage_Click(object sender, EventArgs e)
        {
            Panel embedAttendaceManage = attendanceManegement.getAttendaceManagement();
            adminSide.getAdminContentPanel().Controls.Clear();
            adminSide.getAdminContentPanel().Controls.Add(embedAttendaceManage);
            embedAttendaceManage.Dock = DockStyle.Fill;
        }

        private void btnWorkoutManagement_Click(object sender, EventArgs e)
        {
            Panel embedWorkoutManage = workoutManegement.getWorkoutManagement();
            adminSide.getAdminContentPanel().Controls.Clear();
            adminSide.getAdminContentPanel().Controls.Add(embedWorkoutManage);
            embedWorkoutManage.Dock = DockStyle.Fill;

        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            adminSide.Close();
        }
    }
}
