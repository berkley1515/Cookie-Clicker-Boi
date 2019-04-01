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
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
        }

        public void switchScreen(String next, UserControl current)
        {
            UserControl c = new MenuScreen();
            switch (next)
            {
                case "MS":
                    c = new MenuScreen();
                    break;

                case "GS":
                    c = new GameScreen();
                    break;

                case "CS":
                    c = new Controls();
                    break;
            }
            Controls.Add(c);
            Controls.Remove(current);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Program goes directly to the GameScreen method on start
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
        }
    }
}
