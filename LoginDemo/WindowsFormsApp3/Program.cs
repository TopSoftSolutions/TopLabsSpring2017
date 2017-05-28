using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // CHANGE IT TO FileUserStore !!!!
            var inMemmoryUserStore = new InMemoryUserStore();
            var userService = new UserService(inMemmoryUserStore);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(userService));
        }
    }
}
