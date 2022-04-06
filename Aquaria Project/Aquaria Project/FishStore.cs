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
        List<Fish> storeFishList = new List<Fish>();
        Fish store = new Fish("store");
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
            }
            else
            {
                buyCardinal.Enabled = true;
                buyJawfish.Enabled = true;
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
                storeFishList.Add(clownfish);
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
                storeFishList.Add(goby);
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
                storeFishList.Add(puffer);
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
                storeFishList.Add(butterfly);
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
                storeFishList.Add(blueTang);
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
                storeFishList.Add(royalGramma);
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
                storeFishList.Add(cardinal);
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
                storeFishList.Add(blueDotJawfish);
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
                storeFishList.Add(seahorse);
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
                storeFishList.Add(possumWrasse);
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
                storeFishList.Add(lionfish);
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
                storeFishList.Add(mandarinDragonet);
                store.setFishList(storeFishList);
                fishStoreCoin.loseCoins("100");
            }
            else
            {
                MessageBox.Show("Maximum fishes in the aquarium");
            }
        }

    }
}
