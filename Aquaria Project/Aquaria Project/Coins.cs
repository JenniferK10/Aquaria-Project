using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Jennifer Kalies
 */
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
