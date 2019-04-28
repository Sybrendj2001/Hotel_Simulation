using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using Hotel.vector;

namespace Hotel.Objects.MovingObjects
{
    public class User : Person
    {
        //Booleans
        private bool _reachedPosition;
        private bool _goingUp;
        private bool _goingDown;
        private bool _rightKeyDown;
        private bool _leftKeyDown;
        private bool _clickReached;
        private bool _inElevator;
        private bool _floorScreenVisible;

        //Part of this needs to become an enum eventually
        //Variables
        private const int _clickWalkStairsX = 940;       //Hardcoded x for the user has to be above to walk on the stairs for mouseclick

        private const int _elevatorXRequirement = 110;   //Hardcoded x for the user it needs to be atleast to use the elevator
        private const int _elevatorXMinimum = 100;       //Hardcoded x for the user it needs to be between to enter the elevator
        private const int _elevatorXUser = 35;           //Hardcoded x for the user to stand in the elevator

        private const int _allowRightX = 970;            //Hardcoded x for the user to be allowed to walk to the right
        private const int _allowLeftX = 100;             //Hardcoded x for the user to be allowed to walk to the left
        private const int _allowWalkStairsX = 900;       //Hardcoded x for the user to be allowed to walk on the stairs
        private const int _hotelHeightY = 600;           //Hardcoded y for the hotelheight so person cannot walk to the roof

        private const int _offStairsY = 100;             //Hardcoded y for the user to be allowed to walk left and right on the stairs
        private const int _outcomeX = 10;                //Outcome for x for the mouse
        private const int _mouseVariableLeft = 1000;     //Left boundary mouse
        private const int _mouseVariableRight = 800;     //Right boundary mouse

        private const int _elevatorWaitingTime = 10;
        private const int _elevatorWaitingPositionMin = 90;
        private const int _elevatorWaitingPositionMax = 110;

        private int _personWaitCounter;

        //Creation of a mouse position where there can be clicked
        private readonly Vector2D _clickDestination = new Vector2D(100, 600);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">x-Axis</param>
        /// <param name="y">y-Axis</param>
        public User()
        {
            Position = new Vector2D(_spawnX, _spawnY);
            _reachedPosition = true;
        }

        /// <summary>
        /// If user is standing next to the elevator shaft for a set amount of time, the function for moving the elevator to the user will be called
        /// </summary>
        public void WaitingForElevator()
        {
            if (Position.X > _elevatorWaitingPositionMin && Position.X < _elevatorWaitingPositionMax)
            {
                _personWaitCounter++;
            }
            if (_personWaitCounter == _elevatorWaitingTime)
            {
                Window.HotelGame.ElevatorToPerson(Position.Y);
                _personWaitCounter = 0;
            }
        }

        /// <summary>
        /// Method used to let the user automatically leave the elevator
        /// </summary>
        public void ExitElevator()
        {
            Position.X = _elevatorXRequirement;
            _inElevator = false;
        }
        /// <summary>
        /// Method used to let the user enter the elevator
        /// </summary>
        /// <param name="elevatorPosition"></param>
        public void UsingElevator(Vector2D elevatorPosition)
        {
            if (_inElevator)
            {
                if (_floorScreenVisible)
                {
                    _floorScreenVisible = false;
                    ChooseFloor chooseFloor = new ChooseFloor();
                    chooseFloor.ShowDialog();
                    Window.HotelGame.MoveElevatorToFloor(chooseFloor.ChosenFloor);
                }
                Position.Y = elevatorPosition.Y;
            }
            else if (Keyboard.IsKeyDown(Key.A) && Position.X < _elevatorXRequirement && Position.X >= _elevatorXMinimum && Position.Y == elevatorPosition.Y)
            {
                _floorScreenVisible = true;
                Position.X = _elevatorXUser;
                _inElevator = true;
            }
        }
        /// <summary>
        /// User can move using arrow keys, and can take the stairs
        /// </summary>
        public void MoveUser()
        {
            if (_reachedPosition)
            {
                if (Keyboard.IsKeyDown(Key.Right))
                {
                    _rightKeyDown = !_rightKeyDown;
                    _leftKeyDown = false;
                }
                else if (Keyboard.IsKeyDown(Key.Left))
                {
                    _rightKeyDown = false;
                    _leftKeyDown = !_leftKeyDown;
                }
                if (_rightKeyDown && Position.X < _allowRightX)
                {
                    Position.X += (int)Speed;
                }
                else if (_leftKeyDown && Position.X > _allowLeftX)
                {
                    Position.X -= (int)Speed;
                }
                if (Keyboard.IsKeyDown(Key.Up) && Position.Y > 0 && Position.X > _allowWalkStairsX)
                {
                    WalkStairs();
                }
                else if (Keyboard.IsKeyDown(Key.Down) && Position.Y < _hotelHeightY && Position.X > _allowWalkStairsX)
                {
                    WalkStairs();
                }
            }
            else
            {
                WalkStairs();
            }
        }

