using System;

namespace BirthStones
{
	class Program
	{
		//Save your code in a file that matches the above - make it work!
		//Write a program that asks for a number.
		//Match that number against the month number.
		//Printout the name of the month and its corresponding birth stone.
		//Use Ifs and Elses to complete it.
		static void Main(string[] args)
		{
			string input;
			int January  = 1;
			int February = 2;
			int March = 3;
			int April = 4;
			int May = 5;
			int June = 6;
			int July = 7;
			int August = 8;
			int September = 9;
			int October = 10;
			int November = 11;
			int December = 12;
	

			while(true)
			{
				Console.Write("What month's birthstone are you wanting to know? ");
				input = Console.ReadLine();

				if (input == "1" )
				{
					Console.WriteLine("January birthstone is Garnet");
					continue;
				}
				else if(input == "2")
				{
					Console.WriteLine("February birthstone is Amethyst");
					continue;
				}
				else if (input == "3")
				{
					Console.WriteLine("March birthstone is Amethyst");
					continue;
				}
				else if (input == "4")
				{
					Console.WriteLine("April birthstone is Aquamarine");
					continue;
				}
				else if (input == "5")
				{
					Console.WriteLine("May birthstone is Diamond");
					continue;
				}
				else if (input == "6")
				{
					Console.WriteLine("June birthstone is Emerald");
					continue;
				}
				else if (input == "7")
				{
					Console.WriteLine("July birthstone is Pearl");
					continue;
				}
				else if (input == "8")
				{
					Console.WriteLine("August birthstone is Ruby");
					continue;
				}
				else if (input == "9")
				{
					Console.WriteLine("September birthstone is Sapphire");
					continue;
				}
				else if (input == "10")
				{
					Console.WriteLine("October birthstone is Opal");
					continue;
				}
				else if (input == "11")
				{
					Console.WriteLine("November birthstone is Topaz");
					continue;
				}
				else if (input == "12")
				{
					Console.WriteLine("December birthstone is Turquoise");
					continue;
				}
				else
				{
					Console.WriteLine($"I think you must be confused {input} doesn't match a month.");
					continue;
				}

				Console.WriteLine("Press any key to quit...");
				Console.ReadKey();
				//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
			}

		}
	}
}
