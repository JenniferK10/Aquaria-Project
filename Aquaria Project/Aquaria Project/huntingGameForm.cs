/**************************************
 * Name: huntingGameForm.cs
 * Purpose: To create a game where users can hunt fishes and earn points to buy fishes later
 * Author: Suhali Patel
 *************************************/
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
    /*
     * Suhali Patel
     */
    public partial class huntingGameForm : Form
    {
        Coins c = new Coins();
        public huntingGameForm()
        {
            InitializeComponent();
        }

        int miss, hunt, score;
        private int duration = 60;
        void game_Status()
        {
            if (lab_miss.Text == "Missed: 5")
            {
                lab_over.Visible = true;
                timer.Stop();
                Restart.Visible = true;
                Exit.Visible = true;
            } 
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
                fish4.Left = 1000;
                fish4.Image = Properties.Resources.fish5;
            }
            if(fish5.Left < 0)
            {
                fish5.Left = 1000;
                fish5.Image = Properties.Resources.cardinal;
            }
            fish1.Left -= 5;
            fish2.Left -= 7;
            fish3.Left -= 10;
            fish4.Left -= 13;
            fish5.Left -= 15;
        }

        private void Restart_Click_1(object sender, EventArgs e)
        {
            string[] score = lab_score.Text.Split();
            c.setCoins(score[1]);
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
        }

        private void huntingGameForm_MouseClick(object sender, MouseEventArgs e)
        {
            miss++;
            lab_miss.Text = "Missed: " + miss;// if the user miss the target 
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        //JK begin
        private void huntingGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] score = lab_score.Text.Split();
            c.setCoins(score[1]);//adds score to money
        }
        //JK end

        private void fish5_Click(object sender, EventArgs e)
        {
            hunt++;
            lab_hunt.Text = "Hunted: " + hunt;
            fish5.Image = Properties.Resources.fire;
            score += 8;
            lab_score.Text = "Score: " + score;
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
