using System;

namespace UsingArrayinCode_Video
{
	class Program
	{
		static void Main(string[] args)
		{
			///find min and max
			int[] numbers = { 3, 7, 2, 4, 7, 12 };
			int sum = 0;
			int min = numbers[0];
			int max = numbers[0];

			for (int i = 0; i < numbers.Length; i++)
			{
				sum = +numbers[i];

				if (numbers[i] < min)
				{
					min = numbers[i];
				}

				if (numbers[i] > max)
				{
					max = numbers[i];
				}
			}

			//bubble sort or swapping 
			int [] numbers = { 3, 7, 2, 4, 7, 12 };
			int temp;

			for (int i = 1; i < numbers.Length; i++)
			{
				for(int j =0; j < numbers.Length-1; j++)
				{
					if (numbers[j] > numbers[j + 1])
					{
						temp = numbers[j + 1];
						numbers[j + 1] = temp;
					}
				}
			}

			///challenge - introduce a boolean to break out o a loop if no swaps are made in a pass
			///key points
			///1) First element of an array is index 0
			///2) Last element of an array is at index Length - 1
			///3) Always check your array boundaries
			///4) Always check that array data exists and is the length you expect
		}
	}
}
