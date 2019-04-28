using System.Drawing;
using System.IO;
using Hotel.vector;

namespace Hotel.Objects.RoomObjects.GroundFloor
{
    class FrontDesk : Area
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">x-Axis</param>
        /// <param name="y">y-Axis</param>
        /// <param name="spawnSizeXy"></param>
        public FrontDesk(int x, int y, int spawnSizeXy, string imagePath = "../../Resources/Balie.png")
        {
            Position = new Vector2D(x, y);
            Size = new Size(spawnSizeXy, spawnSizeXy);
            if (imagePath != null && File.Exists(imagePath))
            {
                Image = Image.FromFile(imagePath); // Image that is used
            }
        }
    }
}