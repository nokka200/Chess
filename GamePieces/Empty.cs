namespace Chess.GamePieces
{
    public class Empty : Piece
    {
        public Empty(int x, int y) : base(x, y)
        {
            PieceType = Type.Empty;
            Logo = ' ';
        }
    }
}
