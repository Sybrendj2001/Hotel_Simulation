using System.Drawing;

namespace Hotel.vector
{
    public class Vector2D
    {
        //Variables
        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        /// Sets X and Y to 0
        /// </summary>
        public Vector2D()
        {
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// Sets an ...... to the X and Y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vector2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Operators
        public static Vector2D operator -(Vector2D left, Vector2D right)
        {
            return new Vector2D(left.X - right.X, left.Y - right.Y);
        }
    }

    public static class VectorExtensionMethods
    {
        /// <summary>
        /// Extension class for Vector2D
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static Vector2D ToVector2D(this Point point)
        {
            return new Vector2D(point.X, point.Y);
        }
    }
}
