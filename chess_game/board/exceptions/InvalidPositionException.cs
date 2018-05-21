using System;
using chess_game_board;

namespace chess_game_board_exceptions
{
	class InvalidPositionException : Exception
	{
		public InvalidPositionException(Position p) : base("Invalid Position used: " + p)
		{
		}
	}
}
