using System;
using System.Collections.Generic;

namespace ToyRobot
{
    public enum Facing
    {
        NORTH,
        SOUTH,
        EAST,
        WEST
    }

    public class Robot
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public Facing Facing { get; set; }

        public void Move()
        {
            switch (Facing)
            {
                case Facing.NORTH:
                    if (Row < 5) Row++;
                    break;
                case Facing.SOUTH:
                    if (Row > 1) Row--;
                    break;
                case Facing.EAST:
                    if (Col < 5) Col++;
                    break;
                case Facing.WEST:
                    if (Col > 1) Col--;
                    break;
                default:
                    throw new InvalidOperationException("Invalid facing direction");
            }
        }

        public void TurnLeft()
        {
            switch (Facing)
            {
                case Facing.NORTH:
                    Facing = Facing.WEST;
                    break;
                case Facing.SOUTH:
                    Facing = Facing.EAST;
                    break;
                case Facing.EAST:
                    Facing = Facing.NORTH;
                    break;
                case Facing.WEST:
                    Facing = Facing.SOUTH;
                    break;
                default:
                    throw new InvalidOperationException("Invalid facing direction");
            }
        }

        public void TurnRight()
        {
            switch (Facing)
            {
                case Facing.NORTH:
                    Facing = Facing.EAST;
                    break;
                case Facing.SOUTH:
                    Facing = Facing.WEST;
                    break;
                case Facing.EAST:
                    Facing = Facing.SOUTH;
                    break;
                case Facing.WEST:
                    Facing = Facing.NORTH;
                    break;
                default:
                    throw new InvalidOperationException("Invalid facing direction");
            }
        }

        public string Report()
        {
            return $"({Row}, {Col}), {Facing}";
        }
    }
}
