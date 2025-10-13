using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_Management_System.pages.user;
using Gym_Management_System.pages.admin;

namespace Gym_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Trainers_Add());
            //Application.Run(new Players_Add());
            //Application.Run(new AdminSide());
            //Application.Run(new UserSide());
            Application.Run(new Login());
        }
    }
}
