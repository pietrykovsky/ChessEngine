using ChessEngine.Core.Pieces;

namespace ChessEngine.Core.Models
{
    internal interface IBoard
    {
        public Piece GetPieceAtPosition(Position position);
        public bool IsSquareUnderAttack(Position position);
    }
}