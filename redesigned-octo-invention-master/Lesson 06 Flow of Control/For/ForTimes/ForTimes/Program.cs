using System;

namespace ForTimes
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Which times table shall I recite? 7");
			for(int x = 1; x < 16; x++)
			{
				Console.WriteLine(x + "  * 7 is: {0}", x * 7);
			}
		}
	}
}
