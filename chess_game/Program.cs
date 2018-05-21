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

			b.insertPiece(new Tower(b, Color.White), new Position(0, 0));
			b.insertPiece(new King(b, Color.White), new Position(1, 3));

			Screen.printBoard(b);

			Console.ReadLine();
		}
	}
}
