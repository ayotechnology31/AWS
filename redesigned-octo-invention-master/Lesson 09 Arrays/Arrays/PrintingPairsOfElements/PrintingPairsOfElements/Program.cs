using System;

namespace PrintingPairsOfElements
{
	class Program
	{
		static void Main(string[] args)
		{
			//For this example, let’s consider that we want to print pairs of elements, skipping one number in between each pair. 
			//So, if we have the numbers 1, 2, 3, 4, 5, 6, we want to print 1,2 then 4,5:

			//There are three key ideas in this sample:

			//Pairs, skipping one number in between means 3 elements.Thus, our increment for the loop needs to be i += 3.
			//  Since we are reading three elements in we need to stop earlier than length.i < numbers.Length works for one element at a time, but since we have 3 we need to subtract the difference(3 - 1 = 2).
			// We can use an expression as an index.So[i + 1] is the index next to the current element i.
			// As always, be sure to write pseudo code, flow chart the process, or 
			//simply write the steps of the process out with sample data before attempting to code.The majority of times we assist students with array issues it is because they have not solved the problem on paper before writing code.
		  

			int[] numbers = { 1, 2, 3, 4, 5, 6 };

			for (int i = 0; i < numbers.Length - 2; i += 3)
			{
				Console.WriteLine($"Pair: ({numbers[i]}, {numbers[i + 1]})");
			}
		}
	}
}
