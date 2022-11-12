using Chess.GamePieces;

namespace Chess.Player
{
	public class PlayerProfile
	{
		// properties
		public string? Name { get; private set; }
		public bool HasWon { get; set; }
        public int Color { get; private set; }

        // fields
        List<Piece> playersPieces = new();
		

        // consts
        const int MAX_PAWN = 8;

		public PlayerProfile(string name, int color)
		{
			Name = name;
			HasWon = false;
            Color = color;

            CreatePieces();
		}

        /// <summary>
        /// Prints players pieces locations and type
        /// </summary>
        public void PrintPieces()
        {
            foreach(var item in playersPieces)
            {
                Console.WriteLine(item.PieceType);
                Console.WriteLine($"X: {item.X}");
                Console.WriteLine($"Y: {item.Y}");
            }
        }

		void CreatePieces()
		{
			if (Color == 1)
			{
                CreatePiecesWhite();
            }
			else
			{
				CreatePiecesBlack();
			}
				
		}

		void CreatePiecesWhite()
		{
			for (int i = 0; i < MAX_PAWN; i++)
			{
				Pawn tempObj = new(i, 1);
				playersPieces.Add(tempObj);
			}

			Bishop tempBis1 = new(2, 0);
			playersPieces.Add(tempBis1);
            Bishop tempBis2 = new(5, 0);
            playersPieces.Add(tempBis2);

			Rook tempRook1 = new(0, 0);
			playersPieces.Add(tempRook1);
            Rook tempRook2 = new(7, 0);
            playersPieces.Add(tempRook2);

            Knight tempKnight1 = new(1, 0);
            playersPieces.Add(tempKnight1);
            Knight tempKnight2 = new(6, 0);
            playersPieces.Add(tempKnight2);

            Bishop tempBish1 = new(2, 0);
            playersPieces.Add(tempBish1);
            Bishop tempBish2 = new(5, 0);
            playersPieces.Add(tempBish2);

            Queen tempQueen = new(3, 0);
            playersPieces.Add(tempQueen);

            King tempKing = new(4, 0);
            playersPieces.Add(tempKing);

        }

		void CreatePiecesBlack()
		{
            for (int i = 0; i < MAX_PAWN; i++)
            {
                Pawn tempObj = new(i, 6);
                playersPieces.Add(tempObj);
            }

            Bishop tempBis1 = new(2, 7);
            playersPieces.Add(tempBis1);
            Bishop tempBis2 = new(5, 7);
            playersPieces.Add(tempBis2);

            Rook tempRook1 = new(0, 7);
            playersPieces.Add(tempRook1);
            Rook tempRook2 = new(7, 7);
            playersPieces.Add(tempRook2);

            Knight tempKnight1 = new(1, 7);
            playersPieces.Add(tempKnight1);
            Knight tempKnight2 = new(6, 7);
            playersPieces.Add(tempKnight2);

            Bishop tempBish1 = new(2, 7);
            playersPieces.Add(tempBish1);
            Bishop tempBish2 = new(5, 7);
            playersPieces.Add(tempBish2);

            Queen tempQueen = new(3, 7);
            playersPieces.Add(tempQueen);

            King tempKing = new(4, 7);
            playersPieces.Add(tempKing);
        }
	}
}

