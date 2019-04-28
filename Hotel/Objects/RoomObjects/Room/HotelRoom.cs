using System.Drawing;
using System.IO;
using Hotel.vector;

namespace Hotel.Objects.RoomObjects.Room
{
    class HotelRoom : Area
    {
        //Constants
        private const int _dimTwoByOne = 1;//Dimensions 2x1 rooms
        private const int _dimTwoByTwo = 2;//Dimensions 2x2 rooms

        //Variables
        private int StarRoom { get; set; }

        /// <summary>
        /// Makes the switch able to detect which type of room is needed to be drawn and assigns the right number
        /// </summary>
        private enum Roomstars
        {
            RoomOneStars = 1,
            RoomTwoStars = 2,
            RoomThreeStars = 3,
            RoomFourStars = 4,
            RoomFiveStars = 5
        };

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="convertionRoom">Gives the values of a JSON file to the constructor</param>
        /// <param name="squareSize">Width and Height of a picture</param>
        /// <param name="yAxis">y-Axis</param>
        public HotelRoom(JSON.ConvertionRoom convertionRoom, int squareSize, int yAxis, string imagePath = "../../Resources/EmptyRoom.png")
        {
            Position = new Vector2D(convertionRoom.PositionX * squareSize, yAxis * squareSize - (convertionRoom.PositionY * squareSize));
            Size = new Size(convertionRoom.DimensionX * squareSize, convertionRoom.DimensionY * squareSize);
            AreaType = convertionRoom.AreaType;
            if (imagePath != null && File.Exists(imagePath))
            {
                switch (convertionRoom.Classification)// chooses the correct image for the set room in JSON
                {
                    case "1 Star":

                        Image = Image.FromFile("../../Resources/Room1.png");
                        StarRoom = (int)Roomstars.RoomOneStars;
                        break;
                    case "2 stars":
                        Image = Image.FromFile("../../Resources/Room2.png");
                        StarRoom = (int)Roomstars.RoomTwoStars;
                        break;
                    case "3 stars":
                        Image = Image.FromFile("../../Resources/Room3.png");
                        StarRoom = (int)Roomstars.RoomThreeStars;
                        break;
                    case "4 stars" when convertionRoom.DimensionY == _dimTwoByOne:
                        Image = Image.FromFile("../../Resources/Room4.png");
                        StarRoom = (int)Roomstars.RoomFourStars;
                        break;
                    case "4 stars" when convertionRoom.DimensionY == _dimTwoByTwo:
                        Image = Image.FromFile("../../Resources/Room42D.png");
                        StarRoom = (int)Roomstars.RoomFourStars;
                        Position = new Vector2D(convertionRoom.PositionX * squareSize, yAxis * squareSize - (convertionRoom.PositionY * squareSize) - squareSize);
                        break;
                    case "5 stars":
                        Image = Image.FromFile("../../Resources/Room5.png");
                        StarRoom = (int)Roomstars.RoomFiveStars;
                        Position = new Vector2D(convertionRoom.PositionX * squareSize, yAxis * squareSize - (convertionRoom.PositionY * squareSize) - squareSize);
                        break;
                }
            }
        }
    }
}
