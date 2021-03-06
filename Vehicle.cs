using System;
namespace rover_alg
{
    public abstract class Vehicle
    {
        public int x { get; set; }
        public int y { get; set; }
        public char direction { get; set; }
        public abstract void Move();
    }

}
