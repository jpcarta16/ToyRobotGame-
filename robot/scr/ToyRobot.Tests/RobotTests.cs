using System;
using Xunit;
using ToyRobot;

namespace ToyRobot.Tests
{
    public class RobotTests
    {
        [Fact]
        public void Robot_Should_Move_North_When_Facing_North_And_Moving_Forward()
        {
            // Arrange
            var board = new Board(5, 5);
            var robot = new Robot(board);
            robot.Place(2, 2, Direction.NORTH);

            // Act
            robot.Move();

            // Assert
            Assert.Equal(2, robot.X);
            Assert.Equal(3, robot.Y);
            Assert.Equal(Direction.NORTH, robot.Direction);
        }

        [Fact]
        public void Robot_Should_Move_East_When_Facing_East_And_Moving_Forward()
        {
            // Arrange
            var board = new Board(5, 5);
            var robot = new Robot(board);
            robot.Place(2, 2, Direction.EAST);

            // Act
            robot.Move();

            // Assert
            Assert.Equal(3, robot.X);
            Assert.Equal(2, robot.Y);
            Assert.Equal(Direction.EAST, robot.Direction);
        }

        [Fact]
        public void Robot_Should_Move_South_When_Facing_South_And_Moving_Forward()
        {
            // Arrange
            var board = new Board(5, 5);
            var robot = new Robot(board);
            robot.Place(2, 2, Direction.SOUTH);

            // Act
            robot.Move();

            // Assert
            Assert.Equal(2, robot.X);
            Assert.Equal(1, robot.Y);
            Assert.Equal(Direction.SOUTH, robot.Direction);
        }

        [Fact]
        public void Robot_Should_Move_West_When_Facing_West_And_Moving_Forward()
        {
            // Arrange
            var board = new Board(5, 5);
            var robot = new Robot(board);
            robot.Place(2, 2, Direction.WEST);

            // Act
            robot.Move();

            // Assert
            Assert.Equal(1, robot.X);
            Assert.Equal(2, robot.Y);
            Assert.Equal(Direction.WEST, robot.Direction);
        }

        [Fact]
        public void Robot_Should_Not_Move_If_Move_Will_Fall_Off_The_Board()
        {
            // Arrange
            var board = new Board(5, 5);
            var robot = new Robot(board);
            robot.Place(0, 0, Direction.SOUTH);

            // Act
            robot.Move();

            // Assert
            Assert.Equal(0, robot.X);
            Assert.Equal(0, robot.Y);
            Assert.Equal(Direction.SOUTH, robot.Direction);
        }

        [Fact]
        public void Robot_Should_Turn_Left_Correctly()
        {
            // Arrange
            var board = new Board(5, 5);
            var robot = new Robot(board);
            robot.Place(2, 2, Direction.NORTH);

            // Act
            robot.Left();

            // Assert
            Assert.Equal(Direction.WEST, robot.Direction);
        }

        [Fact]
        public void Robot_Should_Turn_Right_Correctly()
        {
            // Arrange
            var board = new Board(5, 5);
            var robot = new Robot(board);
            robot.Place(2, 2, Direction.NORTH);

            // Act
            robot.Right();

            // Assert
            Assert.Equal(Direction.EAST, robot.Direction);
        }
    }
}
