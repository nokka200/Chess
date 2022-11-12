﻿using Chess.GamePieces;using Chess.Player;namespace Chess.Board{	public class GameBoard	{		// fields		readonly DateTime startTime;		// properties		public Piece[,] CurrentBoard { get; private set; }		public PlayerProfile Player1 { get; private set; }		public PlayerProfile Player2 { get; private set; }		// const		const int X = 8;		const int Y = 8;		public GameBoard(string firstName, string secondName)		{			Player1 = new(firstName, "White");			Player2 = new(secondName, "Black");			CurrentBoard = new Piece[X, Y];			startTime = DateTime.Now;
			CreateBoard();
        }		// public methods		public void PrintBoard()		{			for (int i = 0; i < X; i++)			{				for (int k = 0;  k < Y;  k++)				{					Console.WriteLine(CurrentBoard[i, k].Logo);				}				Console.WriteLine();			}		}

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
    }}