using System;
using System.Windows.Forms;

namespace Hotel.StatusScreen
{
    public partial class StatusScreen : Form
    {
        /// <summary>
        /// Makes the class game able to show the statusscreen
        /// </summary>
        public StatusScreen()
        {
            InitializeComponent();
            configureHTE1.Hide();// hides info till you click the button
            events1.Hide();
        }

        /// <summary>
        /// when button1 is pressed, it will show the user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            configureHTE1.Show();
            configureHTE1.BringToFront();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            events1.Show();
            events1.BringToFront();
        }
    }
}
