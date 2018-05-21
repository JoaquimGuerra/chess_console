using System;
using chess_game_board;

namespace chess_game
{
	class Screen
	{
		public static void printBoard(Board board)
		{
			for (int i = 0; i < board.rows; i++)
			{
				for (int j = 0; j < board.columns; j++)
				{
					Piece p = board.piece(new Position(i,j));

					if (p == null)
					{
						Console.Write("- ");
					}
					else
					{
						Console.Write(p + " ");
					}
				}
				Console.WriteLine();
			}
		}

	}
}
