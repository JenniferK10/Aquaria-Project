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
            location1.AllowDrop = true;//allows for drag and drop
            location2.AllowDrop = true;
        }

        
        private void timer_Tick(object sender, EventArgs e)//JK
        {
            coinLabel.Text = c.getCoins().ToString();//updates money label

            if(c.getCoins() < 100) //decides if user has enough money to unlock decoration, user does not
                Unlock1.Enabled = false;
            if(c.getCoins() < 150)
                Unlock2.Enabled = false;

            if (c.getCoins() >= 100)//user has enough money to unlock decoration
            {
                if(Unlock1.Text != "Unlocked")
                 Unlock1.Enabled = true;
            }
            if(c.getCoins() >= 150)
            {
                if (Unlock2.Text != "Unlocked")
                 Unlock2.Enabled = true;
            }
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
            Unlock3.Text = "Unlocked";
        }

        private void Unlock4_Click(object sender, EventArgs e)
        {
            decoration4.Enabled = true;
            Unlock4.Text = "Unlocked";
        }

        private void decoration5_Click(object sender, EventArgs e)
        {

        }

        private void Unlock5_Click(object sender, EventArgs e)
        {
            decoration5.Enabled = true;
            Unlock5.Text = "Unlocked";
        }

        private void Unlock6_Click(object sender, EventArgs e)
        {
            decoration6.Enabled = true;
            Unlock6.Text = "Unlocked";
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
            ((PictureBox)sender).DoDragDrop(((PictureBox)sender).Image, DragDropEffects.Copy);
        }

        private void decoration6_Click(object sender, EventArgs e)
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
    }
}
