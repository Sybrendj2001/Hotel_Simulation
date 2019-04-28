using System.Drawing;
using System.IO;
using Hotel.vector;

namespace Hotel.Objects.RoomObjects.Elevator
{
    class ElevatorShaft : Area
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">x-Axis</param>
        /// <param name="y">y-Axis</param>
        /// <param name="spawnSizeXy"></param>
        public ElevatorShaft(int x, int y, int spawnSizeXy, string imagePath = "../../Resources/LiftSchacht.png")
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
