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
        public Cinema(int x, int y, int width, int height)
        {
            Position = new Point(x, y - 100);
            Size = new Size(width, height);
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
