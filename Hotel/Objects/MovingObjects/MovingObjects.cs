using System.Drawing;

namespace Hotel.Objects.MovingObjects
{
    public abstract class MovingObjects : Entity
    {
        /// <summary>
        /// Every entitiy uses a speed that needs to be accessed from here
        /// </summary>
        protected float Speed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="graphics"></param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(Image, Position.X, Position.Y, Size.Width, Size.Height);
        }
    }
}
