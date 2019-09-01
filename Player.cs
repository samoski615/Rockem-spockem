using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockspock
{
    public abstract class Player 
    {
        Rules rules;
        int score;
        string name;
        string input;
        public List<string> gameGestures;


        public Player()
        {
            rules = new Rules();
            gameGestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        }

        public string ChooseGesture(string input)
        {
            rules.GestureRules();
            input = Console.ReadLine().ToLower();
            return input;
        }
        public string ChooseName()
        {
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            return name;
        }



    }

}
