using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**************************************
 * Name: CollectionBookForm.cs
 * Purpose: Include all functionalities for collection book
 * Author: Jennifer Kalies
 * Note: checks if fish was obtained before it becomes visible
 *************************************/

namespace Aquaria_Project
{
    public partial class CollectionBookForm : Form
    {
        //JK begin
        public CollectionBookForm(Image []fishPictures)
        {
            InitializeComponent();
            SetFishPicture(fishPictures);
        }
        
        int page = 1;

        Fish f = new Fish();
        
        Image clownpic, gobyPic, pufferPic, butterflyPic, blueTangPic, royalGrammaPic, cardinalPic; //variable for each picture
        Image jawfishPic, seahorsePic, possumWrassePic, lionfishPic, mandarinDragonetPic;

        //creating instances of fish class to get data for the collection book
        Fish clownCollection = new Fish(1);
        Fish gobyCollection = new Fish(2);
        Fish pufferCollection = new Fish(3);
        Fish butterflyCollection = new Fish(4); 
        Fish blueTangCollection = new Fish(5);
        Fish royalGrammaCollection = new Fish(6);
        Fish cardinalCollection = new Fish(7);
        Fish jawfishCollection = new Fish(8);
        Fish seahorseCollection = new Fish(9);
        Fish possumWrasseCollection = new Fish(10);
        Fish lionfishCollection = new Fish(11);
        Fish mandarinCollection = new Fish(12);
        
        //takes pictures from array and sets them to pictures for collection book
        public void SetFishPicture(Image[]fishPictures)
        {
            clownpic = fishPictures[0];
            gobyPic = fishPictures[1];
            pufferPic = fishPictures[2];
            butterflyPic = fishPictures[3];
            blueTangPic = fishPictures[4];
            royalGrammaPic = fishPictures[5];
            cardinalPic = fishPictures[6];
            jawfishPic = fishPictures[7];
            seahorsePic = fishPictures[8];
            possumWrassePic = fishPictures[9];
            lionfishPic = fishPictures[10];
            mandarinDragonetPic = fishPictures[11];
        }

        

        private void fishPicture2_Click(object sender, EventArgs e)
        {

        }

        private void CollectionBookForm_Load(object sender, EventArgs e)
        {
            RarityLabel.Text = "Common";//changes label to show which rarity fish are

            if (f.getObtained("clownfish"))
            {
                fishPicture1.Image = clownpic; //chnages image in the picture box
                Name1.Text = clownCollection.getKind(); //chnages name/kind of the fish
                Size1.Text = clownCollection.getSize(); //changes size label
                FunFact1.Text = clownCollection.getFact();//displays appropriate fun fact
            }
            else
            {
                fishPicture1.Image = null;
                Name1.Text = " ";
                Size1.Text = " ";
                FunFact1.Text = " ";
            }

            if (f.getObtained("goby"))
            {
                fishPicture2.Image = gobyPic;
                Name2.Text = gobyCollection.getKind();
                Size2.Text = gobyCollection.getSize();
                FunFact2.Text = gobyCollection.getFact();
            }
            else
            {
                fishPicture2.Image = null;
                Name2.Text = " ";
                Size2.Text = " ";
                FunFact2.Text = " ";
            }

            if (f.getObtained("puffer fish"))
            {
                fishPicture3.Image = pufferPic;
                Name3.Text = pufferCollection.getKind();
                Size3.Text = pufferCollection.getSize();
                FunFact3.Text = pufferCollection.getFact();
            }
            else
            {
                fishPicture3.Image = null;
                Name3.Text = " ";
                Size3.Text = " ";
                FunFact3.Text = " ";
            }
        }

        private void Name3_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(page < 5)//error cehckin, user can not go beyond page 5
            page++;
            ChangeLabels();
        }

