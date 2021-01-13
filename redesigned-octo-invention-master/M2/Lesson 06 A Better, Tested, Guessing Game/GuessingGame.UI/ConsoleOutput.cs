using GuessingGame.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame.UI
{
    public class ConsoleOutput
    {
        public static void DisplayTitle()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Better, Testable, Guessing Game!\n\n");
            Console.WriteLine("Press any key to start the game...");
            Console.ReadKey();
        }

        public static void DisplayGuessMessage(GuessResult result)
        {
            switch (result)
            {
                case GuessResult.Invalid:
                    DisplayInvalid();
                    break;
                case GuessResult.Higher:
                    DisplayHigher();
                    break;
                case GuessResult.Lower:
                    DisplayLower();
                    break;
                case GuessResult.Victory:
                    DisplayVictory();
                    break;
            }
        }

        private static void DisplayVictory()
        {
            Console.WriteLine("You did it! You are awesome!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DisplayLower()
        {
            Console.WriteLine("Your guess was too high, try something lower.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DisplayHigher()
        {
            Console.WriteLine("Your guess was too low, try something higher.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DisplayInvalid()
        {
            Console.WriteLine("That guess wasn't valid, try something between 1 and 20.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
    
