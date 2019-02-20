using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.KamerObjecten
{
    class Restaurant : Area
    {
        public Brush Color { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        Image imgRestaurant = Image.FromFile("../../Resources/Restaurant.png");
        public Image Images;
        public Restaurant(int x, int y, int width, int height)
        {
            Position = new Point(x, y);
            Size = new Size(width, height);
            
            Images = imgRestaurant;
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
