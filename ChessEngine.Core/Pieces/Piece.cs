using ChessEngine.Core.Enumerators;
using ChessEngine.Core.Models;

namespace ChessEngine.Core.Pieces;

internal abstract class Piece
{
    public Color Color { get; }
    public Position Position { get; set; }

    protected Piece(Color color, Position position)
    {
        Color = color;
        Position = position;
    }
}