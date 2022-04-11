using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquaria_Project
{
    public partial class FlappyFishForm : Form
    {//MF
        int pipeSpeed = 5; //sets speed at which pipes move
        int gravity = 13;  // makes bird fall
        int score = 0;     //keeps track of how many points you get, may turn to coins
        Random rnd = new Random(); //random number generator
        int rand = 0;

        Coins c = new Coins();

        public FlappyFishForm()
        {
            InitializeComponent();
        }

        private void FlappyFishForm_Load(object sender, EventArgs e)
        {
            
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

            rand = rnd.Next(0, 2); //generates number 0-2, chooses pipe hight

            if (PipeBottom.Left < -150 || PipeBottomHigh.Left < -150 || PipeBottomLow.Left < -150)
            {
                if (rand == 0) //bottom pipe middle
                {
                    PipeBottom.Visible = true;
                    PipeBottom.Left = 800;
                    PipeBottomHigh.Visible = false;
                    PipeBottomLow.Visible = false;
                    PipeBottomHigh.Left = 800;
                    PipeBottomLow.Left = 800;

                }
                if (rand == 1) //bottom pipe high
                {
                    PipeBottomHigh.Visible = true;
                    PipeBottomHigh.Left = 800;
                    PipeBottom.Visible = false;
                    PipeBottomLow.Visible = false;
                    PipeBottom.Left = 800;
                    PipeBottomLow.Left = 800;


                }
                if (rand == 2) //bottom pipe low
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
                if (rand == 0) //same as bottom but for top
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
            if (PipeTop.Visible == true) //fish only collides with visible pipes
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
        private void endGame()
        {
            GameTimer.Stop(); //ends game
            score1.Text += " Game over!!!"; //score text box says messge
            Restart.Visible = true; //button to restart game shows
            ExitButton.Visible = true;  //button to exit game shows
        }

  

        private void Restart_Click(object sender, EventArgs e)
        {
            PipeTop.Left = 800; //resets all pies
            PipeTopLow.Left = 800;
            PipeTopHigh.Left = 800;
            PipeBottomLow.Left = 800;
            PipeBottom.Left = 800;
            PipeBottomHigh.Left = 800;
            Fish.Location = new Point(91, 207); //resets fish
            StartButton.Visible = true; 
            Restart.Visible = false;
            ExitButton.Visible = false;
        
        }

        private void SpaceKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is down fish goes up
                gravity = -13;
            }
        }

        private void SpaceKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is up fish goes down
                gravity = 13;
            }
        }

        //JK begin
        private void FlappyFishForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            c.setCoins((score * 20).ToString());//add score to money
        }
        //JK end 

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //close form
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GameTimer.Start(); //starts game
            StartButton.Visible = false;
        }
    }
}
