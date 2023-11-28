using System;

namespace HeroGameForm
{
    public class HeroTile : CharacterTile
    {
        public HeroTile(Position position)
            : base(position, 40, 5)
        {
        }

        public override char Display => IsDead ? 'x' : '▼';

        public override bool IsDead => hitPoints <= 0;

        public override void UpdateVision(Level level)
        {
            // Logic to update the hero's vision can be implemented here
        }
    }
}
