using System;

namespace rover_alg
{
    class Program
    {
        abstract class Vehicle
        {
            public int x {get;set;}
            public int y {get;set;}
            public char direction {get;set;}
            public abstract void Move();
        }

        class Rover:Vehicle
        {
            public override void Move()
            {

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
        }
    }
}
