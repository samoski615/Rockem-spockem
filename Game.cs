using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockspock
{
    class Game
    {
        Gestures gestures;
        Rules rules;
        Player player1;
        Player player2;
        public int nOfPlayers;
        public string input;
        public Game()
        {
            
            rules = new Rules();
        }
        public void RunGame()
        {
            rules.DisplayTheRules();
            rules.WinningCombinations();

            //HowManyPlayersPlaying(nOfPlayers);
            SettingUpPlayers();
            player1.ChooseGesture(input);
            player2.ChooseGesture(input);


        }
        
        private int SettingUpPlayers() //try/catch for number of players to verify input
        {
            Console.WriteLine("How many people are playing?");
            nOfPlayers = Convert.ToInt32(Console.ReadLine());
            if (nOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new Robot();
            }
            else
            {
                player1 = new Human();
                player2 = new Human();
            }
            return nOfPlayers;
        }
        public string CompareGestures(string input)
        {
            rules.GestureRules();
            input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "rock":
                    if (player1.ChooseGesture(input) == player2.ChooseGesture(input))
                    {
                        gestures.DrawCondition();
                        //if player1ChooseGesture "rock" and player2ChooseGesture choose "rock"
                        //....send to method for consoleWriteLine "draw"
                        //if player1ChooseGesture "rock" Console.WriteLine "you chose rock"
                    }
                    else if(player1.ChooseGesture(input) != player2.ChooseGesture(input))
                    {
                        return input;
                    }
                    break;
                case "1":
                    break;

                case "paper":
                    break;
                case "2":
                    break;
                case "scissors":
                    break;
                case "3":
                    break;
                case "lizard":
                    break;
                case "4":
                    break;
                case "spock":
                    break;
                case "5":
                    break;
                default:
                    break;
            }
            return input;
        }

        //private int HowManyPlayersPlaying(int nOfPlayers)
        //{
        //    Console.WriteLine("How many people are playing");
        //    nOfPlayers = 
        //        Convert.ToInt32(Console.ReadLine());
        //    return nOfPlayers;
        //}

    }
}
