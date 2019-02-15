using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Hotel.JSON
{
    class InlezenJSON
    {
        static string json = File.ReadAllText(@"d:\hotel.layout"); // Leest de file

        List<Rooms> kamers = JsonConvert.DeserializeObject<List<Rooms>>(json); // zet de JSON om in een lijst in Rooms.cs
    }
}
