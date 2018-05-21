namespace chess_game_board
{
	class Board
	{
		public int rows { get; private set; }
		public int columns { get; private set; }
		public Piece[,] pieces;


		public Board(int _rows, int _cols)
		{
			this.rows = _rows;
			this.columns = _cols;
			this.pieces = new Piece[_rows, _cols];
		}
	}
}
