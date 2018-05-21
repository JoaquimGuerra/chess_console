using System;
using chess_game_board;

namespace chess_game
{
	class Program
	{
		static void Main(string[] args)
		{
			Board b = new Board(8, 8);

			Screen.printBoard(b);

			Console.ReadLine();
		}
	}
}
