using System;
using System.Collections.Generic;

namespace rover_alg
{
    class Program
    {
        public enum Direction
        {
            North = 'N',
            South = 'S',
            West = 'W',
            East = 'E'
        }

        public enum CommandDirection
        {
            Left = 0,
            Right = 1
        }

        class Rover : Vehicle
        {

            public override void Move()
            {
                switch (Direction)
                {
                    case (char)Program.Direction.North:
                        Y += 1;
                        break;
                    case (char)Program.Direction.South:
                        Y -= 1;
                        break;
                    case (char)Program.Direction.East:
                        X += 1;
                        break;
                    case (char)Program.Direction.West:
                        X -= 1;
                        break;
                    default:
                        break;
                }
            }

        }

        public static char[] RemoveRepeatedSteps(char[] commands)
        {
            List<string> repeatedCommandList = new List<string>() { "LLLL", "RRRR", "LMLMLMLM", "RMRMRMRM" };
            string tempCommand = new string(commands);
            foreach (var item in repeatedCommandList)
            {
                while (true)
                    if (tempCommand.Contains(item))
                        tempCommand = tempCommand.Replace(item, "");
                    else break;
            }

            return tempCommand.ToCharArray();
        }

        static void Main(string[] args)
        {
            Dictionary<char, char[]> findNewDirection = new Dictionary<char, char[]>();
            // initial N  > command L =>  newDirection = findNewDirection['N'][0]
            // initial N  > command R =>  newDirection = findNewDirection['N'][1]

            findNewDirection.Add('N', new char[2] { (char)Direction.West, (char)Direction.East });
            findNewDirection.Add('W', new char[2] { (char)Direction.South, (char)Direction.North });
            findNewDirection.Add('S', new char[2] { (char)Direction.East, (char)Direction.West });
            findNewDirection.Add('E', new char[2] { (char)Direction.North, (char)Direction.South });


            string[] upperRightCoordinates = Console.ReadLine().Split(" ");
            Rover rover = new Rover();

            while (true)
            {
                var readRoverInfo = Console.ReadLine();
                if (readRoverInfo == null)
                    break;

                var roverInfo = readRoverInfo.Split(" ");
                var commands = Console.ReadLine().ToCharArray();

                if (roverInfo != null && commands != null)
                {
                    rover.X = int.Parse(roverInfo[0]);
                    rover.Y = int.Parse(roverInfo[1]);
                    rover.Direction = char.Parse(roverInfo[2]);

                    commands = RemoveRepeatedSteps(commands);

                    foreach (char command in commands)
                    {
                        if (command == 'M')
                            rover.Move();
                        else if (command == 'L')
                            rover.Direction = findNewDirection[rover.Direction][(int)CommandDirection.Left];
                        else if (command == 'R')
                            rover.Direction = findNewDirection[rover.Direction][(int)CommandDirection.Right];
                    }


                    Console.WriteLine("{0} {1} {2}", rover.X, rover.Y, rover.Direction);
                    
                }
                else
                    break;


            }


        }
    }
}
