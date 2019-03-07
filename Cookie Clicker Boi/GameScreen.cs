using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie_Clicker_Boi
{
    public partial class GameScreen : UserControl
    {
        public int score;
        public int cps;
        public int clicks;

        public GameScreen()
        {
            InitializeComponent();
            

        }

        private void cookieButton_Click(object sender, EventArgs e)
        {
            score++; // for score (amount of cookies)
            clicks++; // for cps

            ScoreLabel.Text = "Cookies: " + score +""; // printing
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
