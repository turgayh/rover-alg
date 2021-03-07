using System.Collections.Generic;

namespace rover_alg
{

    public static class RoverHelper
    {
        /// <summary>
        /// To delete unnecessary repetitions in the command list.
        /// </summary>
        /// <param name="commands"></param>
        /// <returns></returns>
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

    }
}
