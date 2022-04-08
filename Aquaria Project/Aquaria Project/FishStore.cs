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
    public partial class FishStore : Form
    {

        Coins fishStoreCoin = new Coins();
        List<string> storeFishList = new List<string>();
        Fish store = new Fish("store");
        Random rnd = new Random();
        int number = 0;
        int determineFish = 0;
        string type = "";

        //Common
        Fish clownfish = new Fish("clownfish");
        Fish goby = new Fish("goby");
        Fish puffer = new Fish("puffer fish");
        //Uncommon
        Fish butterfly = new Fish("butterfly fish");
        Fish blueTang = new Fish("blue tang");
        Fish royalGramma = new Fish("royal gramma");
        //Rare
        Fish cardinal = new Fish("cardinal fish");
        Fish blueDotJawfish = new Fish("blue dot jawfish");
        //Epic
        Fish seahorse = new Fish("seahorse");
        Fish possumWrasse = new Fish("possum wrasse");
        //Legendary
        Fish lionfish = new Fish("lionfish");
        Fish mandarinDragonet = new Fish("mandarin dragonet");
        public FishStore()
        {
            InitializeComponent();
        }

        private void FishStore_Load(object sender, EventArgs e)
        {
            storeFishList = store.getFishList();
        }

        public string getMysteryFish()
        {
            string fish = "";
            number = rnd.Next(1, 100);
            if(number <= 30)
            {
                type = "common";
            }
            else if(number > 30 & number <= 55)
            {
                type = "uncommon";
            }
            else if (number > 55 & number <= 75)
            {
                type = "rare";
            }
            else if (number > 75 & number <= 90)
            {
                type = "epic";
            }
            else
            {
                type = "legendary";
            }

            determineFish = rnd.Next(1, 30);
            if (type.Equals("common"))
            {
                if(determineFish <= 10)
                {
                    fish = clownfish.getName();
                }
                else if (determineFish > 10 & determineFish <= 20)
                {
                    fish = goby.getName();
                }
                else
                {
                    fish = puffer.getName();
                }
            }
            else if (type.Equals("uncommon"))
            {
                if (determineFish <= 10)
                {
                    fish = butterfly.getName();
                }
                else if (determineFish > 10 & determineFish <= 20)
                {
                    fish = blueTang.getName();
                }
                else
                {
                    fish = royalGramma.getName();
                }
            }
            else if (type.Equals("rare"))
            {
                if (determineFish <= 15)
                {
                    fish = cardinal.getName();
                }
                else
                {
                    fish = blueDotJawfish.getName();
                }               
            }
            else if (type.Equals("epic"))
            {
                if (determineFish <= 15)
                {
                    fish = seahorse.getName();
                }
                else
                {
                    fish = possumWrasse.getName();
                }
            }
            else if (type.Equals("legendary"))
            {
                if (determineFish <= 15)
                {
                    fish = lionfish.getName();
                }
                else
                {
                    fish = mandarinDragonet.getName();
                }
            }
            return fish;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (fishStoreCoin.getCoins() < 20)
            {
                buyClownfish.Enabled = false;
                buyGoby.Enabled = false;
                buyPuffer.Enabled = false;
            }
            else
            {
                buyClownfish.Enabled = true;
                buyGoby.Enabled = true;
                buyPuffer.Enabled = true;
            }

            if (fishStoreCoin.getCoins() < 30)
            {
                buyButterfly.Enabled = false;
                buyBlue.Enabled = false;
                buyRoyal.Enabled = false;
            }
            else
            {
                buyButterfly.Enabled = true;
                buyBlue.Enabled = true;
                buyRoyal.Enabled = true;
            }

            if (fishStoreCoin.getCoins() < 50)
            {
                buyCardinal.Enabled = false;
                buyJawfish.Enabled = false;
                buyMystery.Enabled = false;
            }
            else
            {
                buyCardinal.Enabled = true;
                buyJawfish.Enabled = true;
                buyMystery.Enabled = true;
            }

            if (fishStoreCoin.getCoins() < 70)
            {
                buySeahorse.Enabled = false;
                buyPossum.Enabled = false;
            }
            else
            {
                buySeahorse.Enabled = true;
                buyPossum.Enabled = true;
            }

            if (fishStoreCoin.getCoins() < 100)
            {
                buyLionfish.Enabled = false;
                buyMandarin.Enabled = false;
            }
            else
            {
                buyLionfish.Enabled = true;
                buyMandarin.Enabled = true;
            }
        }

        private void buyClownfish_Click(object sender, EventArgs e)
        {
            if (storeFishList.Count < 9)
            {
                storeFishList.Add(clownfish.getName());
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("20");
    }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }

        private void buyGoby_Click(object sender, EventArgs e)
        {
            if (storeFishList.Count < 9)
            {
                storeFishList.Add(goby.getName());
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("20");
            }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }

        private void buyPuffer_Click(object sender, EventArgs e)
        {
            if (storeFishList.Count < 9)
            {
                storeFishList.Add(puffer.getName());
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("20");
            }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }

        private void buyButterfly_Click(object sender, EventArgs e)
        {
            if (storeFishList.Count < 9)
            {
                storeFishList.Add(butterfly.getName());
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("30");
            }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }

        private void buyBlue_Click(object sender, EventArgs e)
        {
            if (storeFishList.Count < 9)
            {
                storeFishList.Add(blueTang.getName());
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("30");
            }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }

        private void buyRoyal_Click(object sender, EventArgs e)
        {
            if (storeFishList.Count < 9)
            {
                storeFishList.Add(royalGramma.getName());
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("30");
            }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }

        private void buyCardinal_Click(object sender, EventArgs e)
        {
            if (storeFishList.Count < 9)
            {
                storeFishList.Add(cardinal.getName());
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("50");
            }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }

        private void buyJawfish_Click(object sender, EventArgs e)
        {
            if (storeFishList.Count < 9)
            {
                storeFishList.Add(blueDotJawfish.getName());
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("50");
            }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }

        private void buySeahorse_Click(object sender, EventArgs e)
        {
            if (storeFishList.Count < 9)
            {
                storeFishList.Add(seahorse.getName());
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("70");
            }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }

        private void buyPossum_Click(object sender, EventArgs e)
        {
            if (storeFishList.Count < 9)
            {
                storeFishList.Add(possumWrasse.getName());
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("70");
            }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }

        private void buyLionfish_Click(object sender, EventArgs e)
        {
            if (storeFishList.Count < 9)
            {
                storeFishList.Add(lionfish.getName());
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("100");
            }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }

        private void buyMandarin_Click(object sender, EventArgs e)
        {
            if (storeFishList.Count < 9)
            {
                storeFishList.Add(mandarinDragonet.getName());
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("100");
            }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }

        private void buyMystery_Click(object sender, EventArgs e)
        {
            if (storeFishList.Count < 9)
            {
                string mysteryFish = getMysteryFish();
                storeFishList.Add(mysteryFish);
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("50");
                MessageBox.Show("You got a " + mysteryFish);
            }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }
    }
}
