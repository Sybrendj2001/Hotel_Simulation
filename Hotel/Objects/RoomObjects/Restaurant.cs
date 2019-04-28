using System.Drawing;
using System.IO;
using Hotel.vector;

namespace Hotel.Objects.RoomObjects
{
    class Restaurant : Area
    {
        private int Capacity { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="convertionRoom">Gives the values of a JSON file to the constructor</param>
        /// <param name="squareSize">Width and Height of a picture</param>
        /// <param name="yAxis">y-Axis</param>
        public Restaurant(JSON.ConvertionRoom convertionRoom, int squareSize, int yAxis, string imagePath = "../../Resources/Restaurant.png")
        {
            Position = new Vector2D(convertionRoom.PositionX * squareSize, yAxis * squareSize - (convertionRoom.PositionY * squareSize));
            Size = new Size(convertionRoom.DimensionX * squareSize, convertionRoom.DimensionY * squareSize);
            if (imagePath != null && File.Exists(imagePath))
            {
                Image = Image.FromFile(imagePath); // Image that is used
            }
            Capacity = convertionRoom.Capacity;
        }
    }
}
