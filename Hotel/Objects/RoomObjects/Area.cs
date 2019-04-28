using System.Drawing;

namespace Hotel.Objects.RoomObjects
{
    public abstract class Area : Entity
    {

        /// <summary>
        /// Every Area has a Areatype so it can get set to get drawn
        /// </summary>
        protected string AreaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="graphics"></param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(Image, Position.X, Position.Y, Size.Width, Size.Height);
        }
        protected bool Occupied { get; set; }
    }
}
