using Chess.GamePieces;
using Chess.Player;

namespace Chess.Board
{
	/// <summary>
	/// Represents a Chessboard where the game will be played
	/// </summary>
	public class GameBoard
	{
		// fields
		readonly DateTime startTime;

		// properties
		public Piece[,] CurrentBoard { get; private set; }
		public PlayerProfile Player1 { get; private set; }
		public PlayerProfile Player2 { get; private set; }

		// const
		const int X = 8;
		const int Y = 8;

		/// <summary>
		/// Creates and new board with pieces in correct places.
		/// </summary>
		/// <param name="firstName">White players name</param>
		/// <param name="secondName">Black players name</param>
		public GameBoard(string firstName, string secondName)
		{
			Player1 = new(firstName, "White");
			Player2 = new(secondName, "Black");
			CurrentBoard = new Piece[X, Y];
			startTime = DateTime.Now;

			EmptyBoard();
			CreateBoard();
        }

		// public methods
		/// <summary>
		/// Prints the current state of the board
		/// </summary>
		public void PrintBoard()
		{
			for (int i = 0; i < X; i++)
			{
				for (int k = 0;  k < Y;  k++)
				{
					Console.Write(CurrentBoard[i, k].Logo);
				}
                Console.WriteLine();
            }
            
        }

        /// <summary>
        /// Moves a players piece to a new location, leaves an empty spot to the start location
        /// </summary>
        /// <param name="player">Player to move</param>
        /// <param name="newX">New x location</param>
        /// <param name="newY">New x location</param>
        /// <param name="pieceToMove">What piece to move</param>
        public void MovePiece(int player, int newX, int newY, int pieceToMove)
		{
			if (player == 1)
            {
                MovePlayer(newX, newY, pieceToMove, Player1);
            }
            else
			{
                MovePlayer(newX, newY, pieceToMove, Player2);
            }
		}



        // private methods
        void MovePlayer(int newX, int newY, int pieceToMove, PlayerProfile playerToMove)
        {
            int tempX;
            int tempY;

            tempX = playerToMove.PlayersPieces[pieceToMove].X;
            tempY = playerToMove.PlayersPieces[pieceToMove].Y;
            EmptySpace(tempX, tempY);

            playerToMove.PlayersPieces[pieceToMove].X = newX;
            playerToMove.PlayersPieces[pieceToMove].Y = newY;
            FillPlace(Player1.PlayersPieces[pieceToMove]);
        }

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

		void EmptySpace(int x, int y)
		{
			Empty tempObj = new(x, y);
			CurrentBoard[x, y] = tempObj;
		}

		void FillPlace(Piece toAdd)
		{
			CurrentBoard[toAdd.X, toAdd.Y] = toAdd;
		}
    }
}

