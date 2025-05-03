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
        private readonly float _designAspectRatio = 16f / 9f;
        private readonly GameEngine _gameEngine;
        public GameForm()
        {
            InitializeComponent();
            ConfigureFormSettings();
            SetupEventHandlers();
            KeyPreview = true;
            _gameEngine = new GameEngine(this, this, picPlayer, pillar1, pillar2);
            _gameEngine.ScoreUpdated += OnScoreUpdated;
            _gameEngine.GameOver += OnGameOver;

        }
        private void ConfigureFormSettings()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint, true);

            WindowState = FormWindowState.Maximized;
            MinimumSize = new Size(1024, 576);
            StartPosition = FormStartPosition.CenterScreen;

            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Arial", 12f * (96f / 120f), FontStyle.Regular, GraphicsUnit.Point);
        }

        private void SetupEventHandlers()
        {
            KeyDown += (s, e) => _gameEngine.HandleKeyDown(e.KeyCode);
            KeyUp += (s, e) => _gameEngine.HandleKeyUp(e.KeyCode);
            Resize += GameForm_Resize;
            Load += GameForm_Load;
        }
        private void OnScoreUpdated(int score) => txtScore.Text = $"Score: {score}";
        private void OnGameOver(int score) => txtScore.Text = $"Score: {score} Game over, press enter to retry!";

        private void GameForm_KeyDown(object sender, KeyEventArgs e) => _gameEngine.HandleKeyDown(e.KeyCode);
        private void GameForm_KeyUp(object sender, KeyEventArgs e) => _gameEngine.HandleKeyUp(e.KeyCode);
        private void GameForm_Resize(object sender, System.EventArgs e)
        {
            // Поддержание соотношения сторон
            if (WindowState != FormWindowState.Maximized)
            {
                var newWidth = Math.Max(ClientSize.Width, MinimumSize.Width);
                var newHeight = (int)(newWidth / _designAspectRatio);
                ClientSize = new Size(newWidth, newHeight);
            }

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }


    }
}
