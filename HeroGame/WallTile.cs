using System;

namespace HeroGameForm
{
    public class WallTile : Tile
    {
        public WallTile(Position position) : base(position) { }

        public override char Display => '█';
    }
}
