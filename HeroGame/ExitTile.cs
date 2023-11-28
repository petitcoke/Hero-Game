using System;

namespace HeroGameForm
{
    public class ExitTile : Tile
    {
        public ExitTile(Position position) : base(position) { }

        public override char Display => 'E';
    }
}
