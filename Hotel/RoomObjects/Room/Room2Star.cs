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
        Image imgRoom2Star = Image.FromFile("../../Resources/Room2.png");
        public Image Images;
        public Room2Star(int x, int y, int width, int height)
        {
            Position = new Point(x, y);
            Size = new Size(width , height);
            //Color = color;
            Images = imgRoom2Star;
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