        private void ChangeLabels()//changes information on picture box to turn to next page
        {
            if(page == 1)
            {
                RarityLabel.Text = "Common";//changes label to show which rarity fish are

                if (f.getObtained("clownfish"))//checks if fish was obtained before displaying
                {
                    fishPicture1.Image = clownpic; //chnages image in the picture box
                    Name1.Text = clownCollection.getKind(); //chnages name/kind of the fish
                    Size1.Text = clownCollection.getSize(); //changes size label
                    FunFact1.Text = clownCollection.getFact();//displays appropriate fun fact
                }
                else
                {
                    fishPicture1.Image = null;
                    Name1.Text = " ";
                    Size1.Text = " ";
                    FunFact1.Text = " ";
                }

                if (f.getObtained("goby"))
                {
                    fishPicture2.Image = gobyPic;
                    Name2.Text = gobyCollection.getKind();
                    Size2.Text = gobyCollection.getSize();
                    FunFact2.Text = gobyCollection.getFact();
                }
                else
                {
                    fishPicture2.Image = null;
                    Name2.Text = " ";
                    Size2.Text = " ";
                    FunFact2.Text = " ";
                }

                if (f.getObtained("puffer fish"))
                {
                    fishPicture3.Image = pufferPic;
                    Name3.Text = pufferCollection.getKind();
                    Size3.Text = pufferCollection.getSize();
                    FunFact3.Text = pufferCollection.getFact();
                }
                else
                {
                    fishPicture3.Image = null;
                    Name3.Text = " ";
                    Size3.Text = " ";
                    FunFact3.Text = " ";
                }

                
            }

            if (page == 2)
            {
                RarityLabel.Text = "Uncommon";

                if (f.getObtained("butterfly fish"))
                {
                    fishPicture1.Image = butterflyPic;
                    Name1.Text = butterflyCollection.getKind();
                    Size1.Text = butterflyCollection.getSize();
                    FunFact1.Text = butterflyCollection.getFact();
                }
                else
                {
                    fishPicture1.Image = null;
                    Name1.Text = " ";
                    Size1.Text = " ";
                    FunFact1.Text = " ";
                }

                if (f.getObtained("bluetang"))
                {
                    fishPicture2.Image = blueTangPic;
                    Name2.Text = blueTangCollection.getKind();
                    Size2.Text = blueTangCollection.getSize();
                    FunFact2.Text = blueTangCollection.getFact();
                }
                else
                {
                    fishPicture2.Image = null;
                    Name2.Text = " ";
                    Size2.Text = " ";
                    FunFact2.Text = " ";
                }

                if (f.getObtained("royal gramma"))
                {
                    fishPicture3.Image = royalGrammaPic;
                    Name3.Text = royalGrammaCollection.getKind();
                    Size3.Text = royalGrammaCollection.getSize();
                    FunFact3.Text = royalGrammaCollection.getFact();
                }
                else
                {
                    fishPicture3.Image = null;
                    Name3.Text = " ";
                    Size3.Text = " ";
                    FunFact3.Text = " ";
                }

                
            }

            if(page == 3)
            {
                RarityLabel.Text = "Rare";

                if (f.getObtained("cardinal fish"))
                {
                    fishPicture1.Image = cardinalPic;
                    Name1.Text = cardinalCollection.getKind();
                    Size1.Text = cardinalCollection.getSize();
                    FunFact1.Text = cardinalCollection.getFact();
                }
                else
                {
                    fishPicture1.Image = null;
                    Name1.Text = " ";
                    Size1.Text = " ";
                    FunFact1.Text = " ";
                }

                if (f.getObtained("blue dot jawfish"))
                {
                    fishPicture2.Image = jawfishPic;
                    Name2.Text = jawfishCollection.getKind();
                    Size2.Text = jawfishCollection.getSize();
                    FunFact2.Text = jawfishCollection.getFact();
                }
                else
                {
                    fishPicture2.Image = null;
                    Name2.Text = " ";
                    Size2.Text = " ";
                    FunFact2.Text = " ";
                }

                fishPicture3.Image = null;
                Name3.Text = " ";
                Size3.Text = " ";
                FunFact3.Text = " ";

                
            }

            if(page == 4)
            {
                RarityLabel.Text = "Epic";

                if (f.getObtained("seahorse"))
                {
                    fishPicture1.Image = seahorsePic;
                    Name1.Text = seahorseCollection.getKind();
                    Size1.Text = seahorseCollection.getSize();
                    FunFact1.Text = seahorseCollection.getFact();
                }
                else
                {
                    fishPicture1.Image = null;
                    Name1.Text = " ";
                    Size1.Text = " ";
                    FunFact1.Text = " ";
                }

                if (f.getObtained("possum wrasse"))
                {
                    fishPicture2.Image = possumWrassePic;
                    Name2.Text = possumWrasseCollection.getKind();
                    Size2.Text = possumWrasseCollection.getSize();
                    FunFact2.Text = possumWrasseCollection.getFact();
                }
                else
                {
                    fishPicture2.Image = null;
                    Name2.Text = " ";
                    Size2.Text = " ";
                    FunFact2.Text = " ";
                }

                fishPicture3.Image = null;
                Name3.Text = " ";
                Size3.Text = " ";
                FunFact3.Text = " ";

            }

            if(page == 5)
            {
                RarityLabel.Text = "Legendary";

                if (f.getObtained("lionfish"))
                {
                    fishPicture1.Image = lionfishPic;
                    Name1.Text = lionfishCollection.getKind();
                    Size1.Text = lionfishCollection.getSize();
                    FunFact1.Text = lionfishCollection.getFact();
                }
                else
                {
                    fishPicture1.Image = null;
                    Name1.Text = " ";
                    Size1.Text = " ";
                    FunFact1.Text = " ";
                }

                if (f.getObtained("mandarin dragonet"))
                {
                    fishPicture2.Image = mandarinDragonetPic;
                    Name2.Text = mandarinCollection.getKind();
                    Size2.Text = mandarinCollection.getSize();
                    FunFact2.Text = mandarinCollection.getFact();
                }
                else
                {
                    fishPicture2.Image = null;
                    Name2.Text = " ";
                    Size2.Text = " ";
                    FunFact2.Text = " ";
                }


                fishPicture3.Image = null;
                Name3.Text = " ";
                Size3.Text = " ";
                FunFact3.Text = " ";

               
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if(page > 1)//error checking, user can not go before page 1
            page--;
            ChangeLabels();
        }

        private void CommonButton_Click(object sender, EventArgs e)
        {
            page = 1;//chnages labels based on page pciked by user
            ChangeLabels();
        }

        private void UncommonButton_Click(object sender, EventArgs e)
        {
            page = 2;
            ChangeLabels();
        }

        private void RareButton_Click(object sender, EventArgs e)
        {
            page = 3;
            ChangeLabels();
        }

        private void EpicButton_Click(object sender, EventArgs e)
        {
            page = 4;
            ChangeLabels();
        }

        private void LegendaryButton_Click(object sender, EventArgs e)
        {
            page = 5;
            ChangeLabels();
        }
        //JK end
    }
}
