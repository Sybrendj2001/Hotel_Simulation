using Hotel.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Hotel
{
    class ManGuest : Guest
    {
        Image imgPerson1 = Image.FromFile("../../Resources/Person1.png");
        private Image Images;

        public ManGuest(int x, int y)
        {
            Position = new Point(x, y);
            Images = imgPerson1;
        }
    }
}
