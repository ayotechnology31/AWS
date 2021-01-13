using System;

namespace SimpleSort
{
	class Program
	{
		//Combine the following 2 arrays into one large array that has all the numbers sorted in increasing order, then print them out!
		static void Main(string[] args)
		{
			int[] firstHalf = { 3, 7, 9, 10, 16, 19, 20, 34, 55, 67, 88, 99 };
			int[] secondHalf = { 1, 4, 8, 11, 15, 18, 21, 44, 54, 79, 89, 100 };

			int[] wholeNumbers = new int[24];

			// Sorting code should go here!
			Console.WriteLine("Here ya go - all nice and ordered:");

			for(int i = 0; i < firstHalf.Length; i++)
			{
				wholeNumbers[i] = firstHalf[i];
			}

			for (int j = 0; j < secondHalf.Length; j++)
			{
				wholeNumbers[j] = secondHalf[j];
			}


			//for (int i = 0; i < firstHalf.Length && i < secondHalf.Length; i++)
			//{
			//	if(firstHalf[i] > secondHalf[i])
			//	{
			//		Console.WriteLine(secondHalf[i]);
			//	}
			//	else
			//	{
			//		Console.WriteLine(firstHalf[i]);
			//	}

			//}

			//for (int j = 0; j < firstHalf.Length; j++)
			//{
			//	if (firstHalf[j] > 0)
			//	{
			//		Console.WriteLine(firstHalf[j]);
			//	}
			//}

			//for (int i = 0; i < wholeNumbers.Length; i++)
			//{
			//	Console.WriteLine(i);
			//}





			//int f = firstHalf[0];
			//int s = secondHalf[0];

			//int temp1;
			//for (int i = 1; i < firstHalf.Length; i++)
			//{
			//	for (int j = 0; j <wholeNumbers.Length - 1; j++)
			//	{
			//		if(firstHalf[j] > firstHalf[j + 1])
			//		{
			//			temp1 = firstHalf[j];
			//			firstHalf[j] = firstHalf[j + 1];
			//			firstHalf[j + 1] = temp1; 
			//		}
			//	}
			//}

		}
	}
}
