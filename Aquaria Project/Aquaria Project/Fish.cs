/**************************************
 * Name: Fish.cs
 * Purpose: To contain information for each fish
 * Author: Jennifer Kalies and Florence Lourdes
 * Note: Holds a continuously updated fish array list
 *************************************/

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
        string kind;//keeps track of kind
        string size;//keeps track of size
        string fact;//keeps track of fun fact

        //booleans to dtermine if a fish kind was obtained yet
        static bool clownOptained = false;
        static bool gobyOptained = false;
        static bool pufferObtained = false;
        static bool butterflyObtained = false;
        static bool blueTangObtained = false;
        static bool royalGrammaObtained = false;
        static bool cardinalObtained = false;
        static bool jawfishObtained = false;
        static bool seahorseObtained = false;
        static bool possumObtained = false;
        static bool lionfishObatined = false;
        static bool madarinObtained = false;


        public Fish()
        {

        }

        public Fish(String name)
        {
            this.name = name;
        }

        public Fish (int kind)
        {
            setKind(kind);
            setSize(kind);
            setFact(kind);
        }

        //JK begin
        public void setKind(int k)//sets kind for collection book
        {
            switch (k)
            {
                case 1:
                    this.kind = "Clownfish";
                    break;
                case 2:
                    this.kind = "Goby Fish";
                    break;
                case 3:
                    this.kind = "Puffer Fish";
                    break;
                case 4:
                    this.kind = "Butterfly Fish";
                    break;
                case 5:
                    this.kind = "Blue Tang";
                    break;
                case 6:
                    this.kind = "Royal Gramma";
                    break;
                case 7:
                    this.kind = "Cardinal Fish";
                    break;
                case 8:
                    this.kind = "Jawfish";
                    break;
                case 9:
                    this.kind = "Seahorse";
                    break;
                case 10:
                    this.kind = "Possum Wrasse";
                    break;
                case 11:
                    this.kind = "Lionfish";
                    break;
                case 12:
                    this.kind = "Mandarin Dragonet";
                    break;
            }
        }

        public string getKind()
        {
            return kind;
        }

        
        public void setSize(int k)//Sets size for collection book
        {
            switch (k)
            {
                case 1:
                    this.size = "Size: 4 in";
                    break;
                case 2:
                    this.size = "Size: 4 in";
                    break;
                case 3:
                    this.size = "Size: 1 in to 2 ft";
                    break;
                case 4:
                    this.size = "Size: 5-9 in";
                    break;
                case 5:
                    this.size = "Size: 10-12 in";
                    break;
                case 6:
                    this.size = "Size: 3 in";
                    break;
                case 7:
                    this.size = "Size: 2-8 in";
                    break;
                case 8:
                    this.size = "Size: 4-5 in";
                    break;
                case 9:
                    this.size = "Size: 1-14 in";
                    break;
                case 10:
                    this.size = "Size: 2-2.6 in";
                    break;
                case 11:
                    this.size = "Size: 18 in";
                    break;
                case 12:
                    this.size = "Size: 3 in";
                    break;
            }
        }

        public string getSize()
        {
            return size;
        }

        //JK
        public void setFact(int k)//sets fun fact for collection book
        {
            switch (k)
            {
                case 1:
                    this.fact = "Fun Fact: All clownfishes are born male. As they mature, the dominant male in the group will become a female.";
                    break;
                case 2:
                    this.fact = "Fun Fact: Gobies are bottom-dwellers who have a weak suction cup formed by the fusion of their pelvic fins used to shift sand.";
                    break;
                case 3:
                    this.fact = "Fun Fact: They are the most poisonous fish in the sea. They don’t have scales, and will inflate as a self defense mechanism.";
                    break;
                case 4:
                    this.fact = "Fun Fact: They have thin, dish shaped bodies that closely resemble their equally recognizable cousins, the angelfish.";
                    break;
                case 5:
                    this.fact = "Fun Fact: Blue tangs are capable of adjusting the intensity of their hue from light blue to deep purple.";
                    break;
                case 6:
                    this.fact = "Fun Fact: The royal gramma gets its name from its bright “royal purple” front part.";
                    break;
                case 7:
                    this.fact = "Fun Fact: These fish hide among the spines of sea urchins for protection against predators.";
                    break;
                case 8:
                    this.fact = "Fun Fact: The Spanish name for jawfishes is bocas grandes, meaning big mouths.Jawfishes use their big mouths like scoops as they move sand and rocks while digging their burrows.";
                    break;
                case 9:
                    this.fact = "Fun Fact: Male seahorses will store eggs and give birth to the babies.";
                    break;
                case 10:
                    this.fact = "Fun Fact: They are some of the smallest of the wrasses.";
                    break;
                case 11:
                    this.fact = "Fun Fact: The spines of this species can deliver a venomous sting. Lionfish are also nocturnal.";
                    break;
                case 12:
                    this.fact = "Fun Fact: Mandarin fish are very picky eaters. They eat mainly small worms, protozoans, and small crustaceans";
                    break;
            }
        }
        public string getFact()
        {
            return fact;
        }

        public void setObtained(string fish)//if fish was obtained than function sets accoridng boolean to true
        {
            if (fish == "clownfish")
                clownOptained = true;
            if (fish == "goby")
                gobyOptained = true;
            if(fish == "puffer fish")
                pufferObtained = true;
            if (fish == "butterfly fish")
                butterflyObtained = true;
            if (fish == "bluetang")
                blueTangObtained = true;
            if(fish == "royal gramma")
                royalGrammaObtained = true;
            if (fish == "cardinal fish")
                cardinalObtained = true;
            if(fish == "blue dot jawfish")
                jawfishObtained = true;
            if(fish == "seahorse")
                seahorseObtained = true;
            if(fish == "possum wrasse")
                possumObtained = true;
            if(fish == "lionfish")
                lionfishObatined = true;
            if (fish == "mandarin dragonet")
                madarinObtained = true;
        }

        public bool getObtained(string fish)//returns if fish kind was obtained
        {
            if (fish == "clownfish")
                return clownOptained;
            if (fish == "goby")
                return gobyOptained;
            if (fish == "puffer fish")
                return pufferObtained;
            if (fish == "butterfly fish")
                return butterflyObtained;
            if (fish == "bluetang")
                return blueTangObtained;
            if (fish == "royal gramma")
                return royalGrammaObtained;
            if (fish == "cardinal fish")
                return cardinalObtained;
            if (fish == "blue dot jawfish")
                return jawfishObtained;
            if (fish == "seahorse")
                return seahorseObtained;
            if (fish == "possum wrasse")
                return possumObtained;
            if (fish == "lionfish")
                return lionfishObatined;
            if (fish == "mandarin dragonet")
                return madarinObtained;
            else
                return false;
        }
        //JK end
        

        //Florence Lourdes start
        public string getName() //returns fish name as a string
        {
            return name; 
        }
    
        static List<string> fishList = new List<string>(); //array list to hold fishes

        public void setFishList(List<string> list) //set fish list function
        {
            fishList = list; 
        }

        public List<string> getFishList() //get fish list function
        {
            return fishList; 
        }
        //Florence Lourdes end
    }
}
