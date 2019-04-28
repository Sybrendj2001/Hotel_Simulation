using System.Collections.Generic;
using Hotel.JSON;
using Hotel.Objects;
using Hotel.Objects.RoomObjects;
using Hotel.Objects.RoomObjects.Elevator;
using Hotel.Objects.RoomObjects.GroundFloor;
using Hotel.Objects.RoomObjects.Room;
using Hotel.Objects.RoomObjects.Stairs;

namespace Hotel.HotelGenerators
{
    class RoomGenerator
    {
        //Variables
        private const int _squareSize = 100;

        private int _maxYAxis;
        private int _maxXAxis;

        /// <summary>
        /// The method Generator will scroll through the list.
        /// It will return a list with areas.
        /// </summary>
        /// <param name="rooms">A list of rooms which still needs to be drawn.</param>
        /// <returns></returns>
        public List<Entity> Generator(List<ConvertionRoom> rooms)
        {
            List<Entity> areas = new List<Entity>();
            foreach (ConvertionRoom room in rooms)
            {
                switch (room.AreaType) //Makes rooms based on the Json file.
                {
                    case "Cinema":
                        areas.Add(new Cinema(room, _squareSize, _maxYAxis));
                        break;
                    case "Restaurant":
                        areas.Add(new Restaurant(room, _squareSize, _maxYAxis));
                        break;
                    case "Fitness":
                        areas.Add(new Fitness(room, _squareSize, _maxYAxis));
                        break;
                    case "Room":
                        areas.Add(new HotelRoom(room, _squareSize, _maxYAxis));
                        break;
                }
            }

            for (int i = 0; i < (_maxYAxis + 1); i++) // adds the Elevator-shaft and the staircase.
            {
                areas.Add(new ElevatorShaft(0, i * _squareSize, _squareSize));
                areas.Add(new Staircase((_maxXAxis + 1) * _squareSize, i * _squareSize, _squareSize));
            }

            for (int x = 0; x < _maxXAxis; x++) // adds the ground floor, like lobby and the front desk
            {
                if (x == 0)
                {
                    areas.Add(new FrontDesk(x * _squareSize + _squareSize, _maxYAxis * _squareSize, _squareSize));
                }
                else
                {
                    areas.Add(new Lobby(x * _squareSize + _squareSize, _maxYAxis * _squareSize, _squareSize));
                }
            }
            return areas;
        }

        /// <summary>
        /// Method SetXyAxis will look for the highest x-Axis and y-Axis and stores them in _yAxis and _xAxis.
        /// </summary>
        /// <param name="rooms">A list of rooms which still needs to be drawn.</param>
        public void SetXyAxis(List<ConvertionRoom> rooms)
        {
            foreach (ConvertionRoom room in rooms)
            {
                if (room.PositionY > _maxYAxis)
                {
                    _maxYAxis = room.PositionY; // will scroll through the array of PositionY to search the highest Y-axis, and will store it in yAxis
                }
                if (room.PositionX > _maxXAxis)
                {
                    _maxXAxis = room.PositionX; // will scroll through the array of PositionX to search the highest X-axis, and will store it in xAxis
                }
            }
        }
    }
}
