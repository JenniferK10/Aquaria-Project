using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquaria_Project
{
    internal class Fish
    {

        String name;
        public Fish(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        List<Fish> fishList = new List<Fish>();

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
