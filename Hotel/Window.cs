using System;
using System.Drawing;
using System.Windows.Forms;
using Hotel.vector;

namespace Hotel
{
    public partial class Window : Form
    {
        //Constants
        private const int _defaultInterval = 80; //Standard Interval for the start
        //Variables
        public static Game HotelGame { get; set; }
        public static Timer HotelTimer { get; set; }

        /// <summary>
        /// Initializes the Game and the Timer
        /// </summary>
        public Window()
        {
            InitializeComponent();
            HotelGame = new Game();
            HotelTimer = new Timer
            {
                Interval = _defaultInterval
            };
            HotelTimer.Tick += Timer_Tick;
            HotelTimer.Start();
        }

        /// <summary>
        /// updates "game" and draws image
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e)
        {
            ActiveControl = pbxBackground;
            HotelGame.Update(pbxBackground.PointToScreen(Point.Empty).ToVector2D(), pbxBackground.Focused);
            pbxBackground.Image = HotelGame.Compose();
        }
    }
}
