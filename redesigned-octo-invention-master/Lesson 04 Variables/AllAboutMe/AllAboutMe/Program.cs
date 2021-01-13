using System;

namespace AllAboutMe
{
	class Program
	{
		static void Main(string[] args)
		{
			string myName, favoriteFood;
			double numOfPets, age;
			bool eatenGnocci;

			myName = "Cookie";
			numOfPets = 3;
			favoriteFood = "spaghetti";
			eatenGnocci = true;
			age = 5;

			Console.WriteLine("I am " + myName);
			Console.WriteLine("I have " + numOfPets + " pets");
			Console.WriteLine("My favorite food is " + favoriteFood);
			Console.WriteLine("It is " + eatenGnocci + " that have eaten gnocci.");
			Console.WriteLine("And when I was " + age + " years old, I learned to whistle.");
		}
	}
}
