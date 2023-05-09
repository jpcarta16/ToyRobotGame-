using System;
using Xunit;
using ToyRobot;

namespace ToyRobot.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Program_Should_Show_Error_Message_For_Invalid_File_Path()
        {
            // Arrange
            string[] args = { "invalid_file_path.txt" };

            // Act
            Program.Main(args);

            // Assert
            Assert.Equal("File not found: invalid_file_path.txt", Console.Error.ReadLine());
        }

        [Fact]
        public void Program_Should_Process_Valid_Command_File_Correctly()
        {
            // Arrange
            string[] args = { "valid_command_file.txt" };

            // Act
            Program.Main(args);

            // Assert
            Assert.Equal("1,4,EAST", Console.Out.ReadLine());
        }

        [Fact]
        public void Program_Should_Show_Error_Message_For_Invalid_Command_File_Format()
        {
            // Arrange
            string[] args = { "invalid_command_file_format.txt" };

            // Act
            Program.Main(args);

            // Assert
            Assert.Equal("Invalid command file format", Console.Error.ReadLine());
        }

        [Fact]
        public void Program_Should_Show_Help_Message_For_Help_Argument()
        {
            // Arrange
            string[] args = { "-h" };

            // Act
            Program.Main(args);

            // Assert
            Assert.Contains("Toy Robot Simulator", Console.Out.ReadToEnd());
        }

        [Fact]
        public void Program_Should_Show_Version_For_Version_Argument()
        {
            // Arrange
            string[] args = { "-v" };

            // Act
            Program.Main(args);

            // Assert
            Assert.Contains("Toy Robot Simulator v1.0", Console.Out.ReadToEnd());
        }
    }
}
