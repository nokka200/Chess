using Chess.GamePieces;using Chess.Player;namespace Chess.Board{	/// <summary>
	/// Represents a Chessboard where the game will be played
	/// </summary>	public class GameBoard	{		// fields		readonly DateTime startTime;		// properties		public Piece[,] CurrentBoard { get; private set; }		public PlayerProfile Player1 { get; private set; }		public PlayerProfile Player2 { get; private set; }		// const		const int X = 8;		const int Y = 8;		/// <summary>
		/// Creates and new board with pieces in correct places.
		/// </summary>
		/// <param name="firstName">White players name</param>
		/// <param name="secondName">Black players name</param>		public GameBoard(string firstName, string secondName)		{			Player1 = new(firstName, "White");			Player2 = new(secondName, "Black");			CurrentBoard = new Piece[X, Y];			startTime = DateTime.Now;

			EmptyBoard();
			CreateBoard();
        }		// public methods		/// <summary>
		/// Prints the current state of the board
		/// </summary>		public void PrintBoard()		{			for (int i = 0; i < X; i++)			{				for (int k = 0;  k < Y;  k++)				{					Console.Write(CurrentBoard[i, k].Logo);				}
                Console.WriteLine();
            }
            
        }

		// private methods
        void CreateBoard()
        {
            foreach (var item in Player1.PlayersPieces)
            {
                CurrentBoard[item.Y, item.X] = item;
            }

            foreach (var item in Player2.PlayersPieces)
            {
               CurrentBoard[item.Y, item.X] = item;
            }
        }

		void EmptyBoard()
		{
			for (int i = 0; i < Y; i++)
			{
				for (int k = 0; k < X; k++)
				{
					Empty tempObj = new(k, i);

					CurrentBoard[i, k] = tempObj;

                }
			}
		}
    }}