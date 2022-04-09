using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Florence Lourdes

namespace Aquaria_Project
{
    internal class Trivia
    {
        int money = 0;
        string currQuestion = "";
        string choiceA = "";
        string choiceB = "";
        string choiceC = "";
        Random rnd = new Random();

        public string[] questions = new string[20] //an array of 20 questions
        {
            "Which one of these statements is true about clownfish?" ,
            "A bottom dweller fish that has a weak suction cup used to shift sand" ,
            "The most poisonous fish in the sea and a delicacy in Japan" ,
            "A cousin of the Angelfish" ,
            "This fish is known as the character Dory in Finding Nemo" ,
            "Royal Gramma gets its name from?" ,
            "This fish hides among the spines of sea urchins for protection" ,
            "This fish uses its big mouth to scoop sand and dig burrows" ,
            "The male sex of this species will store eggs and give birth" ,
            "This fish is one of the smallest of the wrasses" ,
            "A nocturnal fish with poisonous spines" ,
            "This fish is a very picky eater and eat mainly small worms protozoans, and small crustaceans" ,
            "How many bones do sharks have?" ,
            "What is the biggest fish in the world?" ,
            "Approximately how many species of fish are there worldwide?" ,
            "What is the smallest fish in the world?" ,
            "What is the oldest fish in the world?" ,
            "What is the most common fish in the ocean?" ,
            "Which of these fishes give birth instead of laying eggs?" ,
            "What is the fastest fish in the world?" };

        public Trivia()
        {

        }

        public void SetMoney(string num)
        {
            money = Int32.Parse(num);
        }

        public string GetMoney()
        {
            return money.ToString();
        }

        public string generateQuestion() //generates a random question from the array
        {
            currQuestion = questions[rnd.Next(0, 19)];
            return currQuestion;
        }

        public void generateAnswers() //generates answer options according to the question generated
        {
            if (currQuestion.Equals(questions[0]))
            {
                choiceA = "All clownfishes are born females";
                choiceB = "All clowfishes are born males"; //
                choiceC = "None of the above";
            }
            else if (currQuestion.Equals(questions[1]))
            {
                choiceA = "Mandarin Dragonet";
                choiceB = "Goby fish"; //
                choiceC = "Possum Wrasse";
            }
            else if (currQuestion.Equals(questions[2]))
            {
                choiceA = "Stonefish";
                choiceB = "Lionfish";
                choiceC = "Puffer fish"; //
            }
            else if (currQuestion.Equals(questions[3]))
            {
                choiceA = "Butterfly fish"; //
                choiceB = "Cardinal fish";
                choiceC = "Blue Tang";
            }
            else if (currQuestion.Equals(questions[4]))
            {
                choiceA = "Blue Tang"; //
                choiceB = "Butterfly fish";
                choiceC = "Cardinal fish";
            }
            else if (currQuestion.Equals(questions[5]))
            {
                choiceA = "The fish' personality";
                choiceB = "The royalty who found the species";
                choiceC = "Its purple color"; //
            }
            else if (currQuestion.Equals(questions[6]))
            {
                choiceA = "Cardinal fish"; //
                choiceB = "Clownfish";
                choiceC = "Goby fish";
            }
            else if (currQuestion.Equals(questions[7]))
            {
                choiceA = "Blue Dot Jawfish"; //
                choiceB = "Possum Wrasse";
                choiceC = "Mandarin Dragonet";
            }
            else if (currQuestion.Equals(questions[8]))
            {
                choiceA = "Sea Urchin";
                choiceB = "Clownfish";
                choiceC = "Seahorse"; //
            }
            else if (currQuestion.Equals(questions[9]))
            {
                choiceA = "Humphead Wrasse";
                choiceB = "Leopard Wrasse";
                choiceC = "Possum Wrasse"; //
            }
            else if (currQuestion.Equals(questions[10]))
            {
                choiceA = "Lionfish"; //
                choiceB = "Sea Urchin";
                choiceC = "Puffer fish";
            }
            else if (currQuestion.Equals(questions[11]))
            {
                choiceA = "Clownfish";
                choiceB = "Lionfish";
                choiceC = "Mandarin Dragonet"; //
            }
            else if (currQuestion.Equals(questions[12]))
            {
                choiceA = "121";
                choiceB = "0"; //
                choiceC = "270";
            }
            else if (currQuestion.Equals(questions[13]))
            {
                choiceA = "Whale Shark"; //
                choiceB = "Great White Shark";
                choiceC = "Tiger Shark";
            }
            else if (currQuestion.Equals(questions[14]))
            {
                choiceA = "48000";
                choiceB = "76000";
                choiceC = "33000"; //
            }
            else if (currQuestion.Equals(questions[15]))
            {
                choiceA = "Dwarf Cyprinids"; //
                choiceB = "Dwarf Goby";
                choiceC = "Neon Tetra";
            }
            else if (currQuestion.Equals(questions[16]))
            {
                choiceA = "Great White Shark";
                choiceB = "Methuselah"; //
                choiceC = "Aligator Gar";
            }
            else if (currQuestion.Equals(questions[17]))
            {
                choiceA = "Lanternfish";
                choiceB = "Bristle Mouth"; //
                choiceC = "Atlantic Cod";
            }
            else if (currQuestion.Equals(questions[18]))
            {
                choiceA = "Dolphin"; //
                choiceB = "Swordfish";
                choiceC = "Lionfish";
            }
            else if (currQuestion.Equals(questions[19]))
            {
                choiceA = "Sailfish"; //
                choiceB = "Dolphin";
                choiceC = "Swordfish";
            }
        }

        //methods to return answer options
        public string getChoiceA()
        {
            return choiceA;
        }
        public string getChoiceB()
        {
            return choiceB;
        }
        public string getChoiceC()
        {
            return choiceC;
        }

        public void reset() //resets the game
        {
            money = 0;
            currQuestion = "";
            choiceA = "";
            choiceB = "";
            choiceC = "";
        }
    }
}
