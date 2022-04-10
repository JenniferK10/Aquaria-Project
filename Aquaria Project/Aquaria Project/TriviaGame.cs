/**************************************
 * Name: TriviaGame.cs
 * Purpose: To display the trivia game form
 * Author: Florence Lourdes
 * Note: Adds score and money for each correct answer
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
    public partial class TriviaGame : Form
    {
        Coins c = new Coins();
        Trivia game = new Trivia();
        String currQuestion = "";
        int correct = 0;
        int round = 0;
        public TriviaGame()
        {
            InitializeComponent();
        }

        private void TriviaGame_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click_1(object sender, EventArgs e) 
        {
            //display questions and answer options for a maximum of 5 rounds
            round = round + 1;
            if (round <= 5)
            {
                currQuestion = game.generateQuestion();
                questionBox.Text = currQuestion;
                game.generateAnswers();
                ButtonA.Text = game.getChoiceA();
                ButtonB.Text = game.getChoiceB();
                ButtonC.Text = game.getChoiceC();
            }
            else
            {
                //resets the game after 5 rounds
                MessageBox.Show("correct answer: " + correct + ". Game is reset.");
                game.reset();
                questionBox.Text = "Question";
                ButtonA.Text = "Choice A";
                ButtonB.Text = "Choice B";
                ButtonC.Text = "Choice C";
                correct = 0;
                round = 0;
            }

        }
        
        //methods to determine if the choice of answer is correct
        private void ButtonA_Click(object sender, EventArgs e)
        {
            if (currQuestion.Equals(game.questions[3]) || currQuestion.Equals(game.questions[4]) ||
                currQuestion.Equals(game.questions[6]) || currQuestion.Equals(game.questions[7]) ||
                currQuestion.Equals(game.questions[10]) || currQuestion.Equals(game.questions[13]) ||
                currQuestion.Equals(game.questions[15]) || currQuestion.Equals(game.questions[18]) ||
                currQuestion.Equals(game.questions[19]))
            {
                MessageBox.Show("correct answer!");
                correct = correct + 1;
            }
            else
            {
                MessageBox.Show("false answer!");
            }
        }

        private void ButtonB_Click(object sender, EventArgs e)
        {
            if (currQuestion.Equals(game.questions[0]) || currQuestion.Equals(game.questions[1]) ||
                currQuestion.Equals(game.questions[12]) || currQuestion.Equals(game.questions[16]) ||
                currQuestion.Equals(game.questions[17]))
            {
                MessageBox.Show("correct answer!");
                correct = correct + 1;
            }
            else
            {
                MessageBox.Show("false answer!");
            }
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            if (currQuestion.Equals(game.questions[2]) || currQuestion.Equals(game.questions[5]) ||
               currQuestion.Equals(game.questions[8]) || currQuestion.Equals(game.questions[9]) ||
               currQuestion.Equals(game.questions[11]) || currQuestion.Equals(game.questions[14]))
            {
                MessageBox.Show("correct answer!");
                correct = correct + 1;
            }
            else
            {
                MessageBox.Show("false answer!");
            }
        }

        //reset function
        private void resetButton_Click(object sender, EventArgs e)
        {
            c.setCoins((correct * 10).ToString());
            MessageBox.Show("correct answer: " + correct + ". Game is reset.");
            game.reset();
            questionBox.Text = "Question";
            ButtonA.Text = "Choice A";
            ButtonB.Text = "Choice B";
            ButtonC.Text = "Choice C";
            correct = 0;
            round = 0;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void TriviaGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            c.setCoins((correct * 10).ToString());
        }
    }
}
