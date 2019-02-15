using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Hotel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            string json = File.ReadAllText(@"d:\hotel.layout"); // Leest de file
            List<Rooms> kamers = JsonConvert.DeserializeObject<List<Rooms>>(json); // zet de JSON om in een lijst in Rooms.cs
        }
    }
}
