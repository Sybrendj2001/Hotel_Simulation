using System.Collections.Generic;
using Hotel.HotelGenerators;
using System.Drawing;
using System.Windows.Forms;
using Hotel.JSON;
using Hotel.Objects;
using Hotel.Objects.MovingObjects;
using Hotel.vector;
using Hotel.Events;

namespace Hotel
{
    public class Game
    {
        //properties
        public float PersonTrapSpeed { get; set; } = _defaultTrapSpeed;
        public bool EmergencyBool { get; set; }
        public bool CheckinBool { get; set; }
        private readonly Point _deletePerson = new Point(0, 0);

        //Variables
        private const int _bitmapWidth = 1000; // hard code for the width of the bitmap
        private const int _bitmapHeight = 1000; // hard code for the Height of the bitmap

        private const int _elevatorY = 600; // hard code for the Y-Axis to make the elevator left under in the bitmap
        private const int _elevatorX = 0; // hard code for the x-Axis to make the elevator left under in the bitmap

        private const int _squareSize = 100; //Hardcoded spawnsize for different rooms

        private const float _defaultTrapSpeed = 5.0f;
        
        //List
        private List<Entity> _areas;
        private readonly List<Person> _persons;

        //Readonlies
        private readonly Graphics _graphics;
        private readonly Bitmap _offscreenBitmap;
        private readonly Elevator _elevator;
        private readonly User _user;

        /// <summary>
        /// Will be run the first time the program starts.
        /// </summary>
        public Game()
        {
            _offscreenBitmap = new Bitmap(_bitmapWidth, _bitmapHeight);
            _persons = new List<Person>();
            _elevator = new Elevator(_elevatorX, _elevatorY, _squareSize);
            _user = new User();
            EventStart _eventStart = new EventStart();
            _graphics = Graphics.FromImage(_offscreenBitmap);
            HotelGridGenerator(); // Calls the method HotelGridGenerator, this method sets the pictures on the correct location.
            _eventStart.StartEventChecker();
        }

        /// <summary>
        /// Everything in Update will be executed every tick of the timer.
        /// </summary>
        public void Update(Vector2D pbxLocation, bool hasFocus)
        {
            StatusScreen(pbxLocation);
            _elevator.MoveElevator();
            _user.UsingElevator(_elevator.GetPosition);
            _user.MoveUser();
            _user.MoveUserThroughClickUser(pbxLocation, hasFocus);
            _user.WaitingForElevator();
            _user.StairSpeed = PersonTrapSpeed;
            foreach (Person person in _persons)
            {
                person.MovePerson(_deletePerson);
                person.StairSpeed = PersonTrapSpeed;
            }
        }

        /// <summary>
        /// Will create the first shown bitmap, with every objects into it.
        /// </summary>
        /// <returns>Return's a bitmap, which will be placed on the background.</returns>
        public Bitmap Compose()
        {
            DrawAreas();
            _elevator.Draw(_graphics);
            _user.Draw(_graphics);
            return _offscreenBitmap;
        }

        /// <summary>
        /// Will Draw all areas into the bitmap
        /// </summary>
        private void DrawAreas()
        {
            foreach (Entity area in _areas) // Will Draw all the areas which are stored in _areas.
            {
                area.Draw(_graphics);
            }

            foreach (Person person in _persons) // Will Draw all the persons which are stored in _persons.
            {
                person.Draw(_graphics);
            }
        }

        /// <summary>
        /// Will execute the generator in RoomGenerator. This will store the results in a list called _areas
        /// </summary>
        private void HotelGridGenerator()
        {
            JsonConverter jsonReader = new JsonConverter();
            List<ConvertionRoom> layoutRooms = jsonReader.JsonConvert();
            RoomGenerator roomGenerator = new RoomGenerator();
            roomGenerator.SetXyAxis(layoutRooms); //Gets the Highest number of the x-Axis and the y-Axis, those results will be used in the RoomGenerator.
            _areas = roomGenerator.Generator(layoutRooms);
        }

        /// <summary>
        /// Calls the ChosenFloor method in Elevator and gives it the value that was put in with this method
        /// </summary>
        /// <param name="floor"></param>
        public void MoveElevatorToFloor(int floor)
        {
            _elevator.ChosenFloor = floor;
            _elevator.ReachedFloor = false;
        }

        /// <summary>
        /// Makes the user exit the elevator upon arriving at the chosen floor
        /// </summary>
        public void ElevatorDestinationReached()
        {
            _user.ExitElevator();
        }

        /// <summary>
        /// Makes the elevator move to the person that called the elevator on a different floor
        /// </summary>
        /// <param name="personFloor"></param>
        public void ElevatorToPerson(int personFloor)
        {
            _elevator.MoveToUser(personFloor);
        }

        /// <summary>
        /// when clicking on the lobby, game will pause and a status screen will appear
        /// </summary>
        /// <param name="pbxLocation"></param>
        private void StatusScreen(Vector2D pbxLocation)
        {
            Vector2D mousePosition = Control.MousePosition.ToVector2D() - pbxLocation;
            bool whenToPause = (Control.MouseButtons == MouseButtons.Right && mousePosition.Y >= 600 && mousePosition.X >= 100 && mousePosition.X <= 900);
            if (whenToPause)
            {
                Window.HotelTimer.Stop();
                StatusScreen.StatusScreen statusScreen = new StatusScreen.StatusScreen();
                statusScreen.ShowDialog();
                Window.HotelTimer.Start();
            }
        }

        public void AddPerson()
        {
            _persons.Add(new Person());
        }
    }
}
