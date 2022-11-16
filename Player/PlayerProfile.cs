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
				Piece tempObj = new Pawn(i, 6);
                PlayersPieces.Add(tempObj);
			}

            Piece tempBis1 = new Bishop(2, 7);
            PlayersPieces.Add(tempBis1);
            Piece tempBis2 = new Bishop(5, 7);
            PlayersPieces.Add(tempBis2);

            Piece tempRook1 = new Rook(0, 7);
            PlayersPieces.Add(tempRook1);
            Piece tempRook2 = new Rook(7, 7);
            PlayersPieces.Add(tempRook2);

            Piece tempKnight1 = new Knight(1, 7);
            PlayersPieces.Add(tempKnight1);
            Piece tempKnight2 = new Knight(6, 7);
            PlayersPieces.Add(tempKnight2);

            Piece tempQueen = new Queen(3, 7);
            PlayersPieces.Add(tempQueen);

            Piece tempKing = new King(4, 7);
            PlayersPieces.Add(tempKing);

        }

		void CreatePiecesBlack()
		{
            for (int i = 0; i < MAX_PAWN; i++)
            {
                Piece tempObj = new Pawn(i, 1);
                PlayersPieces.Add(tempObj);
            }

            Piece tempBis1 = new Bishop(2, 0);
            PlayersPieces.Add(tempBis1);
            Piece tempBis2 = new Bishop(5, 0);
            PlayersPieces.Add(tempBis2);

            Piece tempRook1 = new Rook(0, 0);
            PlayersPieces.Add(tempRook1);
            Piece tempRook2 = new Rook(7, 0);
            PlayersPieces.Add(tempRook2);

            Piece tempKnight1 = new Knight(1, 0);
            PlayersPieces.Add(tempKnight1);
            Piece tempKnight2 = new Knight(6, 0);
            PlayersPieces.Add(tempKnight2);

            Piece tempQueen = new Queen(3, 0);
            PlayersPieces.Add(tempQueen);

            Piece tempKing = new King(4, 0);
            PlayersPieces.Add(tempKing);
        }
	}
}

