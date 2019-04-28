using System;
using System.Windows.Forms;

namespace Hotel.StatusScreen.User_Controls
{
    public partial class ConfigureHTE : UserControl
    {
        /// <summary>
        /// Enum for the different speeds that are used in the hotel while the simulation is playing
        /// </summary>
        private enum HotelSpeed
        {
            _hotelSpeedDefault = 20,
            _hotelSpeedTwoHunderd = 10,
            _hotelSpeedFourHunderd = 5,
            _hotelSpeedEightHunderd = 2
        };

        //Variables
        private readonly float _trapSpeedFifty = 2.5f;
        private readonly float _trapSpeedDefault = 5.0f;
        private readonly float _trapSpeedTwoHunderd = 10.0f;
        private readonly float _trapSpeedFourHunderd = 20.0f;


        public ConfigureHTE()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Will change the interval of the time if you click the button
        /// </summary>
        private void btnDefault_Click(object sender, EventArgs e)
        {
            Window.HotelTimer.Interval = (int)HotelSpeed._hotelSpeedDefault;
        }

        /// <summary>
        /// Will change the interval of the time if you click the button
        /// </summary>
        private void btn2x_Click(object sender, EventArgs e)
        {
            Window.HotelTimer.Interval = (int)HotelSpeed._hotelSpeedTwoHunderd;
        }

        /// <summary>
        /// Will change the interval of the time if you click the button
        /// </summary>
        private void btn4x_Click(object sender, EventArgs e)
        {
            Window.HotelTimer.Interval = (int)HotelSpeed._hotelSpeedFourHunderd;
        }

        /// <summary>
        /// Will change the interval of the time if you click the button
        /// </summary>
        private void btn8x_Click(object sender, EventArgs e)
        {
            Window.HotelTimer.Interval = (int)HotelSpeed._hotelSpeedEightHunderd;
        }

        /// <summary>
        /// Will change the interval of the Stairs if you click the button
        /// </summary>
        private void btnTrapSpeed50_Click(object sender, EventArgs e)
        {
            Window.HotelGame.PersonTrapSpeed = _trapSpeedFifty;
        }

        /// <summary>
        /// Will change the interval of the Stairs if you click the button
        /// </summary>
        private void btnTrapSpeed100_Click(object sender, EventArgs e)
        {
            Window.HotelGame.PersonTrapSpeed = _trapSpeedDefault;
        }

        /// <summary>
        /// Will change the interval of the Stairs if you click the button
        /// </summary>
        private void btnTrapSpeed200_Click(object sender, EventArgs e)
        {
            Window.HotelGame.PersonTrapSpeed = _trapSpeedTwoHunderd;
        }

        /// <summary>
        /// Will change the interval of the Stairs if you click the button
        /// </summary>
        private void btnTrapSpeed400_Click(object sender, EventArgs e)
        {
            Window.HotelGame.PersonTrapSpeed = _trapSpeedFourHunderd;
        }
    }
}
