using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Settings
{
    public abstract class Layout
    {

        class Square : PictureBox
        {

        }

        static int yAs = 10;
        static int xAs = 8;
        static int groteHokjes = 64;
        Square[,] square = new Square[xAs, yAs];


    }
}
