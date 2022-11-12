using System;
namespace Chess.GamePieces
{
	public class King : Piece
	{
		public King(int x, int y) :base(x, y)
		{
			PieceType = Type.King;
			Logo = 'K';
        }
	}
}

