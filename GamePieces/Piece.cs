namespace Chess.GamePieces
{
	public abstract class Piece
	{
		// properties
		public bool IsAlive { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
		public Type PieceType { get; protected set; }

		public enum Type
		{
			Pawn,
			Rook,
			Knight,
			Bishop,
			Queen,
			King
		}

        public Piece(int x, int y)
		{
			X = x;
			Y = y;
			IsAlive = true;
		}
	}
}

