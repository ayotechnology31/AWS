using System;

namespace FortuneCookie
{
	class Program
	{
		static void Main(string[] args)
		{
			Random randomizer = new Random();

			int x = randomizer.Next(10);

			Console.WriteLine("Your Geek Fortune :" + x);
			if (x == 0)
			{
				Console.WriteLine("“Those aren’t the droids you’re looking for.”");
			}
			if (x == 1)
			{
				Console.WriteLine("“Never go in against a Sicilian when death is on the line!”");
			}
			if (x == 2)
			{
				Console.WriteLine("“Goonies never say die.”");
			}
			if (x == 3)
			{
				Console.WriteLine("“With great power there must also come — great responsibility.”");
			}
			if (x == 4)
			{
				Console.WriteLine("“Never argue with the data.”");
			}
			if ( x == 5)
			{
				Console.WriteLine("“Try not. Do, or do not. There is no try.”");
			}
			if (x == 6)
			{
				Console.WriteLine("“You are a leaf on the wind, watch how you soar.”");
			}
			if (x == 7)
			{
				Console.WriteLine("“You are a leaf on the wind, watch how you soar.”");
			}
			if (x == 8)
			{
				Console.WriteLine("“Do absolutely nothing, and it will be everything that you thought it could be\\”");
			}
			if (x == 9)
			{
				Console.WriteLine("“Kneel before Zod.”");
			}
			if (x == 10)
			{
				Console.WriteLine("“Make it so.”");
			}
		}
	}
}
