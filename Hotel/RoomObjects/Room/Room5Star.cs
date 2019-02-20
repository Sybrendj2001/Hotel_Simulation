using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.RoomObjects.Room
{
    class Room5Star : Area
    {
        public Brush Color { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        Image imgRoom5Star = Image.FromFile("../../Resources/Room5.png");
        public Image Images;
        public Room5Star(int x, int y, int width, int height)
        {
            Position = new Point(x, y-100);
            Size = new Size(width, height);
            //Color = color;
            Images = imgRoom5Star;
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
