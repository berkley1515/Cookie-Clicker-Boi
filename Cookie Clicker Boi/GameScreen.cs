using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Cookie_Clicker_Boi
{
    
    public partial class GameScreen : UserControl
    {
        
        public int score;
        public int cps_computer;  // cookies per second (done by upgrades)
        public int cps_user; // cookies per second (done by user)
        public int clicks;
        public int multiplier;
        public int tick;


        //public static Shop s;

        public static grandma g;
        public static robot r;
        public static farm f;
        public static factory fa;
        public static cloner clon;
        public static atomic atom;
        public static alien ali;
        public static krypto kyr;
        public static HACK hac;
        public static WIN win;


        public GameScreen()
        {
            InitializeComponent();
            g = new grandma(40, 1.3F, 1);
            int c = g.upgrade_cost;
            g = new grandma(c, 1.3F, 1);

            r = new robot(150, 1.3F, 6);
            int a = r.upgrade_cost;
            r = new robot(a, 1.3F, 6);

            f = new farm(2000, 1.3F, 15);
            int b = f.upgrade_cost;
            f = new farm(b, 1.3F, 15);

            fa = new factory(9000, 1.3F, 50);
            int d = fa.upgrade_cost;
            fa = new factory(d, 1.3F, 50);

            clon = new cloner(90000, 1.3F, 110);
            int e = clon.upgrade_cost;
            clon = new cloner(e, 1.3F, 119);

            atom = new atomic(200000, 1.3F, 1100);
            int h = atom.upgrade_cost;
            atom = new atomic(h, 1.3F, 1100);

            ali = new alien(600000, 1.3F, 11000);
            int l = ali.upgrade_cost;
            ali = new alien(l, 1.3F, 11000);

            kyr = new krypto(9000000, 1.3F, 601000);
            int i = kyr.upgrade_cost;
            kyr = new krypto(i, 1.3F, 601000);

            hac = new HACK(150000000, 1.3F, 4000000);
            int j = hac.upgrade_cost;
            hac = new HACK(j, 1.3F, 4000000);

            win = new WIN(2000000000);
            int k = win.upgrade_cost;
            win = new WIN(k);

        }

        SoundPlayer player = new SoundPlayer(Properties.Resources.clickSound);
        private void cookieButton_Click(object sender, EventArgs e)
        {
            score++; // for score (amount of cookies)
            clicks++; // for cps
            player.Play();

        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            // switch to shopScreen
            Form1 f = (Form1)FindForm();
            f.switchScreen("SS", this);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
            Form1 f = (Form1)Form1.ActiveForm;
            f.switchScreen("MS", this);
            Refresh();
        }



        private void grandmaButton_Click(object sender, EventArgs e)
        {
            cps_computer += g.upgrade_increase;
            g.level++;
            grandmaButton.Text = "Grandma     Level: " + g.level + " Cost: " + g.upgrade_cost + "     Cps: +1.0";
        }

        private void cRobotButton_Click(object sender, EventArgs e)
        {
            cps_computer += r.upgrade_increase;
            r.level++;
            cRobotButton.Text = "C-Robot    Level: " + r.level + " Cost: " + r.upgrade_cost+ "     Cps: +6.0";
        }

        private void cFarmButton_Click(object sender, EventArgs e)
        {
            cps_computer += f.upgrade_increase;
            f.level++;
            cFarmButton.Text = "C - Farm      Level: " + f.level + " Cost: " + f.upgrade_cost + "   Cps: +15";
        }

        private void cFactoryButton_Click(object sender, EventArgs e)
        {
            cps_computer += fa.upgrade_increase;
            fa.level++;
            cFactoryButton.Text = "C-Factory    Level: " + fa.level + " Cost: " + fa.upgrade_cost + "   Cps: +50";
        }

        private void cClonerButton_Click(object sender, EventArgs e)
        {
            cps_computer += clon.upgrade_increase;
            clon.level++;
            cClonerButton.Text = "C-Cloner    Level: " + clon.level + " Cost: " + clon.upgrade_cost + "  Cps: +110";
        }

        private void atomicCButton_Click(object sender, EventArgs e)
        {
            cps_computer += atom.upgrade_increase;
            atom.level++;
            atomicCButton.Text = "Atomic-C    Level: " + atom.level + " Cost: " + atom.upgrade_cost + " Cps: +1100";
        }

        private void alienLabButton_Click(object sender, EventArgs e)
        {
            cps_computer += ali.upgrade_increase;
            ali.level++;
            alienLabButton.Text = "Alien Lab      Level: " + ali.level + " Cost: " + ali.upgrade_cost + " Cps: +11000";
        }

        private void kryptoCButton_Click(object sender, EventArgs e)
        {
            cps_computer += kyr.upgrade_increase;
            kyr.level++;
            kryptoCButton.Text = "Krypto-C         Level: " + kyr.level + " Cost: " + kyr.upgrade_cost + " Cps: +601000";
        }

        private void cookieHackButton_Click(object sender, EventArgs e)
        {
            cps_computer += hac.upgrade_increase;
            hac.level++;
            cookieHackButton.Text = "Cookie Hack        Level: " + hac.level + " Cost: " + hac.upgrade_cost + " Cps: +4000000";
        }

        private void WINBUTTON_Click(object sender, EventArgs e)
        {
            //win the game
            //game over method
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
            //cps_computer += s.cps;
            cpsLabel.Text = "CPS: " + cps_computer;
            ScoreLabel.Text = "Cookies: " + score;
         
            if (tick == 60)
            {
                score += cps_computer;
                tick = 0;
            }
        }
    }
}

