﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public abstract class Area
    {
        public Point Position { get; set; }
        public Size Size { get; set; }

        public abstract void Draw(Graphics g);
        
    }
}
