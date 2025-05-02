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
        public GameForm()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += GameForm_KeyDown;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();
                Close();
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
