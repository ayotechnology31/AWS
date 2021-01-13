using System;

namespace PassingTheTuringTest
{
	class Program
	{
		static void Main(string[] args)
		{
			//Type your code into the Visual Studio project named above. Make it work!
			//Create a program that uses taken user input in a conversation. 
			//First ask the user for their name. 
			//Then display that name, and tell them yours(or your AI's name!) 
			//Ask them for their favorite color.
			//Then display that, but in a conversational way.
			//Do the same thing with favorite food and number, and then say goodbye!
			//Make sure you use the right variable with the right user input!

			string theirName, myName, color, food;
			int number;


			Console.WriteLine("Hi, what's your name?");
			theirName = Console.ReadLine();
			Console.WriteLine("Hi " + theirName + (". My name is Cookie. "));

			Console.WriteLine("What's your favorite color? ");
			color = Console.ReadLine();
			Console.WriteLine("I like " + color + " too.");

			Console.WriteLine("What's your favorite food? ");
			food = Console.ReadLine();
			Console.WriteLine(food + " is delicious! ");

			Console.WriteLine("What's your favorite number? ");
			number = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(number + " is a lucky number ");

			Console.WriteLine("Nice to meet you. Goodbye.");
		}
	}
}
