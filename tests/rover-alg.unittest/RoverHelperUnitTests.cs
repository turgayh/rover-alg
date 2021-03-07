using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace rover_alg.unittest
{
    public class RoverHelperUnitTests
    {
        [Fact]
        public void RemoveRepeatedSteps_ZeroLengthCommandList_ReturnEmptyList()
        {
            //Arrange
            char[] commands = "".ToCharArray();
            //Action
            char[] result = RoverHelper.RemoveRepeatedSteps(commands);
            //Assert
            Assert.Empty(result);
        }

        [Fact]
        public void RemoveRepeatedSteps_RotateCommandsParameter_ReturnWithoutRotateParameters()
        {
            //Arrange
            char[] commands = "RRRRMMLLLLRR".ToCharArray();
            char[] expected = "MMRR".ToCharArray();
            //Action
            char[] result = RoverHelper.RemoveRepeatedSteps(commands);
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RemoveRepeatedSteps_CommandsListContainsRepetatedSteps_ReturnWithoutRepeteadSteps()
        {
            //Arrange
            char[] commands = "RRRRMMLLLLRRMRMRMRMMMLMRLMLMLMLM".ToCharArray();
            char[] expected = "MMRMMLMR".ToCharArray();
            //Action
            char[] result = RoverHelper.RemoveRepeatedSteps(commands);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
