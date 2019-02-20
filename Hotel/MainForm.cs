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

        public int yAs = 6;
        public int xAs = 8;


        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _rooms = new List<Area>();
            _persons = new List<Guest>();
            _offscreenBitmap = new Bitmap(1000, 1000);

            //  Area roomStar001 = new Room1Star(100, 100, 200, 100, Brushes.Red);
            //_rooms.Add(roomStar001);
            //_rooms.Add(new Room2Star(300, 100, 200, 100, Brushes.Yellow));
            SetAs();
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

        public void SetAs()
        {
            JSON.JSONtoCode _roomdata = new JSON.JSONtoCode();
            _roomdata.Roomlist(); // initiates everything in JSONtoCode.cs
                                  // Console.WriteLine(_roomdata.rooms[1].AreaType);
                                   int totalRooms = 0;
                                   

            for (int y = 0; y < yAs; y++)
            {

                for (int x = 0; x < xAs; x++)
                {
                    
                    
                    Console.WriteLine(_roomdata.rooms[totalRooms].AreaType);
                    Console.WriteLine(_roomdata.rooms[totalRooms].Classification);
                    
                    if (_roomdata.rooms[totalRooms].AreaType == "Cinema" && _roomdata.rooms[totalRooms].DimensionY == 2)
                    {
                        _rooms.Add(new Cinema((_roomdata.rooms[totalRooms].PositionX * 100), (yAs * 100 - (_roomdata.rooms[totalRooms].PositionY * 100)), (_roomdata.rooms[totalRooms].DimensionX * 100), (_roomdata.rooms[totalRooms].DimensionY * 100)));
                        totalRooms++;
                    }
                    else if (_roomdata.rooms[totalRooms].AreaType == "Restaurant")
                    {
                         _rooms.Add(new Restaurant((_roomdata.rooms[totalRooms].PositionX * 100), (yAs * 100 - (_roomdata.rooms[totalRooms].PositionY * 100)), (_roomdata.rooms[totalRooms].DimensionX * 100), (_roomdata.rooms[totalRooms].DimensionY * 100)));
                        totalRooms++;
                    }
                    else if (_roomdata.rooms[totalRooms].AreaType == "Room" && _roomdata.rooms[totalRooms].Classification == "1 Star" && _roomdata.rooms[totalRooms].DimensionY == 1)
                    {
                        _rooms.Add(new Room1Star((_roomdata.rooms[totalRooms].PositionX * 100), (yAs * 100 - (_roomdata.rooms[totalRooms].PositionY * 100)), (_roomdata.rooms[totalRooms].DimensionX * 100), (_roomdata.rooms[totalRooms].DimensionY * 100)));
                        totalRooms++;
                    }
                    else if (_roomdata.rooms[totalRooms].AreaType == "Room" && _roomdata.rooms[totalRooms].Classification == "2 stars" && _roomdata.rooms[totalRooms].DimensionY == 1)
                    {
                        _rooms.Add(new Room2Star((_roomdata.rooms[totalRooms].PositionX * 100), (yAs * 100 - (_roomdata.rooms[totalRooms].PositionY * 100)), (_roomdata.rooms[totalRooms].DimensionX * 100), (_roomdata.rooms[totalRooms].DimensionY * 100)));
                        totalRooms++;
                    }
                    else if (_roomdata.rooms[totalRooms].AreaType == "Room" && _roomdata.rooms[totalRooms].Classification == "3 stars" && _roomdata.rooms[totalRooms].DimensionY == 1)
                    {
                        _rooms.Add(new Room3Star((_roomdata.rooms[totalRooms].PositionX * 100), (yAs * 100 - (_roomdata.rooms[totalRooms].PositionY * 100)), (_roomdata.rooms[totalRooms].DimensionX * 100), (_roomdata.rooms[totalRooms].DimensionY * 100)));
                        totalRooms++;
                    }
                    else if (_roomdata.rooms[totalRooms].AreaType == "Room" && _roomdata.rooms[totalRooms].Classification == "4 stars" && _roomdata.rooms[totalRooms].DimensionY == 1)
                    {
                        _rooms.Add(new Room4Star1D((_roomdata.rooms[totalRooms].PositionX * 100), (yAs * 100 - (_roomdata.rooms[totalRooms].PositionY * 100)), (_roomdata.rooms[totalRooms].DimensionX * 100), (_roomdata.rooms[totalRooms].DimensionY * 100)));
                        totalRooms++;
                    }
                    else if (_roomdata.rooms[totalRooms].AreaType == "Room" && _roomdata.rooms[totalRooms].Classification == "4 stars" && _roomdata.rooms[totalRooms].DimensionY == 2)
                    {
                        _rooms.Add(new Room4Star2D((_roomdata.rooms[totalRooms].PositionX * 100), (yAs * 100 - (_roomdata.rooms[totalRooms].PositionY * 100)), (_roomdata.rooms[totalRooms].DimensionX * 100), (_roomdata.rooms[totalRooms].DimensionY * 100)));
                        totalRooms++;
                    }
                    else if (_roomdata.rooms[totalRooms].AreaType == "Room" && _roomdata.rooms[totalRooms].Classification == "5 stars" && _roomdata.rooms[totalRooms].DimensionY == 2 )
                    {
                        _rooms.Add(new Room5Star((_roomdata.rooms[totalRooms].PositionX * 100), (yAs * 100 - (_roomdata.rooms[totalRooms].PositionY * 100)), (_roomdata.rooms[totalRooms].DimensionX * 100), (_roomdata.rooms[totalRooms].DimensionY * 100)));
                       //totalRooms++;
                    }
                    else if (x == 0 && y == 0)
                    {
                        
                    }

                    



                    // Area roomStar001 = new Room1Star(0, 600, 100, 100, Brushes.Gray);
                    //_rooms.Add(roomStar001);

                    _graphics = Graphics.FromImage(_offscreenBitmap);


                }

            }


        }

    }
}
