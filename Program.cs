using System;

namespace rover_alg
{
    class Program
    {
        public enum Direction
        {
            North = 'N',
            South = 'S',
            Westh = 'W',
            Easth = 'E'
        }

        abstract class Vehicle
        {
            public int x {get;set;}
            public int y {get;set;}
            public char direction {get;set;}
            public abstract void Move();
        }

        class Rover:Vehicle
        {
            public Rover(int x, int y , char direction)
            {
                this.x = x;
                this.y = y;
                this.direction = direction;
            } 
            public override void Move()
            {
                switch(this.direction)
                {
                    case (char)Direction.North:
                        this.y += 1;
                        break;
                    case (char)Direction.South:
                        this.y -= 1;
                        break; 
                    case (char)Direction.Easth:
                        this.x += 1;
                        break;
                    case (char)Direction.Westh:
                        this.x -= 1;
                        break;
                    default:
                       break; 
                }
            }
        }

        static void Main(string[] args)
        {
            Rover q1 = new Rover(1,2,'N');
            q1.Move();
            Console.WriteLine("Hello World!!");
        }
    }
}
