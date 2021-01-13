using System;

namespace KnockKnock
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Knock Knock! Guess who!! ");
            String nameGuess = Console.ReadLine();

            ////https://stackoverflow.com/questions/6371150/comparing-two-strings-ignoring-case-in-c-sharp
            if (nameGuess.Equals("Marty McFly", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Hey! That's right! I'm back!");
                Console.WriteLine(".... from the Future."); // Sorry, had to!
            }
            else
            {
                Console.WriteLine("Dude, do I -look- like " + nameGuess);
            }

        }
    }
}
