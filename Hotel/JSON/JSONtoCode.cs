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
    class JSONtoCode
    {

        //static WebClient client = new WebClient();
        //static string json = File.ReadAllText(@"d:\hotel.layout"); // Reads file from local drive
        //static string text = client.DownloadString("http://sab.re/hotel.layout"); // Reads file from website
        //<Rooms> rooms = JsonConvert.DeserializeObject<List<Rooms>>(text); // puts the JSON data into object in Rooms.cs

        List<Rooms> rooms;
        public void JSONReading()
        {
            WebClient client = new WebClient();
            //string json = File.ReadAllText(@"d:\hotel.layout"); // Reads file from local drive
            string text = client.DownloadString("http://sab.re/hotel.layout"); // Reads file from website
            rooms = JsonConvert.DeserializeObject<List<Rooms>>(text); // puts the JSON data into object in Rooms.cs
        }
        
        public void PositionsXY() // Turns position from string to int
        {
            for (int i = 0; i < rooms.Count; i++) // Loops through the amount of rooms in rooms
            {
                string[] positionString = rooms[i].Position.Split(','); // splits every string at the comma, puts them in array "positionString"
                int[] positionInts = Array.ConvertAll<string, int>(positionString, int.Parse); // converts strings to ints, puts them in array "positionInts"

                foreach (int item in positionInts)
                {
                    rooms[i].PositionX = positionInts[0]; // sets X coordinate
                    rooms[i].PositionY = positionInts[1]; // sets Y coordinate
                }
            }
        }
        public void DimensionsXY() // Turns position from string to int
        {
            for (int i = 0; i < rooms.Count; i++) // Loops through the amount of rooms in rooms
            {
                string[] dimensionString = rooms[i].Dimention.Split(','); // splits every string at the comma, puts them in array "dimensionString"
                int[] dimensionInts = Array.ConvertAll<string, int>(dimensionString, int.Parse); // converts strings to ints, puts them in array "dimensionInts"

                foreach (int item in dimensionInts)
                {
                    rooms[i].DimensionX = dimensionInts[0]; // sets X size
                    rooms[i].DimensionY = dimensionInts[1]; // sets Y size
                }
            }
        }
        public void Roomlist()
        {
            JSONReading();
            PositionsXY();
            DimensionsXY();
        }
    }
}
