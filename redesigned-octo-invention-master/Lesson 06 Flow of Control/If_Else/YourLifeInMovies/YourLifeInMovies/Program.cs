using System;

namespace YourLifeInMovies
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputName;
			int yr1 = 2005;
			int yr2 = 1995;
			int yr3 = 1985;
			int yr4 = 1975;
			int yr5 = 1965;
			string inputYear;
			int Year;


			while (true)
			{
				Console.Write("Hey, let's play a game! What's your name?");
				inputName = Console.ReadLine();

				Console.Write("What year were you born? ");
				inputYear = Console.ReadLine();

				if (int.TryParse(inputYear, out Year))
				{
					if (yr2 < Year && Year < yr1)
					{
						Console.WriteLine("Well {0}, Did you know that Pixar's 'Up' came out half a decade ago?", inputName);
						break;
					}
					if (yr3 < Year && Year < yr2)
					{
						Console.WriteLine("Well {0}, Did you know that Pixar's 'Up' came out half a decade ago?", inputName);
						Console.WriteLine("And that the first Harry Potter came out over 15 years ago!");
						break;
					}
					if (yr4 < Year && Year < yr3)
					{
						Console.WriteLine("Well {0}, Did you know that Pixar's 'Up' came out half a decade ago?", inputName);
						Console.WriteLine("And that the first Harry Potter came out over 15 years ago!");
						Console.WriteLine("Also, Space Jam came out not last decade, but the one before THAT.");
						break;
					}
					if (yr5 < Year && Year < yr4)
					{
						Console.WriteLine("Well {0}, Did you know that Pixar's 'Up' came out half a decade ago?", inputName);
						Console.WriteLine("And that the first Harry Potter came out over 15 years ago!");
						Console.WriteLine("Also, Space Jam came out not last decade, but the one before THAT.");
						Console.WriteLine("The original Jurassic Park release is closer to the lunar landing, than today.");
						break;
					}
					if (Year < yr5)
					{
						Console.WriteLine("Well {0}, Did you know that Pixar's 'Up' came out half a decade ago?", inputName);
						Console.WriteLine("And that the first Harry Potter came out over 15 years ago!");
						Console.WriteLine("Also, Space Jam came out not last decade, but the one before THAT.");
						Console.WriteLine("The original Jurassic Park release is closer to the lunar landing, than today.");
						Console.WriteLine("MASH has been around for almost half a century");
						break;
					}

					Console.WriteLine("Press any key to quit...");
					Console.ReadKey();
				}

			}
		}
	}
}
