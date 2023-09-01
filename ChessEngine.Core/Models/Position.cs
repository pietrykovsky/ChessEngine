namespace ChessEngine.Core.Models
{
    /// <summary>
    /// Represents a position on a chess board.
    /// </summary>
    public readonly struct Position
    {
        /// <summary>
        /// Gets the horizontal coordinate (file) of the position.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Gets the vertical coordinate (rank) of the position.
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> struct with specified coordinates.
        /// </summary>
        /// <param name="x">The horizontal coordinate (file).</param>
        /// <param name="y">The vertical coordinate (rank).</param>
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current position.
        /// </summary>
        /// <param name="obj">The object to compare with the current position.</param>
        /// <returns>True if the specified object is equal to the current position; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Position other)
            {
                return X == other.X && Y == other.Y;
            }

            return false;
        }

        /// <summary>
        /// Returns a hash code for the current position.
        /// </summary>
        /// <returns>A hash code for the current position.</returns>
        public override int GetHashCode()
        {
            return (X * 397) ^ Y;
        }

        /// <summary>
        /// Determines whether two specified positions are equal.
        /// </summary>
        /// <param name="left">The first position to compare.</param>
        /// <param name="right">The second position to compare.</param>
        /// <returns>True if the positions are equal; otherwise, false.</returns>
        public static bool operator ==(Position left, Position right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two specified positions are not equal.
        /// </summary>
        /// <param name="left">The first position to compare.</param>
        /// <param name="right">The second position to compare.</param>
        /// <returns>True if the positions are not equal; otherwise, false.</returns>
        public static bool operator !=(Position left, Position right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a string that represents the current position.
        /// </summary>
        /// <returns>A string representation of the current position in the format (X, Y).</returns>
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
