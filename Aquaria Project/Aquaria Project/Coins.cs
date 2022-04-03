using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquaria_Project
{
    internal class Coins
    {
        static int money = 100;


        public void setCoins (string score)
        {
            money += Int32.Parse(score);
        }

        public string Say()
        {
            return money.ToString();
        }

        public int getCoins()
        {
            return money;
        }
    }
}
