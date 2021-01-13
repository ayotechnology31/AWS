using System;

namespace SummativeSums
{
	class Program
	{
		static void Main(string[] args)
		{
			//Write a static method that takes in an array of ints, adds them together, and returns the result.
			//Call your new method inside a main method and print out the result for the following three example arrays:
			//    { 1, 90, -33, -55, 67, -16, 28, -55, 15 }
			//    { 999, -60, -77, 14, 160, 301 }
			//    { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 }

			int[] array1 = { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
			int[] array2 = { 999, -60, -77, 14, 160, 301 };
			int[] array3 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 };

			int sum1 = AddArrays(array1);
			int sum2 = AddArrays(array2);
			int sum3 = AddArrays(array3);

			Console.WriteLine("#1 Array Sum: " + sum1);
			Console.WriteLine("#2 Array Sum: " + sum2);
			Console.WriteLine("#3 Array Sum: " + sum3);
		}


		public static int AddArrays(int[] array)
		{
			int sumArray = 0;

			for (int i = 0; i < array.Length; i++)
			{
				sumArray += array[i];
			}
			return sumArray;
		}

		//public static int AddArray1()
		//{

		//	int[] array1 = { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
		//	int sumArray1 = 0;

		//	for (int i = 0; i < array1.Length; i++)
		//	{
		//		sumArray1 += array1[i];
		//	}
		//	return sumArray1;
		//}

		//public static int AddArray2()
		//{
		//	int[] array2 = { 999, -60, -77, 14, 160, 301 };
		//	int sumArray2 = 0;

		//	for (int i = 0; i < array2.Length; i++)
		//	{
		//		sumArray2 += array2[i];
		//	}
		//	return sumArray2;
		//}

		//public static int AddArray3()
		//{
		//	int[] array3 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 };
		//	int sumArray3 = 0;

		//	for (int i = 0; i < array3.Length; i++)
		//	{
		//		sumArray3 += array3[i];
		//	}
		//	return sumArray3;
		//}
	}
}
