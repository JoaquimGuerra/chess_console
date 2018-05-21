using chess_game_board;


namespace chess_game_chess
{
	class King : Piece
	{
		public King(Board board, Color color) : base(board, color)
		{

		}

		public override string ToString()
		{
			return "K";
		}

	}
}
