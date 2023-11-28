public abstract class Tile
{
    public Position Position { get; set; }

    public Tile(Position position)
    {
        Position = position;
    }

    public int X
    {
        get { return Position.X; }
    }

    public int Y
    {
        get { return Position.Y; }
    }

    public abstract char Display { get; }
}
