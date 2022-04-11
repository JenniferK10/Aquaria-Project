using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**************************************
 * Name: GuessingGameForm.cs
 * Purpose: Includes functionalities of guessign game form
 * Author: Jennifer Kalies
 * Note: uses guessing game class
 *************************************/

namespace Aquaria_Project
{
    public partial class GuessingGameForm : Form
    {
        //JK begin
        GuessingGame g = new GuessingGame(); //creating instance of guessing game class
        Coins c = new Coins(); //adding coins class to send score to aquarium form
        public GuessingGameForm()
        {
            InitializeComponent();
        }

        private void Box1_Click(object sender, EventArgs e)//determines of clicked box is good or bad
        {
            g.DetermineBadBox();
            if (g.IsGood1())
                MessageBox.Show("Good Box");
            else
            {
                badGuessForm badGuess = new badGuessForm();//opening guessing game form
                badGuess.ShowDialog();
                g.ResetGuessingGame();//resetting game for wrong guess
            }
            Score.Text = g.GetScore();//updates money label
        }

        private void Box2_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood2())
                MessageBox.Show("Good Box");
            else
            {
                badGuessForm badGuess = new badGuessForm();//opening guessing game form
                badGuess.ShowDialog();
                g.ResetGuessingGame();
            }
            Score.Text = g.GetScore();
        }

        private void Box3_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood3())
                MessageBox.Show("Good Box");
            else
            {
                badGuessForm badGuess = new badGuessForm();//opening guessing game form
                badGuess.ShowDialog();
                g.ResetGuessingGame();
            }
            Score.Text = g.GetScore();
        }

        private void Box4_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood4())
                MessageBox.Show("Good Box");
            else
            {
                badGuessForm badGuess = new badGuessForm();//opening guessing game form
                badGuess.ShowDialog();
                g.ResetGuessingGame();
            }
            Score.Text = g.GetScore();
        }

        private void Box5_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood5())
                MessageBox.Show("Good Box");
            else
            {
                badGuessForm badGuess = new badGuessForm();//opening guessing game form
                badGuess.ShowDialog();
                g.ResetGuessingGame();
            }
            Score.Text = g.GetScore();
        }

        private void Box6_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood6())
                MessageBox.Show("Good Box");
            else
            {
                badGuessForm badGuess = new badGuessForm();//opening guessing game form
                badGuess.ShowDialog();
                g.ResetGuessingGame();
            }
            Score.Text = g.GetScore();
        }

        private void Box7_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood7())
                MessageBox.Show("Good Box");
            else
            {
                badGuessForm badGuess = new badGuessForm();//opening guessing game form
                badGuess.ShowDialog();
                g.ResetGuessingGame();
            }
            Score.Text = g.GetScore();
        }

        private void Box8_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood8())
                MessageBox.Show("Good Box");
            else
            {
                badGuessForm badGuess = new badGuessForm();//opening guessing game form
                badGuess.ShowDialog();
                g.ResetGuessingGame();
            }
            Score.Text = g.GetScore();
        }

        private void Box9_Click(object sender, EventArgs e)
        {
            g.DetermineBadBox();
            if (g.IsGood9())
                MessageBox.Show("Good Box");
            else
            {
                badGuessForm badGuess = new badGuessForm();//opening guessing game form
                badGuess.ShowDialog();
                g.ResetGuessingGame();
            }
            Score.Text = g.GetScore();
        }

        private void Money_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void GuessingGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            c.setCoins(g.GetScore());//adds score to money
        }
        //JK end
    }
}
