using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquaria_Project
{
    internal class FishList
    {
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


        List<Fish> fishList;
        public FishList()
        {
            fishList = new List<Fish>();
        }
        public void AddFish(Fish fishType)
        {
            fishList.Add(fishType);
        }

        public void RemoveFish(Fish fishType)
        {
            fishList.Remove(fishType);
        }
    }
}
