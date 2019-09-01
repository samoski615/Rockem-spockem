using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockspock
{
    public class Rules
    {
        public void DisplayTheRules()
        {
            Console.WriteLine("ROCK YOUR SPOCK OUT!");
            Console.WriteLine("Time to play -- Rock, Paper, Scissors, Lizard, Spock!");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("The rules are simple -- pick your gesture, hope your gesture beats the other player's gesture!");
            Console.WriteLine("Best of three wins the game -- GOOD LUCK!");
            Console.WriteLine("\n");
            Console.WriteLine("Here are the winning combinations: ");
            Console.WriteLine("\n");
        }

        public void WinningCombinations()
        {
            Console.WriteLine("ROCK crushes SCISSORS");
            Console.WriteLine("ROCK crushes LIZARD");
            Console.WriteLine("PAPER covers ROCK");
            Console.WriteLine("PAPER disproves SPOCK");
            Console.WriteLine("SCISSORS cuts PAPER");
            Console.WriteLine("SCISSORS decapitates LIZARD");
            Console.WriteLine("LIZARD poisons SPOCK");
            Console.WriteLine("LIZARD eats PAPER");
            Console.WriteLine("SPOCK smashes SCISSORS");
            Console.WriteLine("SPOCK vaporizes ROCK");
            Console.WriteLine("\n");
        }

        
        
        public void WinPaperVsRock()
        {
            Console.WriteLine("PAPER covers ROCK");
        }
        public void WinPaperVsSpock()
        {
            Console.WriteLine("PAPER disproves SPOCK");
        }
        public void WinScissorsVsPaper()
        {
            Console.WriteLine("SCISSORS cuts PAPER");
        }
        public void WinScissorsVsLizard()
        {
            Console.WriteLine("SCISSORS decapitates LIZARD");
        }
        public void WinLizardVsSpock()
        {
            Console.WriteLine("LIZARD poisons SPOCK");
        }
        public void WinLizardVsPaper()
        {
            Console.WriteLine("LIZARD eats PAPER");
        }
        public void WinSpockVsScissors()
        {
            Console.WriteLine("SPOCK smashes SCISSORS");
        }
        public void WinSpockVsRock()
        {
            Console.WriteLine("SPOCK vaporizes ROCK");
        }

        public void GestureRules()
        {
            Console.WriteLine("Choose your gesture: ");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            Console.WriteLine("4. Lizard");
            Console.WriteLine("5. Spock");
        }
    }
}

