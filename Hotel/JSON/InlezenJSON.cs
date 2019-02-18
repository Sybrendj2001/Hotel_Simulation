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
        public void Posities() // Hier worden de posities geregeld
        {
            
            for (int i = 0; i < kamers.Count; i++) // loopt door het aantal kamers dat geregistreerd staan in list kamers
            {
                string[] positionString = kamers[i].Position.Split(','); // split de string waar de komma staat
                int[] positionInts = Array.ConvertAll<string, int>(positionString, int.Parse); // convert alle strings naar ints

                foreach (int item in positionInts) // loopt voor elke coordinaat
                {
                    kamers[i].PositionX = positionInts[0]; // vult X positie in
                    kamers[i].PositionY = positionInts[1]; // vult Y positie in
                }
            }
        }
    }
}
