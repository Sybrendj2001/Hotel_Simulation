using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class ChooseFloor : Form
    {
        //Constants
        private const int _maxHeightY = 700;     //Maximum height for the elevator
        private const int _factor = 100;         //Factor
        private const int _minHeightY = 0;
        //Variables
        internal int ChosenFloor;
        /// <summary>
        /// Constructor
        /// </summary>
        public ChooseFloor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Activates the elevator to get to the floor it is designated
        /// Prevents the user from inputting invalid floor numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFloor_Click(object sender, EventArgs e)
        {
            try
            {
                ChosenFloor = Convert.ToInt32(txtSelectFloor.Text) + 1; //converts text to int, sets ground floor to 0
                if (ChosenFloor > _maxHeightY / _factor || ChosenFloor <= _minHeightY / _factor)
                {
                    lblError.Text = "Please enter a valid number!";
                    txtSelectFloor.Text = string.Empty;
                }
                else
                {
                    ChosenFloor = _maxHeightY - (ChosenFloor * _factor);
                    this.Dispose();
                }
            }
            catch
            {
                lblError.Text = "Please enter a valid number!";
                txtSelectFloor.Text = string.Empty;
            }

        }
    }
}
