using System;
using System.Collections.Generic;
using System.Net;

namespace Hotel.JSON
{
    public class JsonConverter
    {
        private List<ConvertionRoom> _rooms;
        public void JsonReading()
        {
            using (WebClient client = new WebClient())
            {
                string text = client.DownloadString("http://sab.re/hotel.layout"); // Reads file from website
                _rooms = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ConvertionRoom>>(text); // puts the JSON data into object in Rooms.cs
            }
        }
        private void PositionAndDimensionParse() // Turns position from string to int
        {
            foreach (ConvertionRoom room in _rooms)
            {
                string[] positionString = room.Position.Split(','); // splits every string at the comma, puts them in array "positionString"
                int[] positionInt = Array.ConvertAll(positionString, int.Parse); // converts strings to ints, puts them in array "positionInts"

                string[] dimensionString = room.Dimension.Split(','); // splits every string at the comma, puts them in array "dimensionString"
                int[] dimensionInt = Array.ConvertAll(dimensionString, int.Parse); // converts strings to ints, puts them in array "dimensionInts"

                foreach (int item in positionInt)
                {
                    room.PositionX = positionInt[0]; // sets x coordinate
                    room.PositionY = positionInt[1]; // sets y coordinate
                }

                foreach (int item in dimensionInt)
                {
                    room.DimensionX = dimensionInt[0]; // sets x size
                    room.DimensionY = dimensionInt[1]; // sets y size
                }
            }
        }
       
        public List<ConvertionRoom> JsonConvert()
        {
            JsonReading();
            PositionAndDimensionParse();
            return _rooms;
        }
    }
}
