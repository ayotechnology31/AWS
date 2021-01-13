using System;

namespace GuessMeMore
{
	class Program
	{
		static void Main(string[] args)
		{

			Random yourGuess = new Random();
			int rightAnswer = yourGuess.Next(-100, 100);
			string input;
			int guess;

			while (true)
			{
				Console.WriteLine("I've chosen a number between -100 and 100. Betcha can't guess it!" );
				input = Console.ReadLine();
				Console.WriteLine("Your guess: " + input);

				///changing from one type to another
				if (int.TryParse(input, out guess))
				{
					if (rightAnswer == guess)
					{
						Console.WriteLine("Wow, nice guess! That was it!");
						break;
					}

					//compare right answer and users guess
					if (rightAnswer > guess)
					{
						Console.WriteLine("Ha, nice try -too low! Try again!");
						continue;
					}

					if (rightAnswer < guess)
					{
						Console.WriteLine("Too bad, way too high. Try again!");
						continue;
					}
				}
			}
			Console.WriteLine("Press any key to quit...");
			Console.ReadKey();
		}
	}
}
