using Xunit;
using ToyRobot;

namespace ToyRobot.Tests
{
    public class WallTests
    {
        [Fact]
        public void Wall_Should_Be_Placed_At_Correct_Position()
        {
            // Arrange
            var board = new Board(5, 5);
            var wall = new Wall(3, 3, board);

            // Assert
            Assert.Equal(3, wall.X);
            Assert.Equal(3, wall.Y);
        }

        [Fact]
        public void Wall_Should_Not_Be_Placed_Outside_Board()
        {
            // Arrange
            var board = new Board(5, 5);

            // Act & Assert
            Assert.Throws<OutsideBoardException>(() => new Wall(-1, -1, board));
            Assert.Throws<OutsideBoardException>(() => new Wall(0, 5, board));
            Assert.Throws<OutsideBoardException>(() => new Wall(5, 0, board));
            Assert.Throws<OutsideBoardException>(() => new Wall(6, 6, board));
        }

        [Fact]
        public void Wall_Should_Be_Removed_From_Board()
        {
            // Arrange
            var board = new Board(5, 5);
            var wall = new Wall(3, 3, board);

            // Act
            board.RemoveWall(wall);

            // Assert
            Assert.DoesNotContain(wall, board.Walls);
        }
    }
}
