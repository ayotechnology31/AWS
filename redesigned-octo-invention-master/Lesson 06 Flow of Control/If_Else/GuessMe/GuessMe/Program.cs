using System;

namespace GuessMe
{
	class Program
	{
		static void Main(string[] args)
		{
			int answer = 38;
			string input;
			int guess;

			while (true)
			{
				Console.Write("Guess my age from 25 to 45: ");
				input = Console.ReadLine();

				if(int.TryParse(input, out guess))
				{
					if (guess == answer)
					{
						Console.WriteLine("Wow, nice guess! That was it!");
						break;
					}

					if (guess < answer)
					{
						Console.WriteLine("Ha, nice try -too low! I chose {0}", answer);
						continue;
					}

					if (guess > answer)
					{
						Console.WriteLine("Too bad, way too high. I chose {0}", answer);
						continue;
					}
				}
			}
			Console.WriteLine("You got it! The answer was {0}.", answer);
			Console.WriteLine("Press any key to quit...");
			Console.ReadKey();

			// TODO: try random as well
		}
	}
}
