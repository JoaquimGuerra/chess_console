using chess_game_board;


namespace chess_game_chess
{
	class Tower : Piece
	{
		public Tower(Board board, Color color) : base(board, color)
		{

		}

		public override string ToString()
		{
			return "T";
		}

	}
}
