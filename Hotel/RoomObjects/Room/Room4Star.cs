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
        public Room4Star1D(int x, int y, int width, int height)
        {
            Position = new Point(x, y);
            Size = new Size(width, height);
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
        public Room4Star2D(int x, int y, int width, int height)
        {
            Position = new Point(x, y-100);
            Size = new Size(width, height);
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
