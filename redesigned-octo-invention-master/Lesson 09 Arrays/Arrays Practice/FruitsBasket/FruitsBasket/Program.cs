using System;

namespace FruitsBasket
{
	class Program
	{
		static void Main(string[] args)
		{
			//Iterate over the below array and determine how many oranges and how many apples it contains, and print it out.

			//Then make 2 new arrays, one for each type, and sort the fruit into those new arrays. (I.e.move the String value from the first array into the appropriate sorting array).

			//Finally, once they are sorted, print out how many fruit you have total, and then how many oranges are in the orange array, and how many apples are in the apple array.


			String[] fruit = { "Orange", "Apple", "Orange", "Apple", "Orange", "Apple", "Orange", "Apple", "Orange", "Orange", "Orange", "Apple", "Orange", "Orange", "Apple", "Orange", "Orange", "Apple", "Apple", "Orange", "Apple", "Apple", "Orange", "Orange", "Apple", "Apple", "Apple", "Apple", "Orange", "Orange", "Apple", "Apple", "Orange", "Orange", "Orange", "Orange", "Apple", "Apple", "Apple", "Apple", "Orange", "Orange", "Apple", "Orange", "Orange", "Apple", "Orange", "Orange", "Apple", "Apple", "Orange", "Orange", "Apple", "Orange", "Apple", "Orange", "Apple", "Orange", "Apple", "Orange", "Orange" };

			// Fruit sorting code goes here!

			int totalFruit = 0;
			string apple = "Apple";
			int totalApples = 0;
			string orange = "Orange";
			int totalOranges = 0;

			for (int t = totalFruit; t < fruit.Length; t++)
			{
				totalFruit++;
			}
			Console.WriteLine("Total# of Fruit in Basket: {0}", totalFruit);

			for (int a = totalApples; a < fruit.Length; a++)
			{
				if(apple == fruit[a])
				{
					totalApples++;
				}
			}
			Console.WriteLine("Total of Apples: {0}", totalApples);

			for (int o = totalOranges; o < fruit.Length; o++)
			{
				if(orange ==fruit[o])
				{
					totalOranges++;
				}
			}
			Console.WriteLine("Total of Oranges: {0}", totalOranges);
		}
	}
}
