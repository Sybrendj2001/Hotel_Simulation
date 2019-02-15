using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace Hotel.JSON
{
    class InlezenJSON
    {
        static WebClient client = new WebClient();
        //static string json = File.ReadAllText(@"d:\hotel.layout"); // Leest de file vanaf een locatie op je schijf

        static string text = client.DownloadString("http://sab.re/hotel.layout"); // leest de file van een website.

        List<Rooms> kamers = JsonConvert.DeserializeObject<List<Rooms>>(text); // zet de JSON om in een lijst in Rooms.cs
    }
}
