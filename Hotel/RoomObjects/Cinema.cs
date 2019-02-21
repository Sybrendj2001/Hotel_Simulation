using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.RoomObjects
{
    class Cinema : Area
    {

        public Brush Color { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>


        Image imgCinema = Image.FromFile("../../Resources/Cinema.png");
        public Image Images;
        public Cinema(int dataArrayJSON)
        {
            JSON.JSONtoCode _roomdata = new JSON.JSONtoCode();
            _roomdata.Roomlist(); // initiates everything in JSONtoCode.cs

            Position = new Point(_roomdata.rooms[dataArrayJSON].PositionX * 100, MainForm.yAxis * 100 - (_roomdata.rooms[dataArrayJSON].PositionY * 100) - 100);
            Size = new Size(_roomdata.rooms[dataArrayJSON].DimensionX * 100, _roomdata.rooms[dataArrayJSON].DimensionY * 100);
            //Color = color;
            Images = imgCinema;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="graphics">...</param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(Images, Position.X, Position.Y, Size.Width, Size.Height);
        }
    }
}
