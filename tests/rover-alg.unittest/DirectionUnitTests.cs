
using Xunit;

namespace rover_alg.unittest
{
    public class DirectionUnitTests
    {
        [Fact]
        public void FindNewDirection_NorthToLeftCommand_ShouldBeWest()
        {

            //Arrange
            char direction = 'N';
            char command = 'L';
            char expected = 'W';
            //Actions
            char result = Direction.FindNewDirection(direction,command);
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindNewDirection_SouthToRightCommand_ShouldBeWest()
        {

            //Arrange
            char direction = 'S';
            char command = 'R';
            char expected = 'W';
            //Actions
            char result = Direction.FindNewDirection(direction, command);
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindNewDirection_MeaninglessCommand_ShouldBeNotEffectDirection()
        {

            //Arrange
            char direction = 'S';
            char command = 'U';
            char expected = 'S';
            //Actions
            char result = Direction.FindNewDirection(direction, command);
            //Assert
            Assert.Equal(expected, result);
        }


        [Fact]
        public void FindNewDirection_MoveCommand_ShouldBeNotEffectDirection()
        {

            //Arrange
            char direction = 'S';
            char command = 'M';
            char expected = 'S';
            //Actions
            char result = Direction.FindNewDirection(direction, command);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
