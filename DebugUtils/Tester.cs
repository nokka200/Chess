using Chess.Board;

namespace Chess.DebugUtils
{
	static public class Tester
	{
		readonly static GameBoard newGame = new("Pasi", "Jussi");

        public static void TestColors()
		{
			Console.WriteLine(newGame.Player1.Color);
            Console.WriteLine(newGame.Player2.Color);

            Console.WriteLine(newGame.Player1.Name);
            Console.WriteLine(newGame.Player2.Name);
        }

		public static void TestPieces()
		{
            Console.WriteLine(newGame.Player1.Name);
            newGame.Player1.PrintPieces();

            Console.WriteLine(newGame.Player2.Name);
            newGame.Player2.PrintPieces();
        }

        public static void TestBoardPrint() 
        {
            newGame.PrintBoard();
        }


	}
}

