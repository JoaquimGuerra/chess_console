using chess_game_board_exceptions;

namespace chess_game_board
{
	class Board
	{
		public int rows { get; private set; }
		public int columns { get; private set; }
		private Piece[,] pieces;


		public Board(int _rows, int _cols)
		{
			this.rows = _rows;
			this.columns = _cols;
			this.pieces = new Piece[_rows, _cols];
		}

		public Piece piece(Position p)
		{
			validatePosition(p, false);
			return (this.pieces[p.row, p.column]);
		}

		public void insertPiece(Piece p, Position pos)
		{
			validatePosition(pos, true);
			this.pieces[pos.row, pos.column] = p;
			p.pos = pos;
		}

		public bool validPosition(Position p, bool isInsert)
		{
			if (p.row < 0 || p.column < 0 || p.row >= this.rows || p.column >= this.columns)
			{
				return (false);
			}
			if (this.pieces[p.row, p.column] != null && isInsert)
			{
				return (false);
			}
			return (true);
		}

		public void validatePosition(Position p, bool isInsert)
		{
			if (!validPosition(p, isInsert))
			{
				throw new InvalidPositionException(p);
			}
		}
	}
}
