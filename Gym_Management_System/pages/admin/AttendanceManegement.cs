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
    public partial class AttendanceManegement : Form
    {
        public AttendanceManegement()
        {
            InitializeComponent();
        }

        public Panel getAttendaceManagement()
        {
            return pnlAttendanceManage;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
