namespace rover_alg
{

    public abstract class Vehicle
    {
        /// <summary>
        /// Cartesian Coordinate System  |  x point
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Cartesian Coordinate System  |  y point
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// A single character to determine the direction. ('N','W','S',E)
        /// </summary>
        public char Direction { get; set; }

        /// <summary>
        /// To move vehicle 
        /// </summary>
        public abstract void Move();
    }

}
