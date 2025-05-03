using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public class Player : GameObject
    {
        private const int BaseWidth = 200;
        private const int BaseHeight = 90;
        private readonly Control _container;
        private const int PlayerSpeed = 7;
        private bool _movingUp, _movingDown;

        public Player(PictureBox existingSprite, Control container)
        {
            Sprite = existingSprite;
            _container = container;
            UpdatePlayerSize();
            Reset();
        }
        public void UpdatePlayerSize()
        {
            float scaleX = _container.ClientSize.Width / 1920f;
            float scaleY = _container.ClientSize.Height / 1080f;
            float scale = Math.Min(scaleX, scaleY);
            int newWidth = (int)(BaseWidth * scale);
            int newHeight = (int)(BaseHeight * scale);

            Sprite.Size = new Size(newWidth, newHeight);
        }
        public void MoveUp() => _movingUp = true;
        public void MoveDown() => _movingDown = true;
        public void StopMovingUp() => _movingUp = false;
        public void StopMovingDown() => _movingDown = false;

        public void Update()
        {
            if (_movingUp && Top > 0) Sprite.Top -= PlayerSpeed;
            if (_movingDown && Bottom < Sprite.Parent.ClientSize.Height) Sprite.Top += PlayerSpeed;
        }

        public void Reset()
        {
            UpdatePlayerSize();
            Sprite.Top = (int)(_container.ClientSize.Height * 0.5f);
            Sprite.Left = (int)(_container.ClientSize.Width * 0.02f);
            _movingUp = _movingDown = false;
        }
    }
}
