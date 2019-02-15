﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Persons
{
    class Guest
    {


        public Point Position { get; set; }
        public Point WalkPerTick { get; set; }

        public Guest()
        {
            Position = new Point(50, 50);
            WalkPerTick = new Point(3, 0);
        }

        public void Update()
        {
            Position = new Point(Position.X + WalkPerTick.X, Position.Y + WalkPerTick.Y);
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Pink, Position.X, Position.Y, 10, 20);
        }
    }
}
