using System;

namespace ForTimesFor
{
	class Program
	{
		static void Main(string[] args)
		{
			////Refactor your times table program from the previous exercise so that instead of just "reciting" a times table, the program prints out each "times" as a question, and waits for an answer. If the user answers correctly - they get a point!If not...they get corrected.

			////Print out the total number of points at the end.

			////Bonus: Print out a message that they should study more if they get less than 50 % correct, and give them a congratulatory message if they got over 90 % correct!

			string input;
			int guess;
			int total = 0;

			Console.WriteLine("Which times table shall I recite? 5");
			for (int x = 1; x < 16; x++)
			{
				Console.WriteLine("What is " + x + " * 5 is: ");
				input = Console.ReadLine();
				if (int.TryParse(input, out guess))
				{
					if (guess == x * 5)
					{
						Console.WriteLine("Correct!");
						total++;
					}
					else
					{
						Console.WriteLine("Sorry no, the answer is: {0}", x * 5);
					}
				}
				//Console.WriteLine(x + "  * 5 is: {0}", x * 5);
			}
			Console.WriteLine("You got " + total + " correct.");
		}
	}
}
