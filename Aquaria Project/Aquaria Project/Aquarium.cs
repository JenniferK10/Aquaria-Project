﻿using System;
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

        //making array of fish pcitures to pass to collection form
        Image [] fishPictures = new Image []
            { Image.FromFile("clownfish.jpg"), Image.FromFile("goby.jpg"), Image.FromFile("puffer.jpg"),
            Image.FromFile("butterfly.jpg"), Image.FromFile("bluetang.jpg"), Image.FromFile("royalgramma.jpg"),
            Image.FromFile("cardinal.jpg"), Image.FromFile("jawfish.jpg"), Image.FromFile("seahorse.jpg"), Image.FromFile("possumwrasse.jpg"),
            Image.FromFile("lionfish.jpg"), Image.FromFile("mandarindragonet.jpg")};

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

        private void Aquarium_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            coinLabel.Text = c.getCoins().ToString();
        }

        private void FlappyFishStart_Click(object sender, EventArgs e)
        {
            FlappyFishForm FlappyFishForm = new FlappyFishForm();//opening Flappy Fish form
            FlappyFishForm.ShowDialog();
        }
    }
}
