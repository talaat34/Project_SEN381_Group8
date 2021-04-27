using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Project_Call_Center_Group_8
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //53, 210, 147
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBoxManager.Register();
            Application.Run(new AdministratorDashboard());
            MessageBoxManager.Unregister();
        }
    }
}
