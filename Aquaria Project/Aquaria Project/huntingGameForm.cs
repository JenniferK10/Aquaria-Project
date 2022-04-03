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
    public partial class huntingGameForm : Form
    {
        Coins c = new Coins();
        public huntingGameForm()
        {
            InitializeComponent();
        }

        int miss, hunt, score;
        private int duration = 60;
        //Random r = new Random();
        
        void game_Status()
        {
            if (lab_miss.Text == "Missed: 5")
            {
                lab_over.Visible = true;
                timer.Stop();
                Restart.Visible = true;
                Exit.Visible = true;
            } // game over is 5 fish missed
            /*if (lab_hunt.Text == "Hunted: 10")// game over is 10 fish is hunted
            {
                lab_over.Visible = true;
                timer.Stop();
                Restart.Visible=true;
                Exit.Visible=true;
            }*/
        }


        void fish() // add all the fish images and make them move
        {
            if (fish1.Left < 0)
            {
                fish1.Left = 1000;
                fish1.Image = Properties.Resources.clown;
            }
            if (fish2.Left < 0)
            {
                fish2.Left = 1000;
                fish2.Image = Properties.Resources.fish11;
            }
            if (fish3.Left < 0)
            {
                fish3.Left = 1000;
                fish3.Image = Properties.Resources.crop;
            }
            if (fish4.Left < 0)
            {
                fish4.Left = -1000;
                fish4.Image = Properties.Resources.fish5;
            }
            fish1.Left -= 5;
            fish2.Left -= 10;
            fish3.Left -= 15;
            fish4.Left -= 13;
        }

        private void Restart_Click_1(object sender, EventArgs e)
        {
            reset();// set the button
        }

        private void fish4_Click_1(object sender, EventArgs e)
        {
            hunt++;
            lab_hunt.Text = "Hunted: " + hunt;
            fish4.Image = Properties.Resources.fire;
            score += 5;
            lab_score.Text = "Score: " + score;
        }

        private void fish3_Click_1(object sender, EventArgs e)
        {
            hunt++;
            lab_hunt.Text = "Hunted: " + hunt;
            fish3.Image = Properties.Resources.fire;
            score += 5;
            lab_score.Text = "Score: " + score;
        }

        private void fish2_Click_1(object sender, EventArgs e)
        {
            hunt++;
            lab_hunt.Text = "Hunted: " + hunt;
            fish2.Image = Properties.Resources.fire;
            score += 3;
            lab_score.Text = "Score: " + score;
        }

        private void fish1_Click(object sender, EventArgs e)
        {
            hunt++;
            lab_hunt.Text = "Hunted: " + hunt;
            fish1.Image = Properties.Resources.fire;
            score += 1;
            lab_score.Text = "Score: " + score;
        }

        private void huntingGameForm_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            fish();
            game_Status();

            /*int x, y;
            x = r.Next(100, 300);
            y = r.Next(100, 300);
            fish1.Location = new Point(x, y);*/
        }

        private void huntingGameForm_MouseClick(object sender, MouseEventArgs e)
        {
            miss++;
            lab_miss.Text = "Missed: " + miss;// if the user miss the target 
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            string[] score = lab_score.Text.Split();
            c.setCoins(score[1]);
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (duration == 0)// if 0 secodns left 
            {
                lab_over.Visible = true;
                timer1.Stop();
                Restart.Visible = true;
                Exit.Visible = true;
            }
            if (duration > 0)// if there is still some time
            {
                duration--;
                lab_timer.Text = "Time: " + duration.ToString();
            }
        }

        void reset()// reset the game 
        {
            miss = 0;//everything == 0
            hunt = 0;
            score = 0;
            lab_miss.Text = "Missed: " + miss;
            lab_hunt.Text = "Hunted: " + hunt;
            lab_score.Text = "Score: " + score;
            duration = 60;
            lab_timer.Text = "Time: " + duration;
            timer.Start();// reset the timer
            timer1.Start();
            //remove from the screen
            lab_over.Visible = false;
            Restart.Visible = false;
            Exit.Visible = false;
        }
      
    }
}
