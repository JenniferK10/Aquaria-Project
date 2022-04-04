using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquaria_Project
{
    /*
     Jennifer Kalies
    */
    internal class GuessingGame
    {
        Coins c;
        
        bool goodBox1 = true;// booleans to determine if the box is good or bad
        bool goodBox2 = true;
        bool goodBox3 = true;
        bool goodBox4 = true;
        bool goodBox5 = true;
        bool goodBox6 = true;
        bool goodBox7 = true;
        bool goodBox8 = true;
        bool goodBox9 = true;
        string badBox; //holds random number to check if box is already bad
        string badNumber = "";//keeps strack of boxes that are already bad
        int corrcetGuesses = 0;//counts correct guesses to increase the earned money
        int score = 0;


        Random rnd = new Random();

        public GuessingGame()
        {
            c = new Coins();
        }

        public void SetScore(string num)
        {
            score = Int32.Parse(num);
        }

        public string GetScore()
        {
            return score.ToString();
        }


        public string DetermineBadBox()//function determines a random box to become bad
        {
            badBox = (rnd.Next(9) + 1).ToString();//generates random number 1-9
            while (badNumber.Contains(badBox))//checks if box number is already bad
            {
                badBox = (rnd.Next(9) + 1).ToString();
            }

            switch (badBox)
            {
                case "1":
                    goodBox1 = false;//turns box bad
                    badNumber += "1";
                    break;
                case "2":
                    goodBox2 = false;
                    badNumber += "2";
                    break;
                case "3":
                    goodBox3 = false;
                    badNumber += "3";
                    break;
                case "4":
                    goodBox4 = false;
                    badNumber += "4";
                    break;
                case "5":
                    goodBox5 = false;
                    badNumber += "5";
                    break;
                case "6":
                    goodBox6 = false;
                    badNumber += "6";
                    break;
                case "7":
                    goodBox7 = false;
                    badNumber += "7";
                    break;
                case "8":
                    goodBox8 = false;
                    badNumber += "8";
                    break;
                case "9":
                    goodBox9 = false;
                    badNumber += "9";
                    break;
                default:
                    badBox = "0";
                    break;
            }

            return badBox;

        }

        public bool IsGood1()//determines if box is good, adds money when box is good and resets game if player guessed every box
        {
            if (goodBox1)
            {
                if (corrcetGuesses == 0)
                    score += 1;
                if (corrcetGuesses == 1)
                    score += 2;
                if (corrcetGuesses == 2)
                    score += 3;
                if (corrcetGuesses == 3)
                    score += 4;
                if (corrcetGuesses == 4)
                    score += 5;
                if (corrcetGuesses == 5)
                    score += 6;
                if (corrcetGuesses == 6)
                    score += 7;
                if (corrcetGuesses == 7)
                    score += 8;
                if (corrcetGuesses == 8)
                {
                    score += 9;
                    ResetGuessingGame();
                }

                ++corrcetGuesses;
            }

            return goodBox1;
        }
        public bool IsGood2()
        {
            if (goodBox2)
            {
                if (corrcetGuesses == 0)
                    score += 1;
                if (corrcetGuesses == 1)
                    score += 2;
                if (corrcetGuesses == 2)
                    score += 3;
                if (corrcetGuesses == 3)
                    score += 4;
                if (corrcetGuesses == 4)
                    score += 5;
                if (corrcetGuesses == 5)
                    score += 6;
                if (corrcetGuesses == 6)
                    score += 7;
                if (corrcetGuesses == 7)
                    score += 8;
                if (corrcetGuesses == 8)
                {
                    score += 9;
                    ResetGuessingGame();
                }

                ++corrcetGuesses;

            }

            return goodBox2;
        }
        public bool IsGood3()
        {
            if (goodBox3)
            {
                if (corrcetGuesses == 0)
                    score += 1;
                if (corrcetGuesses == 1)
                    score += 2;
                if (corrcetGuesses == 2)
                    score += 3;
                if (corrcetGuesses == 3)
                    score += 4;
                if (corrcetGuesses == 4)
                    score += 5;
                if (corrcetGuesses == 5)
                    score += 6;
                if (corrcetGuesses == 6)
                    score += 7;
                if (corrcetGuesses == 7)
                    score += 8;
                if (corrcetGuesses == 8)
                {
                    score += 9;
                    ResetGuessingGame();
                }

                ++corrcetGuesses;
            }

            return goodBox3;
        }
        public bool IsGood4()
        {
            if (goodBox4)
            {
                if (corrcetGuesses == 0)
                    score += 1;
                if (corrcetGuesses == 1)
                    score += 2;
                if (corrcetGuesses == 2)
                    score += 3;
                if (corrcetGuesses == 3)
                    score += 4;
                if (corrcetGuesses == 4)
                    score += 5;
                if (corrcetGuesses == 5)
                    score += 6;
                if (corrcetGuesses == 6)
                    score += 7;
                if (corrcetGuesses == 7)
                    score += 8;
                if (corrcetGuesses == 8)
                {
                    score += 9;
                    ResetGuessingGame();
                }

                ++corrcetGuesses;
            }

            return goodBox4;
        }
        public bool IsGood5()
        {
            if (goodBox5)
            {
                if (corrcetGuesses == 0)
                    score += 1;
                if (corrcetGuesses == 1)
                    score += 2;
                if (corrcetGuesses == 2)
                    score += 3;
                if (corrcetGuesses == 3)
                    score += 4;
                if (corrcetGuesses == 4)
                    score += 5;
                if (corrcetGuesses == 5)
                    score += 6;
                if (corrcetGuesses == 6)
                    score += 7;
                if (corrcetGuesses == 7)
                    score += 8;
                if (corrcetGuesses == 8)
                {
                    score += 9;
                    ResetGuessingGame();
                }

                ++corrcetGuesses;
            }

            return goodBox5;
        }
        public bool IsGood6()
        {
            if (goodBox6)
            {
                if (corrcetGuesses == 0)
                    score += 1;
                if (corrcetGuesses == 1)
                    score += 2;
                if (corrcetGuesses == 2)
                    score += 3;
                if (corrcetGuesses == 3)
                    score += 4;
                if (corrcetGuesses == 4)
                    score += 5;
                if (corrcetGuesses == 5)
                    score += 6;
                if (corrcetGuesses == 6)
                    score += 7;
                if (corrcetGuesses == 7)
                    score += 8;
                if (corrcetGuesses == 8)
                {
                    score += 9;
                    ResetGuessingGame();
                }

                ++corrcetGuesses;
            }

            return goodBox6;
        }
        public bool IsGood7()
        {
            if (goodBox7)
            {
                if (corrcetGuesses == 0)
                    score += 1;
                if (corrcetGuesses == 1)
                    score += 2;
                if (corrcetGuesses == 2)
                    score += 3;
                if (corrcetGuesses == 3)
                    score += 4;
                if (corrcetGuesses == 4)
                    score += 5;
                if (corrcetGuesses == 5)
                    score += 6;
                if (corrcetGuesses == 6)
                    score += 7;
                if (corrcetGuesses == 7)
                    score += 8;
                if (corrcetGuesses == 8)
                {
                    score += 9;
                    ResetGuessingGame();
                }

                ++corrcetGuesses;
            }

            return goodBox7;
        }
        public bool IsGood8()
        {
            if (goodBox8)
            {
                if (corrcetGuesses == 0)
                    score += 1;
                if (corrcetGuesses == 1)
                    score += 2;
                if (corrcetGuesses == 2)
                    score += 3;
                if (corrcetGuesses == 3)
                    score += 4;
                if (corrcetGuesses == 4)
                    score += 5;
                if (corrcetGuesses == 5)
                    score += 6;
                if (corrcetGuesses == 6)
                    score += 7;
                if (corrcetGuesses == 7)
                    score += 8;
                if (corrcetGuesses == 8)
                {
                    score += 9;
                    ResetGuessingGame();
                }

                ++corrcetGuesses;
            }

            return goodBox8;
        }
        public bool IsGood9()
        {
            if (goodBox9)
            {
                if (corrcetGuesses == 0)
                    score += 1;
                if (corrcetGuesses == 1)
                    score += 2;
                if (corrcetGuesses == 2)
                    score += 3;
                if (corrcetGuesses == 3)
                    score += 4;
                if (corrcetGuesses == 4)
                    score += 5;
                if (corrcetGuesses == 5)
                    score += 6;
                if (corrcetGuesses == 6)
                    score += 7;
                if (corrcetGuesses == 7)
                    score += 8;
                if (corrcetGuesses == 8)
                {
                    score += 9;
                    ResetGuessingGame();
                }

                ++corrcetGuesses;
            }

            return goodBox9;
        }

        public void ResetGuessingGame()//resets game
        {
            goodBox1 = true;
            goodBox2 = true;
            goodBox3 = true;
            goodBox4 = true;
            goodBox5 = true;
            goodBox6 = true;
            goodBox7 = true;
            goodBox8 = true;
            goodBox9 = true;
            badNumber = "";
            corrcetGuesses = 0;
        }
    }
}
