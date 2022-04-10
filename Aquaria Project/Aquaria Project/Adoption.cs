/**************************************
 * Name: Adoption.cs
 * Purpose: To display the fish adoption form and sell fishes
 * Author: Florence Lourdes
 * Note: Uses the Coins class and temporary array list to hold fishes
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
    public partial class Adoption : Form
    {

         Coins adoptionCoins = new Coins();
         List<string> adoptionFishList = new List<string>();
        Fish adoption = new Fish("adoption");

        public Adoption()
        {
            InitializeComponent();
        }

        private void Adoption_Load(object sender, EventArgs e)
        {
            adoptionFishList = adoption.getFishList(); //sets a local array to hold fishes
        }

        private void timer1_Tick(object sender, EventArgs e) //enables buttons based on updated array
        {           

            if (adoption.getFishList().Contains("clownfish"))
            {
                sellClownfish.Enabled = true;
            }
            else
            {
                sellClownfish.Enabled = false;
            }

            if (adoption.getFishList().Contains("goby"))
            {
                sellGoby.Enabled = true;
            }
            else
            {
                sellGoby.Enabled = false;
            }

            if (adoption.getFishList().Contains("puffer fish"))
            {
                sellPuffer.Enabled = true;
            }
            else
            {
                sellPuffer.Enabled = false;
            }

            if (adoption.getFishList().Contains("butterfly fish"))
            {
                sellButterfly.Enabled = true;
            }
            else
            {
                sellButterfly.Enabled = false;
            }

            if (adoption.getFishList().Contains("bluetang"))
            {
                sellBlue.Enabled = true;
            }
            else
            {
                sellBlue.Enabled = false;
            }

            if (adoption.getFishList().Contains("royal gramma"))
            {
                sellRoyal.Enabled = true;
            }
            else
            {
                sellRoyal.Enabled = false;
            }

            if (adoption.getFishList().Contains("cardinal fish"))
            {
                sellCardinal.Enabled = true;
            }
            else
            {
                sellCardinal.Enabled = false;
            }

            if (adoption.getFishList().Contains("blue dot jawfish"))
            {
                sellJawfish.Enabled = true;
            }
            else
            {
                sellJawfish.Enabled = false;
            }

            if (adoption.getFishList().Contains("seahorse"))
            {
                sellSeahorse.Enabled = true;
            }
            else
            {
                sellSeahorse.Enabled = false;
            }

            if (adoption.getFishList().Contains("possum wrasse"))
            {
                sellPossum.Enabled = true;
            }
            else
            {
                sellPossum.Enabled = false;
            }

            if (adoption.getFishList().Contains("lionfish"))
            {
                sellLionfish.Enabled = true;
            }
            else
            {
                sellLionfish.Enabled = false;
            }

            if (adoption.getFishList().Contains("mandarin dragonet"))
            {
                sellMandarin.Enabled = true;
            }
            else
            {
                sellMandarin.Enabled = false;
            }


        }

        //sell methods to remove target fish and earn coins
        private void sellClownfish_Click(object sender, EventArgs e)
        {
            adoptionFishList.Remove("clownfish");
            adoption.setFishList(adoptionFishList);
            adoptionCoins.setCoins("10");
        }

        private void sellGoby_Click(object sender, EventArgs e)
        {
            adoptionFishList.Remove("goby");
            adoption.setFishList(adoptionFishList);
            adoptionCoins.setCoins("10");
        }

        private void sellPuffer_Click(object sender, EventArgs e)
        {
            adoptionFishList.Remove("puffer fish");
            adoption.setFishList(adoptionFishList);
            adoptionCoins.setCoins("10");
        }

        private void sellButterfly_Click(object sender, EventArgs e)
        {
            adoptionFishList.Remove("butterfly fish");
            adoption.setFishList(adoptionFishList);
            adoptionCoins.setCoins("15");
        }

        private void sellBlue_Click(object sender, EventArgs e)
        {
            adoptionFishList.Remove("bluetang");
            adoption.setFishList(adoptionFishList);
            adoptionCoins.setCoins("15");
        }

        private void sellRoyal_Click(object sender, EventArgs e)
        {
            adoptionFishList.Remove("royal gramma");
            adoption.setFishList(adoptionFishList);
            adoptionCoins.setCoins("15");
        }

        private void sellCardinal_Click(object sender, EventArgs e)
        {
            adoptionFishList.Remove("cardinal fish");
            adoption.setFishList(adoptionFishList);
            adoptionCoins.setCoins("25");
        }
        private void sellJawfish_Click(object sender, EventArgs e)
        {
            adoptionFishList.Remove("blue dot jawfish");
            adoption.setFishList(adoptionFishList);
            adoptionCoins.setCoins("25");
        }

        private void sellSeahorse_Click(object sender, EventArgs e)
        {
            adoptionFishList.Remove("seahorse");
            adoption.setFishList(adoptionFishList);
            adoptionCoins.setCoins("35");
        }

        private void sellPossum_Click(object sender, EventArgs e)
        {
            adoptionFishList.Remove("possum wrasse");
            adoption.setFishList(adoptionFishList);
            adoptionCoins.setCoins("35");
        }

        private void sellLionfish_Click(object sender, EventArgs e)
        {
            adoptionFishList.Remove("lionfish");
            adoption.setFishList(adoptionFishList);
            adoptionCoins.setCoins("50");
        }

        private void sellMandarin_Click(object sender, EventArgs e)
        {
            adoptionFishList.Remove("mandarin dragonet");
            adoption.setFishList(adoptionFishList);
            adoptionCoins.setCoins("50");
        }
    }
}
