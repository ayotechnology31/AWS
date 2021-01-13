using System;

namespace TraditionalFizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			//Ask the user for a number.

			//Counting from zero (using a for loop!) replace every multiple of 3 with "fizz" and every multiple of 5 with "buzz".Multiples of BOTH should print out "fizz buzz".Every time you print out fizz, buzz, or fizz buzz - keep track.When you've reached the number that as prompted from the user - stop! (You might consider it ... taking a break, so to speak.)

			//Finish it all up with a large, all caps printout of "TRADITION!!!!!" and do a little dance.
			////*** How do I do it? Where does it go


			string howMuch;
			int hm;
			int total = 0;

			Console.Write("How much units fizzing and buzzing do you need in your life? ");
			howMuch = Console.ReadLine();

			if (int.TryParse(howMuch, out hm))
				for (int numberLoops = 0; numberLoops < hm; numberLoops++) 
				{
					
					if (numberLoops == 0)
					{
						Console.WriteLine(numberLoops);

					}
					else if (numberLoops % 3 == 0 && numberLoops % 5 == 0)
					{
						Console.WriteLine("fizz buzz");
						total++;
						if (total == hm)
						{
							break;
						}
					}
					else if(numberLoops % 3 == 0)
					{
						Console.WriteLine("fizz");
						total++;
						if (total == hm)
						{
							break;
						}
					}
					else if (numberLoops % 5 == 0)
					{
						Console.WriteLine("buzz");
						total++;
						if (total == hm)
						{
							break;
						}
					}
					else
					{
						Console.WriteLine(numberLoops);
					}
				}
			Console.Write("TRADITION!!!!!");
		}
	}
}