public class Shop
    {
        public int base_cost;
        public float cost_multiplier = 1.3F;
        public int upgrade_cost;
        public int upgrade_increase;
        public int level = 1;
        public int cps = 0;
    }

    public class grandma : Shop
    {
        public grandma(int _base_cost, float _cost_multiplier, int _upgrade_increase)
        {
            float f = _base_cost * (_cost_multiplier);
            upgrade_cost = (int)f;
        }
    }
public class robot : Shop
{
    public robot(int _base_cost, float _cost_multiplier, int _upgrade_increase)
    {
        float f = _base_cost * (_cost_multiplier);
        upgrade_cost = (int)f;
    }
}
public class farm : Shop
{
    public farm(int _base_cost, float _cost_multiplier, int _upgrade_increase)
    {
        level = 1;
        _base_cost = 2000;
        _cost_multiplier = cost_multiplier;
        float f = _base_cost * (_cost_multiplier);
        upgrade_cost = (int)f;
        _upgrade_increase = 15;
    }
}
public class factory : Shop
{
    public factory(int _base_cost, float _cost_multiplier, int _upgrade_increase)
    {
        level = 1;
        _base_cost = 9000;
        _cost_multiplier = cost_multiplier;
        float f = _base_cost * (_cost_multiplier);
        upgrade_cost = (int)f;
        _upgrade_increase = 50;
    }
}
public class cloner : Shop
{
    public cloner(int _base_cost, float _cost_multiplier, int _upgrade_increase)
    {
        level = 1;
        _base_cost = 90000;
        _cost_multiplier = cost_multiplier;
        float f = _base_cost * (_cost_multiplier);
        upgrade_cost = (int)f;
        _upgrade_increase = 110;
    }
}
public class atomic : Shop
{
    public atomic(int _base_cost, float _cost_multiplier, int _upgrade_increase)
    {
        level = 1;
        _base_cost = 200000;
        _cost_multiplier = cost_multiplier;
        float f = _base_cost * (_cost_multiplier);
        upgrade_cost = (int)f;
        _upgrade_increase = 1100;
    }
}
public class alien : Shop
{
    public alien(int _base_cost, float _cost_multiplier, int _upgrade_increase)
    {
        level = 1;
        _base_cost = 600000;
        _cost_multiplier = cost_multiplier;
        float f = _base_cost * (_cost_multiplier);
        upgrade_cost = (int)f;
        _upgrade_increase = 11000;
    }
}
public class krypto : Shop
{
    public krypto(int _base_cost, float _cost_multiplier, int _upgrade_increase)
    {
        level = 1;
        _base_cost = 9000000;
        _cost_multiplier = cost_multiplier;
        float f = _base_cost * (_cost_multiplier);
        upgrade_cost = (int)f;
        _upgrade_increase = 601000;
    }
}
public class HACK : Shop
{
    public HACK(int _base_cost, float _cost_multiplier, int _upgrade_increase)
    {
        level = 1;
        _base_cost = 150000000;
        _cost_multiplier = cost_multiplier;
        float f = _base_cost * (_cost_multiplier);
        upgrade_cost = (int)f;
        _upgrade_increase = 1100;
    }
}
public class WIN : Shop
{
    public WIN(int _base_cost)
    {
        _base_cost = 2000000000;
    }
}
