using System;
using System.Windows.Forms;
using static HeroGameForm.CharacterTile;

namespace HeroGameForm
{
    public partial class HeroGame : Form
    {
        private GameEngine gameEngine;

        public HeroGame()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            gameEngine = new GameEngine(numberOfLevels: 10);
            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            lblDisplay.Text = gameEngine.ToString();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            gameEngine.TriggerMovement(Direction.Up);
            UpdateDisplay();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            gameEngine.TriggerMovement(Direction.Down);
            UpdateDisplay();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            gameEngine.TriggerMovement(Direction.Left);
            UpdateDisplay();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            gameEngine.TriggerMovement(Direction.Right);
            UpdateDisplay();
        }
    }
}
