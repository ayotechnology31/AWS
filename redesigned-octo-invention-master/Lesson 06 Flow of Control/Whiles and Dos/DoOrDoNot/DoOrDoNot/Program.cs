using System;

namespace DoOrDoNot
{
	class Program
	{
		static void Main(string[] args)
		{
			//Type in the following code, make it work!
			//What does it print out if you tell it to do it?
			//What if you tell it not to? (answer in a comment)
			//Comment out the do/while loop and write a while loop that checks the same condition, and executes the same loop code.
			//When you just have a while loop, what prints out when you tell it to do it?
			//When you tell it not to? (answer in a comment) 

			Console.Write("Should I do it? (y/n) ");
			bool doIt;

			if (Console.ReadLine().Equals("y"))
			{
				doIt = true; // DO IT!
			}
			else
			{
				doIt = false; // DONT YOU DARE!
			}

			bool iDidIt = false;

			do
			{
				iDidIt = true;
				break;
			} while (doIt);

			if (doIt && iDidIt)
			{
				Console.WriteLine("I did it!");
			}
			else if (!doIt && iDidIt)
			{
				Console.WriteLine("I know you said not to ... but I totally did anyways.");
			}
			else
			{
				Console.WriteLine("Don't look at me, I didn't do anything!");
			}
		}
	}
}
