using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public class Obstacle : GameObject
    {
        private const int BaseWidthFullHD = 104;
        private const int BaseHeightFullHD = 430;
        private const int BaseSpeedFullHD = 8;
        private const int BaseGapFullHD = 220;
        private readonly Control _container;
        private readonly bool _isTop;
        public Obstacle(PictureBox sprite, Control container, bool isTop)
        {
            Sprite = sprite;
            _container = container;
            _isTop = isTop;
            InitializeObstacle();
        }
        private void InitializeObstacle()
        {
            Sprite.SizeMode = PictureBoxSizeMode.StretchImage;
            UpdateSizeAndSpeed();

            if (!_isTop)
            {
                Sprite.Top = _container.Height - Sprite.Height;
            }
        }
        private float GetScaleFactor()
        {
            float scaleX = _container.ClientSize.Width / 1920f;
            float scaleY = _container.ClientSize.Height / 1080f;
            return Math.Min(scaleX, scaleY);
        }
        public void UpdateSizeAndSpeed()
        {
            float scale = GetScaleFactor();

            int newWidth = (int)(BaseWidthFullHD * scale);
            int newHeight = (int)(BaseHeightFullHD * scale);
            Sprite.Size = new Size(newWidth, newHeight);
            if (!_isTop)
            {
                Sprite.Top = _container.Height - Sprite.Height;
            }
            Speed = (int)(BaseSpeedFullHD * scale);
        }
        public int GetScaledGap()
        {
            return (int)(BaseGapFullHD * GetScaleFactor());
        }
        public void Update()
        {

            if (Sprite == null || Sprite.Parent == null)
                return;

            Sprite.Left -= Speed;
            if (Sprite.Right < 0)
            {
                Sprite.Left = Sprite.Parent.ClientSize.Width;
                UpdateSizeAndSpeed();
                if (!_isTop)
                {
                    Sprite.Top = _container.Height - Sprite.Height;
                }
            }
        }

    }
}
