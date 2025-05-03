using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public class Bullet : GameObject
    {
        private const int BaseWidth = 20;
        private const int BaseHeight = 10;
        private int _baseSpeed = 25;
        public Bullet(Control container, int startX, int startY)
        {
            float scaleX = container.ClientSize.Width / 1920f;
            float scaleY = container.ClientSize.Height / 1080f;
            float scale = Math.Min(scaleX, scaleY);

            int newWidth = (int)(BaseWidth * scale);
            int newHeight = (int)(BaseHeight * scale);

            Sprite = new PictureBox
            {
                Size = new Size(newWidth, newHeight),
                BackColor = Color.Maroon,
                Left = startX,
                Top = startY,
                Tag = "bullet"
            };
            container.Controls.Add(Sprite);
            Speed = (int)(_baseSpeed * scale);
        }


        public bool IsOutOfScreen(int screenWidth)
        {
            if (Sprite == null) return true;
            return Sprite.Left > screenWidth;
        }

        public void Update(List<Obstacle> obstacles)
        {
            if (Sprite == null || Sprite.Parent == null)
                return;

            Sprite.Left += Speed;


            if (CheckCollision(obstacles))
            {
                Destroy();
            }
        }
        public bool CheckCollision(List<Obstacle> obstacles)
        {
            if (Sprite == null || obstacles == null)
                return false;

            foreach (var obstacle in obstacles)
            {
                if (obstacle?.Sprite != null && Sprite.Bounds.IntersectsWith(obstacle.Sprite.Bounds))
                {
                    return true;
                }
            }
            return false;
        }

        public void Destroy()
        {
            if (Sprite != null && Sprite.Parent != null)
            {
                Sprite.Parent.Controls.Remove(Sprite);
                Sprite.Dispose();
                Sprite = null;
            }
        }
    }
}
