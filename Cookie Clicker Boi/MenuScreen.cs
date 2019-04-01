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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
            this.Controls.Add(gs);
            Form1 f = (Form1)Form1.ActiveForm;
            f.switchScreen("GS", this);
            Refresh();
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            Controls cs = new Controls();
            this.Controls.Add(cs);
            Form1 f = (Form1)Form1.ActiveForm;
            f.switchScreen("CS", this);
            Refresh();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
