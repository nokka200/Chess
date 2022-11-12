using Chess.GamePieces;

namespace Chess.Player
{
	public class PlayerProfile
	{
		// properties
		public string? Name { get; private set; }
		public bool HasWon { get; set; }
        public string? Color { get; private set; }
        public List<Piece> PlayersPieces { get; private set; }

        // consts
        const int MAX_PAWN = 8;

		public PlayerProfile(string name, string color)
		{
			Name = name;
			HasWon = false;
            Color = color;
            PlayersPieces = new List<Piece>();

            CreatePieces();
		}

        /// <summary>
        /// Prints players pieces locations and type
        /// </summary>
        public void PrintPieces()
        {
            foreach(var item in PlayersPieces)
            {
                Console.WriteLine(item.PieceType);
                Console.WriteLine($"Color: {Color}");
                Console.WriteLine($"X: {item.X}");
                Console.WriteLine($"Y: {item.Y}");
            }
        }

		void CreatePieces()
		{
			if (Color == "White")
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
				Pawn tempObj = new(i, 6);
                PlayersPieces.Add(tempObj);
			}

			Bishop tempBis1 = new(2, 7);
            PlayersPieces.Add(tempBis1);
            Bishop tempBis2 = new(5, 7);
            PlayersPieces.Add(tempBis2);

			Rook tempRook1 = new(0, 7);
            PlayersPieces.Add(tempRook1);
            Rook tempRook2 = new(7, 7);
            PlayersPieces.Add(tempRook2);

            Knight tempKnight1 = new(1, 7);
            PlayersPieces.Add(tempKnight1);
            Knight tempKnight2 = new(6, 7);
            PlayersPieces.Add(tempKnight2);

            Bishop tempBish1 = new(2, 7);
            PlayersPieces.Add(tempBish1);
            Bishop tempBish2 = new(5, 7);
            PlayersPieces.Add(tempBish2);

            Queen tempQueen = new(3, 7);
            PlayersPieces.Add(tempQueen);

            King tempKing = new(4, 7);
            PlayersPieces.Add(tempKing);

        }

		void CreatePiecesBlack()
		{
            for (int i = 0; i < MAX_PAWN; i++)
            {
                Pawn tempObj = new(i, 1);
                PlayersPieces.Add(tempObj);
            }

            Bishop tempBis1 = new(2, 0);
            PlayersPieces.Add(tempBis1);
            Bishop tempBis2 = new(5, 0);
            PlayersPieces.Add(tempBis2);

            Rook tempRook1 = new(0, 0);
            PlayersPieces.Add(tempRook1);
            Rook tempRook2 = new(7, 0);
            PlayersPieces.Add(tempRook2);

            Knight tempKnight1 = new(1, 0);
            PlayersPieces.Add(tempKnight1);
            Knight tempKnight2 = new(6, 0);
            PlayersPieces.Add(tempKnight2);

            Bishop tempBish1 = new(2, 0);
            PlayersPieces.Add(tempBish1);
            Bishop tempBish2 = new(5, 0);
            PlayersPieces.Add(tempBish2);

            Queen tempQueen = new(3, 0);
            PlayersPieces.Add(tempQueen);

            King tempKing = new(4, 0);
            PlayersPieces.Add(tempKing);
        }
	}
}

