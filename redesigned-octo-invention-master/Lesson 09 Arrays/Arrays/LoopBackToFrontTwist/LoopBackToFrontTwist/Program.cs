using System;

namespace LoopBackToFrontTwist
{
	class Program
	{
		static void Main(string[] args)
		{
			//In C# a for loops can count up or down, so we can also loop through an array from back to front if we wish. 
			//In fact, let’s go from back to front and print only the elements that are in odd numbered indexes:

			int[] numbers = { 3, 5, 2, 0 };

			// start at last index, go to first (0)
			for (int i = numbers.Length - 1; i >= 0; i--)
			{
				if (i % 2 == 0)
					continue;
				else
					Console.WriteLine($"index {i} - {numbers[i]}");
			}

		}
	}
}
