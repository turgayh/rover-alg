using System;
namespace rover_alg
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] upperRightCoordinates = Console.ReadLine().Split(" ");
            Rover rover = new Rover();

            while (true)
            {
                var readRoverInfo = Console.ReadLine();
                if (readRoverInfo == null)
                    break;
                var roverInfo = readRoverInfo.Split(" ");

                var readCommands = Console.ReadLine();
                if (readCommands == null)
                    break;
                var commands = readCommands.ToCharArray();

                if (roverInfo != null && commands != null)
                {
                    rover.X = int.Parse(roverInfo[0]);
                    rover.Y = int.Parse(roverInfo[1]);
                    rover.Direction = char.Parse(roverInfo[2]);

                    commands = RoverHelper.RemoveRepeatedSteps(commands);

                    foreach (char command in commands)
                    {
                        if (command == 'M')
                            rover.Move();
                        else
                            rover.Direction = Direction.FindNewDirection(rover.Direction, command);
                    }


                    rover.PrintInfo();
                    
                }
                else
                    break;

            }


        }
    }
}
