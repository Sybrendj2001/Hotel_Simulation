using Hotel.KamerObjecten;
using Hotel.Persons;
using Hotel.RoomObjects;
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

        public static int yAxis ;
        public static int xAxis ;


        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _rooms = new List<Area>();
            _persons = new List<Guest>();
            _offscreenBitmap = new Bitmap(1000, 1000);

            getXandY();
            GenerateRooms();
            _graphics = Graphics.FromImage(_offscreenBitmap);

            JSON.JSONtoCode _roomdata = new JSON.JSONtoCode();
            _roomdata.Roomlist(); // initiates everything in JSONtoCode.cs


            //Guest vincent = new Guest();
            //_persons.Add(vincent);

            Draw(_graphics);



            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _offscreenBitmap = new Bitmap(1000, 1000);

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

        public void GenerateRooms()
        {
            JSON.JSONtoCode _roomdata = new JSON.JSONtoCode();
            _roomdata.Roomlist(); // initiates everything in JSONtoCode.cs

            int totalRooms = 0;

            for (int y = 0; y < 1; y++)
            {
                for (int x = 0; x < xAxis; x++)
                {
                    if(y == 0 && x == 0)
                    {
                        _rooms.Add(new Balie(x, y));
                    }
                    else
                    {
                        _rooms.Add(new Lobby(x, y));
                    }
                }
            }
            


            try
            {
                for (int y = 0; y < yAxis; y++)
                {

                    for (int x = 0; x < xAxis; x++)
                    {
                        if (_roomdata.rooms[totalRooms].AreaType == "Cinema")
                        {
                            _rooms.Add(new Cinema(totalRooms));
                        }
                        else if (_roomdata.rooms[totalRooms].AreaType == "Restaurant")
                        {
                            _rooms.Add(new Restaurant(totalRooms));
                        }
                        else if (_roomdata.rooms[totalRooms].AreaType == "Room" && _roomdata.rooms[totalRooms].Classification == "1 Star")
                        {
                            _rooms.Add(new Room1Star(totalRooms));
                        }
                        else if (_roomdata.rooms[totalRooms].AreaType == "Room" && _roomdata.rooms[totalRooms].Classification == "2 stars")
                        {
                            _rooms.Add(new Room2Star(totalRooms));
                        }
                        else if (_roomdata.rooms[totalRooms].AreaType == "Room" && _roomdata.rooms[totalRooms].Classification == "3 stars")
                        {
                            _rooms.Add(new Room3Star(totalRooms));
                        }
                        else if (_roomdata.rooms[totalRooms].AreaType == "Room" && _roomdata.rooms[totalRooms].Classification == "4 stars" && _roomdata.rooms[totalRooms].DimensionY == 1)
                        {
                            _rooms.Add(new Room4Star1D(totalRooms));
                        }
                        else if (_roomdata.rooms[totalRooms].AreaType == "Room" && _roomdata.rooms[totalRooms].Classification == "4 stars" && _roomdata.rooms[totalRooms].DimensionY == 2)
                        {
                            _rooms.Add(new Room4Star2D(totalRooms));
                        }
                        else if (_roomdata.rooms[totalRooms].AreaType == "Room" && _roomdata.rooms[totalRooms].Classification == "5 stars")
                        {
                            _rooms.Add(new Room5Star(totalRooms));
                        }
                        totalRooms++; // +1 everytime the forloop is running, this will make sure that every room will get into the bitmap
                        _graphics = Graphics.FromImage(_offscreenBitmap); //adds the room to the bitmap which is shown on the screen
                    }

                }

            }
            catch
            {
            }


        }
        public void getXandY()
        {

            JSON.JSONtoCode _roomdata = new JSON.JSONtoCode();
            _roomdata.Roomlist(); // initiates everything in JSONtoCode.cs
            for (int i = 0; i < _roomdata.rooms.Count; i++)
            {
                if (_roomdata.rooms[i].PositionY > yAxis)
                {
                    yAxis = _roomdata.rooms[i].PositionY; // will scroll through the array of PositionY to search the highest Y-axis, and will store it in yAxis
                }
                if (_roomdata.rooms[i].PositionX > xAxis)
                {
                    xAxis = _roomdata.rooms[i].PositionX; // will scroll through the array of PositionX to search the highest X-axis, and will store it in xAxis
                }
            }
            
        }
    }
}

