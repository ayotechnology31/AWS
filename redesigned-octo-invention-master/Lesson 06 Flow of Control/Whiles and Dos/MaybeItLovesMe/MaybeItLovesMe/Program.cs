using System;

namespace MaybeItLovesMe
{
	class Program
	{
		static void Main(string[] args)
		{
			//Change your daisy-prediction program from before, to have a RANDOM number of petals for the daisy (range is usually from 13 - 89 petals).
			//If the last petal ends on "it loves me NOT" print "Awwww, bummer." otherwise print "Oh, wow! It really LOV

			Random numberOfPedals = new Random();
			int lastPedal = numberOfPedals.Next(13, 89);
			int noPedals = 0;

			Console.WriteLine("Well here goes nothing...");

			while (lastPedal > noPedals)
			{
				if (noPedals % 2 == 0)
				{
					Console.WriteLine("It LOVES me!   {0}", noPedals);
					if (noPedals == lastPedal - 1)
					{
						Console.WriteLine("Oh, wow! It really LOVES me!");
					}
				}
				else
				{
					Console.WriteLine("It loves me NOT!   {0}", noPedals);
					if(noPedals == lastPedal -1)
					{
						Console.WriteLine("Awwww, bummer.");
					}
				}
				noPedals++;
			}
		}
	}
}
