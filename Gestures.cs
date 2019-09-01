using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockspock
{
    class Gestures
    {
        //choose true or false for winning condition
        bool winningGesture;
        bool losingGesture;

        public void DrawCondition()
        {
            Console.WriteLine("You both chose 'Rock'. DRAW! Choose again.");
        }
        public void WinRockVsScissors()
        {
            Console.WriteLine("ROCK crushes SCISSORS");
        }
        public void WinRockVsLizard()
        {
            Console.WriteLine("ROCK crushes LIZARD");
        }

        //public bool RockGesture(bool input)
        //{
        //    if (input == true)
        //    {
        //        Console.WriteLine("ROCK crushes SCISSORS");
        //    }

        //}
    }
}
