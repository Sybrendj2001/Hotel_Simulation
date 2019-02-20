using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.KamerObjecten
{
    class Lobby : Area
    {
        public Brush Color { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        Image imgLobby = Image.FromFile("../../Resources/Lobby.png");
        public Image Images;
        public Lobby(int x, int y, int width, int height, Brush color)
        {
            Position = new Point(x, y);
            Size = new Size(width, height);
            Color = color;
            Images = imgLobby;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="graphics">...</param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(Images, Position.X, Position.Y, Size.Width, Size.Height);
            // graphics.FillRectangle(Color, Position.X, Position.Y, Size.Width, Size.Height);
        }
    }
}
