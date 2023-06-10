using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment_System
{
    static class Program
    {
        public static string Username { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Load());
           // Application.Run(new Forms.Home());
         
           // Application.Run(new Forms.Dash());


        }
    }
}
