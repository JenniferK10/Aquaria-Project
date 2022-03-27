using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * ****************
 Jennifer Kalies
********************
 */

namespace Aquaria_Project
{
    public partial class CollectionBookForm : Form
    {
        public CollectionBookForm()
        {
            InitializeComponent();
        }

        int page = 1;

        private void CollectionBookForm_Load(object sender, EventArgs e)
        {

        }

        private void Name3_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(page < 5)
            page++;
            ChangeLabels();
        }

        private void ChangeLabels()
        {
            if(page == 1)
            {
                RarityLabel.Text = "Common";

                Name1.Text = "Clownfish";
                Size1.Text = "Size: 4 in";
                FunFact1.Text = "Fun Fact: All clownfishes are born male. As they mature, the dominant male in the group will become a female.";

                Name2.Text = "Goby fish";
                Size2.Text = "Size: 4 in";
                FunFact2.Text = "Fun Fact: Bottom-dwellers have a weak suction cup formed by the fusion of their pelvic fins used to shift sand.";

                Name3.Text = "Puffer Fish";
                Size3.Text = "Size: 1 in to 2 ft";
                FunFact3.Text = "Fun Fact: They are the most poisonous fish in the sea. They don’t have scales, and will inflate as a self defense mechanism.";

                
            }

            if (page == 2)
            {
                RarityLabel.Text = "Uncommon";

                Name1.Text = "Butterfly Fish";
                Size1.Text = "Size: 5-9 in";
                FunFact1.Text = "Fun Fact: They have thin, dish shaped bodies that closely resemble their equally recognizable cousins, the angelfish.";

                Name2.Text = "Blue Tang";
                Size2.Text = "Size: 10-12 in";
                FunFact2.Text = "Fun Fact: Blue tangs are capable of adjusting the intensity of their hue from light blue to deep purple.";

                Name3.Text = "Royal Gramma";
                Size3.Text = "Size: 3 in";
                FunFact3.Text = "Fun Fact: The royal gramma gets its name from its bright “royal purple” front part.";

                
            }

            if(page == 3)
            {
                RarityLabel.Text = "Rare";

                Name1.Text = "Cardinal Fish";
                Size1.Text = "Size: 2-8 in";
                FunFact1.Text = "Fun Fact: These fish hide among the spines of sea urchins for protection against predators.";

                Name2.Text = "Jawfish";
                Size2.Text = "Size: 4-5 in";
                FunFact2.Text = "Fun Fact: The Spanish name for jawfishes is bocas grandes, meaning big mouths.Jawfishes use their big mouths like scoops as they move sand and rocks while digging their burrows.";

                Name3.Text = " ";
                Size3.Text = " ";
                FunFact3.Text = " ";

                
            }

            if(page == 4)
            {
                RarityLabel.Text = "Epic";

                Name1.Text = "Seahorse";
                Size1.Text = "Size: 1-14 in";
                FunFact1.Text = "Fun Fact: Male seahorses will store eggs and give birth to the babies.";

                Name2.Text = "Possum Wrasse";
                Size2.Text = "Size: 2-2.6 in";
                FunFact2.Text = "Fun Fact: They are some of the smallest of the wrasses";

                Name3.Text = " ";
                Size3.Text = " ";
                FunFact3.Text = " ";

            }

            if(page == 5)
            {
                RarityLabel.Text = "Legendary";

                Name1.Text = "Lionfish";
                Size1.Text = "Size: 18 in";
                FunFact1.Text = "Fun Fact: The spines of this species can deliver a venomous sting. Lionfish are also nocturnal.";

                Name2.Text = "Mandarin Dragonet";
                Size2.Text = "Size: 3 in";
                FunFact2.Text = "Fun Fact: Mandarin fish are very picky eaters. They eat mainly small worms, protozoans, and small crustaceans";

                Name3.Text = " ";
                Size3.Text = " ";
                FunFact3.Text = " ";

               
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if(page > 1)
            page--;
            ChangeLabels();
        }

        private void CommonButton_Click(object sender, EventArgs e)
        {
            page = 1;
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
    }
}
