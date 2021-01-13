using System;

namespace Opinionator
{
	class Program
	{
		static void Main(string[] args)
		{
            Random randomizer = new Random();

            Console.WriteLine("I can't decide what animal I like the best.");
            Console.WriteLine("I know! Random can decide FOR ME!");

            int x = randomizer.Next(5);

            Console.WriteLine("The number we chose was: " + x);

            if (x == 0)
            {
                Console.WriteLine("Llamas are the best!");
            }
            else if (x == 1)
            {
                Console.WriteLine("Dodos are the best!");
            }
            else if (x == 2)
            {
                Console.WriteLine("Woolly Mammoths are DEFINITELY the best!");
            }
            else if (x == 3)
            {
                Console.WriteLine("Sharks are the greatest, they have their own week!");
            }
            else if (x == 4)
            {
                Console.WriteLine("Cockatoos are just so awesomme!");
            }
            else if (x == 5)
            {
                Console.WriteLine("Have you ever met a Mole-Rat? They're GREAT!");
            }

            Console.WriteLine("Thanks Random, maybe YOU'RE the best!");
        }
	}
}