        /// <summary>
        /// Makes the user move through a left-mouse click
        /// </summary>
        /// <param name="pbxLocation">Will give the x and y of the pbBackground</param>
        /// <param name="hasFocus">Will give a true or false, this is needed otherwise it's possible to let the user move if it's minimized </param>
        public void MoveUserThroughClickUser(Vector2D pbxLocation, bool hasFocus)
        {
            //Setup for the User to walk to the click
            if (Control.MouseButtons == MouseButtons.Left && hasFocus)
            {
                Vector2D mousePosition = Control.MousePosition.ToVector2D() - pbxLocation;
                if (_allowLeftX <= mousePosition.X && mousePosition.X < _mouseVariableLeft - Size.Width && 0 <= mousePosition.Y && mousePosition.Y < _mouseVariableRight - Size.Height)
                {
                    _clickDestination.X = mousePosition.X - (mousePosition.X % _outcomeX);
                    _clickDestination.Y = mousePosition.Y - (mousePosition.Y % _allowLeftX);
                    _clickReached = false;
                    _reachedPosition = true;
                }
            }
            if (_clickReached)
            {
                return;
            }
            if (_clickDestination.Y < Position.Y && _clickDestination.Y != Position.Y && Position.X >= _clickWalkStairsX)
            {
                Position.Y -= (int)StairSpeed;  // moves the person up on the stairs.
            }
            else if (_clickDestination.Y != Position.Y && Position.X >= _clickWalkStairsX)
            {
                Position.Y += (int)StairSpeed; // moves the person down on the stairs
            }
            else if ((_clickDestination.Y == Position.Y && _clickDestination.X > Position.X) || (_clickDestination.Y != Position.Y && Position.X != _clickWalkStairsX))
            {
                Position.X += (int)Speed; // moves the person to the right
            }
            else if (_clickDestination.X < Position.X || _clickDestination.Y != Position.Y)
            {
                Position.X -= (int)Speed; // moves the person to the left
            }

            if (_clickDestination.Y == Position.Y && _clickDestination.X == Position.X)
            {
                _clickReached = true;
            }
        }

        /// <summary>
        /// Method for making the user walk up and down the stairs with one button press
        /// </summary>
        private void WalkStairs()
        {
            _reachedPosition = false;
            if (Keyboard.IsKeyDown(Key.Up) && Position.Y > 0)
            {
                _goingUp = true;
                _goingDown = false;
            }

            else if (Keyboard.IsKeyDown(Key.Down))
            {
                _goingDown = true;
                _goingUp = false;
            }

            if (_goingUp)
            {
                Position.Y -= (int)StairSpeed;
            }

            else if (_goingDown)
            {
                Position.Y += (int)StairSpeed;
            }

            if (Position.Y % _offStairsY == 0)
            {
                _reachedPosition = true;
                _goingDown = false;
                _goingUp = false;
            }

        }
    }
}
