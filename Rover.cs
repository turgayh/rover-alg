using System;

namespace rover_alg
{
    public class Rover : Vehicle
    {

        public override void Move()
        {
            switch (Direction)
            {
                case (char)Enums.Direction.North:
                    Y += 1;
                    break;
                case (char)Enums.Direction.South:
                    Y -= 1;
                    break;
                case (char)Enums.Direction.East:
                    X += 1;
                    break;
                case (char)Enums.Direction.West:
                    X -= 1;
                    break;
                default:
                    break;
            }
        }

        public void PrintInfo() 
        {
            Console.WriteLine("{0} {1} {2}", X, Y, Direction);
        }

    }
}
