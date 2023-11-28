public class EmptyTile : Tile
{
    public EmptyTile(Position position) : base(position)
    {
    }

    public override char Display
    {
        get { return '.'; }
    }
}
