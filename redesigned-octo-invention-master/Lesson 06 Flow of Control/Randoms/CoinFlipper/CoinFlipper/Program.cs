using System;

namespace CoinFlipper
{
	class Program
	{
		static void Main(string[] args)
		{
			Random coin = new Random();

			int heads = coin.Next(2);

			Console.WriteLine("Ready, Set, Flip....!!");

			if (heads == 1)
			{
				Console.WriteLine("You got HEADS!");
			}
			
			else if (heads == 2)
			{
				Console.WriteLine("You got TAILS!");
			}

		}
	}
}
