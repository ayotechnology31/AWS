using System;

namespace MiniMadLibs
{
	class Program
	{
		static void Main(string[] args)
		{
			//Type your code into the Visual Studio project named above. Make it work
			//Make a program that lets you play mad libs!
			//You'll have to ask the user for the following (unless you use a different mad lib!):
			//1) noun
			//2) adjective
			//3) noun
			//4) number
			//5) adjective
			//6,7,8) 3 plural nouns
			//9) verb present tense
			//10) same verb but past tense

			string noun, adj, noun2, adj2, pNoun1, pNoun2, pNoun3, verbPresent, verbPast;
			int number;

			Console.WriteLine("Let's play MAD LIBS!");
			Console.Write("I need a noun: ");
			noun = Console.ReadLine();
			Console.Write("Now an adj: ");
			adj = Console.ReadLine();
			Console.Write("Another noun: ");
			noun2 = Console.ReadLine();
			Console.Write("And a number: ");
			number = Convert.ToInt32(Console.ReadLine());
			Console.Write("Another adj: ");
			adj2 = Console.ReadLine();
			Console.Write("A plural noun: ");
			pNoun1 = Console.ReadLine();
			Console.Write("Another one: ");
			pNoun2 = Console.ReadLine();
			Console.Write("One more: ");
			pNoun3 = Console.ReadLine();
			Console.Write("A verb (present tense): ");
			verbPresent = Console.ReadLine();
			Console.Write("Same verb (past tense): ");
			verbPast = Console.ReadLine();

			Console.WriteLine("*** NOW LETS GET MAD (libs) ***");
			Console.WriteLine(noun + ": " + " the " + adj + " frontier. " + "These are the voyages of the starship " + noun2 + ". It's " + number + 
				"-year mission: to explore strange " + adj2 + " " + pNoun1 + ", to seek out " + adj2 + " " + pNoun2 + " " + adj2 + " " + pNoun3 + 
				", to boldly " + verbPresent + " where no one has " + verbPast + " before. ");
		}
	}
}
