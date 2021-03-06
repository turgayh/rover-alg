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
            West  = 'W',
            East  = 'E'
        }

        public enum commandDirection
        {
            Left = 0,
            Right = 1
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
                    case (char)Direction.East:
                        this.x += 1;
                        break;
                    case (char)Direction.West:
                        this.x -= 1;
                        break;
                    default:
                       break; 
                }
            }

        }

        public static char[] removeRepeatedSteps(char[] commands)
        {
            List<string> repeatedCommandList = new List<string>() {"LLLL","RRRR","LMLMLMLM","RMRMRMRM" };
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

            findNewDirection.Add('N', new char[2] { (char)Direction.West, (char)Direction.East});
            findNewDirection.Add('W', new char[2] { (char)Direction.South, (char)Direction.North });
            findNewDirection.Add('S', new char[2] { (char)Direction.East, (char)Direction.West });
            findNewDirection.Add('E', new char[2] { (char)Direction.North, (char)Direction.South });


            var upperRightCoordinates = Console.ReadLine().Split(" ");
            Rover rover = new Rover(0,0,'N') ;

            while (true)
            {
                var roverInfo = Console.ReadLine().Split(" ");
                var commands = Console.ReadLine().ToCharArray();
                if (roverInfo != null && commands != null)
                {
                    rover.x = Int32.Parse(roverInfo[0]);
                    rover.y = Int32.Parse(roverInfo[1]);
                    rover.direction = Char.Parse(roverInfo[2]);

                    commands = removeRepeatedSteps(commands);

                    foreach (var command in commands)
                    {
                        if (command == 'M')
                            rover.Move();
                        else if (command == 'L')
                            rover.direction = findNewDirection[rover.direction][(int)commandDirection.Left];
                        else if (command == 'R')
                            rover.direction = findNewDirection[rover.direction][(int)commandDirection.Right];
                    }


                    Console.WriteLine("{0} {1} {2}", rover.x, rover.y, rover.direction);
                }
                else
                    break;


            }


        }
    }
}
