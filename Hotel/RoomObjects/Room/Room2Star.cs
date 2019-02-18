using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.RoomObjects.Room
{
    class Room2Star : Area
    {

        public Brush Color { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Room2Star(int x, int y, int width, int height, Brush color)
        {
            Position = new Point(x, y);
            Size = new Size(width +600, height);
            Color = color;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="graphics">...</param>
        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Color, Position.X, Position.Y, Size.Width, Size.Height);
        }
    }
}
