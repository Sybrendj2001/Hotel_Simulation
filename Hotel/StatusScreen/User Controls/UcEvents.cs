using System;
using System.Windows.Forms;

namespace Hotel.StatusScreen
{
    public partial class UcEvents : UserControl
    {
        //Initializes the component
        public UcEvents()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Starts the emergency
        /// </summary>
        /// <param name="sender">Mouse</param>
        /// <param name="e">Event</param>
        private void btnEmergency_Click(object sender, EventArgs e)
        {
            Window.HotelGame.EmergencyBool = !Window.HotelGame.EmergencyBool;
        }

        /// <summary>
        /// Starts a single checkIn
        /// </summary>
        /// <param name="sender">Mouse</param>
        /// <param name="e">Event</param>
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            Window.HotelGame.CheckinBool = !Window.HotelGame.CheckinBool;
        }
    }
}
