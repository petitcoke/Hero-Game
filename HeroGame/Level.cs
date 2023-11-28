using System;
using System.Linq;
using static HeroGameForm.CharacterTile;

namespace HeroGameForm
{
    public class Level
    {
        public const int MIN_SIZE = 10;
        public const int MAX_SIZE = 20;
        private Tile[,] tiles;
        private int width;
        private int height;
        private HeroTile hero;
        private ExitTile exit; // ExitTile field

        public enum TileType
        {
            Empty,
            Wall,
            Hero,
            Exit, // Exit type
            // more tile types in the future possibly
        }

        public Level(int width, int height, HeroTile hero = null)
        {
            this.width = width;
            this.height = height;
            tiles = new Tile[width, height];
            this.hero = hero;

            InitialiseTiles();
            
                Position heroPosition = GetRandomEmptyPosition();
                this.hero = new HeroTile(heroPosition);
                tiles[heroPosition.X, heroPosition.Y] = this.hero;

            // ExitTile
            Position exitPosition = GetRandomEmptyPosition();
            ExitTile exitTile = (ExitTile)CreateTile(TileType.Exit, exitPosition);
            tiles[exitPosition.X, exitPosition.Y] = exitTile;
            exit = exitTile;
        }

        public HeroTile Hero
        {
            get { return hero; }
            set { hero = value; }
        }

        public ExitTile Exit => exit; // Expose ExitTile

        public void SwapTiles(Tile tile1, Tile tile2)
        {
            Position tempPosition = tile1.Position;
            tile1.Position = tile2.Position;
            tile2.Position = tempPosition;

            tiles[tile1.Position.X, tile1.Position.Y] = tile1;
            tiles[tile2.Position.X, tile2.Position.Y] = tile2;
        }

        public Tile GetTileAt(int x, int y)
        {
            if (x >= 0 && x < width && y >= 0 && y < height)
                return tiles[x, y];
            else
                return null;
        }

        public Position GetRandomEmptyPosition()
        {
            Random random = new Random();
            int x, y;
            do
            {
                x = random.Next(width);
                y = random.Next(height);
            } while (!(tiles[x, y] is EmptyTile));
            return new Position(x, y);
        }

        public Tile GetTileInDirection(Position currentPosition, Direction direction)
        {
            Position targetPosition = GetNewPosition(currentPosition, direction);
            return GetTileAt(targetPosition.X, targetPosition.Y);
        }

        public bool MoveHero(Direction direction)
        {
            Position targetPosition = GetNewPosition(hero.Position, direction);
            Tile targetTile = GetTileAt(targetPosition.X, targetPosition.Y);

            if (targetTile is ExitTile)
            {
                return true;
            }

            if (targetTile is EmptyTile)
            {
                SwapTiles(hero, targetTile);
                return true;
            }

            return false;
        }

        private Position GetNewPosition(Position currentPosition, Direction direction)
        {
            int newX = currentPosition.X;
            int newY = currentPosition.Y;

            switch (direction)
            {
                case Direction.Up:
                    newY--;
                    break;
                case Direction.Down:
                    newY++;
                    break;
                case Direction.Left:
                    newX--;
                    break;
                case Direction.Right:
                    newX++;
                    break;
            }

            return new Position(newX, newY);
        }

        private Tile CreateTile(TileType tileType, Position position)
        {
            switch (tileType)
            {
                case TileType.Empty:
                    return new EmptyTile(position);
                case TileType.Wall:
                    return new WallTile(position);
                case TileType.Hero:
                    return hero;
                case TileType.Exit:
                    return new ExitTile(position); // ExitTile
                // more cases for other tile types can be added in the future
                default:
                    return null;
            }
        }

        private void InitialiseTiles()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (x == 0 || y == 0 || x == width - 1 || y == height - 1)
                    {
                        tiles[x, y] = CreateTile(TileType.Wall, new Position(x, y));
                    }
                    else
                    {
                        tiles[x, y] = CreateTile(TileType.Empty, new Position(x, y));
                    }
                }
            }
        }

        public override string ToString()
        {
            string levelString = "";

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (tiles[x, y] == hero)
                    {
                        levelString += hero.Display;
                    }
                    else if (tiles[x, y] == exit) // Check if the tile is the exit
                    {
                        levelString += exit.Display;
                    }
                    else
                    {
                        levelString += tiles[x, y].Display;
                    }
                }
                levelString += "\n"; // New line after each row
            }

            return levelString;
        }
    }
}
