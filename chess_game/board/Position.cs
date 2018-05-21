namespace chess_game_board
{
	class Position
	{
		public int row { get; set; }
		public int column { get; set; }

		public Position(int _row, int _column)
		{
			this.row	= _row;
			this.column = _column;
		}

		public override string ToString()
		{
			return "(" +
					this.row +
					"," +
					this.column +
					")";
		}
	}
}
