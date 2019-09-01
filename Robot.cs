using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockspock
{
    class Robot : Player
    {
        //member variables
        Rules rules;

        //constructor
        public Robot()
        {
            rules = new Rules();
        }
        //member methods
        public string ChooseGesture()
        {
            rules.GestureRules();
            string input = Console.ReadLine().ToLower();
            return input;
        }
        public string ChooseName(string name)
        {
            Console.WriteLine("What is your name");
            name = Console.ReadLine();
            return name;
        }

        public void RandomNumberGenerator()
        {

        }

    }
}
