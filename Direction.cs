using System;
using System.Collections.Generic;
using System.Text;

namespace rover_alg
{
    public static class Direction
    {
        private static readonly Dictionary<char, char[]> FindRotate
             = new Dictionary<char, char[]>
         {
            {'N', new char[2]  { (char)Enums.Direction.West,  (char)Enums.Direction.East  }},
            {'W', new char[2]  { (char)Enums.Direction.South, (char)Enums.Direction.North }},
            {'S', new char[2]  { (char)Enums.Direction.East,  (char)Enums.Direction.West  }},
            {'E', new char[2]  { (char)Enums.Direction.North, (char)Enums.Direction.South }}
         };



        /// <summary>
        /// Determines the current direction result of left and right actions.
        /// </summary>
        /// <param name="direction">Current Direction</param>
        /// <param name="command">'L' : Left , 'R': Right</param>
        /// <returns></returns>
        public static char FindNewDirection(char direction, char command)
        {
            if(command == 'L')
                return FindRotate[direction][(int)Enums.CommandDirection.Left];
            if (command == 'R')
                return FindRotate[direction][(int)Enums.CommandDirection.Right];
            return direction;
        }
    }
}
