/**************************************
 * Name: Aquaria
 * Purpose: A fish collecting game with aquarium display and multiple mini games
 * Author: Jennifer Kalies, Suhali Patel, Matthew Fisher, Florence Lourdes
 * Date: March 1, 2022
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
    public partial class Aquarium : Form
    {
        Coins c = new Coins();
        GuessingGame g = new GuessingGame();
        Fish f = new Fish("aquairum");
        public Aquarium()
        {
            InitializeComponent();
        }

        /*
        //Common
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
        */
        Image brownSand = Properties.Resources.sandBrown;
        Image orangeSand = Properties.Resources.sandOrange;
        Image redSand = Properties.Resources.sandRed;
        Image greenSand = Properties.Resources.sandGreen;

        Image clownPic = Image.FromFile("clownfish.jpg");
        Image gobyPic = Image.FromFile("goby.jpg");
        Image pufferPic = Image.FromFile("puffer.jpg");
        Image butterflyPic = Image.FromFile("butterfly.jpg");
        Image blueTangPic = Image.FromFile("bluetang.jpg");
        Image royalGrammaPic = Image.FromFile("royalgramma.jpg");
        Image cardinalPic = Image.FromFile("cardinal.jpg");
        Image jawfishPic = Image.FromFile("jawfish.jpg");
        Image seahorsePic = Image.FromFile("seahorse.jpg");
        Image possumWrassePic = Image.FromFile("possumwrasse.jpg");
        Image lionfishPic = Image.FromFile("lionfish.jpg");
        Image mandarinDragonetPic = Image.FromFile("mandarindragonet.jpg");

        //making array of fish pcitures to pass to collection form
        Image [] fishPictures = new Image []
            { Image.FromFile("clownfish.jpg"), Image.FromFile("goby.jpg"), Image.FromFile("puffer.jpg"),
            Image.FromFile("butterfly.jpg"), Image.FromFile("bluetang.jpg"), Image.FromFile("royalgramma.jpg"),
            Image.FromFile("cardinal.jpg"), Image.FromFile("jawfish.jpg"), Image.FromFile("seahorse.jpg"), Image.FromFile("possumwrasse.jpg"),
            Image.FromFile("lionfish.jpg"), Image.FromFile("mandarindragonet.jpg")};
        //SP
        Image clown = Image.FromFile("clown.gif");
        Image gobyfish = Properties.Resources.goby1;
        Image pufferfish = Image.FromFile("cropC.png");
        Image butterflyfish = Properties.Resources.butterfly;
        Image bluetang = Image.FromFile("bluetangC.png");
        Image royalgramma = Properties.Resources.royalgamma;
        Image cardinalfish = Image.FromFile("cardinal.png");
        Image bluedotjawfish = Properties.Resources.jawfish;
        Image seaHorse = Properties.Resources.seahorse;
        Image possumwarsse = Image.FromFile("possumwrasse.png");
        Image lionFish = Properties.Resources.lionfish;
        Image mandarindragon = Image.FromFile("mandarindragonet.png");
        void fish()// fish moving to the left
        {
            if(fish1.Left < 0)
            {
                fish1.Left = 1000;
            }
            if (fish2.Left < 0)
            {
                fish2.Left = 1000;
            }
            if (fish3.Left < 0)
            {
                fish3.Left = 1000;
            }
            if (fish4.Left < 0)
            {
                fish4.Left = 1000;
            }
            if (fish5.Left < 0)
            {
                fish5.Left = 1000;
            }
            if (fish5.Left < 0)
            {
                fish5.Left = 1000;
            }
            if (fish6.Left < 0)
            {
                fish6.Left = 1000;
            }
            if (fish7.Left < 0)
            {
                fish7.Left = 1000;
            }
            if (fish8.Left < 0)
            {
                fish8.Left = 1000;
            }
            if (fish9.Left < 0)
            {
                fish9.Left = 1000;
            }
            fish1.Left -= 10;
            fish2.Left -= 10;
            fish3.Left -= 10;
            fish4.Left -= 10;
        }
        void fishRight()// fisah moving to the right
        {
            int width = this.Width;
            //picturebox5
            if (fish5.Location.X > width - fish5.Width)
            {
                fish5.Location = new Point(1, fish5.Location.Y);
            }
            else
            {
                fish5.Location = new Point(fish5.Location.X + 100, fish5.Location.Y);
            }
            //picturebox6
            if (fish6.Location.X > width - fish6.Width)
            {
                fish6.Location = new Point(1, fish6.Location.Y);
            }
            else
            {
                fish6.Location = new Point(fish6.Location.X + 100, fish6.Location.Y);
            }
            //picturebox7
            if (fish7.Location.X > width - fish7.Width)
            {
                fish7.Location = new Point(1, fish7.Location.Y);
            }
            else
            {
                fish7.Location = new Point(fish7.Location.X + 100, fish7.Location.Y);
            }
            //picturebox8
            if (fish8.Location.X > width - fish8.Width)
            {
                fish8.Location = new Point(1, fish8.Location.Y);
            }
            else
            {
                fish8.Location = new Point(fish8.Location.X + 100, fish8.Location.Y);
            }
            //picturebox9
            if(fish9.Location.X > width - fish9.Width)
            {
                fish9.Location = new Point(1, fish9.Location.Y);
            }
            else
            {
                fish9.Location = new Point(fish9.Location.X + 100, fish9.Location.Y);
            }
        }
        //SP
        /*
        public Image getImage(String fish)
        {
            if(fish.Equals("clownfish"))
            {
                return clownPic;
            }
            else if (fish.Equals("goby"))
            {
                return gobyPic;
            }
            else if (fish.Equals("puffer"))
            {
                return pufferPic;
            }
            else if (fish.Equals("butterfly"))
            {
                return butterflyPic;
            }
            else if (fish.Equals("bluetang"))
            {
                return blueTangPic;
            }
            else if (fish.Equals("royalgramma"))
            {
                return royalGrammaPic;
            }
            else if (fish.Equals("cardinal"))
            {
                return cardinalPic;
            }
            else if (fish.Equals("jawfish"))
            {
                return jawfishPic;
            }
            else if (fish.Equals("seahorse"))
            {
                return seahorsePic;
            }
            else if (fish.Equals("possumwrasse"))
            {
                return possumWrassePic;
            }
            else if (fish.Equals("lionfish"))
            {
                return lionfishPic;
            }
            else
            {
                return mandarinDragonetPic;
            }           
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            FishStore fishStore = new FishStore();//opening fish store form
            fishStore.ShowDialog();
        }

        private void CollectionBookOpen_Click(object sender, EventArgs e)
        {
            CollectionBookForm CollectionBook = new CollectionBookForm(fishPictures);//showing collection box form and sending array of pictures
            CollectionBook.ShowDialog();
        }

        private void GuessingGameStart_Click(object sender, EventArgs e)
        {
            GuessingGameForm GuessingGame = new GuessingGameForm();//opening guessing game form
            GuessingGame.ShowDialog();
        }

        private void TriviaGameStart_Click(object sender, EventArgs e)
        {
            TriviaGame TriviaGame = new TriviaGame();//opening trivia game form
            TriviaGame.ShowDialog();
        }

        private void HuntingGameStart_Click(object sender, EventArgs e)
        {
            huntingGameForm huntingGameForm = new huntingGameForm();
            huntingGameForm.ShowDialog();
        }
        private void AdoptButton_Click(object sender, EventArgs e)
        {
            Adoption adoption = new Adoption();//opening adoption form
            adoption.ShowDialog();
        }
        private void Aquarium_Load(object sender, EventArgs e)
        {
            location1.AllowDrop = true;//allows for drag and drop
            location2.AllowDrop = true;
            location3.AllowDrop = true;
            location4.AllowDrop = true;
        }


        private void timer_Tick(object sender, EventArgs e)//JK
        {
            coinLabel.Text = c.getCoins().ToString();//updates money label

            if (c.getCoins() < 20) //decides if user has enough money to unlock decoration, user does not
                Unlock1.Enabled = false;
            else
            {
                if (Unlock1.Text != "Unlocked")
                    Unlock1.Enabled = true;
            }
            if (c.getCoins() < 40) { 
                Unlock2.Enabled = false;
                Unlock5.Enabled = false;
            }
            else
            {
                if (Unlock2.Text != "Unlocked")
                    Unlock2.Enabled = true;
                if(Unlock5.Text != "Unlocked")
                    Unlock5.Enabled = true;
            }
            if (c.getCoins() < 60)
                Unlock3.Enabled = false;
            else
            {
                if (Unlock3.Text != "Unlocked")
                    Unlock3.Enabled = true;
            }
            if (c.getCoins() < 100)
                Unlock4.Enabled = false;
            else
            {
                if (Unlock4.Text != "Unlocked")
                    Unlock4.Enabled = true;
            }
            if (c.getCoins() < 50)
            {
                Unlock6.Enabled = false;
                Unlock7.Enabled = false;
                Unlock8.Enabled = false;
            }
            else
            {
                if (Unlock6.Text != "Unlocked")
                    Unlock6.Enabled = true;
                if(Unlock7.Text != "Unlocked")
                    Unlock7.Enabled = true;
                if(Unlock8.Text != "Unlocked")
                    Unlock8.Enabled = true;
            }




            //SP
            if (f.getFishList().Count >= 1)
                {
                    if (f.getFishList()[0] == ("clownfish"))
                    {
                        fish1.Image = clown;
                        fish1.Visible = true;
                    }
                    if (f.getFishList()[0] == ("goby"))
                    {
                        fish1.Image = gobyfish;
                        fish1.Visible = true;
                    }
                    if (f.getFishList()[0] == ("puffer fish"))
                    {
                        fish1.Image = pufferfish;
                        fish1.Visible = true;
                    }
                    if (f.getFishList()[0] == ("butterfly fish"))
                    {
                        fish1.Image = butterflyfish;
                        fish1.Visible = true;
                    }
                    if (f.getFishList()[0] == ("bluetang"))
                    {
                        fish1.Image = bluetang;
                        fish1.Visible = true;
                    }
                    if (f.getFishList()[0] == ("royal gramma"))
                    {
                        fish1.Image = royalgramma;
                        fish1.Visible = true;
                    }
                    if (f.getFishList()[0] == ("cardinal fish"))
                    {
                        fish1.Image = cardinalfish;
                        fish1.Visible = true;
                    }
                    if (f.getFishList()[0] == ("blue dot jawfish"))
                    {
                        fish1.Image = bluedotjawfish;
                        fish1.Visible = true;
                    }
                    if (f.getFishList()[0] == ("seahorse"))
                    {
                        fish1.Image = seaHorse;
                        fish1.Visible = true;
                    }
                    if (f.getFishList()[0] == ("possum wrasse"))
                    {
                        fish1.Image = possumwarsse;
                        fish1.Visible = true;
                    }
                    if (f.getFishList()[0] == ("lionfish"))
                    {
                        fish1.Image = lionFish;
                        fish1.Visible = true;
                    }
                    if (f.getFishList()[0] == ("mandarin dragonet"))
                    {
                        fish1.Image = mandarindragon;
                        fish1.Visible = true;
                    }
                }
            else
            {
                fish1.Image = null;
                fish1.Visible = false;
                
            }
            
            if (f.getFishList().Count >= 2)
            {
                if (f.getFishList()[1] == ("clownfish"))
                {
                    fish2.Image = clown;
                    fish2.Visible = true;
                }
                if (f.getFishList()[1] == ("goby"))
                {
                    fish2.Image = gobyfish;
                    fish2.Visible = true;
                }
                if (f.getFishList()[1] == ("puffer fish"))
                {
                    fish2.Image = pufferfish;
                    fish2.Visible = true;
                }
                if (f.getFishList()[1] == ("butterfly fish"))
                {
                    fish2.Image = butterflyfish;
                    fish2.Visible = true;
                }
                if (f.getFishList()[1] == ("bluetang"))
                {
                    fish2.Image = bluetang;
                    fish2.Visible = true;
                }
                if (f.getFishList()[1] == ("royal gramma"))
                {
                    fish2.Image = royalgramma;
                    fish2.Visible = true;
                }
                if (f.getFishList()[1] == ("cardinal fish"))
                {
                    fish2.Image = cardinalfish;
                    fish2.Visible = true;
                }
                if (f.getFishList()[1] == ("blue dot jawfish"))
                {
                    fish2.Image = bluedotjawfish;
                    fish2.Visible = true;
                }
                if (f.getFishList()[1] == ("seahorse"))
                {
                    fish2.Image = seaHorse;
                    fish2.Visible = true;
                }
                if (f.getFishList()[1] == ("possum wrasse"))
                {
                    fish2.Image = possumwarsse;
                    fish2.Visible = true;
                }
                if (f.getFishList()[1] == ("lionfish"))
                {
                    fish2.Image = lionFish;
                    fish2.Visible = true;
                }
                if (f.getFishList()[1] == ("mandarin dragonet"))
                {
                    fish2.Image = mandarindragon;
                    fish2.Visible = true;
                }
            }
            else
            {
                fish2.Image = null;
                fish2.Visible = false;
                
            }

            if (f.getFishList().Count >= 3)
            {
                if (f.getFishList()[2] == ("clownfish"))
                {
                    fish3.Image = clown;
                    fish3.Visible = true;
                }
                if (f.getFishList()[2] == ("goby"))
                {
                    fish3.Image = gobyfish;
                    fish3.Visible = true;
                }
                if (f.getFishList()[2] == ("puffer fish"))
                {
                    fish3.Image = pufferfish;
                    fish3.Visible = true;
                }
                if (f.getFishList()[2] == ("butterfly fish"))
                {
                    fish3.Image = butterflyfish;
                    fish3.Visible = true;
                }
                if (f.getFishList()[2] == ("bluetang"))
                {
                    fish3.Image = bluetang;
                    fish3.Visible = true;
                }
                if (f.getFishList()[2] == ("royal gramma"))
                {
                    fish3.Image = royalgramma;
                    fish3.Visible = true;
                }
                if (f.getFishList()[2] == ("cardinal fish"))
                {
                    fish3.Image = cardinalfish;
                    fish3.Visible = true;
                }
                if (f.getFishList()[2] == ("blue dot jawfish"))
                {
                    fish3.Image = bluedotjawfish;
                    fish3.Visible = true;
                }
                if (f.getFishList()[2] == ("seahorse"))
                {
                    fish3.Image = seaHorse;
                    fish3.Visible = true;
                }
                if (f.getFishList()[2] == ("possum wrasse"))
                {
                    fish3.Image = possumwarsse;
                    fish3.Visible = true;
                }
                if (f.getFishList()[2] == ("lionfish"))
                {
                    fish3.Image = lionFish;
                    fish3.Visible = true;
                }
                if (f.getFishList()[2] == ("mandarin dragonet"))
                {
                    fish3.Image = mandarindragon;
                    fish3.Visible = true;
                }
            }
            else
            {
                fish3.Image = null;
                fish3.Visible = false;
                
            }
            if (f.getFishList().Count >= 4)
            {
                if (f.getFishList()[3] == ("clownfish"))
                {
                    fish4.Image = clown;
                    fish4.Visible = true;
                }
                if (f.getFishList()[3] == ("goby"))
                {
                    fish4.Image = gobyfish;
                    fish4.Visible = true;
                }
                if (f.getFishList()[3] == ("puffer fish"))
                {
                    fish4.Image = pufferfish;
                    fish4.Visible = true;
                }
                if (f.getFishList()[3] == ("butterfly fish"))
                {
                    fish4.Image = butterflyfish;
                    fish4.Visible = true;
                }
                if (f.getFishList()[3] == ("bluetang"))
                {
                    fish4.Image = bluetang;
                    fish4.Visible = true;
                }
                if (f.getFishList()[3] == ("royal gramma"))
                {
                    fish4.Image = royalgramma;
                    fish4.Visible = true;
                }
                if (f.getFishList()[3] == ("cardinal fish"))
                {
                    fish4.Image = cardinalfish;
                    fish4.Visible = true;
                }
                if (f.getFishList()[3] == ("blue dot jawfish"))
                {
                    fish4.Image = bluedotjawfish;
                    fish4.Visible = true;
                }
                if (f.getFishList()[3] == ("seahorse"))
                {
                    fish4.Image = seaHorse;
                    fish4.Visible = true;
                }
                if (f.getFishList()[3] == ("possum wrasse"))
                {
                    fish4.Image = possumwarsse;
                    fish4.Visible = true;
                }
                if (f.getFishList()[3] == ("lionfish"))
                {
                    fish4.Image = lionFish;
                    fish4.Visible = true;
                }
                if (f.getFishList()[3] == ("mandarin dragonet"))
                {
                    fish4.Image = mandarindragon;
                    fish4.Visible = true;
                }
            }
            else
            {
                fish4.Image = null;
                fish4.Visible = false;
               
            }
            if (f.getFishList().Count >= 5)
            {
                if (f.getFishList()[4] == ("clownfish"))
                {
                    fish5.Image = clown;
                    fish5.Visible = true;
                }
                if (f.getFishList()[4] == ("goby"))
                {
                    fish5.Image = gobyfish;
                    fish5.Visible = true;
                }
                if (f.getFishList()[4] == ("puffer fish"))
                {
                    fish5.Image = pufferfish;
                    fish5.Visible = true;
                }
                if (f.getFishList()[4] == ("butterfly fish"))
                {
                    fish5.Image = butterflyfish;
                    fish5.Visible = true;
                }
                if (f.getFishList()[4] == ("bluetang"))
                {
                    fish5.Image = bluetang;
                    fish5.Visible = true;
                }
                if (f.getFishList()[4] == ("royal gramma"))
                {
                    fish5.Image = royalgramma;
                    fish5.Visible = true;
                }
                if (f.getFishList()[4] == ("cardinal fish"))
                {
                    fish5.Image = cardinalfish;
                    fish5.Visible = true;
                }
                if (f.getFishList()[4] == ("blue dot jawfish"))
                {
                    fish5.Image = bluedotjawfish;
                    fish5.Visible = true;
                }
                if (f.getFishList()[4] == ("seahorse"))
                {
                    fish5.Image = seaHorse;
                    fish5.Visible = true;
                }
                if (f.getFishList()[4] == ("possum wrasse"))
                {
                    fish5.Image = possumwarsse;
                    fish5.Visible = true;
                }
                if (f.getFishList()[4] == ("lionfish"))
                {
                    fish5.Image = lionFish;
                    fish5.Visible = true;
                }
                if (f.getFishList()[4] == ("mandarin dragonet"))
                {
                    fish5.Image = mandarindragon;
                    fish5.Visible = true;
                }
            }
            else
            {
                fish5.Image = null;
                fish5.Visible = false;
                
            }
            if (f.getFishList().Count >= 6)
            {
                if (f.getFishList()[5] == ("clownfish"))
                {
                    fish6.Image = clown;
                    fish6.Visible = true;
                }
                if (f.getFishList()[5] == ("goby"))
                {
                    fish6.Image = gobyfish;
                    fish6.Visible = true;
                }
                if (f.getFishList()[5] == ("puffer fish"))
                {
                    fish6.Image = pufferfish;
                    fish6.Visible = true;
                }
                if (f.getFishList()[5] == ("butterfly fish"))
                {
                    fish6.Image = butterflyfish;
                    fish6.Visible = true;
                }
                if (f.getFishList()[5] == ("bluetang"))
                {
                    fish6.Image = bluetang;
                    fish6.Visible = true;
                }
                if (f.getFishList()[5] == ("royal gramma"))
                {
                    fish6.Image = royalgramma;
                    fish6.Visible = true;
                }
                if (f.getFishList()[5] == ("cardinal fish"))
                {
                    fish6.Image = cardinalfish;
                    fish6.Visible = true;
                }
                if (f.getFishList()[5] == ("blue dot jawfish"))
                {
                    fish6.Image = bluedotjawfish;
                    fish6.Visible = true;
                }
                if (f.getFishList()[5] == ("seahorse"))
                {
                    fish6.Image = seaHorse;
                    fish6.Visible = true;
                }
                if (f.getFishList()[5] == ("possum wrasse"))
                {
                    fish6.Image = possumwarsse;
                    fish6.Visible = true;
                }
                if (f.getFishList()[5] == ("lionfish"))
                {
                    fish6.Image = lionFish;
                    fish6.Visible = true;
                }
                if (f.getFishList()[5] == ("mandarin dragonet"))
                {
                    fish6.Image = mandarindragon;
                    fish6.Visible = true;
                }
            }
            else
            {
                fish6.Image = null;
                fish6.Visible = false;
                
            }

            if (f.getFishList().Count >= 7)
            {
                if (f.getFishList()[6] == ("clownfish"))
                {
                    fish7.Image = clown;
                    fish7.Visible = true;
                }
                if (f.getFishList()[6] == ("goby"))
                {
                    fish7.Image = gobyfish;
                    fish7.Visible = true;
                }
                if (f.getFishList()[6] == ("puffer fish"))
                {
                    fish7.Image = pufferfish;
                    fish7.Visible = true;
                }
                if (f.getFishList()[6] == ("butterfly fish"))
                {
                    fish7.Image = butterflyfish;
                    fish7.Visible = true;
                }
                if (f.getFishList()[6] == ("bluetang"))
                {
                    fish7.Image = bluetang;
                    fish7.Visible = true;
                }
                if (f.getFishList()[6] == ("royal gramma"))
                {
                    fish7.Image = royalgramma;
                    fish7.Visible = true;
                }
                if (f.getFishList()[6] == ("cardinal fish"))
                {
                    fish7.Image = cardinalfish;
                    fish7.Visible = true;
                }
                if (f.getFishList()[6] == ("blue dot jawfish"))
                {
                    fish7.Image = bluedotjawfish;
                    fish7.Visible = true;
                }
                if (f.getFishList()[6] == ("seahorse"))
                {
                    fish7.Image = seaHorse;
                    fish7.Visible = true;
                }
                if (f.getFishList()[6] == ("possum wrasse"))
                {
                    fish7.Image = possumwarsse;
                    fish7.Visible = true;
                }
                if (f.getFishList()[6] == ("lionfish"))
                {
                    fish7.Image = lionFish;
                    fish7.Visible = true;
                }
                if (f.getFishList()[6] == ("mandarin dragonet"))
                {
                    fish7.Image = mandarindragon;
                    fish7.Visible = true;
                }
            }
            else
            {
                fish7.Image = null;
                fish7.Visible = false;
                
            }
            if (f.getFishList().Count >= 8)
            {
                if (f.getFishList()[7] == ("clownfish"))
                {
                    fish8.Image = clown;
                    fish8.Visible = true;
                }
                if (f.getFishList()[7] == ("goby"))
                {
                    fish8.Image = gobyfish;
                    fish8.Visible = true;
                }
                if (f.getFishList()[7] == ("puffer fish"))
                {
                    fish8.Image = pufferfish;
                    fish8.Visible = true;
                }
                if (f.getFishList()[7] == ("butterfly fish"))
                {
                    fish8.Image = butterflyfish;
                    fish8.Visible = true;
                }
                if (f.getFishList()[7] == ("bluetang"))
                {
                    fish8.Image = bluetang;
                    fish8.Visible = true;
                }
                if (f.getFishList()[7] == ("royal gramma"))
                {
                    fish8.Image = royalgramma;
                    fish8.Visible = true;
                }
                if (f.getFishList()[7] == ("cardinal fish"))
                {
                    fish8.Image = cardinalfish;
                    fish8.Visible = true;
                }
                if (f.getFishList()[7] == ("blue dot jawfish"))
                {
                    fish8.Image = bluedotjawfish;
                    fish8.Visible = true;
                }
                if (f.getFishList()[7] == ("seahorse"))
                {
                    fish8.Image = seaHorse;
                    fish8.Visible = true;
                }
                if (f.getFishList()[7] == ("possum wrasse"))
                {
                    fish8.Image = possumwarsse;
                    fish8.Visible = true;
                }
                if (f.getFishList()[7] == ("lionfish"))
                {
                    fish8.Image = lionFish;
                    fish8.Visible = true;
                }
                if (f.getFishList()[7] == ("mandarin dragonet"))
                { 
                    fish8.Image = mandarindragon;
                    fish8.Visible = true;
                }
            }
            else
            {
                fish8.Image = null;
                fish8.Visible = false;
                
            }
            if (f.getFishList().Count >= 9)
            {
                if (f.getFishList()[8] == ("clownfish"))
                {
                    fish9.Image = clown;
                    fish9.Visible = true;
                }
                if (f.getFishList()[8] == ("goby"))
                {
                    fish9.Image = gobyfish;
                    fish9.Visible = true;
                }
                if (f.getFishList()[8] == ("puffer fish"))
                {
                    fish9.Image = pufferfish;
                    fish9.Visible = true;
                }
                if (f.getFishList()[8] == ("butterfly fish"))
                {
                    fish9.Image = butterflyfish;
                    fish9.Visible = true;
                }
                if (f.getFishList()[8] == ("bluetang"))
                {
                    fish9.Image = bluetang;
                    fish9.Visible = true;
                }
                if (f.getFishList()[8] == ("royal gramma"))
                {
                    fish9.Image = royalgramma;
                    fish9.Visible = true;
                }
                if (f.getFishList()[8] == ("cardinal fish"))
                {
                    fish9.Image = cardinalfish;
                    fish9.Visible = true;
                }
                if (f.getFishList()[8] == ("blue dot jawfish"))
                {
                    fish9.Image = bluedotjawfish;
                    fish9.Visible = true;
                }
                if (f.getFishList()[8] == ("seahorse"))
                {
                    fish9.Image = seaHorse;
                    fish9.Visible = true;
                }
                if (f.getFishList()[8] == ("possum wrasse"))
                {
                    fish9.Image = possumwarsse;
                    fish9.Visible = true;
                }
                if (f.getFishList()[8] == ("lionfish"))
                {
                    fish9.Image = lionFish;
                    fish9.Visible = true;
                }
                if (f.getFishList()[8] == ("mandarin dragonet"))
                {
                    fish9.Image = mandarindragon;
                    fish9.Visible = true;
                }
            }
            else
            {
                fish9.Image = null;
                fish9.Visible = false;
            }

            /*for (int i = 0; i < f.getFishList().Count; i++)
            {
                if (f.getFishList()[i] == ("clownfish"))
                {
                    fish2.Image = clown;
                    fish2.Visible = true;
                }
                if (f.getFishList()[i] == ("goby"))
                {
                    fish2.Image = gobyfish;
                    fish2.Visible = true;
                }
                if (f.getFishList()[i] == ("pufferfish"))
                {
                    fish2.Image = pufferfish;
                    fish2.Visible = true;
                }
                if (f.getFishList()[i] == ("butterfly fish"))
                {
                    fish3.Image = butterflyfish;
                    fish3.Visible = true;
                }
                if (f.getFishList()[i] == ("bluetang"))
                {
                    fish4.Image = bluetang;
                    fish4.Visible = true;
                }
                if (f.getFishList()[i] == ("royalgramma"))
                {
                    fish5.Image = royalgramma;
                    fish5.Visible = true;
                }
                if (f.getFishList()[i] == ("cardinal"))
                {
                    fish6.Image = cardinalfish;
                    fish6.Visible = true;
                }
                if (f.getFishList()[i] == ("jawfish"))
                {
                    fish7.Image = bluedotjawfish;
                    fish7.Visible = true;
                }
                if (f.getFishList()[i] == ("seahorse"))
                {
                    fish8.Image = seaHorse;
                    fish8.Visible = true;
                }
                if (f.getFishList()[i] == ("possumrasse"))
                {
                    fish9.Image = possumwarsse;
                    fish9.Visible = true;
                }
                if (f.getFishList()[i] == ("lionfish"))
                {
                    fish1.Image = lionFish;
                    fish1.Visible = true;
                }
                if (f.getFishList()[i] == ("mandarindrogan"))
                {
                    fish1.Image = mandarindragon;
                    fish1.Visible = true;
                }
            }*/
            //SP
        }

        private void FlappyFishStart_Click(object sender, EventArgs e)
        {
            FlappyFishForm FlappyFishForm = new FlappyFishForm();//opening Flappy Fish form
            FlappyFishForm.ShowDialog();
        }

        private void Unlock1_Click(object sender, EventArgs e)//JK
        {
            decoration1.Enabled = true;//enable decoration1 because user paid for it
            c.loseCoins(Unlock1.Text);//pay for decoration
            Unlock1.Text = "Unlocked";
            Unlock1.Enabled = false;
        }

        private void DecortationStore_Click(object sender, EventArgs e)//opens decoration store //JK
        {
            decorationPanel.Visible = true;
            
        }

        private void Unlock2_Click(object sender, EventArgs e) //JK
        {
            decoration2.Enabled = true;
            c.loseCoins(Unlock2.Text);
            Unlock2.Text = "Unlocked";
            Unlock2.Enabled = false;
        }

        private void Unlock3_Click(object sender, EventArgs e)
        {
            decoration3.Enabled = true;
            c.loseCoins(Unlock3.Text);
            Unlock3.Text = "Unlocked";
            Unlock3.Enabled = false;
        }

        private void Unlock4_Click(object sender, EventArgs e)
        {
            decoration4.Enabled = true;
            c.loseCoins(Unlock4.Text);
            Unlock4.Text = "Unlocked";
            Unlock4.Enabled = false;
        }

        private void decoration5_Click(object sender, EventArgs e)
        {
            sandDecoration.Image = brownSand;
        }

        private void Unlock5_Click(object sender, EventArgs e)
        {
            decoration5.Enabled = true;
            c.loseCoins(Unlock5.Text);
            Unlock5.Text = "Unlocked";
            Unlock5.Enabled = false;
        }

        private void Unlock6_Click(object sender, EventArgs e)
        {
            decoration6.Enabled = true;
            c.loseCoins(Unlock6.Text);
            Unlock6.Text = "Unlocked";
            Unlock6.Enabled = false;
        }

        //JK
        private void location1_DragDrop(object sender, DragEventArgs e)//update the picture of target picturebox after darg and drop
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            location1.Image = getPicture;
            location1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void location1_DragEnter(object sender, DragEventArgs e)//allows fort drag drop effect //JK
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void decoration1_MouseDown(object sender, MouseEventArgs e)//copying pciture from source pciturebox //JK
        {
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void location2_DragDrop(object sender, DragEventArgs e)
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            location2.Image = getPicture;
            location2.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void location2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void decoration2_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void decoration3_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void decoration4_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void decoration5_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        

        private void decoration6_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void ExitDecoration_Click(object sender, EventArgs e)
        {
            decorationPanel.Visible = false;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {//MF
            TriviaGameStart.Visible = true; //game options drop down
            GuessingGameStart.Visible = true;
            FlappyFishStart.Visible = true;
            HuntingGameStart.Visible = true;
            rope1.Visible = true;
            rope2.Visible = true;
            CloseButton.Visible = true;
            PlayButton.Visible = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {//MF
            TriviaGameStart.Visible = false; //game options go away
            GuessingGameStart.Visible = false;
            FlappyFishStart.Visible = false;
            HuntingGameStart.Visible = false;
            rope1.Visible = false;
            rope2.Visible = false;
            CloseButton.Visible = false;
            PlayButton.Visible = true;
        }
        //SP
        private void timer1_Tick(object sender, EventArgs e)// timer for left moving fish
        {
            fish();
        }

        //SP
        private void timer2_Tick(object sender, EventArgs e)// timer for right moving fish
        {
            fishRight();
        }

        private void decoration4_Click(object sender, EventArgs e)
        {

        }

        private void Unlock7_Click(object sender, EventArgs e)
        {
            decoration7.Enabled = true;
            c.loseCoins(Unlock7.Text);
            Unlock7.Text = "Unlocked";
            Unlock7.Enabled = false;
        }

        private void Unlock8_Click(object sender, EventArgs e)
        {
            decoration8.Enabled = true;
            c.loseCoins(Unlock8.Text);
            Unlock8.Text = "Unlocked";
            Unlock8.Enabled = false;
        }

        private void decoration7_Click(object sender, EventArgs e)
        {
            sandDecoration.Image = redSand;
        }

        private void decoration8_Click(object sender, EventArgs e)
        {
            sandDecoration.Image = greenSand;
        }

        private void decoration6_Click(object sender, EventArgs e)
        {
            sandDecoration.Image = orangeSand;
        }

        private void location3_DragDrop(object sender, DragEventArgs e)
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            location3.Image = getPicture;
            location3.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void location3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void location4_DragDrop(object sender, DragEventArgs e)
        {
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            location4.Image = getPicture;
            location4.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void location4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        
    }
}
