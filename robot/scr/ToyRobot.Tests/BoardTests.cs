using System;
using Xunit;
using ToyRobot;

namespace ToyRobot.Tests
{
    public class BoardTests
    {
        [Fact]
        public void IsValidPosition_Should_Return_True_For_Valid_Position()
        {
            // Arrange
            var board = new Board(5, 5);
            var position = new Position(2, 2);

            // Act
            var result = board.IsValidPosition(position);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidPosition_Should_Return_False_For_Position_Outside_Board()
        {
            // Arrange
            var board = new Board(5, 5);
            var position = new Position(6, 6);

            // Act
            var result = board.IsValidPosition(position);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void HasWall_Should_Return_True_For_Position_With_Wall()
        {
            // Arrange
            var board = new Board(5, 5);
            var wall = new Wall(new Position(3, 3), Direction.NORTH);
            board.AddWall(wall);
            var position = new Position(3, 3);

            // Act
            var result = board.HasWall(position);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void HasWall_Should_Return_False_For_Position_Without_Wall()
        {
            // Arrange
            var board = new Board(5, 5);
            var wall = new Wall(new Position(3, 3), Direction.NORTH);
            board.AddWall(wall);
            var position = new Position(4, 4);

            // Act
            var result = board.HasWall(position);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void AddWall_Should_Add_Wall_To_Board()
        {
            // Arrange
            var board = new Board(5, 5);
            var wall = new Wall(new Position(3, 3), Direction.NORTH);

            // Act
            board.AddWall(wall);

            // Assert
            Assert.Contains(wall, board.Walls);
        }
    }
}

