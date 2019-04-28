using System;
using System.Drawing;
using System.IO;
using Hotel.vector;

namespace Hotel.Objects.MovingObjects
{
    public class Person : MovingObjects
    {
        //Properties
        public float StairSpeed { get; set; }     // Hardcoded speed for the NPCs to walk up the stairs
        private Vector2D GoalPosition { get; set; }
        private readonly float _personSpeed = 5.0f;  // Hardcoded personspeeds 

        //constants
        private const int _factor = 100;         // Hardcoded factor to convert X numbers
        private const int _personWidth = 25;     // Hardcoded width for a person
        private const int _personHeigth = 100;   // Hardcoded height for person
        private const int _boundaryRight = 940;  // Hardcoded Boundary for the right side of the hotel, will need to be soft when we have different layouts
        private const int _boundaryLeft = 100;   // Hardcoded Boundary for the left side of the hotel, will need to be soft when we have different layouts
        protected const int _spawnX = 100;         // Hardcoded Spawnpoint at the frontdesk
        protected const int _spawnY = 600;         // Hardcoded Spawnpoint at the frontdesk

        //Objects
        private readonly Random _rng;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">x-Axis</param>
        /// <param name="y">y-Axis</param>
        public Person(string imagePath = "../../Resources/Person1.png")
        {
            _rng = new Random();
            Speed = _personSpeed;
            Position = new Vector2D(_spawnX, _spawnY);
            Size = new Size(_personWidth, _personHeigth);
            if (imagePath != null && File.Exists(imagePath))
            {
                Image = Image.FromFile(imagePath); // Image that is used
            }
            GoalPosition = new Vector2D();
            RandomGoal();
        }

        /// <summary>
        /// Lets the person move to the left/right, depending on what their goal is.
        /// </summary>
        public void MovePerson(Point deleteperson)
        {
            if (Position.X >= _boundaryRight && Position.Y != GoalPosition.Y)
            {
                WalkStairs();
                Speed = 0;
            }
            else if (Position.Y == GoalPosition.Y)
            {
                Speed = -_personSpeed;
            }
            if (Position.X <= _boundaryLeft)
            {
                Speed = _personSpeed;
            }

            if (Position.X == GoalPosition.X && Position.Y == GoalPosition.Y)
            {
                Speed = 0;
                Size = new Size(deleteperson);
            }
            Position.X += (int)Speed;
        }

        /// <summary>
        /// Will let the NPCs walk up the stairs
        /// </summary>
        private void WalkStairs()
        {
            if (Position.Y != GoalPosition.Y && Position.Y > 0)
            {
                Position.Y -= (int)StairSpeed;
            }
        }

        /// <summary>
        /// Creates a random Goal for person to move to
        /// </summary>
        private void RandomGoal()
        {
            int x = _rng.Next(1, 8) * _factor;
            int y = _rng.Next(1, 6) * _factor;
            GoalPosition.X = x;
            GoalPosition.Y = y;
            Console.WriteLine("X-as: " + x + ", Y-As: " + y);
        }
    }
}
