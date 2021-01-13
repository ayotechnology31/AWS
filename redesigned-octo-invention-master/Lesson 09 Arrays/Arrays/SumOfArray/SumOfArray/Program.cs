using System;

namespace SumOfArray
{
	class Program
	{
		static void Main(string[] args)
		{

			//Below are a series of examples of some techniques for iterating through arrays. They are good templates to study. We encourage you to type them into a console application and debug them to see how they work.

			int[] numbers = { 3, 5, 2, 0 };
			int sum = 0; // keep running total

			for (int i = 0; i < numbers.Length; i++)
			{
				sum += numbers[i];
				Console.WriteLine($"i={i}, current sum={sum}");
			}

			//Some developers prefer to write for loops for arrays with a less than or equal statement.  In this case, they have to subtract 1 from the length like so:
			for (int i = 0; i <= numbers.Length - 1; i++)
			{
				sum += numbers[i];
				Console.WriteLine($"i={i}, current sum ={sum}");
			}

			Console.WriteLine($"Final sum: {sum}");
		}
	}
}
