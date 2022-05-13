using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flapybird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gametimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity; 
            pipeTop.Left -= pipeSpeed; 
            pipeTop.Left -= pipeSpeed; 
            scorelabel.Text = "Score: " + score; 

           

            if (pipeBottom.Left < -150)
            {
               
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                
                pipeTop.Left = 950;
                score++;
            }

           
           

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                )
            {
               
                EndGame();
            }
            if (flappyBird.Top<-20)
            {
                EndGame();
            }


           
            if (score > 5)
            {
                pipeSpeed = 15;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
              
                gravity = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                
                gravity = 15;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void EndGame()
        {
            gametimer.Stop();
            scorelabel.Text="GAME OVER...";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
