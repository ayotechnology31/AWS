using System;

namespace LovesMe
{
	class Program
	{
		static void Main(string[] args)
		{

			//Write a program that picks petals off a daisy(ordinarily 34 petals!) and prints out "It LOVES me NOT!" or "It LOVES me!" for every other petal until it runs out of petals.Feel free to print a happy message at the end too … since the result should ALWAYS be the same.
		   
		    //Did you write it in a while, or do/while loop ? Why ? (answer in a comment)

			int pedals = 34;
			int noPedals = 0;

			Console.WriteLine("Well here goes nothing...");

			while (pedals > noPedals)
			{
				if(pedals % 2 == 0)
				{
					Console.WriteLine("It loves me NOT!");
				}
				else
				{
					Console.WriteLine("It loves me!");
				}
				pedals--;
			}
			Console.WriteLine("I knew it! It LOVES ME!");
		}
	}
}
