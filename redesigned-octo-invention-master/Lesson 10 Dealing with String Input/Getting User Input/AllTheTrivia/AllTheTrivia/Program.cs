using System;

namespace AllTheTrivia
{
	class Program
	{
		static void Main(string[] args)
		{
			//Type your code into the Visual Studio project named above. Make it work!
			//Ask the user for several pieces of trivia, but when you display them, mix up the answers.
			//string userInput = Console.ReadLine();
			int number;
			string planet1, planet2, chemical;

			Console.WriteLine("1,024 Gigabytes is equal to one what? ");
			chemical = Console.ReadLine();

			Console.WriteLine("In our solar system which is the only planet that rotates clockwise? ");
			planet2 = Console.ReadLine();

			Console.WriteLine("The largest volcano ever discovered in our solar system is located on which planet?");
			number = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("What is the most abundant element in the earth's atmosphere?");
			planet1 = Console.ReadLine();

			Console.WriteLine("Wow, 1,024 Gigabytes is a" + chemical);
			Console.WriteLine("I didn't know that the largest ever volcano was discovered on " + planet2);
			Console.WriteLine("That's amazing that " + number + " is the most abundant element in the atmosphere...");
			Console.WriteLine(planet1 + " is the only planet that rotates clockwise, neat! ");
		}
	}
}
