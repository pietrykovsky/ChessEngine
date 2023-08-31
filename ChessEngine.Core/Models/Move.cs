using System;

namespace ChessEngine.Core.Models
{
    /// <summary>
    /// Represents a move in a chess game.
    /// </summary>
    public readonly struct Move
    {
        /// <summary>
        /// The starting position of the move.
        /// </summary>
        public readonly Position From;

        /// <summary>
        /// The ending position of the move.
        /// </summary>
        public readonly Position To;

        /// <summary>
        /// The type of the move.
        /// </summary>
        public readonly MoveType Type;

        /// <summary>
        /// Represents the types of moves in chess.
        /// </summary>
        [Flags]
        public enum MoveType
        {
            None = 0,
            Capture = 1,
            EnPassant = 2,
            Promotion = 4,
            ShortCastle = 8,
            LongCastle = 16,
            Check = 32,
            Checkmate = 64
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Move"/> struct with basic move information.
        /// </summary>
        /// <param name="from">The starting position of the move.</param>
        /// <param name="to">The ending position of the move.</param>
        public Move(Position from, Position to) : this(from, to, MoveType.None)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Move"/> struct with detailed move information.
        /// </summary>
        /// <param name="from">The starting position of the move.</param>
        /// <param name="to">The ending position of the move.</param>
        /// <param name="type">The type of the move.</param>
        public Move(Position from, Position to, MoveType type)
        {
            From = from;
            To = to;
            Type = type;
        }
    }
}
