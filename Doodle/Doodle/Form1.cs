using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doodle
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipespeed = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            doodle.Top += gravity;
            Bpipe.Left -= pipespeed;
            Tpipe.Left -= pipespeed;
            scoreText.Text   = score.ToString();
            if (Bpipe.Left<-150)
            {
                Bpipe.Left = 800;
                score++;
            } 
            if (Tpipe.Left < -150)
            {
                Tpipe.Left = 800;
                score++;
            }
            if (doodle.Bounds.IntersectsWith(Bpipe.Bounds) || (doodle.Bounds.IntersectsWith(Tpipe.Bounds) ||
                (doodle.Bounds.IntersectsWith(ground.Bounds) || doodle.Top < -20)))
            {
                endgame();
            }
        if(score >5)
        {
            pipespeed = 15;

        }
        }      
        private void Form1_Load(object sender, EventArgs e)
        {     }
         private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }       }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

        }
        private void endgame()
        {
            Timer.Stop();
            scoreText.Text += "Game Over ";
        }

       
    }
}
