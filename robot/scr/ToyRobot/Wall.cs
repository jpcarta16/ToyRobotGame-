using System;

namespace ToyRobot
{
    public class Wall
    {
        public int Row { get; }
        public int Col { get; }
        public Facing Facing { get; }

        public Wall(int row, int col, Facing facing)
        {
            Row = row;
            Col = col;
            Facing = facing;
        }

        public bool IsBlocking(int row, int col, Facing facing)
        {
            switch (Facing)
            {
                case Facing.North:
                    return Row == row && Col == col && facing == Facing.South;
                case Facing.South:
                    return Row == row && Col == col && facing == Facing.North;
                case Facing.East:
                    return Row == row && Col == col && facing == Facing.West;
                case Facing.West:
                    return Row == row && Col == col && facing == Facing.East;
                default:
                    return false;
            }
        }
    }
}
