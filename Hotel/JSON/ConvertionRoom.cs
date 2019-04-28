namespace Hotel.JSON
{
   public class ConvertionRoom
    {
        /// <summary>
        /// What kind of area is it, like Cinema/Room/Restaurant.
        /// </summary>
        public string AreaType { get; set; }

        /// <summary>
        /// X and Y axis of an AreaType.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// The Height and Width of a AreaType
        /// </summary>
        public string Dimension { get; set; }

        /// <summary>
        /// How many persons can get in a specific AreaType.
        /// </summary>
        public int Capacity { get; set; } 

        /// <summary>
        /// How many stars a room has.
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// Position is split into X and Y axis, this one stores the X-Axis
        /// </summary>
        public int PositionX { get; set; }

        /// <summary>
        /// Position is split into X and Y axis, this one stores the Y-Axis
        /// </summary>
        public int PositionY { get; set; } 

        /// <summary>
        /// Dimention is split into X and Y axis, this one stores the X-Axis
        /// </summary>
        public int DimensionX { get; set; }

        /// <summary>
        /// Dimention is split into X and Y axis, this one stores the Y-Axis
        /// </summary>
        public int DimensionY { get; set; }
    }
}
