using System.Drawing;
using System.IO;
using Hotel.vector;

namespace Hotel.Objects.MovingObjects
{
    public class Elevator : MovingObjects
    {
        //Variables
        private const int _spawnFloor = 600; //Floor the elevator spawns 
        private const int _waitConfirm = 10; //Checks if the 2 ints are the same
        private readonly float _elevatorSpeed = 100.0f;
        private int _elevatorWaitCounter;

        //properties
        public int ChosenFloor { get; set; }
        public bool ReachedFloor { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">x-Axis</param>
        /// <param name="y">y-Axis</param>
        /// <param name="spawnSizeXy"></param>
        public Elevator(int x, int y, int spawnSizeXy, string imagePath = "../../Resources/Lift.png")
        {
            Position = new Vector2D(x, y);
            Speed = _elevatorSpeed;
            Size = new Size(spawnSizeXy, spawnSizeXy);
            ChosenFloor = _spawnFloor;
            ReachedFloor = true;
            if (imagePath != null && File.Exists(imagePath))
            {
                Image = Image.FromFile(imagePath); // Image that is used
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Vector2D GetPosition
        {
            get
            {
                return Position;
            }
        }

        /// <summary>
        /// Makes the elevator move up or down towards the selected floor
        /// This can happen when a user enters the elevator and selects a floor, or when a user calls the elevator from a different floor
        /// </summary>
        public void MoveElevator()
        {
            _elevatorWaitCounter++;
            if (_elevatorWaitCounter == _waitConfirm)
            {
                if (Position.Y > ChosenFloor)
                {
                    Position.Y -= (int)Speed;
                }
                else if (Position.Y < ChosenFloor)
                {
                    Position.Y += (int)Speed;
                }
                else if (Position.Y == ChosenFloor && !ReachedFloor)
                {
                    ReachedFloor = true;
                    Window.HotelGame.ElevatorDestinationReached();
                }
                _elevatorWaitCounter = 0;
            }
        }

        /// <summary>
        /// Sets chosenfloor to be the same as personfloor, so that the elevator moves to the floor the person is on when the elevator is called.
        /// </summary>
        /// <param name="personFloor"></param>
        public void MoveToUser(int personFloor)
        {
            ChosenFloor = personFloor;
        }
    }
}