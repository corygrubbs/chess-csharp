public enum Color
{
    B,
    W
}

abstract class Piece
{
    public Color Color { get; set; }

    // X position on the board
    public int X { get; set; }

    // Y position on the board
    public int Y { get; set; }

    public string Identifier { get; } = "";

    // List of a available spots for the piece to move
    public abstract int[][] AvailableSpaces();
}