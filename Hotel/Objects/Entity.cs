using System.Drawing;
using Hotel.vector;

namespace Hotel.Objects
{
    public abstract class Entity
    {
        protected Vector2D Position { get; set; }       // every object needs a position, this will be a x-Axis and y-Axis in the grid
        protected Size Size { get; set; }               // every object needs a size, this will be a dimension 
        protected Image Image { get; set; }             // every object needs a image to draw to
        public abstract void Draw(Graphics graphics);   // every object needs to draw something, like an image
    }
}
