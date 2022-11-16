using Chess.Board;

namespace Chess.DebugUtils
{
    /// <summary>
    /// Represents a testing class, used only in development.
    /// </summary>
	static public class Tester
	{
		readonly static GameBoard newGame = new("Pasi", "Jussi");

        /// <summary>
        /// Testing player's colors and names.
        /// </summary>
        public static void TestColors()
		{
			Console.WriteLine(newGame.Player1.Color);
            Console.WriteLine(newGame.Player2.Color);

            Console.WriteLine(newGame.Player1.Name);
            Console.WriteLine(newGame.Player2.Name);
        }

        /// <summary>
        /// Testing print methods
        /// </summary>
		public static void TestPieces()
		{
            Console.WriteLine(newGame.Player1.Name);
            newGame.Player1.PrintPieces();

            Console.WriteLine(newGame.Player2.Name);
            newGame.Player2.PrintPieces();
        }

        /// <summary>
        /// Testing board printing
        /// </summary>
        public static void TestBoardPrint() 
        {
            newGame.PrintBoard();
        }

        public static void TestMovePiece()
        {
            newGame.MovePiece(1, 3, 3, 1);
            newGame.PrintBoard();
        }
	}
}

