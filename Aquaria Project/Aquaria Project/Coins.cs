using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************
 * Name: Coins.cs
 * Purpose: Keeping track of money and allow to add, substract and get money
 * Author: Jennifer Kalies
 * Note: starting coins can be changed when inizializing money
 *************************************/
namespace Aquaria_Project
{
    internal class Coins
    {
        static int money = 100;


        public void setCoins (string score)
        {
            money += Int32.Parse(score);
        }

        public void loseCoins (string price)
        {
            money -= Int32.Parse(price);
        }


        public int getCoins()
        {
            return money;
        }
    }
}
