using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Hotel.RoomObjects;

namespace Hotel.PersonObjects
{     
    class RandomGuest : Person
    {
        readonly Image _imgRandomGuestOne = Image.FromFile("../../Resources/RandomGuestOne.png");
        readonly Image _imgRandomGuestTwo = Image.FromFile("../../Resources/RandomGuestOne.png");
        readonly Image _imgRandomGuestThree = Image.FromFile("../../Resources/RandomGuestOne.png");
        readonly Image _imgRandomGuestFour = Image.FromFile("../../Resources/RandomGuestOne.png");
        readonly Image _imgRandomGuestFive = Image.FromFile("../../Resources/RandomGuestOne.png");
        private readonly Image _image;

        public RandomGuest(Point point, Size size, Point delta)
        {

            Random random = new Random();
            switch (random.Next(1,5))
            {
                case 1:
                    _image = _imgRandomGuestOne;
                    break;
                case 2:
                    _image = _imgRandomGuestOne;
                    break;
                case 3:
                    _image = _imgRandomGuestOne;
                    break;
                case 4:
                    _image = _imgRandomGuestOne;
                    break;
                case 5:
                    _image = _imgRandomGuestOne;
                    break;
            }
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(_image, Position.X, Position.Y, Size.Width, Size.Height);
        }
    }
}
