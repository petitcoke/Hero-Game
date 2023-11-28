using System;

namespace HeroGameForm
{
    public abstract class CharacterTile : Tile
    {
        protected int hitPoints;
        protected int maxHitPoints;
        protected int attackPower;
        protected Tile[] vision;

        public CharacterTile(Position position, int hitPoints, int attackPower)
            : base(position)
        {
            this.hitPoints = hitPoints;
            this.maxHitPoints = hitPoints;
            this.attackPower = attackPower;
            this.vision = new Tile[4];
        }

        public abstract bool IsDead { get; }

        public void TakeDamage(int damage)
        {
            hitPoints -= damage;
            if (hitPoints < 0)
            {
                hitPoints = 0;
            }
        }

        public void Attack(CharacterTile target)
        {
            target.TakeDamage(attackPower);
        }

        public abstract void UpdateVision(Level level);

        // Define the Direction enum here
        public enum Direction
        {
            Up,
            Right,
            Down,
            Left,
            None
        }
    }
}
