using System.Collections.Generic;
using System.Drawing;
using Hotel.JSON;
using Hotel.RoomObjects;

namespace Hotel.HotelGenerators
{
    public class BitmapGenerator
    {
        private List<Person> _persons;
        private List<Area> _areas;
        private Bitmap _shownBitmap;
        private Graphics _graphics;

        public Image OffscreenBitmapGenerator()
        {
            _persons = new List<Person>();
            _areas = new List<Area>();
            _shownBitmap = new Bitmap(1000, 1000);

            HotelGridGenerator(); // Calls the method HotelGridGenerator, this method sets the pictures on the correct location.

            _graphics = Graphics.FromImage(_shownBitmap);

            return Draw(_graphics);
        }

        private Image Draw(Graphics graphics)
        {
            foreach (Area area in _areas)
            {
                area.Draw(graphics);
            }
            foreach (Person person in _persons)
            {
                person.Draw(graphics);
            }

            return _shownBitmap;
        }

        private void HotelGridGenerator()
        {
            var jsonReader = new JsonConverter();
            List<ConvertionRoom> layoutRooms = jsonReader.JsonConvert();
            var generator = new RoomGenerator();
            generator.GetXy(layoutRooms);
            _areas = generator.Generator(layoutRooms);
        }
        
    }
}