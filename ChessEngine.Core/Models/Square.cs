using ChessEngine.Core.Pieces;

namespace ChessEngine.Core.Models
{
    internal struct Square
    {
        internal Position Position;
        internal Piece Piece { get; set; } = null;

        internal Square(Position position)
        {
            Position = position;
        }

        internal Square(Piece piece)
        {
            Piece = piece;
            Position = piece.Position;
        }
    }
}