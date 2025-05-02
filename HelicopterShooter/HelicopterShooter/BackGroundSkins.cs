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
    public partial class BackGroundSkins : Form
    {
        public BackGroundSkins()
        {
            InitializeComponent();
        }
        private void CloseBackGroundSkins_Click(object sender, EventArgs e)
        {
            ShopForm shopform = new ShopForm();
            shopform.Show();
            Close();
        }
    }
}
