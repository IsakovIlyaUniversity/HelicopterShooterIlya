using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public partial class GameForm : Form
    {
        private readonly GameEngine _gameEngine;

        public GameForm()
        {
            InitializeComponent();
            KeyPreview = true;
            _gameEngine = new GameEngine(this, this, picPlayer, pillar1, pillar2);
            _gameEngine.ScoreUpdated += OnScoreUpdated;
            _gameEngine.GameOver += OnGameOver;

            KeyDown += GameForm_KeyDown;
            KeyUp += GameForm_KeyUp;
            Load += GameForm_Load;
        }

        private void OnScoreUpdated(int score) => txtScore.Text = $"Score: {score}";
        private void OnGameOver(int score) => txtScore.Text = $"Score: {score} Game over, press enter to retry!";

        private void GameForm_KeyDown(object sender, KeyEventArgs e) => _gameEngine.HandleKeyDown(e.KeyCode);
        private void GameForm_KeyUp(object sender, KeyEventArgs e) => _gameEngine.HandleKeyUp(e.KeyCode);


        private void GameForm_Load(object sender, EventArgs e)
        {

        }

    }
}
