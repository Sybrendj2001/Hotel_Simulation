using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    /// <summary>
    /// Hier staan de attributen van de kamers
    /// </summary>
    public class Rootobject
    {
        public Rooms[] Property1 { get; set; }
    }

    public class Rooms
    {
        public string AreaType { get; set; }
        public string Position { get; set; }
        public string Dimention { get; set; }
        public int Capacity { get; set; }
        public string Classification { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
    }

}
