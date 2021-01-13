using System;

namespace HighRoller
{
	class Program
	{
		static void Main(string[] args)

		////Type out all the code into the HighRoller.sln file.Make it work!
		////THEN Make it more interactive!
		////Ask the user to tell you the number of sides the dice has. (My favorite is a d20!)
		////Then roll the dice to generate a number between 1 - # sides
		////Add in a conditional print out that prints out:
		////"You rolled a crit failure! Ouch." if it rolled a 1
		////"You rolled a critical! Nice Job!" if it rolled the max.

		{
			//Random diceRoller = new Random();

			//int rollResult = diceRoller.Next(6) + 1;

			//Console.WriteLine("TIME TO ROOOOOOLL THE DICE!");
			//Console.WriteLine("I rolled a " + rollResult);

			//if (rollResult == 1)
			//{
			//	Console.WriteLine("You rolled a critical failure!");
			//}

			Random diceRoller = new Random();

			int rollResult = diceRoller.Next(6) + 1;

			int input;

			Console.WriteLine("TIME TO ROOOOOOLL THE DICE!");
			Console.WriteLine("How many number of sides does the dice have?");
			
			input = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("I rolled a " + rollResult);

			if (rollResult == 1)
			{
				Console.WriteLine("You rolled a critical failure! Ouch");
			}
			else
			{
				Console.WriteLine("You rolled a critical! Nice Job!");
			}
		}
	}
}
