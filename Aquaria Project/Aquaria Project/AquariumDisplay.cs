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
    public partial class AquariumDisplay : Form
    {
        public AquariumDisplay()
        {
            InitializeComponent();
        }

        private void AquariumDisplay_Load(object sender, EventArgs e)
        {
            Image clownPic = Image.FromFile("clownfishjpg");
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
        }
    }
}
