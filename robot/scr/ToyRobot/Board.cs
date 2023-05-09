using System;

namespace ToyRobot
{
    public class Board
    {
        public int Rows { get; }
        public int Cols { get; }
        public Robot Robot { get; set; }

        public Board(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
        }

        public bool IsRobotOnBoard()
        {
            return Robot != null && Robot.Row >= 1 && Robot.Row <= Rows && Robot.Col >= 1 && Robot.Col <= Cols;
        }

        public void PlaceRobot(int row, int col, Facing facing)
        {
            if (Robot == null)
            {
                Robot = new Robot();
            }

            Robot.Row = row;
            Robot.Col = col;
            Robot.Facing = facing;
        }

        public void MoveRobot()
        {
            if (!IsRobotOnBoard())
            {
                throw new InvalidOperationException("Robot is not on the board");
            }

            Robot.Move();

            if (!IsRobotOnBoard())
            {
                Console.WriteLine("Robot fell off the board!");
            }
        }

        public void TurnRobotLeft()
        {
            if (!IsRobotOnBoard())
            {
                throw new InvalidOperationException("Robot is not on the board");
            }

            Robot.TurnLeft();
        }

        public void TurnRobotRight()
        {
            if (!IsRobotOnBoard())
            {
                throw new InvalidOperationException("Robot is not on the board");
            }

            Robot.TurnRight();
        }

        public string ReportRobot()
        {
            if (!IsRobotOnBoard())
            {
                throw new InvalidOperationException("Robot is not on the board");
            }

            return Robot.Report();
        }
    }
}

