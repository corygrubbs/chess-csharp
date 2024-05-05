class Pawn : Piece
{
    public Pawn(Color color, int x, int y)
    {
        Color = color;
        X = x;
        Y = y;

    }

    public new string Identifier { get; } = "P";

    public override int[][] AvailableSpaces() {
        return [];
    }
}