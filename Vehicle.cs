namespace rover_alg
{
    public abstract class Vehicle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Direction { get; set; }
        public abstract void Move();
    }

}
