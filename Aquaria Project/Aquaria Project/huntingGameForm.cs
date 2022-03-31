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
        public huntingGameForm()
        {
            InitializeComponent();
            //change the cursor
            /*Bitmap bmp = new Bitmap(Properties.Resources.cursor);
            Cursor crcs = new Cursor(bmp.GetHbitmap());
            this.Cursor = crcs;*/
        }
        int miss, hunt, score;
        void game_Status()
        {
            if (lab_miss.Text == "Missed: 5")
            {
                lab_over.Visible = true;
                timer.Stop();
            } // game over is 5 fish missed
            if (lab_hunt.Text == "Hunted: 10")// game over is 10 fish is hunted
            {
                lab_over.Visible = true;
                timer.Stop();
            }
        }

        private void fish1_Click(object sender, EventArgs e)
        {
            hunt++;
            lab_hunt.Text = "Hunted: " + hunt;
            Image clown = Image.FromFile("fire.gif");
            score += 2;
            lab_score.Text = "Score: " + score;
        }

        private void fish2_Click(object sender, EventArgs e)
        {
            hunt++;
            lab_hunt.Text = "Hunted: " + hunt;
            Image clown = Image.FromFile("fire.gif");
            score += 5;
            lab_score.Text = "Score: " + score;
        }

        private void fish3_Click(object sender, EventArgs e)
        {
            hunt++;
            lab_hunt.Text = "Hunted: " + hunt;
            Image clown = Image.FromFile("fire.gif");
            score += 5;
            lab_score.Text = "Score: " + score;
        }

        private void fish4_Click(object sender, EventArgs e)
        {
            hunt++;
            lab_hunt.Text = "Hunted: " + hunt;
            Image clown = Image.FromFile("fire.gif");
            score += 5;
            lab_score.Text = "Score: " + score;
        }

        private void huntingGameForm_MouseClick(object sender, MouseEventArgs e)
        {
            miss++;
            lab_miss.Text = "Missed: " + miss;// if the user miss the target 
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            fish();
            game_Status();
        }

        void fish() // add all the fish images and make them move
        {
            if (fish1.Left < 0)
            {
                fish1.Left = 1000;
                Image clown = Image.FromFile("clown.gif");
            }
            if (fish2.Left < 0)
            {
                fish2.Left = 1000;
                Image clown = Image.FromFile("fish11.gif");
            }
            if (fish3.Left < 0)
            {
                fish3.Left = 1000;
                Image clown = Image.FromFile("crop.png");
            }
            if (fish4.Left < 0)
            {
                fish4.Left = 1000;
                Image clown = Image.FromFile("fish5.gif");
            }
            fish1.Left -= 5;
            fish2.Left -= 10;
            fish3.Left -= 15;
            fish4.Left -= 13;
        }
    }
}