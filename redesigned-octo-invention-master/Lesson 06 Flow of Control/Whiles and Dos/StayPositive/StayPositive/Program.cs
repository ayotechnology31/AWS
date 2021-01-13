using System;

namespace StayPositive
{
	class Program
	{
		static void Main(string[] args)
		{
			//Write a while loop that asks the user for a number and counts down from it, printing out each number until it reaches zero, and then stops. (Stop at zero because the numbers after, they just get too NEGATIVE to deal with!)

			//BONUS: Print out 10 numbers per line, and then start a new line ...


			//int numNow = 59;
			//int stop = 0;


			//Console.WriteLine("What number should I count down from?", numNow);
			//Console.WriteLine("Here goes!");

			//while (numNow > stop)
			//{
			//	Console.WriteLine(numNow);
			//	numNow--;
			//}

			//Console.WriteLine("Whew, better stop there...! ");

			////BONUS: Print out 10 numbers per line, and then start a new line ...
			int numNow = 59;
			Console.WriteLine("What number should I count down from?", numNow);
			Console.WriteLine("Here goes!");

			for (int number = 59; number >= 0; number--)
			{
				if(number % 10 == 0 && number > 0)
				{
					Console.Write(number+ "\n");
				}
				else
				{
					Console.Write(number + " ");
				}
			}
			Console.WriteLine("Whew, better stop there...! ");
		}
	}
}
