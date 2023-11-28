using HeroGameForm;
using System;
using static HeroGameForm.CharacterTile;

namespace HeroGameForm
{
    public class GameEngine
    {
        private Level currentLevel;
        private int currentLevelNumber = 1;
        private int numberOfLevels;
        private Random random = new Random();

        private const int MIN_SIZE = 10;
        private const int MAX_SIZE = 20;

        private GameState gameState = GameState.InProgress;

        public GameEngine(int numberOfLevels)
        {
            this.numberOfLevels = numberOfLevels;
            currentLevel = new Level(MIN_SIZE, MAX_SIZE);
            UpdateDisplay();
        }

        public enum GameState
        {
            InProgress,
            Complete,
            GameOver
        }

        public override string ToString()
        {
            switch (gameState)
            {
                case GameState.InProgress:
                    return currentLevel.ToString();
                case GameState.Complete:
                    return "Congratulations! You have completed the game!";
                case GameState.GameOver:
                    // Handle GameOver state (not implemented yet)
                    return "Game Over";
                default:
                    return "";
            }
        }

        private void UpdateDisplay()
        {
            // Update your Windows Form display here
        }

        public void TriggerMovement(Direction direction)
        {
            bool moveSuccessful = MoveHero(direction);

            if (moveSuccessful)
            {
                if (gameState == GameState.InProgress)
                {
                    UpdateDisplay();
                }
            }
        }

        private bool MoveHero(Direction direction)
        {
            if (currentLevel.GetTileInDirection(currentLevel.Hero.Position, direction) is ExitTile)
            {
                if (currentLevelNumber == numberOfLevels)
                {
                    gameState = GameState.Complete;
                    return false;
                }
                else
                {
                    NextLevel();
                    return true;
                }
            }

            if (currentLevel.MoveHero(direction))
            {
                UpdateDisplay();
                return true;
            }

            return false;
        }

        private void NextLevel()
        {
            currentLevelNumber++;
            HeroTile currentHero = currentLevel.Hero;
            currentLevel = new Level(MIN_SIZE, MAX_SIZE, currentHero);
            UpdateDisplay();
        }
    }
}
