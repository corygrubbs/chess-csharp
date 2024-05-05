
class Board
{
    public Board()
    {
        // Initalize Pawns
        for (int i = 0; i < BOARD_SIZE; i++)
        {
            Spaces[i, 1] = new Pawn(Color.W, i, 1);
            Spaces[i, 6] = new Pawn(Color.B, i, 6);
        }
    }

    private int BOARD_SIZE = 8;

    public Piece[,] Spaces { get; set; } = new Piece[8, 8];

    public void PrintBoard()
    {
        for (int i = 0; i < BOARD_SIZE; i++)
        {
            for (int j = 0; j < BOARD_SIZE; j++)
            {
                if (Spaces[i, j] != null)
                {
                    Console.Write($"{Spaces[i, j].Identifier}{Spaces[i, j].Color}");
                }
            }
            Console.WriteLine("");
        }
    }
}