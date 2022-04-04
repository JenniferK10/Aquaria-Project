using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Fish
{
    public partial class FlappyFish : Form
    {
        int pipeSpeed = 5; //sets speed at which pipes move
        int gravity = 13;  // makes bird fall
        int score = 0;     //keeps track of how many points you get, may turn to coins
        Random rnd = new Random();
        int rand = 0;

        public FlappyFish()
        {
            InitializeComponent();
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FlappyFish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //when the space bar is pushed down
            {
                gravity = -13; //the bird goes up
            }

        }

        private void FlappyFish_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //when the space bar is let go
            {
                gravity = 13; //the bird goes down
            }
        }
        private void endGame()
        {
            timer1.Stop(); 
            score1.Text += " Game over!!!"; //score text box says messge
            Restart.Visible = true; //button to restart game shows
            ExitButton.Visible = true;  //button to exit game shows
        }
        private void GameTimerEvent(object sender, EventArgs e)
        {
            Fish.Top += gravity; //links bird with gravity so it falls/rises
            PipeBottom.Left -= pipeSpeed;
            PipeBottomHigh.Left -= pipeSpeed;
            PipeBottomLow.Left -= pipeSpeed;//links pipeSpeed with the pipes so they move
            PipeTop.Left -= pipeSpeed;
            PipeTopHigh.Left -= pipeSpeed;
            PipeTopLow.Left -= pipeSpeed;//top and bottom
            score1.Text = "Score: " + score;  //keeps track of score

            rand = rnd.Next(0, 2);

            if (PipeBottom.Left < -150 || PipeBottomHigh.Left < -150 || PipeBottomLow.Left < -150)
            {
                if (rand == 0)
                {
                    PipeBottom.Visible = true;
                    PipeBottom.Left = 800;
                    PipeBottomHigh.Visible = false;
                    PipeBottomLow.Visible = false;
                    PipeBottomHigh.Left = 800;
                    PipeBottomLow.Left = 800;

                }
                if (rand == 1)
                {
                    PipeBottomHigh.Visible = true;
                    PipeBottomHigh.Left = 800;
                    PipeBottom.Visible = false;
                    PipeBottomLow.Visible = false;
                    PipeBottom.Left = 800;
                    PipeBottomLow.Left = 800;


                }
                if (rand == 2)
                {
                    PipeBottomLow.Visible = true;
                    PipeBottomLow.Left = 800;
                    PipeBottomHigh.Visible = false;
                    PipeBottom.Visible = false;
                    PipeBottom.Left = 800;
                    PipeBottomHigh.Left = 800;

                }
                score++;   //once the pipes go past the bird they reset and score is added
            }
            if (PipeTop.Left < -150 || PipeTopHigh.Left < -150 || PipeTopLow.Left < -150) //-180
            {
                if (rand == 0)
                {
                    PipeTop.Visible = true;
                    PipeTop.Left = 800;
                    PipeTopHigh.Visible = false;
                    PipeTopLow.Visible = false;
                    PipeTopHigh.Left = 800;
                    PipeTopLow.Left = 800;


                }
                if (rand == 1)
                {
                    PipeTopHigh.Visible = true;
                    PipeTopHigh.Left = 800;
                    PipeTop.Visible = false;
                    PipeTopLow.Visible = false;
                    PipeTop.Left = 800;
                    PipeTopLow.Left = 800;
                }
                if (rand == 2)
                {
                    PipeTopLow.Visible = true;
                    PipeTopLow.Left = 800;
                    PipeTopHigh.Visible = false;
                    PipeTop.Visible = false;
                    PipeTopHigh.Left = 800;
                    PipeTop.Left = 800;
                }
            }
            if (PipeTop.Visible == true)
            {
                if (Fish.Bounds.IntersectsWith(PipeBottom.Bounds) ||
                Fish.Bounds.IntersectsWith(PipeTop.Bounds) ||
                Fish.Bounds.IntersectsWith(Ground.Bounds) ||
                Fish.Top < -25)
                {
                    endGame();
                }
            }
            if (PipeTopHigh.Visible == true)
            {
                if (Fish.Bounds.IntersectsWith(PipeBottomHigh.Bounds) ||
                Fish.Bounds.IntersectsWith(PipeTopHigh.Bounds) ||
                Fish.Bounds.IntersectsWith(Ground.Bounds) ||
                Fish.Top < -25)
                {
                    endGame();
                }
            }
            if (PipeTopLow.Visible == true)
            {
                if (Fish.Bounds.IntersectsWith(PipeBottomLow.Bounds) ||
                Fish.Bounds.IntersectsWith(PipeTopLow.Bounds) ||
                Fish.Bounds.IntersectsWith(Ground.Bounds) ||
                Fish.Top < -25)
                {
                    endGame();
                }
            }
              
           
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart(); //restarts game
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void Fish_Click(object sender, EventArgs e)
        {

        }

        private void PipeBottom_Click(object sender, EventArgs e)
        {

        }

        private void score1_Click(object sender, EventArgs e)
        {

        }
    }
}
