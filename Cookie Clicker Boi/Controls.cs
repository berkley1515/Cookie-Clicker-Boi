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
    public partial class Controls : UserControl
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
            Form1 f = (Form1)Form1.ActiveForm;
            f.switchScreen("MS", this);
            Refresh();
        }
    }
}
