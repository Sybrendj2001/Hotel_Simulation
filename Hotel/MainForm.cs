using Hotel.Persons;
using Hotel.RoomObjects.Room;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class MainForm : Form
    {
        private List<Area> _rooms;
        private List<Guest> _persons;

        private Bitmap _offscreenBitmap;
        private Graphics _graphics;



        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _rooms = new List<Area>();
            _persons = new List<Guest>();
            _offscreenBitmap = new Bitmap(500, 500);

            Area roomStar001 = new Room1Star(100, 100, 200, 100, Brushes.Red);
            _rooms.Add(roomStar001);
            _rooms.Add(new Room2Star(300, 100, 200, 100, Brushes.Yellow));

            _graphics = Graphics.FromImage(_offscreenBitmap);

            JSON.JSONtoCode _roomdata = new JSON.JSONtoCode();
            //_roomdata.Roomlist(); // initiates everything in JSONtoCode.cs

            Guest vincent = new Guest();
            _persons.Add(vincent);

            Draw(_graphics);

            

            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _offscreenBitmap = new Bitmap(500, 500);

            UpdateAll();
            Draw(Graphics.FromImage(_offscreenBitmap));
            Refresh();
        }

        public void UpdateAll()
        {
            foreach (Guest person in _persons)
            {
                person.Update();
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Area area in _rooms)
            {
                area.Draw(g);
            }

            foreach (Guest person in _persons)
            {
                person.Draw(g);
            }

          pbBackground.Image = _offscreenBitmap;
        }

        private void pbBackground_Click(object sender, EventArgs e)
        {

        }


    }
}
