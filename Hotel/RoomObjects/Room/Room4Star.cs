using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.RoomObjects.Room
{
    class Room4Star1D : Area
    {
        public Brush Color { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        Image imgRoom4Star1D = Image.FromFile("../../Resources/Room4.png");
        public Image Images;
        public Room4Star1D(int dataArrayJSON)
        {
            JSON.JSONtoCode _roomdata = new JSON.JSONtoCode();
            _roomdata.Roomlist(); // initiates everything in JSONtoCode.cs

            Position = new Point(_roomdata.rooms[dataArrayJSON].PositionX * 100, MainForm.yAxis * 100 - (_roomdata.rooms[dataArrayJSON].PositionY * 100));
            Size = new Size(_roomdata.rooms[dataArrayJSON].DimensionX * 100, _roomdata.rooms[dataArrayJSON].DimensionY * 100);
            //Color = color;
            Images = imgRoom4Star1D;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="graphics">...</param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(Images, Position.X, Position.Y, Size.Width, Size.Height);
            //graphics.FillRectangle(Color, Position.X, Position.Y, Size.Width, Size.Height);
        }
    }
    class Room4Star2D : Area
    {
        public Brush Color { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        Image imgRoom4Star2D = Image.FromFile("../../Resources/Room42D.png");
        public Image Images;
        public Room4Star2D(int dataArrayJSON)
        {
            JSON.JSONtoCode _roomdata = new JSON.JSONtoCode();
            _roomdata.Roomlist(); // initiates everything in JSONtoCode.cs

            Position = new Point(_roomdata.rooms[dataArrayJSON].PositionX * 100, MainForm.yAxis * 100 - (_roomdata.rooms[dataArrayJSON].PositionY * 100) - 100);
            Size = new Size(_roomdata.rooms[dataArrayJSON].DimensionX * 100, _roomdata.rooms[dataArrayJSON].DimensionY * 100);
            //Color = color;
            Images = imgRoom4Star2D;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="graphics">...</param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(Images, Position.X, Position.Y, Size.Width, Size.Height);
            //graphics.FillRectangle(Color, Position.X, Position.Y, Size.Width, Size.Height);
        }
    }
}
