using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie_Clicker_Boi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameScreen gs = new GameScreen();
            this.Controls.Add(gs);
        }

        public void switchScreen(String next, UserControl current)
        {
            UserControl c = new GameScreen();
            switch (next)
            {
                case "GS":
                c = new GameScreen();
                break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Program goes directly to the GameScreen method on start
            GameScreen gs = new GameScreen();
            this.Controls.Add(gs);
        }
    }
}
