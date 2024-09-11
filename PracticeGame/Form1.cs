using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PracticeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

            
        {
            SoundPlayer sp2 = new SoundPlayer(Properties.Resources.Coin_Drop_Willem_Hunt_569197907);
            sp2.Play();
            Thread.Sleep(4000);

            startbutton.BackColor = Color.DarkGreen;
            startbutton.Text = "3";
            Refresh();
            Thread.Sleep(1000);

            startbutton.Text = "2";
            Refresh();
            Thread.Sleep(1000);

            startbutton.Text = "1";
            Refresh();
            Thread.Sleep(1000);

            startbutton.Text = "Begin";
            startbutton.BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(1000);

            SoundPlayer sp = new SoundPlayer(Properties.Resources.Short_triumphal_fanfare_John_Stracke_815794903);
            sp.Play();




        }

        private void startbutton_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
