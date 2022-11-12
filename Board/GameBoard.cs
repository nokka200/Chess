using Chess.GamePieces;
using Chess.Player;

namespace Chess.Board
{
	public class GameBoard
	{
		// fields
		readonly DateTime startTime = DateTime.Now;

		// properties
		public Piece[,]? CurrentBoard { get; set; }
		public PlayerProfile Player1 { get; set; }
		public PlayerProfile Player2 { get; set; }

		// const
		const int X = 8;
		const int Y = 8;

		public GameBoard(string firstName, string secondName)
		{
			Player1 = new(firstName, 1);
			Player2 = new(secondName, 0);
		}

		public void CreateBoard()
		{
			
		}
	}
}

