using System;

namespace DoItBetter
{
	class Program
	{
		static void Main(string[] args)
		{
			///Type your code into the Visual Studio project named above. Make it work!
			//Ask the user for how many miles they can run, the number of hotdogs they can eat, and the number of languages they know.Immediately after each question, brag that you can do more by multiplying it by 2 and adding 1.
			
			int miles, hotdogs, languages;

			Console.WriteLine("How many miles can you run? ");
			miles = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ha! I can run " + (miles * 2 + 1) + " miles! ");

			Console.WriteLine("How many hotdogs can you eat? ");
			hotdogs = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ha! I can eat " + (hotdogs * 2 + 1) + " hotdogs! ");

			Console.WriteLine("How many languages do you know? ");
			languages = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ha! I know " + (languages * 2 + 1) + " languages! ");

		}
	}
}
