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

        }

        private void CollectionBookOpen_Click(object sender, EventArgs e)
        {
            CollectionBookForm CollectionBook = new CollectionBookForm();
            CollectionBook.ShowDialog();
        }

        private void GuessingGameStart_Click(object sender, EventArgs e)
        {
            GuessingGameForm GuessingGame = new GuessingGameForm();
            GuessingGame.ShowDialog();
        }

    }
}
