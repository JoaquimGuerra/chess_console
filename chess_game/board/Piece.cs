
namespace chess_game_board
{
	abstract class Piece
	{
		public Position pos	{ get; set; }
		public Color color { get; protected set; }
		public int curMovements { get; protected set; }
		public Board board { get; protected set; }

		public Piece(Board _board, Color _color)
		{
			this.pos = null;
			this.board = _board;
			this.color = _color;
			this.curMovements = 0;
		}

	}
}
