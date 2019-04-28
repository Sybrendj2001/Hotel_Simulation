using Hotel.RoomObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Hotel
{
    class Person : Area
    {        
        public Point WalkPerTick { get; set; }
        public Person(Point point, Size size, Point delta)
        {
            Position = point;
            Size = size;
            WalkPerTick = delta;
        }
        public override void Draw(Graphics graphics)
        {
            
        }
        public void Update()
        {
            Position = new Point(Position.X + WalkPerTick.X, Position.Y + WalkPerTick.Y);
        }
    }
}
