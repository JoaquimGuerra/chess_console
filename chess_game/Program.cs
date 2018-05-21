using System;
using chess_game_board;
using chess_game_chess;

namespace chess_game
{
	class Program
	{
		static void Main(string[] args)
		{
			Board b = new Board(8, 8);

			try
			{
				b.insertPiece(new Tower(b, Color.White), new Position(0, 0));
				b.insertPiece(new King(b, Color.White), new Position(0, 0));
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			Screen.printBoard(b);

			Console.ReadLine();
		}
	}
}
