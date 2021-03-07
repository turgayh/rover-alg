using Xunit;

namespace rover_alg.unittest
{
    public class RoverUnitTests
    {
        [Fact]
        public void Rover_MoveToNorth_Successfully()
        {
            //Arrange
            Rover rover = new Rover();
            rover.X = 12;
            rover.Y = 5;
            rover.Direction = (char)Enums.Direction.North;
            //Actions
            rover.Move();
            rover.Move();
            rover.Move();
            //Assets
            Assert.Equal(8, rover.Y);
            Assert.Equal(12, rover.X);
        }


        [Fact]
        public void Rover_MoveToEast_Successfully()
        {
            //Arrange
            Rover rover = new Rover();
            rover.X = 12;
            rover.Y = 5;
            rover.Direction = (char)Enums.Direction.East;
            //Actions
            rover.Move();
            rover.Move();
            rover.Move();
            //Assets
            Assert.Equal(5, rover.Y);
            Assert.Equal(15, rover.X);
        }
    }
}
