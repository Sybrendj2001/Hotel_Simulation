using System;
using System.Windows.Forms;

namespace Hotel
{
    static class Program
    {
        /// <summary>
        /// The main entry Vec2 for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window());
        }
    }
}
